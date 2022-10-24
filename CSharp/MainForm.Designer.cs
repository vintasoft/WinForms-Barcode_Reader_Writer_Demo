namespace BarcodeDemo
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.readerTabPage = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.barcodeReaderPictureBox = new System.Windows.Forms.PictureBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.currentBarcodeInfo = new System.Windows.Forms.Label();
            this.outputTextRichTextBox = new System.Windows.Forms.RichTextBox();
            this.tpSettings = new System.Windows.Forms.TabPage();
            this.readerBarcodeTypes = new BarcodeDemo.ReaderSettingsBarcodeTypesControl();
            this.advancedReaderSettings = new BarcodeDemo.AdvancedReaderSettingsControl();
            this.GroupBox6 = new System.Windows.Forms.GroupBox();
            this.scanIntervalEditor = new BarcodeDemo.ScanIntervalEditorControl();
            this.expectedBarcodesEditor = new BarcodeDemo.ExpectedBarcodesEditorControl();
            this.scanDirectionEditor = new BarcodeDemo.ScanDirectionEditorControl();
            this.maxThreadCountEditor = new BarcodeDemo.MaxThreadCountEditorControl();
            this.minConfidenceEditor = new BarcodeDemo.MinConfidenceEditorControl();
            this.resetSettingsButton = new System.Windows.Forms.Button();
            this.demoVersionRestrictionsGroupBox = new System.Windows.Forms.GroupBox();
            this.unregistredRestrictionsLabel = new System.Windows.Forms.Label();
            this.tpResults = new System.Windows.Forms.TabPage();
            this.barcodeReaderResultsControl1 = new BarcodeDemo.BarcodeReaderResultsControl();
            this.writerTabPage = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.panel4 = new System.Windows.Forms.Panel();
            this.barcodeWriterErrorText = new System.Windows.Forms.Label();
            this.writerPictureBox = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.barcodeWriterBarcodeInformation = new System.Windows.Forms.TextBox();
            this.clearWriterImageButton = new System.Windows.Forms.Button();
            this.saveWriterImageButton = new System.Windows.Forms.Button();
            this.readBarcodeFromWriterImageButton = new System.Windows.Forms.Button();
            this.createWriterImageButton = new System.Windows.Forms.Button();
            this.barcodeWriterSettingsControl1 = new BarcodeDemo.Controls.BarcodeWriterSettingsControl();
            this.readerTools = new System.Windows.Forms.Panel();
            this.expectedBarcodesSlaveEditor = new BarcodeDemo.ParameterSlaveEditorControl();
            this.scanIntervalSlaveEditor = new BarcodeDemo.ParameterSlaveEditorControl();
            this.showProgressCheckBox = new System.Windows.Forms.CheckBox();
            this.showImageProcessingCheckBox = new System.Windows.Forms.CheckBox();
            this.automaticRecognitionCheckBox = new System.Windows.Forms.CheckBox();
            this.fileListGroupBox = new System.Windows.Forms.GroupBox();
            this.filesListTrackBar = new System.Windows.Forms.TrackBar();
            this.zoomImageCheckBox = new System.Windows.Forms.CheckBox();
            this.highThresholdGroupBox = new System.Windows.Forms.GroupBox();
            this.thresholdMaxTrackBar = new System.Windows.Forms.TrackBar();
            this.readBarcodesButton = new System.Windows.Forms.Button();
            this.thresholdGroupBox = new System.Windows.Forms.GroupBox();
            this.thresholdMinTrackBar = new System.Windows.Forms.TrackBar();
            this.progressGroupBox = new System.Windows.Forms.GroupBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.thresholdMethodGroupBox = new System.Windows.Forms.GroupBox();
            this.thresholdMethodAutoRadioButton = new System.Windows.Forms.RadioButton();
            this.thresholdIterationGroupBox = new System.Windows.Forms.GroupBox();
            this.thresholdIterationsTrackBar = new System.Windows.Forms.TrackBar();
            this.thresholdMethodIterationRadioButton = new System.Windows.Forms.RadioButton();
            this.thresholdMethodManualRadioButton = new System.Windows.Forms.RadioButton();
            this.saveImageFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.writerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveImageAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveSVGImageAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.setImageSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetImageSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.barcodeDesignToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetBarcodeDesignToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveSvgFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.readerTabPage.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barcodeReaderPictureBox)).BeginInit();
            this.panel9.SuspendLayout();
            this.tpSettings.SuspendLayout();
            this.GroupBox6.SuspendLayout();
            this.demoVersionRestrictionsGroupBox.SuspendLayout();
            this.tpResults.SuspendLayout();
            this.writerTabPage.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.writerPictureBox)).BeginInit();
            this.panel2.SuspendLayout();
            this.readerTools.SuspendLayout();
            this.fileListGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filesListTrackBar)).BeginInit();
            this.highThresholdGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdMaxTrackBar)).BeginInit();
            this.thresholdGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdMinTrackBar)).BeginInit();
            this.progressGroupBox.SuspendLayout();
            this.thresholdMethodGroupBox.SuspendLayout();
            this.thresholdIterationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdIterationsTrackBar)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "All supported (*.pdf;*.bmp;*.jpg;*.jpeg;*.jpe;*.jfif;*.tif;*.tiff;*.png;*.gif;*.t" +
    "ga;*.wmf;*.emf)|*.bmp;*.jpg;*.jpeg;*.jpe;*.jfif;*.tif;*.tiff;*.png;*.gif;*.tga;*" +
    ".wmf;*.emf;*.pdf";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.readerTools);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 637);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(784, 489);
            this.panel3.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.tabControl);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(784, 489);
            this.panel6.TabIndex = 2;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.readerTabPage);
            this.tabControl.Controls.Add(this.tpSettings);
            this.tabControl.Controls.Add(this.tpResults);
            this.tabControl.Controls.Add(this.writerTabPage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(784, 489);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // readerTabPage
            // 
            this.readerTabPage.Controls.Add(this.splitContainer1);
            this.readerTabPage.Location = new System.Drawing.Point(4, 22);
            this.readerTabPage.Name = "readerTabPage";
            this.readerTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.readerTabPage.Size = new System.Drawing.Size(776, 463);
            this.readerTabPage.TabIndex = 0;
            this.readerTabPage.Text = "Reader";
            this.readerTabPage.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel7);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.outputTextRichTextBox);
            this.splitContainer1.Size = new System.Drawing.Size(770, 457);
            this.splitContainer1.SplitterDistance = 528;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.panel9);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(528, 457);
            this.panel7.TabIndex = 2;
            // 
            // panel8
            // 
            this.panel8.AutoScroll = true;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.barcodeReaderPictureBox);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(528, 437);
            this.panel8.TabIndex = 3;
            // 
            // barcodeReaderPictureBox
            // 
            this.barcodeReaderPictureBox.Location = new System.Drawing.Point(0, 0);
            this.barcodeReaderPictureBox.Name = "barcodeReaderPictureBox";
            this.barcodeReaderPictureBox.Size = new System.Drawing.Size(190, 187);
            this.barcodeReaderPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.barcodeReaderPictureBox.TabIndex = 5;
            this.barcodeReaderPictureBox.TabStop = false;
            this.barcodeReaderPictureBox.Click += new System.EventHandler(this.barcodeReaderPictureBox_Click);
            this.barcodeReaderPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.barcodeReaderPictureBox_MouseMove);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.Control;
            this.panel9.Controls.Add(this.currentBarcodeInfo);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(0, 437);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(528, 20);
            this.panel9.TabIndex = 2;
            // 
            // currentBarcodeInfo
            // 
            this.currentBarcodeInfo.AutoSize = true;
            this.currentBarcodeInfo.Location = new System.Drawing.Point(5, 3);
            this.currentBarcodeInfo.Name = "currentBarcodeInfo";
            this.currentBarcodeInfo.Size = new System.Drawing.Size(28, 13);
            this.currentBarcodeInfo.TabIndex = 0;
            this.currentBarcodeInfo.Text = "(0,0)";
            // 
            // outputTextRichTextBox
            // 
            this.outputTextRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputTextRichTextBox.Location = new System.Drawing.Point(0, 0);
            this.outputTextRichTextBox.Name = "outputTextRichTextBox";
            this.outputTextRichTextBox.ReadOnly = true;
            this.outputTextRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.outputTextRichTextBox.Size = new System.Drawing.Size(238, 457);
            this.outputTextRichTextBox.TabIndex = 0;
            this.outputTextRichTextBox.Text = "";
            // 
            // tpSettings
            // 
            this.tpSettings.Controls.Add(this.readerBarcodeTypes);
            this.tpSettings.Controls.Add(this.advancedReaderSettings);
            this.tpSettings.Controls.Add(this.GroupBox6);
            this.tpSettings.Location = new System.Drawing.Point(4, 22);
            this.tpSettings.Name = "tpSettings";
            this.tpSettings.Size = new System.Drawing.Size(776, 463);
            this.tpSettings.TabIndex = 2;
            this.tpSettings.Text = "Reader settings";
            this.tpSettings.UseVisualStyleBackColor = true;
            // 
            // readerBarcodeTypes
            // 
            this.readerBarcodeTypes.Location = new System.Drawing.Point(3, 0);
            this.readerBarcodeTypes.Name = "readerBarcodeTypes";
            this.readerBarcodeTypes.Size = new System.Drawing.Size(491, 258);
            this.readerBarcodeTypes.TabIndex = 26;
            // 
            // advancedReaderSettings
            // 
            this.advancedReaderSettings.InterpretEciCharacters = false;
            this.advancedReaderSettings.Location = new System.Drawing.Point(498, 0);
            this.advancedReaderSettings.Name = "advancedReaderSettings";
            this.advancedReaderSettings.Size = new System.Drawing.Size(275, 259);
            this.advancedReaderSettings.TabIndex = 25;
            // 
            // GroupBox6
            // 
            this.GroupBox6.Controls.Add(this.scanIntervalEditor);
            this.GroupBox6.Controls.Add(this.expectedBarcodesEditor);
            this.GroupBox6.Controls.Add(this.scanDirectionEditor);
            this.GroupBox6.Controls.Add(this.maxThreadCountEditor);
            this.GroupBox6.Controls.Add(this.minConfidenceEditor);
            this.GroupBox6.Controls.Add(this.resetSettingsButton);
            this.GroupBox6.Controls.Add(this.demoVersionRestrictionsGroupBox);
            this.GroupBox6.Location = new System.Drawing.Point(4, 258);
            this.GroupBox6.Name = "GroupBox6";
            this.GroupBox6.Size = new System.Drawing.Size(773, 206);
            this.GroupBox6.TabIndex = 22;
            this.GroupBox6.TabStop = false;
            this.GroupBox6.Text = "Barcode read parameters";
            // 
            // scanIntervalEditor
            // 
            this.scanIntervalEditor.Location = new System.Drawing.Point(6, 17);
            this.scanIntervalEditor.Maximum = 30;
            this.scanIntervalEditor.Minimum = 1;
            this.scanIntervalEditor.Name = "scanIntervalEditor";
            this.scanIntervalEditor.Size = new System.Drawing.Size(240, 75);
            this.scanIntervalEditor.TabIndex = 34;
            this.scanIntervalEditor.TickFrequency = 1;
            this.scanIntervalEditor.Title = "Scan interval";
            this.scanIntervalEditor.Value = 5;
            // 
            // expectedBarcodesEditor
            // 
            this.expectedBarcodesEditor.Location = new System.Drawing.Point(259, 17);
            this.expectedBarcodesEditor.Maximum = 72;
            this.expectedBarcodesEditor.Minimum = 1;
            this.expectedBarcodesEditor.Name = "expectedBarcodesEditor";
            this.expectedBarcodesEditor.Size = new System.Drawing.Size(252, 75);
            this.expectedBarcodesEditor.TabIndex = 33;
            this.expectedBarcodesEditor.TickFrequency = 2;
            this.expectedBarcodesEditor.Title = "Expected barcodes";
            this.expectedBarcodesEditor.Value = 1;
            // 
            // scanDirectionEditor
            // 
            this.scanDirectionEditor.Location = new System.Drawing.Point(260, 100);
            this.scanDirectionEditor.Name = "scanDirectionEditor";
            this.scanDirectionEditor.Size = new System.Drawing.Size(252, 97);
            this.scanDirectionEditor.TabIndex = 32;
            // 
            // maxThreadCountEditor
            // 
            this.maxThreadCountEditor.Location = new System.Drawing.Point(6, 99);
            this.maxThreadCountEditor.Name = "maxThreadCountEditor";
            this.maxThreadCountEditor.Size = new System.Drawing.Size(240, 97);
            this.maxThreadCountEditor.TabIndex = 31;
            this.maxThreadCountEditor.TickFrequency = 1;
            this.maxThreadCountEditor.Title = "Max threads count";
            this.maxThreadCountEditor.Value = 4;
            // 
            // minConfidenceEditor
            // 
            this.minConfidenceEditor.Location = new System.Drawing.Point(525, 16);
            this.minConfidenceEditor.Maximum = 100;
            this.minConfidenceEditor.Minimum = 0;
            this.minConfidenceEditor.Name = "minConfidenceEditor";
            this.minConfidenceEditor.Size = new System.Drawing.Size(237, 77);
            this.minConfidenceEditor.TabIndex = 30;
            this.minConfidenceEditor.TickFrequency = 2;
            this.minConfidenceEditor.Title = "Min Confidence";
            this.minConfidenceEditor.Value = 95;
            // 
            // resetSettingsButton
            // 
            this.resetSettingsButton.Location = new System.Drawing.Point(586, 172);
            this.resetSettingsButton.Name = "resetSettingsButton";
            this.resetSettingsButton.Size = new System.Drawing.Size(101, 23);
            this.resetSettingsButton.TabIndex = 29;
            this.resetSettingsButton.Text = "Reset settings";
            this.resetSettingsButton.UseVisualStyleBackColor = true;
            this.resetSettingsButton.Click += new System.EventHandler(this.ResetSettingsButton_Click);
            // 
            // demoVersionRestrictionsGroupBox
            // 
            this.demoVersionRestrictionsGroupBox.Controls.Add(this.unregistredRestrictionsLabel);
            this.demoVersionRestrictionsGroupBox.Location = new System.Drawing.Point(525, 100);
            this.demoVersionRestrictionsGroupBox.Name = "demoVersionRestrictionsGroupBox";
            this.demoVersionRestrictionsGroupBox.Size = new System.Drawing.Size(237, 67);
            this.demoVersionRestrictionsGroupBox.TabIndex = 28;
            this.demoVersionRestrictionsGroupBox.TabStop = false;
            this.demoVersionRestrictionsGroupBox.Text = "Unregistered version restrictions";
            this.demoVersionRestrictionsGroupBox.Visible = false;
            // 
            // unregistredRestrictionsLabel
            // 
            this.unregistredRestrictionsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.unregistredRestrictionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.unregistredRestrictionsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.unregistredRestrictionsLabel.Location = new System.Drawing.Point(3, 16);
            this.unregistredRestrictionsLabel.Name = "unregistredRestrictionsLabel";
            this.unregistredRestrictionsLabel.Size = new System.Drawing.Size(231, 48);
            this.unregistredRestrictionsLabel.TabIndex = 29;
            this.unregistredRestrictionsLabel.Text = "Barcode value in evaluation version will be replaced to the \"*DEMO*\" string for R" +
    "SS(GS1) and Intelligent Mail barcodes.";
            // 
            // tpResults
            // 
            this.tpResults.Controls.Add(this.barcodeReaderResultsControl1);
            this.tpResults.Location = new System.Drawing.Point(4, 22);
            this.tpResults.Name = "tpResults";
            this.tpResults.Padding = new System.Windows.Forms.Padding(3);
            this.tpResults.Size = new System.Drawing.Size(776, 463);
            this.tpResults.TabIndex = 1;
            this.tpResults.Text = "Reader results";
            this.tpResults.UseVisualStyleBackColor = true;
            // 
            // barcodeReaderResultsControl1
            // 
            this.barcodeReaderResultsControl1.BarcodeImage = null;
            this.barcodeReaderResultsControl1.BarcodeInfoIndex = 0;
            this.barcodeReaderResultsControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.barcodeReaderResultsControl1.InterpretEciCharacters = false;
            this.barcodeReaderResultsControl1.InvertBarcodeImage = false;
            this.barcodeReaderResultsControl1.Location = new System.Drawing.Point(3, 3);
            this.barcodeReaderResultsControl1.Name = "barcodeReaderResultsControl1";
            this.barcodeReaderResultsControl1.RecognizedBarcodes = null;
            this.barcodeReaderResultsControl1.Size = new System.Drawing.Size(770, 457);
            this.barcodeReaderResultsControl1.TabIndex = 0;
            // 
            // writerTabPage
            // 
            this.writerTabPage.Controls.Add(this.splitContainer2);
            this.writerTabPage.Location = new System.Drawing.Point(4, 22);
            this.writerTabPage.Name = "writerTabPage";
            this.writerTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.writerTabPage.Size = new System.Drawing.Size(776, 463);
            this.writerTabPage.TabIndex = 3;
            this.writerTabPage.Text = "Writer";
            this.writerTabPage.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.panel4);
            this.splitContainer2.Panel1.Controls.Add(this.panel2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.barcodeWriterSettingsControl1);
            this.splitContainer2.Size = new System.Drawing.Size(770, 457);
            this.splitContainer2.SplitterDistance = 501;
            this.splitContainer2.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.AutoScroll = true;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.barcodeWriterErrorText);
            this.panel4.Controls.Add(this.writerPictureBox);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(501, 309);
            this.panel4.TabIndex = 1;
            // 
            // barcodeWriterErrorText
            // 
            this.barcodeWriterErrorText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.barcodeWriterErrorText.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barcodeWriterErrorText.ForeColor = System.Drawing.Color.DarkRed;
            this.barcodeWriterErrorText.Location = new System.Drawing.Point(0, 0);
            this.barcodeWriterErrorText.Name = "barcodeWriterErrorText";
            this.barcodeWriterErrorText.Size = new System.Drawing.Size(499, 307);
            this.barcodeWriterErrorText.TabIndex = 1;
            this.barcodeWriterErrorText.Text = "Barcode Writing Error";
            this.barcodeWriterErrorText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.barcodeWriterErrorText.Visible = false;
            // 
            // writerPictureBox
            // 
            this.writerPictureBox.Location = new System.Drawing.Point(0, 0);
            this.writerPictureBox.Name = "writerPictureBox";
            this.writerPictureBox.Size = new System.Drawing.Size(100, 100);
            this.writerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.writerPictureBox.TabIndex = 0;
            this.writerPictureBox.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.barcodeWriterBarcodeInformation);
            this.panel2.Controls.Add(this.clearWriterImageButton);
            this.panel2.Controls.Add(this.saveWriterImageButton);
            this.panel2.Controls.Add(this.readBarcodeFromWriterImageButton);
            this.panel2.Controls.Add(this.createWriterImageButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 309);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(501, 148);
            this.panel2.TabIndex = 0;
            // 
            // barcodeWriterBarcodeInformation
            // 
            this.barcodeWriterBarcodeInformation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.barcodeWriterBarcodeInformation.Location = new System.Drawing.Point(178, 3);
            this.barcodeWriterBarcodeInformation.Multiline = true;
            this.barcodeWriterBarcodeInformation.Name = "barcodeWriterBarcodeInformation";
            this.barcodeWriterBarcodeInformation.ReadOnly = true;
            this.barcodeWriterBarcodeInformation.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.barcodeWriterBarcodeInformation.Size = new System.Drawing.Size(321, 141);
            this.barcodeWriterBarcodeInformation.TabIndex = 4;
            // 
            // clearWriterImageButton
            // 
            this.clearWriterImageButton.Enabled = false;
            this.clearWriterImageButton.Location = new System.Drawing.Point(2, 112);
            this.clearWriterImageButton.Name = "clearWriterImageButton";
            this.clearWriterImageButton.Size = new System.Drawing.Size(167, 29);
            this.clearWriterImageButton.TabIndex = 4;
            this.clearWriterImageButton.Text = "Clear image";
            this.clearWriterImageButton.UseVisualStyleBackColor = true;
            this.clearWriterImageButton.Click += new System.EventHandler(this.clearWriterImageButton_Click);
            // 
            // saveWriterImageButton
            // 
            this.saveWriterImageButton.Enabled = false;
            this.saveWriterImageButton.Location = new System.Drawing.Point(2, 77);
            this.saveWriterImageButton.Name = "saveWriterImageButton";
            this.saveWriterImageButton.Size = new System.Drawing.Size(167, 29);
            this.saveWriterImageButton.TabIndex = 2;
            this.saveWriterImageButton.Text = "Save as...";
            this.saveWriterImageButton.UseVisualStyleBackColor = true;
            this.saveWriterImageButton.Click += new System.EventHandler(this.saveImageButton_Click);
            // 
            // readBarcodeFromWriterImageButton
            // 
            this.readBarcodeFromWriterImageButton.Enabled = false;
            this.readBarcodeFromWriterImageButton.Location = new System.Drawing.Point(2, 41);
            this.readBarcodeFromWriterImageButton.Name = "readBarcodeFromWriterImageButton";
            this.readBarcodeFromWriterImageButton.Size = new System.Drawing.Size(167, 30);
            this.readBarcodeFromWriterImageButton.TabIndex = 1;
            this.readBarcodeFromWriterImageButton.Text = "Read barcode";
            this.readBarcodeFromWriterImageButton.UseVisualStyleBackColor = true;
            this.readBarcodeFromWriterImageButton.Click += new System.EventHandler(this.readBarcodesInWriterButton_Click);
            // 
            // createWriterImageButton
            // 
            this.createWriterImageButton.Location = new System.Drawing.Point(2, 5);
            this.createWriterImageButton.Name = "createWriterImageButton";
            this.createWriterImageButton.Size = new System.Drawing.Size(167, 30);
            this.createWriterImageButton.TabIndex = 0;
            this.createWriterImageButton.Text = "Write barcode";
            this.createWriterImageButton.UseVisualStyleBackColor = true;
            this.createWriterImageButton.Click += new System.EventHandler(this.createWriterImageButton_Click);
            // 
            // barcodeWriterSettingsControl1
            // 
            this.barcodeWriterSettingsControl1.BarcodeWriterSettings = null;
            this.barcodeWriterSettingsControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.barcodeWriterSettingsControl1.Location = new System.Drawing.Point(0, 0);
            this.barcodeWriterSettingsControl1.Name = "barcodeWriterSettingsControl1";
            this.barcodeWriterSettingsControl1.SelectedBarcodeSubset = null;
            this.barcodeWriterSettingsControl1.Size = new System.Drawing.Size(265, 457);
            this.barcodeWriterSettingsControl1.TabIndex = 0;
            this.barcodeWriterSettingsControl1.WriterException += new System.EventHandler<BarcodeDemo.ExceptionEventArgs>(this.barcodeWriterSettingsControl1_WriterException);
            // 
            // readerTools
            // 
            this.readerTools.Controls.Add(this.expectedBarcodesSlaveEditor);
            this.readerTools.Controls.Add(this.scanIntervalSlaveEditor);
            this.readerTools.Controls.Add(this.showProgressCheckBox);
            this.readerTools.Controls.Add(this.showImageProcessingCheckBox);
            this.readerTools.Controls.Add(this.automaticRecognitionCheckBox);
            this.readerTools.Controls.Add(this.fileListGroupBox);
            this.readerTools.Controls.Add(this.zoomImageCheckBox);
            this.readerTools.Controls.Add(this.highThresholdGroupBox);
            this.readerTools.Controls.Add(this.readBarcodesButton);
            this.readerTools.Controls.Add(this.thresholdGroupBox);
            this.readerTools.Controls.Add(this.progressGroupBox);
            this.readerTools.Controls.Add(this.thresholdMethodGroupBox);
            this.readerTools.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.readerTools.Location = new System.Drawing.Point(0, 489);
            this.readerTools.Name = "readerTools";
            this.readerTools.Size = new System.Drawing.Size(784, 148);
            this.readerTools.TabIndex = 0;
            // 
            // expectedBarcodesSlaveEditor
            // 
            this.expectedBarcodesSlaveEditor.Location = new System.Drawing.Point(186, 9);
            this.expectedBarcodesSlaveEditor.MasterParameterEditor = this.expectedBarcodesEditor;
            this.expectedBarcodesSlaveEditor.Maximum = 72;
            this.expectedBarcodesSlaveEditor.Minimum = 1;
            this.expectedBarcodesSlaveEditor.Name = "expectedBarcodesSlaveEditor";
            this.expectedBarcodesSlaveEditor.Size = new System.Drawing.Size(288, 97);
            this.expectedBarcodesSlaveEditor.TabIndex = 30;
            this.expectedBarcodesSlaveEditor.TickFrequency = 2;
            this.expectedBarcodesSlaveEditor.Title = "Expected barcodes";
            this.expectedBarcodesSlaveEditor.Value = 1;
            // 
            // scanIntervalSlaveEditor
            // 
            this.scanIntervalSlaveEditor.Location = new System.Drawing.Point(484, 9);
            this.scanIntervalSlaveEditor.MasterParameterEditor = this.scanIntervalEditor;
            this.scanIntervalSlaveEditor.Maximum = 25;
            this.scanIntervalSlaveEditor.Minimum = 1;
            this.scanIntervalSlaveEditor.Name = "scanIntervalSlaveEditor";
            this.scanIntervalSlaveEditor.Size = new System.Drawing.Size(288, 97);
            this.scanIntervalSlaveEditor.TabIndex = 1;
            this.scanIntervalSlaveEditor.TickFrequency = 1;
            this.scanIntervalSlaveEditor.Title = "Scan interval";
            this.scanIntervalSlaveEditor.Value = 5;
            // 
            // showProgressCheckBox
            // 
            this.showProgressCheckBox.Checked = true;
            this.showProgressCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showProgressCheckBox.Location = new System.Drawing.Point(410, 120);
            this.showProgressCheckBox.Name = "showProgressCheckBox";
            this.showProgressCheckBox.Size = new System.Drawing.Size(101, 17);
            this.showProgressCheckBox.TabIndex = 28;
            this.showProgressCheckBox.Text = "Show progress";
            this.showProgressCheckBox.UseVisualStyleBackColor = true;
            this.showProgressCheckBox.CheckedChanged += new System.EventHandler(this.showProgressCheckBox_CheckedChanged);
            // 
            // showImageProcessingCheckBox
            // 
            this.showImageProcessingCheckBox.Location = new System.Drawing.Point(279, 120);
            this.showImageProcessingCheckBox.Name = "showImageProcessingCheckBox";
            this.showImageProcessingCheckBox.Size = new System.Drawing.Size(125, 17);
            this.showImageProcessingCheckBox.TabIndex = 12;
            this.showImageProcessingCheckBox.Text = "Show preprocessing";
            this.showImageProcessingCheckBox.UseVisualStyleBackColor = true;
            this.showImageProcessingCheckBox.CheckedChanged += new System.EventHandler(this.showImageProcessing_CheckedChanged);
            // 
            // automaticRecognitionCheckBox
            // 
            this.automaticRecognitionCheckBox.BackColor = System.Drawing.SystemColors.Control;
            this.automaticRecognitionCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.automaticRecognitionCheckBox.ForeColor = System.Drawing.Color.DarkGreen;
            this.automaticRecognitionCheckBox.Location = new System.Drawing.Point(21, 57);
            this.automaticRecognitionCheckBox.Name = "automaticRecognitionCheckBox";
            this.automaticRecognitionCheckBox.Size = new System.Drawing.Size(151, 17);
            this.automaticRecognitionCheckBox.TabIndex = 24;
            this.automaticRecognitionCheckBox.Text = "Automatic recognition";
            this.automaticRecognitionCheckBox.UseVisualStyleBackColor = false;
            this.automaticRecognitionCheckBox.CheckedChanged += new System.EventHandler(this.automaticRecognitionCheckBox_CheckedChanged);
            // 
            // fileListGroupBox
            // 
            this.fileListGroupBox.Controls.Add(this.filesListTrackBar);
            this.fileListGroupBox.Location = new System.Drawing.Point(10, 89);
            this.fileListGroupBox.Name = "fileListGroupBox";
            this.fileListGroupBox.Size = new System.Drawing.Size(169, 48);
            this.fileListGroupBox.TabIndex = 22;
            this.fileListGroupBox.TabStop = false;
            this.fileListGroupBox.Text = "File X of YY";
            // 
            // filesListTrackBar
            // 
            this.filesListTrackBar.AutoSize = false;
            this.filesListTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filesListTrackBar.LargeChange = 50;
            this.filesListTrackBar.Location = new System.Drawing.Point(3, 16);
            this.filesListTrackBar.Maximum = 1;
            this.filesListTrackBar.Minimum = 1;
            this.filesListTrackBar.Name = "filesListTrackBar";
            this.filesListTrackBar.Size = new System.Drawing.Size(163, 29);
            this.filesListTrackBar.TabIndex = 0;
            this.filesListTrackBar.Value = 1;
            this.filesListTrackBar.ValueChanged += new System.EventHandler(this.filesListTrackBar_ValueChanged);
            // 
            // zoomImageCheckBox
            // 
            this.zoomImageCheckBox.Location = new System.Drawing.Point(185, 119);
            this.zoomImageCheckBox.Name = "zoomImageCheckBox";
            this.zoomImageCheckBox.Size = new System.Drawing.Size(88, 17);
            this.zoomImageCheckBox.TabIndex = 21;
            this.zoomImageCheckBox.Text = "Zoom image";
            this.zoomImageCheckBox.UseVisualStyleBackColor = true;
            this.zoomImageCheckBox.CheckedChanged += new System.EventHandler(this.zoomReaderImage_CheckedChanged);
            // 
            // highThresholdGroupBox
            // 
            this.highThresholdGroupBox.Controls.Add(this.thresholdMaxTrackBar);
            this.highThresholdGroupBox.Location = new System.Drawing.Point(345, 63);
            this.highThresholdGroupBox.Name = "highThresholdGroupBox";
            this.highThresholdGroupBox.Size = new System.Drawing.Size(427, 47);
            this.highThresholdGroupBox.TabIndex = 19;
            this.highThresholdGroupBox.TabStop = false;
            this.highThresholdGroupBox.Text = "High threshold";
            this.highThresholdGroupBox.Visible = false;
            // 
            // thresholdMaxTrackBar
            // 
            this.thresholdMaxTrackBar.AutoSize = false;
            this.thresholdMaxTrackBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.thresholdMaxTrackBar.LargeChange = 50;
            this.thresholdMaxTrackBar.Location = new System.Drawing.Point(3, 14);
            this.thresholdMaxTrackBar.Maximum = 765;
            this.thresholdMaxTrackBar.Name = "thresholdMaxTrackBar";
            this.thresholdMaxTrackBar.Size = new System.Drawing.Size(421, 30);
            this.thresholdMaxTrackBar.TabIndex = 0;
            this.thresholdMaxTrackBar.TickFrequency = 25;
            this.thresholdMaxTrackBar.Value = 150;
            this.thresholdMaxTrackBar.ValueChanged += new System.EventHandler(this.thresholdMaxTrackBar_ValueChanged);
            // 
            // readBarcodesButton
            // 
            this.readBarcodesButton.Enabled = false;
            this.readBarcodesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.readBarcodesButton.Location = new System.Drawing.Point(10, 10);
            this.readBarcodesButton.Name = "readBarcodesButton";
            this.readBarcodesButton.Size = new System.Drawing.Size(169, 42);
            this.readBarcodesButton.TabIndex = 1;
            this.readBarcodesButton.Text = "Read barcodes";
            this.readBarcodesButton.UseVisualStyleBackColor = true;
            this.readBarcodesButton.Click += new System.EventHandler(this.readBarcodesButton_Click);
            // 
            // thresholdGroupBox
            // 
            this.thresholdGroupBox.Controls.Add(this.thresholdMinTrackBar);
            this.thresholdGroupBox.Enabled = false;
            this.thresholdGroupBox.Location = new System.Drawing.Point(345, 8);
            this.thresholdGroupBox.Name = "thresholdGroupBox";
            this.thresholdGroupBox.Size = new System.Drawing.Size(427, 47);
            this.thresholdGroupBox.TabIndex = 18;
            this.thresholdGroupBox.TabStop = false;
            this.thresholdGroupBox.Text = "Threshold";
            // 
            // thresholdMinTrackBar
            // 
            this.thresholdMinTrackBar.AutoSize = false;
            this.thresholdMinTrackBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.thresholdMinTrackBar.LargeChange = 50;
            this.thresholdMinTrackBar.Location = new System.Drawing.Point(3, 14);
            this.thresholdMinTrackBar.Maximum = 768;
            this.thresholdMinTrackBar.Name = "thresholdMinTrackBar";
            this.thresholdMinTrackBar.Size = new System.Drawing.Size(421, 30);
            this.thresholdMinTrackBar.TabIndex = 0;
            this.thresholdMinTrackBar.TickFrequency = 25;
            this.thresholdMinTrackBar.Value = 150;
            this.thresholdMinTrackBar.ValueChanged += new System.EventHandler(this.thresholdMinTrackBar_ValueChanged);
            // 
            // progressGroupBox
            // 
            this.progressGroupBox.Controls.Add(this.progressBar);
            this.progressGroupBox.Location = new System.Drawing.Point(10, 89);
            this.progressGroupBox.Name = "progressGroupBox";
            this.progressGroupBox.Size = new System.Drawing.Size(169, 48);
            this.progressGroupBox.TabIndex = 21;
            this.progressGroupBox.TabStop = false;
            this.progressGroupBox.Text = "0%; 0 barcodes found";
            this.progressGroupBox.Visible = false;
            // 
            // progressBar
            // 
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar.Location = new System.Drawing.Point(3, 16);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(163, 29);
            this.progressBar.TabIndex = 0;
            // 
            // thresholdMethodGroupBox
            // 
            this.thresholdMethodGroupBox.Controls.Add(this.thresholdMethodAutoRadioButton);
            this.thresholdMethodGroupBox.Controls.Add(this.thresholdIterationGroupBox);
            this.thresholdMethodGroupBox.Controls.Add(this.thresholdMethodIterationRadioButton);
            this.thresholdMethodGroupBox.Controls.Add(this.thresholdMethodManualRadioButton);
            this.thresholdMethodGroupBox.Enabled = false;
            this.thresholdMethodGroupBox.Location = new System.Drawing.Point(185, 8);
            this.thresholdMethodGroupBox.Name = "thresholdMethodGroupBox";
            this.thresholdMethodGroupBox.Size = new System.Drawing.Size(157, 102);
            this.thresholdMethodGroupBox.TabIndex = 20;
            this.thresholdMethodGroupBox.TabStop = false;
            this.thresholdMethodGroupBox.Text = "Threshold mode";
            // 
            // thresholdMethodAutoRadioButton
            // 
            this.thresholdMethodAutoRadioButton.Location = new System.Drawing.Point(79, 14);
            this.thresholdMethodAutoRadioButton.Name = "thresholdMethodAutoRadioButton";
            this.thresholdMethodAutoRadioButton.Size = new System.Drawing.Size(75, 17);
            this.thresholdMethodAutoRadioButton.TabIndex = 20;
            this.thresholdMethodAutoRadioButton.TabStop = true;
            this.thresholdMethodAutoRadioButton.Text = "Automatic";
            this.thresholdMethodAutoRadioButton.UseVisualStyleBackColor = true;
            this.thresholdMethodAutoRadioButton.CheckedChanged += new System.EventHandler(this.thresholdMethodAutoRadioButton_CheckedChanged);
            // 
            // thresholdIterationGroupBox
            // 
            this.thresholdIterationGroupBox.Controls.Add(this.thresholdIterationsTrackBar);
            this.thresholdIterationGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.thresholdIterationGroupBox.Location = new System.Drawing.Point(3, 51);
            this.thresholdIterationGroupBox.Name = "thresholdIterationGroupBox";
            this.thresholdIterationGroupBox.Size = new System.Drawing.Size(151, 48);
            this.thresholdIterationGroupBox.TabIndex = 19;
            this.thresholdIterationGroupBox.TabStop = false;
            this.thresholdIterationGroupBox.Text = "Iteration count - xx";
            this.thresholdIterationGroupBox.Visible = false;
            // 
            // thresholdIterationsTrackBar
            // 
            this.thresholdIterationsTrackBar.AutoSize = false;
            this.thresholdIterationsTrackBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.thresholdIterationsTrackBar.LargeChange = 50;
            this.thresholdIterationsTrackBar.Location = new System.Drawing.Point(3, 11);
            this.thresholdIterationsTrackBar.Maximum = 20;
            this.thresholdIterationsTrackBar.Minimum = 2;
            this.thresholdIterationsTrackBar.Name = "thresholdIterationsTrackBar";
            this.thresholdIterationsTrackBar.Size = new System.Drawing.Size(145, 34);
            this.thresholdIterationsTrackBar.TabIndex = 0;
            this.thresholdIterationsTrackBar.Value = 2;
            this.thresholdIterationsTrackBar.ValueChanged += new System.EventHandler(this.thresholdIterationsTrackBar_ValueChanged);
            // 
            // thresholdMethodIterationRadioButton
            // 
            this.thresholdMethodIterationRadioButton.Location = new System.Drawing.Point(9, 31);
            this.thresholdMethodIterationRadioButton.Name = "thresholdMethodIterationRadioButton";
            this.thresholdMethodIterationRadioButton.Size = new System.Drawing.Size(63, 17);
            this.thresholdMethodIterationRadioButton.TabIndex = 2;
            this.thresholdMethodIterationRadioButton.TabStop = true;
            this.thresholdMethodIterationRadioButton.Text = "Iteration";
            this.thresholdMethodIterationRadioButton.UseVisualStyleBackColor = true;
            this.thresholdMethodIterationRadioButton.CheckedChanged += new System.EventHandler(this.thresholdMethodIterationRadioButton_CheckedChanged);
            // 
            // thresholdMethodManualRadioButton
            // 
            this.thresholdMethodManualRadioButton.Location = new System.Drawing.Point(9, 14);
            this.thresholdMethodManualRadioButton.Name = "thresholdMethodManualRadioButton";
            this.thresholdMethodManualRadioButton.Size = new System.Drawing.Size(60, 17);
            this.thresholdMethodManualRadioButton.TabIndex = 0;
            this.thresholdMethodManualRadioButton.TabStop = true;
            this.thresholdMethodManualRadioButton.Text = "Manual";
            this.thresholdMethodManualRadioButton.UseVisualStyleBackColor = true;
            this.thresholdMethodManualRadioButton.CheckedChanged += new System.EventHandler(this.thresholdMethodManualRadioButton_CheckedChanged);
            // 
            // saveImageFileDialog
            // 
            this.saveImageFileDialog.DefaultExt = "png";
            this.saveImageFileDialog.Filter = "PNG (*.png)|*.png";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.writerToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.toolStripSeparator3,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.openToolStripMenuItem.Text = "Open Image...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openImageButton_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.closeToolStripMenuItem.Text = "Close Image";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeImageButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(188, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // writerToolStripMenuItem
            // 
            this.writerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveImageAsToolStripMenuItem,
            this.saveSVGImageAsToolStripMenuItem,
            this.toolStripSeparator2,
            this.setImageSizeToolStripMenuItem,
            this.resetImageSizeToolStripMenuItem,
            this.toolStripSeparator1,
            this.barcodeDesignToolStripMenuItem,
            this.resetBarcodeDesignToolStripMenuItem});
            this.writerToolStripMenuItem.Name = "writerToolStripMenuItem";
            this.writerToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.writerToolStripMenuItem.Text = "Writer";
            // 
            // saveImageAsToolStripMenuItem
            // 
            this.saveImageAsToolStripMenuItem.Name = "saveImageAsToolStripMenuItem";
            this.saveImageAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveImageAsToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.saveImageAsToolStripMenuItem.Text = "Save As Image...";
            this.saveImageAsToolStripMenuItem.Click += new System.EventHandler(this.saveImageButton_Click);
            // 
            // saveSVGImageAsToolStripMenuItem
            // 
            this.saveSVGImageAsToolStripMenuItem.Name = "saveSVGImageAsToolStripMenuItem";
            this.saveSVGImageAsToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.saveSVGImageAsToolStripMenuItem.Text = "Save As SVG File...";
            this.saveSVGImageAsToolStripMenuItem.Click += new System.EventHandler(this.saveSVGImageAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(196, 6);
            // 
            // setImageSizeToolStripMenuItem
            // 
            this.setImageSizeToolStripMenuItem.Name = "setImageSizeToolStripMenuItem";
            this.setImageSizeToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.setImageSizeToolStripMenuItem.Text = "Set Image Size...";
            this.setImageSizeToolStripMenuItem.Click += new System.EventHandler(this.setWriterImageSizeButton_Click);
            // 
            // resetImageSizeToolStripMenuItem
            // 
            this.resetImageSizeToolStripMenuItem.Name = "resetImageSizeToolStripMenuItem";
            this.resetImageSizeToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.resetImageSizeToolStripMenuItem.Text = "Reset Image Size";
            this.resetImageSizeToolStripMenuItem.Click += new System.EventHandler(this.resetBarcodeImageSizeButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(196, 6);
            // 
            // barcodeDesignToolStripMenuItem
            // 
            this.barcodeDesignToolStripMenuItem.Name = "barcodeDesignToolStripMenuItem";
            this.barcodeDesignToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.barcodeDesignToolStripMenuItem.Text = "Barcode Design...";
            this.barcodeDesignToolStripMenuItem.Click += new System.EventHandler(this.barcodeDesignToolStripMenuItem_Click);
            // 
            // resetBarcodeDesignToolStripMenuItem
            // 
            this.resetBarcodeDesignToolStripMenuItem.Name = "resetBarcodeDesignToolStripMenuItem";
            this.resetBarcodeDesignToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.resetBarcodeDesignToolStripMenuItem.Text = "Reset Barcode Design";
            this.resetBarcodeDesignToolStripMenuItem.Click += new System.EventHandler(this.resetBarcodeDesignToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // saveSvgFileDialog
            // 
            this.saveSvgFileDialog.DefaultExt = "svg";
            this.saveSvgFileDialog.Filter = "SVG (*.svg)|*.svg";
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(784, 661);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.readerTabPage.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barcodeReaderPictureBox)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.tpSettings.ResumeLayout(false);
            this.GroupBox6.ResumeLayout(false);
            this.demoVersionRestrictionsGroupBox.ResumeLayout(false);
            this.tpResults.ResumeLayout(false);
            this.writerTabPage.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.writerPictureBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.readerTools.ResumeLayout(false);
            this.fileListGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.filesListTrackBar)).EndInit();
            this.highThresholdGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.thresholdMaxTrackBar)).EndInit();
            this.thresholdGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.thresholdMinTrackBar)).EndInit();
            this.progressGroupBox.ResumeLayout(false);
            this.thresholdMethodGroupBox.ResumeLayout(false);
            this.thresholdIterationGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.thresholdIterationsTrackBar)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel readerTools;
        private System.Windows.Forms.Button readBarcodesButton;
        private System.Windows.Forms.CheckBox showImageProcessingCheckBox;
        internal System.Windows.Forms.GroupBox thresholdGroupBox;
        internal System.Windows.Forms.TrackBar thresholdMinTrackBar;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage readerTabPage;
        private System.Windows.Forms.TabPage tpSettings;
        internal System.Windows.Forms.GroupBox GroupBox6;
        internal System.Windows.Forms.GroupBox highThresholdGroupBox;
        internal System.Windows.Forms.TrackBar thresholdMaxTrackBar;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.PictureBox barcodeReaderPictureBox;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label currentBarcodeInfo;
        private System.Windows.Forms.GroupBox thresholdMethodGroupBox;
        private System.Windows.Forms.RadioButton thresholdMethodIterationRadioButton;
        private System.Windows.Forms.RadioButton thresholdMethodManualRadioButton;
        internal System.Windows.Forms.GroupBox thresholdIterationGroupBox;
        internal System.Windows.Forms.TrackBar thresholdIterationsTrackBar;
        private System.Windows.Forms.CheckBox zoomImageCheckBox;
        private System.Windows.Forms.RadioButton thresholdMethodAutoRadioButton;
        private System.Windows.Forms.RichTextBox outputTextRichTextBox;
        internal System.Windows.Forms.GroupBox fileListGroupBox;
        internal System.Windows.Forms.TrackBar filesListTrackBar;
        private System.Windows.Forms.TabPage writerTabPage;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox writerPictureBox;
        private System.Windows.Forms.Button createWriterImageButton;
        private System.Windows.Forms.Button saveWriterImageButton;
        private System.Windows.Forms.Button readBarcodeFromWriterImageButton;
        private System.Windows.Forms.Button clearWriterImageButton;
        private System.Windows.Forms.SaveFileDialog saveImageFileDialog;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.Label barcodeWriterErrorText;
        private System.Windows.Forms.CheckBox automaticRecognitionCheckBox;
        private System.Windows.Forms.GroupBox demoVersionRestrictionsGroupBox;
        internal System.Windows.Forms.Label unregistredRestrictionsLabel;
        private System.Windows.Forms.TextBox barcodeWriterBarcodeInformation;
        private System.Windows.Forms.GroupBox progressGroupBox;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.CheckBox showProgressCheckBox;
        private System.Windows.Forms.Button resetSettingsButton;
        private AdvancedReaderSettingsControl advancedReaderSettings;
        private MinConfidenceEditorControl minConfidenceEditor;
        private BarcodeDemo.MaxThreadCountEditorControl maxThreadCountEditor;
        private System.Windows.Forms.TabPage tpResults;
        private BarcodeReaderResultsControl barcodeReaderResultsControl1;
        private BarcodeDemo.ScanDirectionEditorControl scanDirectionEditor;
        private BarcodeDemo.ExpectedBarcodesEditorControl expectedBarcodesEditor;
        private BarcodeDemo.ScanIntervalEditorControl scanIntervalEditor;
        private BarcodeDemo.ParameterSlaveEditorControl scanIntervalSlaveEditor;
        private BarcodeDemo.ParameterSlaveEditorControl expectedBarcodesSlaveEditor;
        private BarcodeDemo.Controls.BarcodeWriterSettingsControl barcodeWriterSettingsControl1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem writerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setImageSizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetImageSizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem saveImageAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem barcodeDesignToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem resetBarcodeDesignToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem saveSVGImageAsToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveSvgFileDialog;
        private ReaderSettingsBarcodeTypesControl readerBarcodeTypes;
    }
}
