**NOTE**<br />
*This project was made as an assignment*

---

This project consist of two parts:
  1. Java web application with JAX-WS web service
  2. C# desktop GUI application, which acts as a client of the JAX-WS web service

At the <strong>server side</strong>, there is a SOAP web service - SQLQueryExecutor, deployed on Apache Tomcat server. This web service receives SQL queries from its clients, executes them and sends back the resulting table. The communication with the web service is performed using SOAP protocol over HTTP. The appropriate WSDL file is available to the clients, so they can use it to access this web service. There is also a web page, that shows 10 most recent SQL queries along with the time those queries were received by the SQLQueryExecutor web service.

At the <strong>client side</strong>, there is a GUI desktop application, that allows users to send SQL queries for execution by the SQLQueryExecutor web service and shows the resulting table.

###Implementation details
The server side is written using Java platform.<br>
The SQLQueryExecutor web service is implemented using [JAX-WS Reference Implementation](http://jax-ws.java.net/) version 2.2.8 from the project Metro.<br>
The page that shows recent queries is written using Oracle's JSF 2.2 implementation from the project [Mojarra](http://javaserverfaces.java.net/).<br>
As a servlet container this web application uses Apache Tomcat 7.<br>
As a data storage this web application uses MySQL database (Community Edition). 

The client application is written using C# 4.0 and .NET 4.0 platform.<br>
The GUI interface is implemented using Windows Forms.<br>
The SQLQueryExecutor web service is consumed using the appropriate WCF artifacts generated from the web service's WSDL file.
