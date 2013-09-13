====================
SYSTEM REQUIREMENTS:
====================
* Java SE 6+
* Apache Tomcat 7+
* MySQL 5+


===================
INSTALLATION NOTES:
===================
This application is supposed to be deployed on Apache Tomcat server.
It uses MySQL database server at the Data Layer. In the "db" folder,
there are the database creation scripts along with the MySQL JDBC driver.

NB! You must copy the JDBC Driver's jar into $CATALINA_HOME/lib.
This is the recommendation of Apache Tomcat developers.
See the official documentation for additional details:
http://tomcat.apache.org/tomcat-7.0-doc/jndi-datasource-examples-howto.html

In the project folder there is Ant build file and the related properties file.
Make the appropriate changes in the build.properties file.

Also make the appropriate changes in log4j.properties file (found in /src folder)
to configure the path to the log file.