namespace BarcodeDemo.Controls.ReaderResults
{
    partial class BarcodeMatrixModulationForm
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
            this.cellSizeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.alphaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.cellSizeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alphaNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cellSizeNumericUpDown
            // 
            this.cellSizeNumericUpDown.Location = new System.Drawing.Point(85, 8);
            this.cellSizeNumericUpDown.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.cellSizeNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cellSizeNumericUpDown.Name = "cellSizeNumericUpDown";
            this.cellSizeNumericUpDown.Size = new System.Drawing.Size(65, 20);
            this.cellSizeNumericUpDown.TabIndex = 1;
            this.cellSizeNumericUpDown.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.cellSizeNumericUpDown.ValueChanged += new System.EventHandler(this.cellSizeNumericUpDown_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cell Size (px)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Modulation Alpha (%)";
            // 
            // alphaNumericUpDown
            // 
            this.alphaNumericUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.alphaNumericUpDown.Location = new System.Drawing.Point(287, 8);
            this.alphaNumericUpDown.Name = "alphaNumericUpDown";
            this.alphaNumericUpDown.Size = new System.Drawing.Size(65, 20);
            this.alphaNumericUpDown.TabIndex = 3;
            this.alphaNumericUpDown.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.alphaNumericUpDown.ValueChanged += new System.EventHandler(this.alphaNumericUpDown_ValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(271, 230);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(1, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(589, 506);
            this.panel1.TabIndex = 6;
            // 
            // BarcodeMatrixModulationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 544);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.alphaNumericUpDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cellSizeNumericUpDown);
            this.Name = "BarcodeMatrixModulationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BarcodeMatrixModulationForm";
            ((System.ComponentModel.ISupportInitialize)(this.cellSizeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alphaNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown cellSizeNumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown alphaNumericUpDown;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}