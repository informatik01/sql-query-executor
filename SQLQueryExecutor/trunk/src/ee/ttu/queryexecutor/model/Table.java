package ee.ttu.queryexecutor.model;

import java.util.List;

import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlElementWrapper;
import javax.xml.bind.annotation.XmlRootElement;
import javax.xml.bind.annotation.XmlType;

/**
 * <code>Table</code> is a JavaBean class that models a table in the business domain.
 * Along with table data, objects of this class can store related meta data.
 *
 */
@XmlRootElement
@XmlType(propOrder={"contentAvailable", "infoMessage", "columns", "rows"})
public class Table {
	
	/*
	 * IMPLEMENTATION NOTE
	 * 
	 * This class is just a plain and simple solution.
	 * Depending on the requirements, we can make more complex domain objects:
	 * like defining special classes for table meta data, columns etc.
	 *  
	 * Also, using List<Rows> instead of List<List<String>> rows
	 * to overcome the following JAXB be issue:
	 * 		"java.util.List is an interface, and JAXB can't handle interfaces."
	 */
	
	private boolean contentAvailable;
	
	private String infoMessage;
	
	private List<String> columns;
	
	private List<Row> rows;

	@XmlElement(name="ContentAvailable")
	public boolean isContentAvailable() {
		return contentAvailable;
	}
	
	public void setContentAvailable(boolean contentAvailable) {
		this.contentAvailable = contentAvailable;
	}
	
	@XmlElement(name="InfoMessage", nillable=true)
	public String getInfoMessage() {
		return infoMessage;
	}
	
	public void setInfoMessage(String infoMessage) {
		this.infoMessage = infoMessage;
	}
	
	@XmlElementWrapper(name="Columns", nillable=true)
	@XmlElement(name="name")
	public List<String> getColumns() {
		return columns;
	}

	public void setColumns(List<String> columns) {
		this.columns = columns;
	}

	@XmlElementWrapper(name="Rows", nillable=true)
	@XmlElement(name="row")
	public List<Row> getRows() {
		return rows;
	}

	public void setRows(List<Row> rows) {
		this.rows = rows;
	}

}
