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
It uses MySQL database server at the data layer. In the "db" folder,
there are the database creation scripts along with a MySQL JDBC driver.

NB! You must copy the JDBC Driver's jar into $CATALINA_HOME/lib.
This is what the Apache Tomcat developers recommend.
See the official documentation for additional details:
http://tomcat.apache.org/tomcat-7.0-doc/jndi-datasource-examples-howto.html

The Data Sources are configured in context.xml file in /META-INF folder. 
Make the appropriate changes there to configure database access settings.

In the project folder there is an Ant build file and the related properties file.
Make the appropriate changes in the build.properties file to configure Tomcat location etc.

Also make the appropriate changes in log4j.properties file (found in /src folder)
to configure the path to the log file.