package ee.ttu.queryexecutor.model;

import java.sql.Timestamp;

/**
 * The <code>QueryData</code> class is used for
 * storing SQL queries along with related data.
 *
 */
public class QueryData {
	
	private int id;
	
	private String query;
	
	private Timestamp time;
	
	public QueryData() {}
	
	public QueryData(String query, Timestamp time) {
		this.query = query;
		this.time = time;
	}

	public QueryData(int id, String query, Timestamp time) {
		this(query, time);
		this.id = id;
	}
	
	public int getId() {
		return id;
	}

	public void setId(int id) {
		this.id = id;
	}

	public String getQuery() {
		return query;
	}

	public void setQuery(String query) {
		this.query = query;
	}

	public Timestamp getTime() {
		return time;
	}

	public void setTime(Timestamp time) {
		this.time = time;
	}

}
