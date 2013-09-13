package ee.ttu.queryexecutor.ws;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.ResultSetMetaData;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;

import javax.jws.WebService;

import org.apache.log4j.Logger;

import ee.ttu.queryexecutor.model.Row;
import ee.ttu.queryexecutor.model.Table;
import ee.ttu.queryexecutor.service.JDBCQueryStorageService;
import ee.ttu.queryexecutor.service.JdbcConnectionService;
import ee.ttu.queryexecutor.service.QueryStorageService;

/**
 * Implementation of the <tt>SQLQueryExecutor</tt> interface.
 * 
 * @see SQLQueryExecutor
 *
 */
@WebService(endpointInterface = "ee.ttu.queryexecutor.ws.SQLQueryExecutor")
public class SQLQueryExecutorImpl implements SQLQueryExecutor {
	
	private static final Logger logger = Logger.getLogger(SQLQueryExecutor.class);
		
	private static final String FORBIDDEN_OPERATIONS_PATTERN = "(?i)(?s)^\\s*(\\bCREATE\\b" +
																	"|\\bUPDATE\\b" +
																	"|\\bINSERT\\b" +
																	"|\\bDELETE\\b" +
																	"|\\bALTER\\b"  +
																	"|\\bDROP\\b).*";

	private static final String RESOURCE= "java:comp/env/jdbc/TestShopDB";
	
	private static final JdbcConnectionService connectionService = new JdbcConnectionService(RESOURCE);
	
	private QueryStorageService queryStorageService = new JDBCQueryStorageService();
	
	@Override
	public Table executeQuery(String query) {
		if (query.isEmpty()) {
			return null;
		} else {
			queryStorageService.addQuery(query, System.currentTimeMillis());
		}
		
		Table table = new Table();
		List<String> columns = new ArrayList<String>();
		List<Row> rows = new ArrayList<Row>();
		
		if (query.matches(FORBIDDEN_OPERATIONS_PATTERN)) {
			table.setContentAvailable(false);
			table.setInfoMessage("Creating, inserting, updating and deleting data is forbidden.\n" +
								 "Only SELECT queries are allowed.");
			return table;
		}
		
		Connection connection = null;
		PreparedStatement ps = null;
		ResultSet rs = null;
		ResultSetMetaData rsmd = null;
		int columnCount = 0;
		try {
			connection = connectionService.getConnection();
			ps = connection.prepareStatement(query);
			rs = ps.executeQuery();
			
			rsmd = rs.getMetaData();
			columnCount = rsmd.getColumnCount();
			for (int i = 1; i <= columnCount; i++) {
				columns.add(rsmd.getColumnLabel(i));
			}
			table.setColumns(columns);
			
			while (rs.next()) {
				List<String> rowValues = new ArrayList<String>();
				for (int i = 1; i <= columnCount; i++) {
					rowValues.add(rs.getString(i));
				}
				rows.add(new Row(rowValues));
			}
			
			if (!rows.isEmpty()) {
				table.setContentAvailable(true);
				table.setRows(rows);
			} else {
				table.setContentAvailable(false);
				table.setInfoMessage("No data returned after executing the following SQL query:\n" + query);
			}
		} catch (SQLException e) {
			logger.error("Error retrieving data from database.", e);
			table.setContentAvailable(false);
			table.setInfoMessage(e.getMessage());
		} finally {
			connectionService.close(rs, ps, connection);
		}
		
		return table;
	}

}
