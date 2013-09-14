using Webservice.Client.TestService;

namespace Webservice.Client
{
    partial class WSClientForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelHeader = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonClearResult = new System.Windows.Forms.Button();
            this.labelQuery = new System.Windows.Forms.Label();
            this.textBoxQuery = new System.Windows.Forms.TextBox();
            this.buttonSendQuery = new System.Windows.Forms.Button();
            this.dataGridViewResult = new System.Windows.Forms.DataGridView();
            this.labelResult = new System.Windows.Forms.Label();
            this.panelQuery = new System.Windows.Forms.Panel();
            this.buttonClearQuery = new System.Windows.Forms.Button();
            this.panelResult = new System.Windows.Forms.Panel();
            this.buttonClearAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).BeginInit();
            this.panelQuery.SuspendLayout();
            this.panelResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelHeader
            // 
            this.labelHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHeader.BackColor = System.Drawing.Color.Yellow;
            this.labelHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHeader.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelHeader.Location = new System.Drawing.Point(0, 0);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(700, 50);
            this.labelHeader.TabIndex = 0;
            this.labelHeader.Text = "SQL Query Executor";
            this.labelHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExit.Location = new System.Drawing.Point(586, 528);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(107, 25);
            this.buttonExit.TabIndex = 10;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonClearResult
            // 
            this.buttonClearResult.Location = new System.Drawing.Point(0, 192);
            this.buttonClearResult.Name = "buttonClearResult";
            this.buttonClearResult.Size = new System.Drawing.Size(107, 25);
            this.buttonClearResult.TabIndex = 11;
            this.buttonClearResult.Text = "Clear result";
            this.buttonClearResult.UseVisualStyleBackColor = true;
            this.buttonClearResult.Click += new System.EventHandler(this.buttonClearResult_Click);
            // 
            // labelQuery
            // 
            this.labelQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelQuery.Location = new System.Drawing.Point(3, 63);
            this.labelQuery.Name = "labelQuery";
            this.labelQuery.Size = new System.Drawing.Size(135, 25);
            this.labelQuery.TabIndex = 1;
            this.labelQuery.Text = "Enter SQL query:";
            this.labelQuery.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxQuery
            // 
            this.textBoxQuery.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxQuery.Location = new System.Drawing.Point(0, 0);
            this.textBoxQuery.Multiline = true;
            this.textBoxQuery.Name = "textBoxQuery";
            this.textBoxQuery.Size = new System.Drawing.Size(687, 116);
            this.textBoxQuery.TabIndex = 2;
            this.textBoxQuery.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxQuery_KeyDown);
            // 
            // buttonSendQuery
            // 
            this.buttonSendQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSendQuery.Location = new System.Drawing.Point(580, 133);
            this.buttonSendQuery.Name = "buttonSendQuery";
            this.buttonSendQuery.Size = new System.Drawing.Size(107, 24);
            this.buttonSendQuery.TabIndex = 12;
            this.buttonSendQuery.Text = "Send SQL query";
            this.buttonSendQuery.UseVisualStyleBackColor = true;
            this.buttonSendQuery.Click += new System.EventHandler(this.buttonSendQuery_Click);
            // 
            // dataGridViewResult
            // 
            this.dataGridViewResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewResult.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewResult.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewResult.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewResult.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewResult.Name = "dataGridViewResult";
            this.dataGridViewResult.Size = new System.Drawing.Size(687, 172);
            this.dataGridViewResult.TabIndex = 3;
            // 
            // labelResult
            // 
            this.labelResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResult.Location = new System.Drawing.Point(3, 262);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(135, 22);
            this.labelResult.TabIndex = 4;
            this.labelResult.Text = "SQL query result:";
            this.labelResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelQuery
            // 
            this.panelQuery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelQuery.Controls.Add(this.buttonClearQuery);
            this.panelQuery.Controls.Add(this.textBoxQuery);
            this.panelQuery.Controls.Add(this.buttonSendQuery);
            this.panelQuery.Location = new System.Drawing.Point(6, 89);
            this.panelQuery.Name = "panelQuery";
            this.panelQuery.Size = new System.Drawing.Size(687, 160);
            this.panelQuery.TabIndex = 13;
            // 
            // buttonClearQuery
            // 
            this.buttonClearQuery.Location = new System.Drawing.Point(0, 133);
            this.buttonClearQuery.Name = "buttonClearQuery";
            this.buttonClearQuery.Size = new System.Drawing.Size(107, 24);
            this.buttonClearQuery.TabIndex = 13;
            this.buttonClearQuery.Text = "Clear SQL query";
            this.buttonClearQuery.UseVisualStyleBackColor = true;
            this.buttonClearQuery.Click += new System.EventHandler(this.buttonClearQuery_Click);
            // 
            // panelResult
            // 
            this.panelResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelResult.Controls.Add(this.buttonClearAll);
            this.panelResult.Controls.Add(this.dataGridViewResult);
            this.panelResult.Controls.Add(this.buttonClearResult);
            this.panelResult.Location = new System.Drawing.Point(6, 285);
            this.panelResult.Name = "panelResult";
            this.panelResult.Size = new System.Drawing.Size(687, 228);
            this.panelResult.TabIndex = 14;
            // 
            // buttonClearAll
            // 
            this.buttonClearAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClearAll.Location = new System.Drawing.Point(580, 192);
            this.buttonClearAll.Name = "buttonClearAll";
            this.buttonClearAll.Size = new System.Drawing.Size(107, 25);
            this.buttonClearAll.TabIndex = 12;
            this.buttonClearAll.Text = "Clear all";
            this.buttonClearAll.UseVisualStyleBackColor = true;
            this.buttonClearAll.Click += new System.EventHandler(this.buttonClearAll_Click);
            // 
            // WSClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 562);
            this.Controls.Add(this.panelResult);
            this.Controls.Add(this.panelQuery);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.labelQuery);
            this.Controls.Add(this.labelHeader);
            this.MaximumSize = new System.Drawing.Size(1200, 650);
            this.MinimumSize = new System.Drawing.Size(700, 550);
            this.Name = "WSClientForm";
            this.Text = "WSClientForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).EndInit();
            this.panelQuery.ResumeLayout(false);
            this.panelQuery.PerformLayout();
            this.panelResult.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SQLQueryExecutorClient testService;

        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonClearResult;
        private System.Windows.Forms.Label labelQuery;
        private System.Windows.Forms.TextBox textBoxQuery;
        private System.Windows.Forms.Button buttonSendQuery;
        private System.Windows.Forms.DataGridView dataGridViewResult;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Panel panelQuery;
        private System.Windows.Forms.Panel panelResult;
        private System.Windows.Forms.Button buttonClearQuery;
        private System.Windows.Forms.Button buttonClearAll;
    }
}

