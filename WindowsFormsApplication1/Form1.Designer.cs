namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.SimulationTable = new System.Windows.Forms.DataGridView();
            this.CustomerNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InterArrival = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Arrival = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServerIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeBegin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeServiceBegin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalDelay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SetValues = new System.Windows.Forms.Button();
            this.Simulate = new System.Windows.Forms.Button();
            this.Graph1 = new System.Windows.Forms.Button();
            this.Graph2 = new System.Windows.Forms.Button();
            this.Graph3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SimulationTable)).BeginInit();
            this.SuspendLayout();
            // 
            // SimulationTable
            // 
            this.SimulationTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SimulationTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerNo,
            this.InterArrival,
            this.Arrival,
            this.ServerIndex,
            this.TimeBegin,
            this.ServiceTime,
            this.TimeServiceBegin,
            this.TotalDelay});
            this.SimulationTable.Location = new System.Drawing.Point(12, 70);
            this.SimulationTable.Name = "SimulationTable";
            this.SimulationTable.Size = new System.Drawing.Size(843, 432);
            this.SimulationTable.TabIndex = 0;
            // 
            // CustomerNo
            // 
            this.CustomerNo.HeaderText = "CustomerNo";
            this.CustomerNo.Name = "CustomerNo";
            // 
            // InterArrival
            // 
            this.InterArrival.HeaderText = "InterArrival";
            this.InterArrival.Name = "InterArrival";
            // 
            // Arrival
            // 
            this.Arrival.HeaderText = "Arrival";
            this.Arrival.Name = "Arrival";
            // 
            // ServerIndex
            // 
            this.ServerIndex.HeaderText = "ServerIndex";
            this.ServerIndex.Name = "ServerIndex";
            // 
            // TimeBegin
            // 
            this.TimeBegin.HeaderText = "TimeBegin";
            this.TimeBegin.Name = "TimeBegin";
            // 
            // ServiceTime
            // 
            this.ServiceTime.HeaderText = "ServiceTime";
            this.ServiceTime.Name = "ServiceTime";
            // 
            // TimeServiceBegin
            // 
            this.TimeServiceBegin.HeaderText = "TimeServiceBegin";
            this.TimeServiceBegin.Name = "TimeServiceBegin";
            // 
            // TotalDelay
            // 
            this.TotalDelay.HeaderText = "TotalDelay";
            this.TotalDelay.Name = "TotalDelay";
            // 
            // SetValues
            // 
            this.SetValues.Location = new System.Drawing.Point(38, 13);
            this.SetValues.Name = "SetValues";
            this.SetValues.Size = new System.Drawing.Size(83, 34);
            this.SetValues.TabIndex = 1;
            this.SetValues.Text = "SetValues";
            this.SetValues.UseVisualStyleBackColor = true;
            this.SetValues.Click += new System.EventHandler(this.SetValues_Click);
            // 
            // Simulate
            // 
            this.Simulate.Location = new System.Drawing.Point(148, 13);
            this.Simulate.Name = "Simulate";
            this.Simulate.Size = new System.Drawing.Size(81, 34);
            this.Simulate.TabIndex = 2;
            this.Simulate.Text = "Simulate";
            this.Simulate.UseVisualStyleBackColor = true;
            this.Simulate.Click += new System.EventHandler(this.Simulate_Click);
            // 
            // Graph1
            // 
            this.Graph1.Location = new System.Drawing.Point(256, 13);
            this.Graph1.Name = "Graph1";
            this.Graph1.Size = new System.Drawing.Size(75, 34);
            this.Graph1.TabIndex = 3;
            this.Graph1.Text = "Graph1";
            this.Graph1.UseVisualStyleBackColor = true;
            this.Graph1.Click += new System.EventHandler(this.Graph1_Click);
            // 
            // Graph2
            // 
            this.Graph2.Location = new System.Drawing.Point(357, 13);
            this.Graph2.Name = "Graph2";
            this.Graph2.Size = new System.Drawing.Size(74, 34);
            this.Graph2.TabIndex = 4;
            this.Graph2.Text = "Graph2";
            this.Graph2.UseVisualStyleBackColor = true;
            this.Graph2.Click += new System.EventHandler(this.Graph2_Click);
            // 
            // Graph3
            // 
            this.Graph3.Location = new System.Drawing.Point(458, 13);
            this.Graph3.Name = "Graph3";
            this.Graph3.Size = new System.Drawing.Size(77, 34);
            this.Graph3.TabIndex = 5;
            this.Graph3.Text = "Graph3";
            this.Graph3.UseVisualStyleBackColor = true;
            this.Graph3.Click += new System.EventHandler(this.Graph3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 508);
            this.Controls.Add(this.Graph3);
            this.Controls.Add(this.Graph2);
            this.Controls.Add(this.Graph1);
            this.Controls.Add(this.Simulate);
            this.Controls.Add(this.SetValues);
            this.Controls.Add(this.SimulationTable);
            this.Name = "Form1";
            this.Text = "SimulationTable";
            ((System.ComponentModel.ISupportInitialize)(this.SimulationTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView SimulationTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn InterArrival;
        private System.Windows.Forms.DataGridViewTextBoxColumn Arrival;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServerIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeBegin;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeServiceBegin;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalDelay;
        private System.Windows.Forms.Button SetValues;
        private System.Windows.Forms.Button Simulate;
        private System.Windows.Forms.Button Graph1;
        private System.Windows.Forms.Button Graph2;
        private System.Windows.Forms.Button Graph3;

    }
}

