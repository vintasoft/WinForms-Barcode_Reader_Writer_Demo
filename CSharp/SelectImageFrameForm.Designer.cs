namespace BarcodeDemo
{
    partial class SelectImageFrameForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.selectButton = new System.Windows.Forms.Button();
            this.frameNumber = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.frameNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "This image contains {0} frames, select frame:";
            // 
            // selectButton
            // 
            this.selectButton.Location = new System.Drawing.Point(144, 40);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(75, 23);
            this.selectButton.TabIndex = 1;
            this.selectButton.Text = "Select";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // frameNumber
            // 
            this.frameNumber.Location = new System.Drawing.Point(254, 12);
            this.frameNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.frameNumber.Name = "frameNumber";
            this.frameNumber.Size = new System.Drawing.Size(82, 20);
            this.frameNumber.TabIndex = 2;
            this.frameNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // SelectImageFrameForm
            // 
            this.AcceptButton = this.selectButton;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 71);
            this.Controls.Add(this.frameNumber);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectImageFrameForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Frame select";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPageSelect_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.frameNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.NumericUpDown frameNumber;
    }
}