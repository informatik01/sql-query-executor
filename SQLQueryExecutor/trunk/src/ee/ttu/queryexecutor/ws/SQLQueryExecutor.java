package ee.ttu.queryexecutor.ws;

import javax.jws.WebMethod;
import javax.jws.WebParam;
import javax.jws.WebResult;
import javax.jws.WebService;
import javax.jws.soap.SOAPBinding;
import javax.jws.soap.SOAPBinding.Style;
import javax.jws.soap.SOAPBinding.Use;

import ee.ttu.queryexecutor.model.Table;

/**
 * This service executes SQL queries received from clients and sends back
 * the resulting {@link ee.ttu.queryexecutor.model.Table Table}.
 * <p><code>SQLExecutor</code> is a Service Endpoint Interface (SEI)
 * for a JAX-WS web service.
 *
 */
@WebService
@SOAPBinding(style = Style.DOCUMENT, use = Use.LITERAL)
public interface SQLQueryExecutor {
	
	/**
	 * Executes the SQL query received from a client and
	 * returns the <code>Table</code> object, which contains
	 * the result of executing this SQL query.
	 * 
	 * @param query SQL query to execute
	 * @return {@link ee.ttu.queryexecutor.model.Table Table} object,
	 * 			containing the result of executing this SQL query
	 */
	@WebMethod(operationName = "executeQuery")
	@WebResult(name = "Table")
	public Table executeQuery(@WebParam(name = "query") String query);

}
