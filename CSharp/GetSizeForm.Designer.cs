namespace BarcodeDemo
{
    partial class GetSizeForm
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
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelSize = new System.Windows.Forms.Label();
            this.resolutionValueEditor = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.unitsValueEditor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.widthValueEditor = new System.Windows.Forms.NumericUpDown();
            this.heightValueEditor = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.resolutionValueEditor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthValueEditor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightValueEditor)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(42, 124);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(123, 124);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Location = new System.Drawing.Point(12, 9);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(35, 13);
            this.labelSize.TabIndex = 2;
            this.labelSize.Text = "Width";
            // 
            // resolutionValueEditor
            // 
            this.resolutionValueEditor.Location = new System.Drawing.Point(90, 85);
            this.resolutionValueEditor.Maximum = new decimal(new int[] {
            6000,
            0,
            0,
            0});
            this.resolutionValueEditor.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.resolutionValueEditor.Name = "resolutionValueEditor";
            this.resolutionValueEditor.Size = new System.Drawing.Size(75, 20);
            this.resolutionValueEditor.TabIndex = 4;
            this.resolutionValueEditor.Value = new decimal(new int[] {
            96,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Resolution";
            // 
            // unitsValueEditor
            // 
            this.unitsValueEditor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.unitsValueEditor.FormattingEnabled = true;
            this.unitsValueEditor.Location = new System.Drawing.Point(90, 58);
            this.unitsValueEditor.Name = "unitsValueEditor";
            this.unitsValueEditor.Size = new System.Drawing.Size(106, 21);
            this.unitsValueEditor.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "DPI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Height";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Units";
            // 
            // widthValueEditor
            // 
            this.widthValueEditor.DecimalPlaces = 2;
            this.widthValueEditor.Location = new System.Drawing.Point(90, 5);
            this.widthValueEditor.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.widthValueEditor.Name = "widthValueEditor";
            this.widthValueEditor.Size = new System.Drawing.Size(106, 20);
            this.widthValueEditor.TabIndex = 11;
            // 
            // heightValueEditor
            // 
            this.heightValueEditor.DecimalPlaces = 2;
            this.heightValueEditor.Location = new System.Drawing.Point(90, 31);
            this.heightValueEditor.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.heightValueEditor.Name = "heightValueEditor";
            this.heightValueEditor.Size = new System.Drawing.Size(106, 20);
            this.heightValueEditor.TabIndex = 12;
            // 
            // GetSizeForm
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(210, 159);
            this.Controls.Add(this.heightValueEditor);
            this.Controls.Add(this.widthValueEditor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.unitsValueEditor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resolutionValueEditor);
            this.Controls.Add(this.labelSize);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GetSizeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Set image size";
            ((System.ComponentModel.ISupportInitialize)(this.resolutionValueEditor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthValueEditor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightValueEditor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.NumericUpDown resolutionValueEditor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox unitsValueEditor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown widthValueEditor;
        private System.Windows.Forms.NumericUpDown heightValueEditor;
    }
}