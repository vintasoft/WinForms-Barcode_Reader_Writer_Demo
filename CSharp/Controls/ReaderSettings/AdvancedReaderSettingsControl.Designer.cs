namespace BarcodeDemo
{
    partial class AdvancedReaderSettingsControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.qrMaxAxialNonuniformityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.DataMatrixLPatternMaxErasuresNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.interpretEciCharactersCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.barcodeCharacteristicSmallBarcodesCheckBox = new System.Windows.Forms.CheckBox();
            this.barcodeReaderMSIGroupBox = new System.Windows.Forms.GroupBox();
            this.barcodeReaderMSIChecksumComboBox = new System.Windows.Forms.ComboBox();
            this.useCode128ExtendedDecodeTableCheckBox = new System.Windows.Forms.CheckBox();
            this.collectQualityTestInformationCheckBox = new System.Windows.Forms.CheckBox();
            this.telepenEnableNumericModeCheckBox = new System.Windows.Forms.CheckBox();
            this.searchDistortedQRBarcodesCheckBox = new System.Windows.Forms.CheckBox();
            this.searchDistortedDataMatrixBarcodesCheckBox = new System.Windows.Forms.CheckBox();
            this.optionalChecksumCheckBox = new System.Windows.Forms.CheckBox();
            this.groupAustralianPostCustomInfo = new System.Windows.Forms.GroupBox();
            this.barcodeReaderAustralianCustomInfoComboBox = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qrMaxAxialNonuniformityNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataMatrixLPatternMaxErasuresNumericUpDown)).BeginInit();
            this.groupBox11.SuspendLayout();
            this.barcodeReaderMSIGroupBox.SuspendLayout();
            this.groupAustralianPostCustomInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.qrMaxAxialNonuniformityNumericUpDown);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.DataMatrixLPatternMaxErasuresNumericUpDown);
            this.groupBox5.Controls.Add(this.interpretEciCharactersCheckBox);
            this.groupBox5.Controls.Add(this.groupBox11);
            this.groupBox5.Controls.Add(this.barcodeReaderMSIGroupBox);
            this.groupBox5.Controls.Add(this.useCode128ExtendedDecodeTableCheckBox);
            this.groupBox5.Controls.Add(this.collectQualityTestInformationCheckBox);
            this.groupBox5.Controls.Add(this.telepenEnableNumericModeCheckBox);
            this.groupBox5.Controls.Add(this.searchDistortedQRBarcodesCheckBox);
            this.groupBox5.Controls.Add(this.searchDistortedDataMatrixBarcodesCheckBox);
            this.groupBox5.Controls.Add(this.optionalChecksumCheckBox);
            this.groupBox5.Controls.Add(this.groupAustralianPostCustomInfo);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(0, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(276, 245);
            this.groupBox5.TabIndex = 24;
            this.groupBox5.TabStop = false;
            // 
            // qrMaxAxialNonuniformityNumericUpDown
            // 
            this.qrMaxAxialNonuniformityNumericUpDown.Location = new System.Drawing.Point(207, 115);
            this.qrMaxAxialNonuniformityNumericUpDown.Name = "qrMaxAxialNonuniformityNumericUpDown";
            this.qrMaxAxialNonuniformityNumericUpDown.Size = new System.Drawing.Size(63, 20);
            this.qrMaxAxialNonuniformityNumericUpDown.TabIndex = 45;
            this.qrMaxAxialNonuniformityNumericUpDown.ValueChanged += new System.EventHandler(this.qrMaxANNumericUpDown_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 26);
            this.label1.TabIndex = 44;
            this.label1.Text = "Max erasures in \"L\" pattern \r\nof DataMatrix barcodes";
            // 
            // DataMatrixLPatternMaxErasuresNumericUpDown
            // 
            this.DataMatrixLPatternMaxErasuresNumericUpDown.Location = new System.Drawing.Point(207, 90);
            this.DataMatrixLPatternMaxErasuresNumericUpDown.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.DataMatrixLPatternMaxErasuresNumericUpDown.Name = "DataMatrixLPatternMaxErasuresNumericUpDown";
            this.DataMatrixLPatternMaxErasuresNumericUpDown.Size = new System.Drawing.Size(63, 20);
            this.DataMatrixLPatternMaxErasuresNumericUpDown.TabIndex = 43;
            this.DataMatrixLPatternMaxErasuresNumericUpDown.ValueChanged += new System.EventHandler(this.DataMatrixLPatternMaxErasuresNumericUpDown_ValueChanged);
            // 
            // interpretEciCharactersCheckBox
            // 
            this.interpretEciCharactersCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.interpretEciCharactersCheckBox.Location = new System.Drawing.Point(7, 184);
            this.interpretEciCharactersCheckBox.Name = "interpretEciCharactersCheckBox";
            this.interpretEciCharactersCheckBox.Size = new System.Drawing.Size(241, 17);
            this.interpretEciCharactersCheckBox.TabIndex = 42;
            this.interpretEciCharactersCheckBox.Text = "Interpret ECI characters (text encoding info)";
            this.interpretEciCharactersCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.barcodeCharacteristicSmallBarcodesCheckBox);
            this.groupBox11.Location = new System.Drawing.Point(6, 200);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(264, 40);
            this.groupBox11.TabIndex = 41;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Barcode Characteristics";
            // 
            // barcodeCharacteristicSmallBarcodesCheckBox
            // 
            this.barcodeCharacteristicSmallBarcodesCheckBox.Location = new System.Drawing.Point(6, 17);
            this.barcodeCharacteristicSmallBarcodesCheckBox.Name = "barcodeCharacteristicSmallBarcodesCheckBox";
            this.barcodeCharacteristicSmallBarcodesCheckBox.Size = new System.Drawing.Size(106, 17);
            this.barcodeCharacteristicSmallBarcodesCheckBox.TabIndex = 42;
            this.barcodeCharacteristicSmallBarcodesCheckBox.Text = "Small bacodes";
            this.barcodeCharacteristicSmallBarcodesCheckBox.UseVisualStyleBackColor = true;
            this.barcodeCharacteristicSmallBarcodesCheckBox.CheckedChanged += new System.EventHandler(this.settingCheckBox_CheckedChanged);
            // 
            // barcodeReaderMSIGroupBox
            // 
            this.barcodeReaderMSIGroupBox.Controls.Add(this.barcodeReaderMSIChecksumComboBox);
            this.barcodeReaderMSIGroupBox.Location = new System.Drawing.Point(145, 10);
            this.barcodeReaderMSIGroupBox.Name = "barcodeReaderMSIGroupBox";
            this.barcodeReaderMSIGroupBox.Size = new System.Drawing.Size(126, 42);
            this.barcodeReaderMSIGroupBox.TabIndex = 33;
            this.barcodeReaderMSIGroupBox.TabStop = false;
            this.barcodeReaderMSIGroupBox.Text = "MSI Checksum";
            // 
            // barcodeReaderMSIChecksumComboBox
            // 
            this.barcodeReaderMSIChecksumComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.barcodeReaderMSIChecksumComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.barcodeReaderMSIChecksumComboBox.FormattingEnabled = true;
            this.barcodeReaderMSIChecksumComboBox.Location = new System.Drawing.Point(3, 16);
            this.barcodeReaderMSIChecksumComboBox.Name = "barcodeReaderMSIChecksumComboBox";
            this.barcodeReaderMSIChecksumComboBox.Size = new System.Drawing.Size(120, 21);
            this.barcodeReaderMSIChecksumComboBox.TabIndex = 0;
            this.barcodeReaderMSIChecksumComboBox.SelectedIndexChanged += new System.EventHandler(this.barcodeReaderMSIChecksumComboBox_SelectedIndexChanged);
            // 
            // useCode128ExtendedDecodeTableCheckBox
            // 
            this.useCode128ExtendedDecodeTableCheckBox.Location = new System.Drawing.Point(7, 168);
            this.useCode128ExtendedDecodeTableCheckBox.Name = "useCode128ExtendedDecodeTableCheckBox";
            this.useCode128ExtendedDecodeTableCheckBox.Size = new System.Drawing.Size(241, 17);
            this.useCode128ExtendedDecodeTableCheckBox.TabIndex = 40;
            this.useCode128ExtendedDecodeTableCheckBox.Text = "Code128: use extended ASCII (FNC4 shift)";
            this.useCode128ExtendedDecodeTableCheckBox.UseVisualStyleBackColor = true;
            this.useCode128ExtendedDecodeTableCheckBox.CheckedChanged += new System.EventHandler(this.settingCheckBox_CheckedChanged);
            // 
            // collectQualityTestInformationCheckBox
            // 
            this.collectQualityTestInformationCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.collectQualityTestInformationCheckBox.Location = new System.Drawing.Point(7, 151);
            this.collectQualityTestInformationCheckBox.Name = "collectQualityTestInformationCheckBox";
            this.collectQualityTestInformationCheckBox.Size = new System.Drawing.Size(236, 17);
            this.collectQualityTestInformationCheckBox.TabIndex = 39;
            this.collectQualityTestInformationCheckBox.Text = "Collect quality test information";
            this.collectQualityTestInformationCheckBox.UseVisualStyleBackColor = true;
            this.collectQualityTestInformationCheckBox.CheckedChanged += new System.EventHandler(this.settingCheckBox_CheckedChanged);
            // 
            // telepenEnableNumericModeCheckBox
            // 
            this.telepenEnableNumericModeCheckBox.Location = new System.Drawing.Point(7, 134);
            this.telepenEnableNumericModeCheckBox.Name = "telepenEnableNumericModeCheckBox";
            this.telepenEnableNumericModeCheckBox.Size = new System.Drawing.Size(236, 17);
            this.telepenEnableNumericModeCheckBox.TabIndex = 37;
            this.telepenEnableNumericModeCheckBox.Text = "Enable Numeric mode in Telepen barcode";
            this.telepenEnableNumericModeCheckBox.UseVisualStyleBackColor = true;
            this.telepenEnableNumericModeCheckBox.CheckedChanged += new System.EventHandler(this.settingCheckBox_CheckedChanged);
            // 
            // searchDistortedQRBarcodesCheckBox
            // 
            this.searchDistortedQRBarcodesCheckBox.Location = new System.Drawing.Point(7, 118);
            this.searchDistortedQRBarcodesCheckBox.Name = "searchDistortedQRBarcodesCheckBox";
            this.searchDistortedQRBarcodesCheckBox.Size = new System.Drawing.Size(211, 17);
            this.searchDistortedQRBarcodesCheckBox.TabIndex = 36;
            this.searchDistortedQRBarcodesCheckBox.Text = "Search distorted QR, max AN (x0.01):";
            this.searchDistortedQRBarcodesCheckBox.UseVisualStyleBackColor = true;
            this.searchDistortedQRBarcodesCheckBox.CheckedChanged += new System.EventHandler(this.settingCheckBox_CheckedChanged);
            // 
            // searchDistortedDataMatrixBarcodesCheckBox
            // 
            this.searchDistortedDataMatrixBarcodesCheckBox.Location = new System.Drawing.Point(7, 70);
            this.searchDistortedDataMatrixBarcodesCheckBox.Name = "searchDistortedDataMatrixBarcodesCheckBox";
            this.searchDistortedDataMatrixBarcodesCheckBox.Size = new System.Drawing.Size(225, 17);
            this.searchDistortedDataMatrixBarcodesCheckBox.TabIndex = 35;
            this.searchDistortedDataMatrixBarcodesCheckBox.Text = "Search distorted DataMatrix barcodes";
            this.searchDistortedDataMatrixBarcodesCheckBox.UseVisualStyleBackColor = true;
            this.searchDistortedDataMatrixBarcodesCheckBox.CheckedChanged += new System.EventHandler(this.settingCheckBox_CheckedChanged);
            // 
            // optionalChecksumCheckBox
            // 
            this.optionalChecksumCheckBox.Location = new System.Drawing.Point(7, 54);
            this.optionalChecksumCheckBox.Name = "optionalChecksumCheckBox";
            this.optionalChecksumCheckBox.Size = new System.Drawing.Size(169, 17);
            this.optionalChecksumCheckBox.TabIndex = 33;
            this.optionalChecksumCheckBox.Text = "Optional checksum";
            this.optionalChecksumCheckBox.UseVisualStyleBackColor = true;
            this.optionalChecksumCheckBox.CheckedChanged += new System.EventHandler(this.settingCheckBox_CheckedChanged);
            // 
            // groupAustralianPostCustomInfo
            // 
            this.groupAustralianPostCustomInfo.Controls.Add(this.barcodeReaderAustralianCustomInfoComboBox);
            this.groupAustralianPostCustomInfo.Location = new System.Drawing.Point(7, 10);
            this.groupAustralianPostCustomInfo.Name = "groupAustralianPostCustomInfo";
            this.groupAustralianPostCustomInfo.Size = new System.Drawing.Size(135, 42);
            this.groupAustralianPostCustomInfo.TabIndex = 32;
            this.groupAustralianPostCustomInfo.TabStop = false;
            this.groupAustralianPostCustomInfo.Text = "Australian custom info";
            // 
            // barcodeReaderAustralianCustomInfoComboBox
            // 
            this.barcodeReaderAustralianCustomInfoComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.barcodeReaderAustralianCustomInfoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.barcodeReaderAustralianCustomInfoComboBox.FormattingEnabled = true;
            this.barcodeReaderAustralianCustomInfoComboBox.Location = new System.Drawing.Point(3, 16);
            this.barcodeReaderAustralianCustomInfoComboBox.Name = "barcodeReaderAustralianCustomInfoComboBox";
            this.barcodeReaderAustralianCustomInfoComboBox.Size = new System.Drawing.Size(129, 21);
            this.barcodeReaderAustralianCustomInfoComboBox.TabIndex = 1;
            this.barcodeReaderAustralianCustomInfoComboBox.SelectedIndexChanged += new System.EventHandler(this.barcodeReaderAustralianCustomInfoComboBox_SelectedIndexChanged);
            // 
            // AdvancedReaderSettingsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox5);
            this.Name = "AdvancedReaderSettingsControl";
            this.Size = new System.Drawing.Size(276, 245);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qrMaxAxialNonuniformityNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataMatrixLPatternMaxErasuresNumericUpDown)).EndInit();
            this.groupBox11.ResumeLayout(false);
            this.barcodeReaderMSIGroupBox.ResumeLayout(false);
            this.groupAustralianPostCustomInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox11;
        internal System.Windows.Forms.CheckBox barcodeCharacteristicSmallBarcodesCheckBox;
        private System.Windows.Forms.ComboBox barcodeReaderMSIChecksumComboBox;
        internal System.Windows.Forms.CheckBox useCode128ExtendedDecodeTableCheckBox;
        internal System.Windows.Forms.CheckBox collectQualityTestInformationCheckBox;
        internal System.Windows.Forms.CheckBox telepenEnableNumericModeCheckBox;
        internal System.Windows.Forms.CheckBox searchDistortedQRBarcodesCheckBox;
        internal System.Windows.Forms.CheckBox searchDistortedDataMatrixBarcodesCheckBox;
        internal System.Windows.Forms.CheckBox optionalChecksumCheckBox;
        private System.Windows.Forms.ComboBox barcodeReaderAustralianCustomInfoComboBox;
        private System.Windows.Forms.GroupBox barcodeReaderMSIGroupBox;
        private System.Windows.Forms.GroupBox groupAustralianPostCustomInfo;
        internal System.Windows.Forms.CheckBox interpretEciCharactersCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown DataMatrixLPatternMaxErasuresNumericUpDown;
        private System.Windows.Forms.NumericUpDown qrMaxAxialNonuniformityNumericUpDown;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
