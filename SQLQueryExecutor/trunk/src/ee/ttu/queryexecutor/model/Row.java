package ee.ttu.queryexecutor.model;

import java.util.List;

import javax.xml.bind.annotation.XmlElement;

/**
 * <code>Row</code> is a JavaBean class for storing values of a table row.
 *
 */
public class Row {

	List<String> values;

	public Row() {}

	public Row(List<String> values) {
		this.values = values;
	}

	/*
	 * IMPORTANT NOTE
	 * Setting attribute "nillable=true" to produce a correct XML.
	 * This will prevent an issue when an element, which has null value,
	 * is missing in the resulting XML.
	 * 
	 */
	@XmlElement(name="value", nillable=true)
	public List<String> getValues() {
		return values;
	}

	public void setValues(List<String> rows) {
		this.values = rows;
	}
	
}
