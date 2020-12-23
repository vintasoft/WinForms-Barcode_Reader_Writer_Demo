namespace BarcodeDemo
{
    partial class SelectPdfPageForm
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
            this.selectButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pages = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // selectButton
            // 
            this.selectButton.Location = new System.Drawing.Point(167, 37);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(75, 28);
            this.selectButton.TabIndex = 4;
            this.selectButton.Text = "Select";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "This PDF file contains {0} pages with images, select page:";
            // 
            // pages
            // 
            this.pages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pages.FormattingEnabled = true;
            this.pages.Location = new System.Drawing.Point(294, 7);
            this.pages.Name = "pages";
            this.pages.Size = new System.Drawing.Size(86, 21);
            this.pages.TabIndex = 5;
            // 
            // SelectPdfPageForm
            // 
            this.ClientSize = new System.Drawing.Size(399, 73);
            this.Controls.Add(this.pages);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "SelectPdfPageForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select a PDF page number";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPdfPageSelect_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox pages;
    }
}
