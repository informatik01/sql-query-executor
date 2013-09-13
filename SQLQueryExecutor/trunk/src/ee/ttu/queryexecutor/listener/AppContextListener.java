package ee.ttu.queryexecutor.listener;

import javax.servlet.ServletContext;
import javax.servlet.ServletContextEvent;
import javax.servlet.ServletContextListener;
import javax.servlet.annotation.WebListener;

import ee.ttu.queryexecutor.service.JDBCQueryStorageService;
import ee.ttu.queryexecutor.service.QueryStorageService;

/**
 * The <code>AppContextListener</code> class acts as
 * a web application context listener.
 * 
 * @see javax.servlet.ServletContextListener
 *
 */
@WebListener
public class AppContextListener implements ServletContextListener {

	private QueryStorageService queryStorageService = new JDBCQueryStorageService();
	
	@Override
    public void contextInitialized(ServletContextEvent event) {
		ServletContext sc = event.getServletContext();
        queryStorageService.loadQueries();
        sc.setAttribute("queryStorageService", queryStorageService);
    }

	@Override
    public void contextDestroyed(ServletContextEvent event) {
		queryStorageService.shutdown();
		queryStorageService.saveQueries();
    }
	
}
