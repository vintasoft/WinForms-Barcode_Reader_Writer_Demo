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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.commonTabPage = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.maxCellSizeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.barcodeCharacteristicNormalBarcodesCheckBox = new System.Windows.Forms.CheckBox();
            this.barcodeCharacteristicSmallBarcodesCheckBox = new System.Windows.Forms.CheckBox();
            this.optionalChecksumCheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.recognitionTimeoutNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.interpretEciCharactersCheckBox = new System.Windows.Forms.CheckBox();
            this.collectQualityTestInformationCheckBox = new System.Windows.Forms.CheckBox();
            this.imagePreproceesingTabPage = new System.Windows.Forms.TabPage();
            this.erodeCheckBox = new System.Windows.Forms.CheckBox();
            this.removePeasCheckBox = new System.Windows.Forms.CheckBox();
            this.invertColorsCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.downscale3RadioButton = new System.Windows.Forms.RadioButton();
            this.downscale2RadioButton = new System.Windows.Forms.RadioButton();
            this.upscale3RadioButton = new System.Windows.Forms.RadioButton();
            this.upscale2RadioButton = new System.Windows.Forms.RadioButton();
            this.noScaleRadioButton = new System.Windows.Forms.RadioButton();
            this.downscale4RadioButton = new System.Windows.Forms.RadioButton();
            this.barcodesTabPage = new System.Windows.Forms.TabPage();
            this.searchQRModel1CheckBox = new System.Windows.Forms.CheckBox();
            this.barcodeReaderAustralianCustomInfoComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.barcodeReaderMSIChecksumComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.useCode128ExtendedDecodeTableCheckBox = new System.Windows.Forms.CheckBox();
            this.code39WithoutStartStopCheckBox = new System.Windows.Forms.CheckBox();
            this.telepenEnableNumericModeCheckBox = new System.Windows.Forms.CheckBox();
            this.searchDistortedQRBarcodesCheckBox = new System.Windows.Forms.CheckBox();
            this.DataMatrixLPatternMaxErasuresNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.searchDistortedDataMatrixBarcodesCheckBox = new System.Windows.Forms.CheckBox();
            this.qrMaxAxialNonuniformityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox5.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.commonTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxCellSizeNumericUpDown)).BeginInit();
            this.groupBox11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recognitionTimeoutNumericUpDown)).BeginInit();
            this.imagePreproceesingTabPage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.barcodesTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataMatrixLPatternMaxErasuresNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qrMaxAxialNonuniformityNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tabControl1);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(0, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(276, 245);
            this.groupBox5.TabIndex = 24;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Barcode reader advanced settings";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.commonTabPage);
            this.tabControl1.Controls.Add(this.imagePreproceesingTabPage);
            this.tabControl1.Controls.Add(this.barcodesTabPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 16);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(270, 226);
            this.tabControl1.TabIndex = 48;
            // 
            // commonTabPage
            // 
            this.commonTabPage.Controls.Add(this.label5);
            this.commonTabPage.Controls.Add(this.label6);
            this.commonTabPage.Controls.Add(this.maxCellSizeNumericUpDown);
            this.commonTabPage.Controls.Add(this.groupBox11);
            this.commonTabPage.Controls.Add(this.optionalChecksumCheckBox);
            this.commonTabPage.Controls.Add(this.label2);
            this.commonTabPage.Controls.Add(this.label1);
            this.commonTabPage.Controls.Add(this.recognitionTimeoutNumericUpDown);
            this.commonTabPage.Controls.Add(this.interpretEciCharactersCheckBox);
            this.commonTabPage.Controls.Add(this.collectQualityTestInformationCheckBox);
            this.commonTabPage.Location = new System.Drawing.Point(4, 22);
            this.commonTabPage.Name = "commonTabPage";
            this.commonTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.commonTabPage.Size = new System.Drawing.Size(262, 200);
            this.commonTabPage.TabIndex = 0;
            this.commonTabPage.Text = "Common";
            this.commonTabPage.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(236, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 49;
            this.label5.Text = "px";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 13);
            this.label6.TabIndex = 50;
            this.label6.Text = "Matrix barcode cell size (max)";
            // 
            // maxCellSizeNumericUpDown
            // 
            this.maxCellSizeNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.maxCellSizeNumericUpDown.Location = new System.Drawing.Point(163, 109);
            this.maxCellSizeNumericUpDown.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.maxCellSizeNumericUpDown.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.maxCellSizeNumericUpDown.Name = "maxCellSizeNumericUpDown";
            this.maxCellSizeNumericUpDown.Size = new System.Drawing.Size(67, 20);
            this.maxCellSizeNumericUpDown.TabIndex = 48;
            this.maxCellSizeNumericUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.maxCellSizeNumericUpDown.ValueChanged += new System.EventHandler(this.maxCellSizeNumericUpDown_ValueChanged);
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.barcodeCharacteristicNormalBarcodesCheckBox);
            this.groupBox11.Controls.Add(this.barcodeCharacteristicSmallBarcodesCheckBox);
            this.groupBox11.Location = new System.Drawing.Point(6, 158);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(250, 40);
            this.groupBox11.TabIndex = 41;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Barcode Characteristics";
            // 
            // barcodeCharacteristicNormalBarcodesCheckBox
            // 
            this.barcodeCharacteristicNormalBarcodesCheckBox.Location = new System.Drawing.Point(124, 17);
            this.barcodeCharacteristicNormalBarcodesCheckBox.Name = "barcodeCharacteristicNormalBarcodesCheckBox";
            this.barcodeCharacteristicNormalBarcodesCheckBox.Size = new System.Drawing.Size(126, 17);
            this.barcodeCharacteristicNormalBarcodesCheckBox.TabIndex = 43;
            this.barcodeCharacteristicNormalBarcodesCheckBox.Text = "Normal size bacodes";
            this.barcodeCharacteristicNormalBarcodesCheckBox.UseVisualStyleBackColor = true;
            this.barcodeCharacteristicNormalBarcodesCheckBox.CheckedChanged += new System.EventHandler(this.settingCheckBox_CheckedChanged);
            // 
            // barcodeCharacteristicSmallBarcodesCheckBox
            // 
            this.barcodeCharacteristicSmallBarcodesCheckBox.Location = new System.Drawing.Point(6, 17);
            this.barcodeCharacteristicSmallBarcodesCheckBox.Name = "barcodeCharacteristicSmallBarcodesCheckBox";
            this.barcodeCharacteristicSmallBarcodesCheckBox.Size = new System.Drawing.Size(121, 17);
            this.barcodeCharacteristicSmallBarcodesCheckBox.TabIndex = 42;
            this.barcodeCharacteristicSmallBarcodesCheckBox.Text = "Small size bacodes";
            this.barcodeCharacteristicSmallBarcodesCheckBox.UseVisualStyleBackColor = true;
            this.barcodeCharacteristicSmallBarcodesCheckBox.CheckedChanged += new System.EventHandler(this.settingCheckBox_CheckedChanged);
            // 
            // optionalChecksumCheckBox
            // 
            this.optionalChecksumCheckBox.Location = new System.Drawing.Point(6, 52);
            this.optionalChecksumCheckBox.Name = "optionalChecksumCheckBox";
            this.optionalChecksumCheckBox.Size = new System.Drawing.Size(169, 17);
            this.optionalChecksumCheckBox.TabIndex = 33;
            this.optionalChecksumCheckBox.Text = "Check optional checksum";
            this.optionalChecksumCheckBox.UseVisualStyleBackColor = true;
            this.optionalChecksumCheckBox.CheckedChanged += new System.EventHandler(this.settingCheckBox_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ms";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Recognition time-out";
            // 
            // recognitionTimeoutNumericUpDown
            // 
            this.recognitionTimeoutNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.recognitionTimeoutNumericUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.recognitionTimeoutNumericUpDown.Location = new System.Drawing.Point(163, 133);
            this.recognitionTimeoutNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.recognitionTimeoutNumericUpDown.Name = "recognitionTimeoutNumericUpDown";
            this.recognitionTimeoutNumericUpDown.Size = new System.Drawing.Size(67, 20);
            this.recognitionTimeoutNumericUpDown.TabIndex = 0;
            this.recognitionTimeoutNumericUpDown.ValueChanged += new System.EventHandler(this.recognitionTimeoutNumericUpDown_ValueChanged);
            // 
            // interpretEciCharactersCheckBox
            // 
            this.interpretEciCharactersCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.interpretEciCharactersCheckBox.Location = new System.Drawing.Point(6, 29);
            this.interpretEciCharactersCheckBox.Name = "interpretEciCharactersCheckBox";
            this.interpretEciCharactersCheckBox.Size = new System.Drawing.Size(241, 17);
            this.interpretEciCharactersCheckBox.TabIndex = 42;
            this.interpretEciCharactersCheckBox.Text = "Interpret ECI characters (text encoding info)";
            this.interpretEciCharactersCheckBox.UseVisualStyleBackColor = true;
            // 
            // collectQualityTestInformationCheckBox
            // 
            this.collectQualityTestInformationCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.collectQualityTestInformationCheckBox.Location = new System.Drawing.Point(6, 6);
            this.collectQualityTestInformationCheckBox.Name = "collectQualityTestInformationCheckBox";
            this.collectQualityTestInformationCheckBox.Size = new System.Drawing.Size(236, 17);
            this.collectQualityTestInformationCheckBox.TabIndex = 39;
            this.collectQualityTestInformationCheckBox.Text = "Collect quality test information";
            this.collectQualityTestInformationCheckBox.UseVisualStyleBackColor = true;
            this.collectQualityTestInformationCheckBox.CheckedChanged += new System.EventHandler(this.settingCheckBox_CheckedChanged);
            // 
            // imagePreproceesingTabPage
            // 
            this.imagePreproceesingTabPage.Controls.Add(this.erodeCheckBox);
            this.imagePreproceesingTabPage.Controls.Add(this.removePeasCheckBox);
            this.imagePreproceesingTabPage.Controls.Add(this.invertColorsCheckBox);
            this.imagePreproceesingTabPage.Controls.Add(this.groupBox1);
            this.imagePreproceesingTabPage.Location = new System.Drawing.Point(4, 22);
            this.imagePreproceesingTabPage.Name = "imagePreproceesingTabPage";
            this.imagePreproceesingTabPage.Size = new System.Drawing.Size(262, 200);
            this.imagePreproceesingTabPage.TabIndex = 2;
            this.imagePreproceesingTabPage.Text = "Image Preprocessing";
            this.imagePreproceesingTabPage.UseVisualStyleBackColor = true;
            // 
            // erodeCheckBox
            // 
            this.erodeCheckBox.Location = new System.Drawing.Point(12, 96);
            this.erodeCheckBox.Name = "erodeCheckBox";
            this.erodeCheckBox.Size = new System.Drawing.Size(62, 17);
            this.erodeCheckBox.TabIndex = 55;
            this.erodeCheckBox.Text = "Erode";
            this.erodeCheckBox.UseVisualStyleBackColor = true;
            this.erodeCheckBox.CheckedChanged += new System.EventHandler(this.imageProcessing_SettingsChanged);
            // 
            // removePeasCheckBox
            // 
            this.removePeasCheckBox.Checked = true;
            this.removePeasCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.removePeasCheckBox.Location = new System.Drawing.Point(12, 50);
            this.removePeasCheckBox.Name = "removePeasCheckBox";
            this.removePeasCheckBox.Size = new System.Drawing.Size(106, 17);
            this.removePeasCheckBox.TabIndex = 54;
            this.removePeasCheckBox.Text = "Remove \"peas\"";
            this.removePeasCheckBox.UseVisualStyleBackColor = true;
            this.removePeasCheckBox.CheckedChanged += new System.EventHandler(this.imageProcessing_SettingsChanged);
            // 
            // invertColorsCheckBox
            // 
            this.invertColorsCheckBox.Location = new System.Drawing.Point(12, 73);
            this.invertColorsCheckBox.Name = "invertColorsCheckBox";
            this.invertColorsCheckBox.Size = new System.Drawing.Size(92, 17);
            this.invertColorsCheckBox.TabIndex = 53;
            this.invertColorsCheckBox.Text = "Invert colors";
            this.invertColorsCheckBox.UseVisualStyleBackColor = true;
            this.invertColorsCheckBox.CheckedChanged += new System.EventHandler(this.imageProcessing_SettingsChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.downscale3RadioButton);
            this.groupBox1.Controls.Add(this.downscale2RadioButton);
            this.groupBox1.Controls.Add(this.upscale3RadioButton);
            this.groupBox1.Controls.Add(this.upscale2RadioButton);
            this.groupBox1.Controls.Add(this.noScaleRadioButton);
            this.groupBox1.Controls.Add(this.downscale4RadioButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(6, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 40);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Image Scale Factor";
            // 
            // downscale3RadioButton
            // 
            this.downscale3RadioButton.AutoSize = true;
            this.downscale3RadioButton.Location = new System.Drawing.Point(48, 14);
            this.downscale3RadioButton.Name = "downscale3RadioButton";
            this.downscale3RadioButton.Size = new System.Drawing.Size(42, 17);
            this.downscale3RadioButton.TabIndex = 5;
            this.downscale3RadioButton.Text = "1/3";
            this.downscale3RadioButton.UseVisualStyleBackColor = true;
            // 
            // downscale2RadioButton
            // 
            this.downscale2RadioButton.AutoSize = true;
            this.downscale2RadioButton.Location = new System.Drawing.Point(93, 14);
            this.downscale2RadioButton.Name = "downscale2RadioButton";
            this.downscale2RadioButton.Size = new System.Drawing.Size(42, 17);
            this.downscale2RadioButton.TabIndex = 4;
            this.downscale2RadioButton.Text = "1/2";
            this.downscale2RadioButton.UseVisualStyleBackColor = true;
            this.downscale2RadioButton.CheckedChanged += new System.EventHandler(this.settingCheckBox_CheckedChanged);
            // 
            // upscale3RadioButton
            // 
            this.upscale3RadioButton.AutoSize = true;
            this.upscale3RadioButton.Location = new System.Drawing.Point(214, 14);
            this.upscale3RadioButton.Name = "upscale3RadioButton";
            this.upscale3RadioButton.Size = new System.Drawing.Size(31, 17);
            this.upscale3RadioButton.TabIndex = 3;
            this.upscale3RadioButton.Text = "3";
            this.upscale3RadioButton.UseVisualStyleBackColor = true;
            this.upscale3RadioButton.CheckedChanged += new System.EventHandler(this.settingCheckBox_CheckedChanged);
            // 
            // upscale2RadioButton
            // 
            this.upscale2RadioButton.AutoSize = true;
            this.upscale2RadioButton.Location = new System.Drawing.Point(180, 14);
            this.upscale2RadioButton.Name = "upscale2RadioButton";
            this.upscale2RadioButton.Size = new System.Drawing.Size(31, 17);
            this.upscale2RadioButton.TabIndex = 2;
            this.upscale2RadioButton.Text = "2";
            this.upscale2RadioButton.UseVisualStyleBackColor = true;
            this.upscale2RadioButton.CheckedChanged += new System.EventHandler(this.settingCheckBox_CheckedChanged);
            // 
            // noScaleRadioButton
            // 
            this.noScaleRadioButton.AutoSize = true;
            this.noScaleRadioButton.Checked = true;
            this.noScaleRadioButton.Location = new System.Drawing.Point(138, 14);
            this.noScaleRadioButton.Name = "noScaleRadioButton";
            this.noScaleRadioButton.Size = new System.Drawing.Size(39, 17);
            this.noScaleRadioButton.TabIndex = 1;
            this.noScaleRadioButton.TabStop = true;
            this.noScaleRadioButton.Text = "No";
            this.noScaleRadioButton.UseVisualStyleBackColor = true;
            this.noScaleRadioButton.CheckedChanged += new System.EventHandler(this.settingCheckBox_CheckedChanged);
            // 
            // downscale4RadioButton
            // 
            this.downscale4RadioButton.AutoSize = true;
            this.downscale4RadioButton.Location = new System.Drawing.Point(4, 14);
            this.downscale4RadioButton.Name = "downscale4RadioButton";
            this.downscale4RadioButton.Size = new System.Drawing.Size(42, 17);
            this.downscale4RadioButton.TabIndex = 0;
            this.downscale4RadioButton.Text = "1/4";
            this.downscale4RadioButton.UseVisualStyleBackColor = true;
            this.downscale4RadioButton.CheckedChanged += new System.EventHandler(this.settingCheckBox_CheckedChanged);
            // 
            // barcodesTabPage
            // 
            this.barcodesTabPage.Controls.Add(this.searchQRModel1CheckBox);
            this.barcodesTabPage.Controls.Add(this.barcodeReaderAustralianCustomInfoComboBox);
            this.barcodesTabPage.Controls.Add(this.label4);
            this.barcodesTabPage.Controls.Add(this.barcodeReaderMSIChecksumComboBox);
            this.barcodesTabPage.Controls.Add(this.label3);
            this.barcodesTabPage.Controls.Add(this.useCode128ExtendedDecodeTableCheckBox);
            this.barcodesTabPage.Controls.Add(this.code39WithoutStartStopCheckBox);
            this.barcodesTabPage.Controls.Add(this.telepenEnableNumericModeCheckBox);
            this.barcodesTabPage.Controls.Add(this.searchDistortedQRBarcodesCheckBox);
            this.barcodesTabPage.Controls.Add(this.DataMatrixLPatternMaxErasuresNumericUpDown);
            this.barcodesTabPage.Controls.Add(this.searchDistortedDataMatrixBarcodesCheckBox);
            this.barcodesTabPage.Controls.Add(this.qrMaxAxialNonuniformityNumericUpDown);
            this.barcodesTabPage.Location = new System.Drawing.Point(4, 22);
            this.barcodesTabPage.Name = "barcodesTabPage";
            this.barcodesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.barcodesTabPage.Size = new System.Drawing.Size(262, 200);
            this.barcodesTabPage.TabIndex = 1;
            this.barcodesTabPage.Text = "Barcodes";
            this.barcodesTabPage.UseVisualStyleBackColor = true;
            // 
            // searchQRModel1CheckBox
            // 
            this.searchQRModel1CheckBox.Location = new System.Drawing.Point(7, 107);
            this.searchQRModel1CheckBox.Name = "searchQRModel1CheckBox";
            this.searchQRModel1CheckBox.Size = new System.Drawing.Size(241, 15);
            this.searchQRModel1CheckBox.TabIndex = 50;
            this.searchQRModel1CheckBox.Text = "Search QR Model 1 and QR Model 2";
            this.searchQRModel1CheckBox.UseVisualStyleBackColor = true;
            this.searchQRModel1CheckBox.CheckedChanged += new System.EventHandler(this.settingCheckBox_CheckedChanged);
            // 
            // barcodeReaderAustralianCustomInfoComboBox
            // 
            this.barcodeReaderAustralianCustomInfoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.barcodeReaderAustralianCustomInfoComboBox.FormattingEnabled = true;
            this.barcodeReaderAustralianCustomInfoComboBox.Location = new System.Drawing.Point(135, 35);
            this.barcodeReaderAustralianCustomInfoComboBox.Name = "barcodeReaderAustralianCustomInfoComboBox";
            this.barcodeReaderAustralianCustomInfoComboBox.Size = new System.Drawing.Size(121, 21);
            this.barcodeReaderAustralianCustomInfoComboBox.TabIndex = 1;
            this.barcodeReaderAustralianCustomInfoComboBox.SelectedIndexChanged += new System.EventHandler(this.barcodeReaderAustralianCustomInfoComboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 49;
            this.label4.Text = "Australian custom info";
            // 
            // barcodeReaderMSIChecksumComboBox
            // 
            this.barcodeReaderMSIChecksumComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.barcodeReaderMSIChecksumComboBox.FormattingEnabled = true;
            this.barcodeReaderMSIChecksumComboBox.Location = new System.Drawing.Point(135, 11);
            this.barcodeReaderMSIChecksumComboBox.Name = "barcodeReaderMSIChecksumComboBox";
            this.barcodeReaderMSIChecksumComboBox.Size = new System.Drawing.Size(121, 21);
            this.barcodeReaderMSIChecksumComboBox.TabIndex = 0;
            this.barcodeReaderMSIChecksumComboBox.SelectedIndexChanged += new System.EventHandler(this.barcodeReaderMSIChecksumComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "MSI Checksum";
            // 
            // useCode128ExtendedDecodeTableCheckBox
            // 
            this.useCode128ExtendedDecodeTableCheckBox.Location = new System.Drawing.Point(7, 171);
            this.useCode128ExtendedDecodeTableCheckBox.Name = "useCode128ExtendedDecodeTableCheckBox";
            this.useCode128ExtendedDecodeTableCheckBox.Size = new System.Drawing.Size(241, 17);
            this.useCode128ExtendedDecodeTableCheckBox.TabIndex = 40;
            this.useCode128ExtendedDecodeTableCheckBox.Text = "Code 128: use extended ASCII (FNC4 shift)";
            this.useCode128ExtendedDecodeTableCheckBox.UseVisualStyleBackColor = true;
            this.useCode128ExtendedDecodeTableCheckBox.CheckedChanged += new System.EventHandler(this.settingCheckBox_CheckedChanged);
            // 
            // code39WithoutStartStopCheckBox
            // 
            this.code39WithoutStartStopCheckBox.Location = new System.Drawing.Point(7, 149);
            this.code39WithoutStartStopCheckBox.Name = "code39WithoutStartStopCheckBox";
            this.code39WithoutStartStopCheckBox.Size = new System.Drawing.Size(241, 17);
            this.code39WithoutStartStopCheckBox.TabIndex = 47;
            this.code39WithoutStartStopCheckBox.Text = "Search Code 39 without Start/Stop";
            this.code39WithoutStartStopCheckBox.UseVisualStyleBackColor = true;
            this.code39WithoutStartStopCheckBox.CheckedChanged += new System.EventHandler(this.settingCheckBox_CheckedChanged);
            // 
            // telepenEnableNumericModeCheckBox
            // 
            this.telepenEnableNumericModeCheckBox.Location = new System.Drawing.Point(7, 128);
            this.telepenEnableNumericModeCheckBox.Name = "telepenEnableNumericModeCheckBox";
            this.telepenEnableNumericModeCheckBox.Size = new System.Drawing.Size(236, 17);
            this.telepenEnableNumericModeCheckBox.TabIndex = 37;
            this.telepenEnableNumericModeCheckBox.Text = "Enable Numeric mode in Telepen barcode";
            this.telepenEnableNumericModeCheckBox.UseVisualStyleBackColor = true;
            this.telepenEnableNumericModeCheckBox.CheckedChanged += new System.EventHandler(this.settingCheckBox_CheckedChanged);
            // 
            // searchDistortedQRBarcodesCheckBox
            // 
            this.searchDistortedQRBarcodesCheckBox.Location = new System.Drawing.Point(7, 86);
            this.searchDistortedQRBarcodesCheckBox.Name = "searchDistortedQRBarcodesCheckBox";
            this.searchDistortedQRBarcodesCheckBox.Size = new System.Drawing.Size(211, 17);
            this.searchDistortedQRBarcodesCheckBox.TabIndex = 36;
            this.searchDistortedQRBarcodesCheckBox.Text = "Search distorted QR, max AN (x0.01):";
            this.searchDistortedQRBarcodesCheckBox.UseVisualStyleBackColor = true;
            this.searchDistortedQRBarcodesCheckBox.CheckedChanged += new System.EventHandler(this.settingCheckBox_CheckedChanged);
            // 
            // DataMatrixLPatternMaxErasuresNumericUpDown
            // 
            this.DataMatrixLPatternMaxErasuresNumericUpDown.Location = new System.Drawing.Point(221, 64);
            this.DataMatrixLPatternMaxErasuresNumericUpDown.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.DataMatrixLPatternMaxErasuresNumericUpDown.Name = "DataMatrixLPatternMaxErasuresNumericUpDown";
            this.DataMatrixLPatternMaxErasuresNumericUpDown.Size = new System.Drawing.Size(37, 20);
            this.DataMatrixLPatternMaxErasuresNumericUpDown.TabIndex = 43;
            this.toolTip1.SetToolTip(this.DataMatrixLPatternMaxErasuresNumericUpDown, "Max Erasures in \"L\" Pattern");
            this.DataMatrixLPatternMaxErasuresNumericUpDown.ValueChanged += new System.EventHandler(this.DataMatrixLPatternMaxErasuresNumericUpDown_ValueChanged);
            // 
            // searchDistortedDataMatrixBarcodesCheckBox
            // 
            this.searchDistortedDataMatrixBarcodesCheckBox.Location = new System.Drawing.Point(7, 65);
            this.searchDistortedDataMatrixBarcodesCheckBox.Name = "searchDistortedDataMatrixBarcodesCheckBox";
            this.searchDistortedDataMatrixBarcodesCheckBox.Size = new System.Drawing.Size(236, 17);
            this.searchDistortedDataMatrixBarcodesCheckBox.TabIndex = 35;
            this.searchDistortedDataMatrixBarcodesCheckBox.Text = "Search distorted DataMatrix, max Eras.:";
            this.searchDistortedDataMatrixBarcodesCheckBox.UseVisualStyleBackColor = true;
            this.searchDistortedDataMatrixBarcodesCheckBox.CheckedChanged += new System.EventHandler(this.settingCheckBox_CheckedChanged);
            // 
            // qrMaxAxialNonuniformityNumericUpDown
            // 
            this.qrMaxAxialNonuniformityNumericUpDown.Location = new System.Drawing.Point(221, 85);
            this.qrMaxAxialNonuniformityNumericUpDown.Name = "qrMaxAxialNonuniformityNumericUpDown";
            this.qrMaxAxialNonuniformityNumericUpDown.Size = new System.Drawing.Size(37, 20);
            this.qrMaxAxialNonuniformityNumericUpDown.TabIndex = 45;
            this.toolTip1.SetToolTip(this.qrMaxAxialNonuniformityNumericUpDown, "Max Axial Nonuniformity");
            this.qrMaxAxialNonuniformityNumericUpDown.ValueChanged += new System.EventHandler(this.qrMaxANNumericUpDown_ValueChanged);
            // 
            // AdvancedReaderSettingsControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox5);
            this.Name = "AdvancedReaderSettingsControl";
            this.Size = new System.Drawing.Size(276, 245);
            this.groupBox5.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.commonTabPage.ResumeLayout(false);
            this.commonTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxCellSizeNumericUpDown)).EndInit();
            this.groupBox11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.recognitionTimeoutNumericUpDown)).EndInit();
            this.imagePreproceesingTabPage.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.barcodesTabPage.ResumeLayout(false);
            this.barcodesTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataMatrixLPatternMaxErasuresNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qrMaxAxialNonuniformityNumericUpDown)).EndInit();
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
        internal System.Windows.Forms.CheckBox interpretEciCharactersCheckBox;
        private System.Windows.Forms.NumericUpDown DataMatrixLPatternMaxErasuresNumericUpDown;
        private System.Windows.Forms.NumericUpDown qrMaxAxialNonuniformityNumericUpDown;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown recognitionTimeoutNumericUpDown;
        internal System.Windows.Forms.CheckBox code39WithoutStartStopCheckBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage commonTabPage;
        private System.Windows.Forms.TabPage barcodesTabPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown maxCellSizeNumericUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.CheckBox searchQRModel1CheckBox;
        private System.Windows.Forms.TabPage imagePreproceesingTabPage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton downscale2RadioButton;
        private System.Windows.Forms.RadioButton upscale3RadioButton;
        private System.Windows.Forms.RadioButton upscale2RadioButton;
        private System.Windows.Forms.RadioButton noScaleRadioButton;
        private System.Windows.Forms.RadioButton downscale4RadioButton;
        private System.Windows.Forms.CheckBox erodeCheckBox;
        private System.Windows.Forms.CheckBox removePeasCheckBox;
        private System.Windows.Forms.CheckBox invertColorsCheckBox;
        private System.Windows.Forms.RadioButton downscale3RadioButton;
        internal System.Windows.Forms.CheckBox barcodeCharacteristicNormalBarcodesCheckBox;
    }
}