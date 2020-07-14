namespace BarcodeDemo
{
    partial class ISO15415QualityTestForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.centerPatternButton = new System.Windows.Forms.Button();
            this.barcodeSymbolButton = new System.Windows.Forms.Button();
            this.stopPatternButton = new System.Windows.Forms.Button();
            this.startPatternButton = new System.Windows.Forms.Button();
            this.gbScanGrade = new System.Windows.Forms.GroupBox();
            this.sgHi = new System.Windows.Forms.Label();
            this.sgLow = new System.Windows.Forms.Label();
            this.sg4 = new System.Windows.Forms.Label();
            this.sg3 = new System.Windows.Forms.Label();
            this.sg2 = new System.Windows.Forms.Label();
            this.sg1 = new System.Windows.Forms.Label();
            this.sg0 = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.cName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cGrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbScanGrade.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.gbScanGrade);
            this.panel1.Controls.Add(this.okButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 514);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(508, 108);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.centerPatternButton);
            this.groupBox1.Controls.Add(this.barcodeSymbolButton);
            this.groupBox1.Controls.Add(this.stopPatternButton);
            this.groupBox1.Controls.Add(this.startPatternButton);
            this.groupBox1.Location = new System.Drawing.Point(4, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 51);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ISO15416 Quality Tests (multi-row symbologies: PDF417, MicroPDF417)";
            // 
            // centerPatternButton
            // 
            this.centerPatternButton.Location = new System.Drawing.Point(116, 19);
            this.centerPatternButton.Name = "centerPatternButton";
            this.centerPatternButton.Size = new System.Drawing.Size(99, 23);
            this.centerPatternButton.TabIndex = 8;
            this.centerPatternButton.Text = "Center Pattern...";
            this.centerPatternButton.UseVisualStyleBackColor = true;
            this.centerPatternButton.Click += new System.EventHandler(this.centerPatternButton_Click);
            // 
            // barcodeSymbolButton
            // 
            this.barcodeSymbolButton.Location = new System.Drawing.Point(326, 19);
            this.barcodeSymbolButton.Name = "barcodeSymbolButton";
            this.barcodeSymbolButton.Size = new System.Drawing.Size(168, 23);
            this.barcodeSymbolButton.TabIndex = 7;
            this.barcodeSymbolButton.Text = "Barcode Symbol (informative)...";
            this.barcodeSymbolButton.UseVisualStyleBackColor = true;
            this.barcodeSymbolButton.Click += new System.EventHandler(this.barcodeSymbolButton_Click);
            // 
            // stopPatternButton
            // 
            this.stopPatternButton.Location = new System.Drawing.Point(221, 19);
            this.stopPatternButton.Name = "stopPatternButton";
            this.stopPatternButton.Size = new System.Drawing.Size(99, 23);
            this.stopPatternButton.TabIndex = 6;
            this.stopPatternButton.Text = "Stop Pattern...";
            this.stopPatternButton.UseVisualStyleBackColor = true;
            this.stopPatternButton.Click += new System.EventHandler(this.stopPatternButton_Click);
            // 
            // startPatternButton
            // 
            this.startPatternButton.Location = new System.Drawing.Point(11, 19);
            this.startPatternButton.Name = "startPatternButton";
            this.startPatternButton.Size = new System.Drawing.Size(96, 23);
            this.startPatternButton.TabIndex = 5;
            this.startPatternButton.Text = "Start Pattern...";
            this.startPatternButton.UseVisualStyleBackColor = true;
            this.startPatternButton.Click += new System.EventHandler(this.startPatternButton_Click);
            // 
            // gbScanGrade
            // 
            this.gbScanGrade.Controls.Add(this.sgHi);
            this.gbScanGrade.Controls.Add(this.sgLow);
            this.gbScanGrade.Controls.Add(this.sg4);
            this.gbScanGrade.Controls.Add(this.sg3);
            this.gbScanGrade.Controls.Add(this.sg2);
            this.gbScanGrade.Controls.Add(this.sg1);
            this.gbScanGrade.Controls.Add(this.sg0);
            this.gbScanGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbScanGrade.Location = new System.Drawing.Point(132, 63);
            this.gbScanGrade.Name = "gbScanGrade";
            this.gbScanGrade.Size = new System.Drawing.Size(249, 39);
            this.gbScanGrade.TabIndex = 3;
            this.gbScanGrade.TabStop = false;
            this.gbScanGrade.Text = "Scan Grade (minimum of all grades) - ";
            // 
            // sgHi
            // 
            this.sgHi.AutoSize = true;
            this.sgHi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sgHi.Location = new System.Drawing.Point(218, 17);
            this.sgHi.Name = "sgHi";
            this.sgHi.Size = new System.Drawing.Size(24, 13);
            this.sgHi.TabIndex = 16;
            this.sgHi.Text = "- HI";
            // 
            // sgLow
            // 
            this.sgLow.AutoSize = true;
            this.sgLow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sgLow.ForeColor = System.Drawing.Color.Black;
            this.sgLow.Location = new System.Drawing.Point(8, 17);
            this.sgLow.Name = "sgLow";
            this.sgLow.Size = new System.Drawing.Size(41, 13);
            this.sgLow.TabIndex = 15;
            this.sgLow.Text = "LOW - ";
            // 
            // sg4
            // 
            this.sg4.AutoSize = true;
            this.sg4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sg4.ForeColor = System.Drawing.Color.Silver;
            this.sg4.Location = new System.Drawing.Point(183, 17);
            this.sg4.Name = "sg4";
            this.sg4.Size = new System.Drawing.Size(29, 13);
            this.sg4.TabIndex = 14;
            this.sg4.Text = "4 (A)";
            // 
            // sg3
            // 
            this.sg3.AutoSize = true;
            this.sg3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sg3.ForeColor = System.Drawing.Color.Silver;
            this.sg3.Location = new System.Drawing.Point(148, 17);
            this.sg3.Name = "sg3";
            this.sg3.Size = new System.Drawing.Size(29, 13);
            this.sg3.TabIndex = 13;
            this.sg3.Text = "3 (B)";
            // 
            // sg2
            // 
            this.sg2.AutoSize = true;
            this.sg2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sg2.ForeColor = System.Drawing.Color.Silver;
            this.sg2.Location = new System.Drawing.Point(113, 17);
            this.sg2.Name = "sg2";
            this.sg2.Size = new System.Drawing.Size(29, 13);
            this.sg2.TabIndex = 12;
            this.sg2.Text = "2 (C)";
            // 
            // sg1
            // 
            this.sg1.AutoSize = true;
            this.sg1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sg1.ForeColor = System.Drawing.Color.Silver;
            this.sg1.Location = new System.Drawing.Point(77, 17);
            this.sg1.Name = "sg1";
            this.sg1.Size = new System.Drawing.Size(30, 13);
            this.sg1.TabIndex = 11;
            this.sg1.Text = "1 (D)";
            // 
            // sg0
            // 
            this.sg0.AutoSize = true;
            this.sg0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sg0.ForeColor = System.Drawing.Color.Silver;
            this.sg0.Location = new System.Drawing.Point(46, 17);
            this.sg0.Name = "sg0";
            this.sg0.Size = new System.Drawing.Size(28, 13);
            this.sg0.TabIndex = 10;
            this.sg0.Text = "0 (F)";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(429, 73);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 27);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(508, 514);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cName,
            this.cValue,
            this.cGrade});
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.ShowEditingIcon = false;
            this.dataGridView.Size = new System.Drawing.Size(508, 514);
            this.dataGridView.TabIndex = 1;
            // 
            // cName
            // 
            this.cName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cName.FillWeight = 130F;
            this.cName.HeaderText = "Name";
            this.cName.Name = "cName";
            this.cName.ReadOnly = true;
            // 
            // cValue
            // 
            this.cValue.HeaderText = "Value";
            this.cValue.Name = "cValue";
            this.cValue.ReadOnly = true;
            // 
            // cGrade
            // 
            this.cGrade.HeaderText = "Grade";
            this.cGrade.Name = "cGrade";
            this.cGrade.ReadOnly = true;
            this.cGrade.Width = 110;
            // 
            // ISO15415QualityTestForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 622);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ISO15415QualityTestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ISO/IEC 15415 Print Quality Test";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.gbScanGrade.ResumeLayout(false);
            this.gbScanGrade.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn cName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn cGrade;
        private System.Windows.Forms.GroupBox gbScanGrade;
        private System.Windows.Forms.Label sgHi;
        private System.Windows.Forms.Label sgLow;
        private System.Windows.Forms.Label sg4;
        private System.Windows.Forms.Label sg3;
        private System.Windows.Forms.Label sg2;
        private System.Windows.Forms.Label sg1;
        private System.Windows.Forms.Label sg0;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button stopPatternButton;
        private System.Windows.Forms.Button startPatternButton;
        private System.Windows.Forms.Button barcodeSymbolButton;
        private System.Windows.Forms.Button centerPatternButton;

    }
}