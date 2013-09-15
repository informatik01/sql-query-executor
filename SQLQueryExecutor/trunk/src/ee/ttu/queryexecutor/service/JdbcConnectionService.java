package ee.ttu.queryexecutor.service;

import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;

import javax.naming.InitialContext;
import javax.naming.NamingException;
import javax.sql.DataSource;

import org.apache.log4j.Logger;

/**
 * This class helps reduce JDBC boilerplate code.
 * It is useful for managing database connections and performing related actions.
 *
 */
public class JdbcConnectionService {
	
	private static final Logger logger = Logger.getLogger(JdbcConnectionService.class);
	
	private DataSource dataSource;
	
	public JdbcConnectionService(String resource) {
		try {
			dataSource = (DataSource) new InitialContext().lookup(resource); 
		} catch (NamingException e) {
			logger.error("The following DataSource is missing: " + resource, e);
			throw new RuntimeException(e);
		}	
	}
	
	public Connection getConnection() throws SQLException {
		return dataSource.getConnection();
	}
	
	public void closeResultSet(ResultSet rs) {
		if (rs != null) {
			try {
				rs.close();
			} catch (SQLException e) {
				System.err.println("Error closing ResultSet: " + e.getMessage());
				logger.error(e);
			}
		}
	}
	
	public void closeStatement(Statement st) {
		if (st != null) {
			try {
				st.close();
			} catch (SQLException e) {
				System.err.println("Error closing Statement: " + e.getMessage());
				logger.error(e);
			}
		}
	}
	
	public void closeConnection(Connection con) {
		if (con != null) {
			try {
				con.close();
			} catch (SQLException e) {
				System.err.println("Error closing Connection: " + e.getMessage());
				logger.error(e);
			}
		}
	}
	
	public void close(ResultSet rs, Statement st) {
		closeResultSet(rs);
		closeStatement(st);
	}
	
	public void close(Statement st, Connection con) {
		closeStatement(st);
		closeConnection(con);
	}
	
	public void close(ResultSet rs, Statement st, Connection con) {
		closeResultSet(rs);
		closeStatement(st);
		closeConnection(con);
	}
	
	public void rollback(Connection con) {
		if (con != null) {
			try {
				con.rollback();
			} catch (SQLException e) {
				System.err.println("Error executing rollback on the connection.");
				logger.error(e);
			}
		}
	}
	
	public void setAutoCommit(Connection con, boolean autoCommit) {
		if (con != null) {
			try {
				con.setAutoCommit(autoCommit);
			} catch (SQLException e) {
				System.err.println("Error setting auto-commit mode.");
				logger.error(e);
			}
		}
	}
	
}
