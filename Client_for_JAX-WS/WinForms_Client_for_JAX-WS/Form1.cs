 using System;
using System.Data;
using System.Windows.Forms;
using Webservice.Client.TestService;


namespace Webservice.Client
{
    /// <summary>
    /// This class represents a GUI window that acts like a web service client.
    /// The web service is a Java SOAP web service, implemented using JAX-WS. 
    /// </summary>
    public partial class WSClientForm : Form
    {
        public WSClientForm()
        {
            InitializeComponent();
            testService = new SQLQueryExecutorClient();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonClearQuery_Click(object sender, EventArgs e)
        {
            textBoxQuery.Clear();
        }

        private void buttonClearResult_Click(object sender, EventArgs e)
        {
            dataGridViewResult.DataSource = null;
        }

        private void buttonClearAll_Click(object sender, EventArgs e)
        {
            textBoxQuery.Clear();
            dataGridViewResult.DataSource = null;
        }

        private void buttonSendQuery_Click(object sender, EventArgs e)
        {
            String query = textBoxQuery.Text.Trim();
            if (query.Length == 0)  // TODO: customize query length
            {
                MessageBox.Show("SQL query string should not be empty.",
                                "Info",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            table table = null;
            try
            {
                table = testService.executeQuery(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception:\n" + ex.Message +
                                "\n===============\n" +
                                "Inner Exception: \n" +
                                (ex.InnerException != null ? ex.InnerException.Message : "No inner exception"),
                                "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (table == null)
            {
                MessageBox.Show("No data returned by service", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (!table.ContentAvailable)
            {
                MessageBox.Show(table.InfoMessage, "Information message",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataTable resultTable = new DataTable();

            DataColumnCollection columnCollection = resultTable.Columns;
            foreach (string column in table.Columns)
            {
                columnCollection.Add(column);
            }

            DataRowCollection rowCollection = resultTable.Rows;
            foreach (string[] row in table.Rows)
            {
                rowCollection.Add(row);
            }

            // Explicitely removing data source by assigning null to prevent column ordering issue.
            // This issue can happen, if the previous request returned the same column(s),
            // as the ones returned by a new request.
            dataGridViewResult.DataSource = null;
            dataGridViewResult.DataSource = resultTable;

            // Enabling resizing of columns, because the DataGridViewAutoSizeColumnMode.AllCells,
            // that is set for the AutoSizeColumnsMode in DataGridView, does not allow manual resizing.
            for (int i = 0; i < dataGridViewResult.Columns.Count; i++)
            {
                int columnWidth = dataGridViewResult.Columns[i].Width;
                dataGridViewResult.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dataGridViewResult.Columns[i].Width = columnWidth;
            }

        }

         
        private void textBoxQuery_KeyDown(object sender, KeyEventArgs e)
        {
            // Capturing "Enter" key press without any modifiers
            if ((e.KeyCode == Keys.Enter) && (e.Modifiers == 0))
            {
                buttonSendQuery.PerformClick();
            }
            // Capturing "Ctrl+A" to enable "Select All" feature,
            // which is not available, when TextBox.Multiline property is enabled
            else if (e.Control && (e.KeyCode == Keys.A))
            {
                textBoxQuery.SelectAll();
                e.SuppressKeyPress = true;  // to supress system bell
            }
        }

    }
}
