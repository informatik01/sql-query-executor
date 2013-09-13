package ee.ttu.queryexecutor.service;

import java.util.Collection;

import ee.ttu.queryexecutor.model.QueryData;

/**
 * A service for keeping track of and storing SQL queries.
 * When this service is running it should store all SQL queries
 * internally to minimize access time.
 * <p>Concrete implementations are free to choose the persistence mechanism
 * used to load and store SQL queries (i.e. database, local serialization etc).
 *
 */
public interface QueryStorageService {

	/**
	 * Adds a query to the list of the stored SQL queries.
	 * 
	 * @param query SQL query to add
	 * @param time time in milliseconds when the query was received 
	 */
	public void addQuery(String query, long time);
	
	/**
	 * Returns the array of all currently stored SQL queries.
	 * 
	 * @return the array of the stored SQL queries
	 */
	public QueryData[] getQueries();
	
	/**
	 * Loads SQL queries to the internal storage
	 * from the outer source (implementation defined).
	 * 
	 * @return collection of loaded SQL queries
	 */
	public Collection<QueryData> loadQueries();
	
	/**
	 * Saves all currently stored SQL queries
	 * to a persistence storage (implementation defined).
	 * 
	 * @return <code>true</code> if ALL SQL queries were successfully saved; 
	 * 		<code>false</false> if only some or none of SQL queries were saved
	 */
	public boolean saveQueries();
	
	/**
	 * Shuts down the service in case some underlying closing mechanisms are required
	 * for stopping this service. This method is OPTIONAL.
	 * 
	 * @return <tt>true</tt> if the service was shut down successfully, otherwise <tt>false</tt>
	 * @throws <tt>UnsupportedOperationException</tt> if this method is not implemented
	 */
	public boolean shutdown() throws UnsupportedOperationException;
	
}
