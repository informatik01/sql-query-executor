# SQLQueryExecutor Project #
This project consist of two parts:
  1. Java web application with JAX-WS web service
  1. C# desktop GUI application, which acts as a client of the JAX-WS web service

At the server side, there is a SOAP web service - SQLQueryExecutor, deployed on Apache Tomcat server. This web service receives SQL queries from its clients, executes them and sends back the resulting table. The communication with the web service is performed using SOAP protocol over HTTP. The appropriate WSDL file is available to the clients, so they can use it to access this web service. There is also a web page, that shows 10 most recent SQL queries along with the time those queries were received by the SQLQueryExecutor web service.

At the client side, there is a GUI desktop application, that allows users to send SQL queries for execution by the SQLQueryExecutor web service and shows the resulting table.

## Implementation details ##
The server side is coded using Java platform.<br>
The SQLQueryExecutor web service is coded using <a href='http://jax-ws.java.net/'>JAX-WS Reference Implementation</a> version 2.2.8 from the project Metro.<br>
The page that shows recent queries is coded using Oracle's JSF 2.2 implementation version 2.2.3 from the project <a href='http://javaserverfaces.java.net/'>Mojarra</a>.<br>
As a servlet container this web application uses Apache Tomcat 7.<br>
As a data storage this web application uses MySQL database (Community Edition).<br>
<br>
The client application is coded using C# 4.0 and .NET 4.0 platform.<br>
The GUI interface is coded using Windows Forms.<br>
The SQLQueryExecutor web service is consumed using the appropriate WCF artifacts generated from the web service's WSDL file.<br>
<br>
<hr />
<br>
<h2>Languages, technologies, frameworks and other solutions used</h2>
<b>Java based:</b><br>
<a href='http://docs.oracle.com/javase/'>Java SE 7</a>, <a href='http://docs.oracle.com/javaee/'>Java EE 6</a> (<a href='http://jcp.org/en/jsr/detail?id=315'>Servlet 3.0</a>, <a href='http://jcp.org/en/jsr/detail?id=314'>JSF 2.1</a>), <a href='http://jcp.org/aboutJava/communityprocess/mrel/jsr221/index.html'>JDBC 4.1</a>, <a href='http://tomcat.apache.org/tomcat-7.0-doc/jdbc-pool.html'>Tomcat JDBC Connection Pool</a>, <a href='http://jcp.org/en/jsr/detail?id=222'>JAXB 2.2</a>, <a href='http://logging.apache.org/log4j/1.2/'>Apache log4j 1.2</a>, <a href='http://ant.apache.org/'>Apache Ant 1.8.4</a>.<br>
<br>
<b>C# and .NET based:</b><br>
<a href='http://msdn.microsoft.com/en-us/library/w0x726c2%28v=vs.100%29.aspx'>.NET 4.0</a>, <a href='http://www.microsoft.com/en-us/download/details.aspx?id=7029'>C# 4.0</a>, <a href='http://msdn.microsoft.com/en-us/library/dd30h2yb%28v=vs.100%29.aspx'>Windows Forms</a>, <a href='http://msdn.microsoft.com/en-us/library/dd456779%28v=vs.100%29.aspx'>WCF</a>.<br>
<br>
<b>Other:</b><br>
<a href='http://www.iso.org/iso/home/store/catalogue_tc/catalogue_detail.htm?csnumber=53681'>SQL</a>, <a href='http://www.w3.org/TR/xml/'>XML 1.0</a>, <a href='http://www.w3.org/TR/xhtml1/'>XHTML 1.0</a>, <a href='http://www.w3.org/TR/2011/REC-CSS2-20110607/'>CSS 2.1</a>.<br>
<br>
<b>Servers used:</b><br>
<a href='http://tomcat.apache.org/'>Apache Tomcat 7</a>, <a href='http://www.mysql.com/products/community/'>MySQL 5.X Community Edition</a>

<b>Web Service communication protocols used:</b><br>
<a href='http://www.w3.org/TR/2000/NOTE-SOAP-20000508/'>SOAP 1.1</a> over <a href='http://tools.ietf.org/html/rfc2616'>HTTP/1.1</a>