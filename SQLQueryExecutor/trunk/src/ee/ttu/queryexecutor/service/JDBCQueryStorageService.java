package ee.ttu.queryexecutor.service;

import java.sql.BatchUpdateException;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Timestamp;
import java.util.ArrayList;
import java.util.Collection;
import java.util.List;
import java.util.concurrent.ArrayBlockingQueue;
import java.util.concurrent.BlockingQueue;
import java.util.concurrent.ExecutorService;
import java.util.concurrent.Executors;
import java.util.concurrent.TimeUnit;

import org.apache.log4j.Logger;

import ee.ttu.queryexecutor.model.QueryData;

/**
 * Implementation of the <tt>QueryStorageService</tt> interface that uses
 * JDBC and a database as a persistent storage.
 * 
 * @see QueryStorageService
 *
 */
public class JDBCQueryStorageService implements QueryStorageService {
	
	private static final Logger logger = Logger.getLogger(JDBCQueryStorageService.class);

	private static final int NTHREADS = 25;

	private static final int NELEMENTS = 10;

	private static final int TIMEOUT = 15;
	
	private static final String LOAD_QUERIES = "SELECT query_id, query, received_time FROM sql_queries";

	private static final String DELETE_QUERIES = "DELETE FROM sql_queries";

	private static final String RESET_AUTO_INCREMENT = "ALTER TABLE sql_queries AUTO_INCREMENT = 1";
	
	private static final String SAVE_QUERIES = "INSERT INTO sql_queries (query, received_time) VALUES (?, ?)";
	
	private static final String RESOURCE = "java:comp/env/jdbc/TestShopAdminDB";
	
	
	private static final JdbcConnectionService connectionService = new JdbcConnectionService(RESOURCE);

	private static final ExecutorService threadPool = Executors.newFixedThreadPool(NTHREADS);

	private static final BlockingQueue<QueryData> queries = new ArrayBlockingQueue<QueryData>(NELEMENTS);

	@Override
	public void addQuery(final String query, final long time) {
		Runnable task = new Runnable() {
			@Override
			public void run() {
				synchronized (queries) {
					while (!queries.offer(new QueryData(query, new Timestamp(time)))) {
						queries.poll();
					}
				}
			}
		};
		threadPool.execute(task);
	}

	@Override
	public QueryData[] getQueries() {
		return queries.toArray(new QueryData[0]);
	}

	@Override
	public Collection<QueryData> loadQueries() {
		List<QueryData> loadedQueries = new ArrayList<QueryData>();
		
		Connection connection = null;
		PreparedStatement psLoad = null;
		ResultSet rs = null;
		try {
			connection = connectionService.getConnection();
			psLoad = connection.prepareStatement(LOAD_QUERIES);			
			rs = psLoad.executeQuery();
			
			while (rs.next()) {
				QueryData queryData = new QueryData();
				queryData.setId(rs.getInt("query_id"));
				queryData.setQuery(rs.getString("query"));
				queryData.setTime(rs.getTimestamp("received_time"));
				loadedQueries.add(queryData);
			}
			logger.info("Successfully loaded queries from database");
		} catch (SQLException e) {
			logger.error("Error retrieving data from database", e);
		} finally {
			connectionService.close(rs, psLoad, connection);
		}
		
		if (loadedQueries.size() <= NELEMENTS) {
			queries.addAll(loadedQueries);
		} else {
			for (QueryData query : loadedQueries) {
				addQuery(query.getQuery(), query.getTime().getTime());
			}
		}
		
		return loadedQueries;
	}

	@Override
	public boolean saveQueries() {
		/*
		 * IMPLEMENTATION NOTE
		 * Not handling AutoCommit because the data is not critical
		 */
		boolean succesfullySaved = true;
		Connection connection = null;
		PreparedStatement psDelete = null;
		PreparedStatement psResetAutoIncrement = null;
		PreparedStatement psSave = null;
		
		try {
			connection = connectionService.getConnection();
			
			psDelete = connection.prepareStatement(DELETE_QUERIES);
			psDelete.executeUpdate();
			
			// Resetting AUTO_INCREMENT for the sake of pleasant look 
			psResetAutoIncrement = connection.prepareStatement(RESET_AUTO_INCREMENT);
			psResetAutoIncrement.executeUpdate();
			
			psSave = connection.prepareStatement(SAVE_QUERIES);
			for (QueryData queryData : queries) {
				psSave.setString(1, queryData.getQuery());
				psSave.setTimestamp(2, queryData.getTime());
				psSave.addBatch();
			}
			try {
				psSave.executeBatch();
				logger.info("Successfully saved all queries to database");
			} catch (BatchUpdateException bue) {
				logger.error("Eather some or all queries were no seved successfully", bue);
				succesfullySaved = false;
			}
		} catch (SQLException e) {
			logger.error("Error saving queries", e);
			succesfullySaved = false;
		} finally {
			connectionService.closeStatement(psDelete);
			connectionService.close(psSave, connection);
		}
		
		return succesfullySaved;
	}

	@Override
	public boolean shutdown() {
		/*
		 * IMPLEMENTATION NOTE
		 * Shutting down ExecutorService pool as shown in one of the examples here:
		 * 		http://docs.oracle.com/javase/7/docs/api/java/util/concurrent/ExecutorService.html
		 */
		boolean successfullyShutDown = true;
		threadPool.shutdown();
		try {
			if (!threadPool.awaitTermination(TIMEOUT, TimeUnit.SECONDS)) {
				threadPool.shutdownNow();
				if (!threadPool.awaitTermination(TIMEOUT, TimeUnit.SECONDS)) {
					logger.error("Thread pool did not terminate");
					successfullyShutDown = false;
				} else {
					logger.info("Thread pool was successfully shut down");
				}
			} else {
				logger.info("Thread pool was successfully shut down");
			}
		} catch (InterruptedException e) {
			threadPool.shutdownNow();
			Thread.currentThread().interrupt();
			logger.error("An error occured while shutting down thread pool", e);
			successfullyShutDown = false;
		}
		
		return successfullyShutDown;
	}

}
