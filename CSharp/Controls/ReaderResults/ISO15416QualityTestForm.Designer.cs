namespace BarcodeDemo
{
    partial class ISO15416QualityTestForm
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
            this.okButton = new System.Windows.Forms.Button();
            this.overallGradeGroupBox = new System.Windows.Forms.GroupBox();
            this.sgHi = new System.Windows.Forms.Label();
            this.sgLow = new System.Windows.Forms.Label();
            this.grade4Label = new System.Windows.Forms.Label();
            this.grade3Label = new System.Windows.Forms.Label();
            this.grade2Label = new System.Windows.Forms.Label();
            this.grade1Label = new System.Windows.Forms.Label();
            this.grade0Label = new System.Windows.Forms.Label();
            this.displayTypeComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rawDataRadioButton = new System.Windows.Forms.RadioButton();
            this.analysisRadioButton = new System.Windows.Forms.RadioButton();
            this.testResults = new System.Windows.Forms.RichTextBox();
            this.overallGradeGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.Location = new System.Drawing.Point(354, 526);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 27);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // overallGradeGroupBox
            // 
            this.overallGradeGroupBox.Controls.Add(this.sgHi);
            this.overallGradeGroupBox.Controls.Add(this.sgLow);
            this.overallGradeGroupBox.Controls.Add(this.grade4Label);
            this.overallGradeGroupBox.Controls.Add(this.grade3Label);
            this.overallGradeGroupBox.Controls.Add(this.grade2Label);
            this.overallGradeGroupBox.Controls.Add(this.grade1Label);
            this.overallGradeGroupBox.Controls.Add(this.grade0Label);
            this.overallGradeGroupBox.Location = new System.Drawing.Point(10, 3);
            this.overallGradeGroupBox.Name = "overallGradeGroupBox";
            this.overallGradeGroupBox.Size = new System.Drawing.Size(249, 61);
            this.overallGradeGroupBox.TabIndex = 4;
            this.overallGradeGroupBox.TabStop = false;
            this.overallGradeGroupBox.Text = "Overall Symbol Grade - ";
            // 
            // sgHi
            // 
            this.sgHi.AutoSize = true;
            this.sgHi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sgHi.Location = new System.Drawing.Point(218, 27);
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
            this.sgLow.Location = new System.Drawing.Point(8, 27);
            this.sgLow.Name = "sgLow";
            this.sgLow.Size = new System.Drawing.Size(41, 13);
            this.sgLow.TabIndex = 15;
            this.sgLow.Text = "LOW - ";
            // 
            // grade4Label
            // 
            this.grade4Label.AutoSize = true;
            this.grade4Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grade4Label.ForeColor = System.Drawing.Color.Silver;
            this.grade4Label.Location = new System.Drawing.Point(183, 27);
            this.grade4Label.Name = "grade4Label";
            this.grade4Label.Size = new System.Drawing.Size(29, 13);
            this.grade4Label.TabIndex = 14;
            this.grade4Label.Text = "4 (A)";
            // 
            // grade3Label
            // 
            this.grade3Label.AutoSize = true;
            this.grade3Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grade3Label.ForeColor = System.Drawing.Color.Silver;
            this.grade3Label.Location = new System.Drawing.Point(148, 27);
            this.grade3Label.Name = "grade3Label";
            this.grade3Label.Size = new System.Drawing.Size(29, 13);
            this.grade3Label.TabIndex = 13;
            this.grade3Label.Text = "3 (B)";
            // 
            // grade2Label
            // 
            this.grade2Label.AutoSize = true;
            this.grade2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grade2Label.ForeColor = System.Drawing.Color.Silver;
            this.grade2Label.Location = new System.Drawing.Point(113, 27);
            this.grade2Label.Name = "grade2Label";
            this.grade2Label.Size = new System.Drawing.Size(29, 13);
            this.grade2Label.TabIndex = 12;
            this.grade2Label.Text = "2 (C)";
            // 
            // grade1Label
            // 
            this.grade1Label.AutoSize = true;
            this.grade1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grade1Label.ForeColor = System.Drawing.Color.Silver;
            this.grade1Label.Location = new System.Drawing.Point(77, 27);
            this.grade1Label.Name = "grade1Label";
            this.grade1Label.Size = new System.Drawing.Size(30, 13);
            this.grade1Label.TabIndex = 11;
            this.grade1Label.Text = "1 (D)";
            // 
            // grade0Label
            // 
            this.grade0Label.AutoSize = true;
            this.grade0Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grade0Label.ForeColor = System.Drawing.Color.Silver;
            this.grade0Label.Location = new System.Drawing.Point(46, 27);
            this.grade0Label.Name = "grade0Label";
            this.grade0Label.Size = new System.Drawing.Size(28, 13);
            this.grade0Label.TabIndex = 10;
            this.grade0Label.Text = "0 (F)";
            // 
            // displayTypeComboBox
            // 
            this.displayTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.displayTypeComboBox.FormattingEnabled = true;
            this.displayTypeComboBox.Location = new System.Drawing.Point(7, 15);
            this.displayTypeComboBox.Name = "displayTypeComboBox";
            this.displayTypeComboBox.Size = new System.Drawing.Size(143, 21);
            this.displayTypeComboBox.TabIndex = 5;
            this.displayTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.infoTypeComboBox_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rawDataRadioButton);
            this.groupBox1.Controls.Add(this.analysisRadioButton);
            this.groupBox1.Controls.Add(this.displayTypeComboBox);
            this.groupBox1.Location = new System.Drawing.Point(265, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(159, 61);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Display Type";
            // 
            // rawDataRadioButton
            // 
            this.rawDataRadioButton.AutoSize = true;
            this.rawDataRadioButton.Location = new System.Drawing.Point(81, 38);
            this.rawDataRadioButton.Name = "rawDataRadioButton";
            this.rawDataRadioButton.Size = new System.Drawing.Size(75, 17);
            this.rawDataRadioButton.TabIndex = 7;
            this.rawDataRadioButton.TabStop = true;
            this.rawDataRadioButton.Text = "RAW data";
            this.rawDataRadioButton.UseVisualStyleBackColor = true;
            this.rawDataRadioButton.CheckedChanged += new System.EventHandler(this.imageRadioButton_CheckedChanged);
            // 
            // analysisRadioButton
            // 
            this.analysisRadioButton.AutoSize = true;
            this.analysisRadioButton.Location = new System.Drawing.Point(7, 38);
            this.analysisRadioButton.Name = "analysisRadioButton";
            this.analysisRadioButton.Size = new System.Drawing.Size(63, 17);
            this.analysisRadioButton.TabIndex = 6;
            this.analysisRadioButton.TabStop = true;
            this.analysisRadioButton.Text = "Analysis";
            this.analysisRadioButton.UseVisualStyleBackColor = true;
            this.analysisRadioButton.CheckedChanged += new System.EventHandler(this.analysisRadioButton_CheckedChanged);
            // 
            // testResults
            // 
            this.testResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.testResults.Font = new System.Drawing.Font("Courier New", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.testResults.Location = new System.Drawing.Point(10, 70);
            this.testResults.Name = "testResults";
            this.testResults.ReadOnly = true;
            this.testResults.Size = new System.Drawing.Size(764, 450);
            this.testResults.TabIndex = 8;
            this.testResults.Text = "";
            this.testResults.WordWrap = false;
            // 
            // ISO15416QualityTestForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.testResults);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.overallGradeGroupBox);
            this.Controls.Add(this.okButton);
            this.MinimizeBox = false;
            this.Name = "ISO15416QualityTestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ISO/IEC 15465 Print Quality Test";
            this.overallGradeGroupBox.ResumeLayout(false);
            this.overallGradeGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.GroupBox overallGradeGroupBox;
        private System.Windows.Forms.Label sgHi;
        private System.Windows.Forms.Label sgLow;
        private System.Windows.Forms.Label grade4Label;
        private System.Windows.Forms.Label grade3Label;
        private System.Windows.Forms.Label grade2Label;
        private System.Windows.Forms.Label grade1Label;
        private System.Windows.Forms.Label grade0Label;
        private System.Windows.Forms.ComboBox displayTypeComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rawDataRadioButton;
        private System.Windows.Forms.RadioButton analysisRadioButton;
        private System.Windows.Forms.RichTextBox testResults;
    }
}