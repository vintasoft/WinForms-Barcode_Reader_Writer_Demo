namespace BarcodeDemo
{
    partial class QuietZoneEditorForm
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.leftNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.allNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.rightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.topNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.bottomNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.leftNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomNumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(97, 104);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(16, 104);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 2;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // leftNumericUpDown
            // 
            this.leftNumericUpDown.Location = new System.Drawing.Point(7, 40);
            this.leftNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.leftNumericUpDown.Name = "leftNumericUpDown";
            this.leftNumericUpDown.Size = new System.Drawing.Size(48, 20);
            this.leftNumericUpDown.TabIndex = 4;
            this.leftNumericUpDown.ValueChanged += new System.EventHandler(this.sideNumericUpDown_ValueChanged);
            // 
            // allNumericUpDown
            // 
            this.allNumericUpDown.Location = new System.Drawing.Point(61, 40);
            this.allNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.allNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.allNumericUpDown.Name = "allNumericUpDown";
            this.allNumericUpDown.Size = new System.Drawing.Size(48, 20);
            this.allNumericUpDown.TabIndex = 5;
            this.allNumericUpDown.ValueChanged += new System.EventHandler(this.allNumericUpDown_ValueChanged);
            // 
            // rightNumericUpDown
            // 
            this.rightNumericUpDown.Location = new System.Drawing.Point(116, 40);
            this.rightNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.rightNumericUpDown.Name = "rightNumericUpDown";
            this.rightNumericUpDown.Size = new System.Drawing.Size(48, 20);
            this.rightNumericUpDown.TabIndex = 6;
            this.rightNumericUpDown.ValueChanged += new System.EventHandler(this.sideNumericUpDown_ValueChanged);
            // 
            // topNumericUpDown
            // 
            this.topNumericUpDown.Location = new System.Drawing.Point(61, 14);
            this.topNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.topNumericUpDown.Name = "topNumericUpDown";
            this.topNumericUpDown.Size = new System.Drawing.Size(48, 20);
            this.topNumericUpDown.TabIndex = 7;
            this.topNumericUpDown.ValueChanged += new System.EventHandler(this.sideNumericUpDown_ValueChanged);
            // 
            // bottomNumericUpDown
            // 
            this.bottomNumericUpDown.Location = new System.Drawing.Point(61, 66);
            this.bottomNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.bottomNumericUpDown.Name = "bottomNumericUpDown";
            this.bottomNumericUpDown.Size = new System.Drawing.Size(48, 20);
            this.bottomNumericUpDown.TabIndex = 8;
            this.bottomNumericUpDown.ValueChanged += new System.EventHandler(this.sideNumericUpDown_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.topNumericUpDown);
            this.groupBox1.Controls.Add(this.bottomNumericUpDown);
            this.groupBox1.Controls.Add(this.leftNumericUpDown);
            this.groupBox1.Controls.Add(this.allNumericUpDown);
            this.groupBox1.Controls.Add(this.rightNumericUpDown);
            this.groupBox1.Location = new System.Drawing.Point(7, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(172, 94);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // QuietZoneEditorForm
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(186, 133);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "QuietZoneEditorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quiet Zone";
            ((System.ComponentModel.ISupportInitialize)(this.leftNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomNumericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.NumericUpDown leftNumericUpDown;
        private System.Windows.Forms.NumericUpDown allNumericUpDown;
        private System.Windows.Forms.NumericUpDown rightNumericUpDown;
        private System.Windows.Forms.NumericUpDown topNumericUpDown;
        private System.Windows.Forms.NumericUpDown bottomNumericUpDown;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}