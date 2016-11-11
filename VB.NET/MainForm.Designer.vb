Partial Class MainForm
	''' <summary>
	''' Required designer variable.
	''' </summary>
	Private components As System.ComponentModel.IContainer = Nothing

	''' <summary>
	''' Clean up any resources being used.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(disposing As Boolean)
		If disposing AndAlso (components IsNot Nothing) Then
			components.Dispose()
		End If
		MyBase.Dispose(disposing)
	End Sub

	#Region "Windows Form Designer generated code"

	''' <summary>
	''' Required method for Designer support - do not modify
	''' the contents of this method with the code editor.
	''' </summary>
	Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.openFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.panel1 = New System.Windows.Forms.Panel
        Me.panel3 = New System.Windows.Forms.Panel
        Me.panel6 = New System.Windows.Forms.Panel
        Me.tabControl = New System.Windows.Forms.TabControl
        Me.readerTabPage = New System.Windows.Forms.TabPage
        Me.splitContainer1 = New System.Windows.Forms.SplitContainer
        Me.panel7 = New System.Windows.Forms.Panel
        Me.panel8 = New System.Windows.Forms.Panel
        Me.barcodeReaderPictureBox = New System.Windows.Forms.PictureBox
        Me.panel9 = New System.Windows.Forms.Panel
        Me.currentBarcodeInfo = New System.Windows.Forms.Label
        Me.outputTextRichTextBox = New System.Windows.Forms.RichTextBox
        Me.tpSettings = New System.Windows.Forms.TabPage
        Me.advancedReaderSettings = New BarcodeDemo.AdvancedReaderSettingsControl
        Me.readerBarcodeTypes = New BarcodeDemo.BarcodeTypesReaderSettingsControl
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.scanIntervalEditor = New BarcodeDemo.ScanIntervalEditorControl
        Me.expectedBarcodesEditor = New BarcodeDemo.ExpectedBarcodesEditorControl
        Me.scanDirectionEditor = New BarcodeDemo.ScanDirectionEditorControl
        Me.maxThreadsCountEditor = New BarcodeDemo.MaxThreadsCountEditorControl
        Me.minConfidenceEditor = New BarcodeDemo.MinConfidenceEditorControl
        Me.resetSettingsButton = New System.Windows.Forms.Button
        Me.demoVersionRestrictionsGroupBox = New System.Windows.Forms.GroupBox
        Me.unregistredRestrictionsLabel = New System.Windows.Forms.Label
        Me.tpResults = New System.Windows.Forms.TabPage
        Me.barcodeReaderResultsControl1 = New BarcodeDemo.BarcodeReaderResultsControl
        Me.writerTabPage = New System.Windows.Forms.TabPage
        Me.splitContainer2 = New System.Windows.Forms.SplitContainer
        Me.panel4 = New System.Windows.Forms.Panel
        Me.barcodeWriterErrorText = New System.Windows.Forms.Label
        Me.writerPictureBox = New System.Windows.Forms.PictureBox
        Me.panel2 = New System.Windows.Forms.Panel
        Me.barcodeWriterBarcodeInformation = New System.Windows.Forms.TextBox
        Me.clearWriterImageButton = New System.Windows.Forms.Button
        Me.saveWriterImageButton = New System.Windows.Forms.Button
        Me.readBarcodeFromWriterImageButton = New System.Windows.Forms.Button
        Me.createWriterImageButton = New System.Windows.Forms.Button
        Me.barcodeWriterSettingsControl1 = New BarcodeDemo.Controls.BarcodeWriterSettingsControl
        Me.readerTools = New System.Windows.Forms.Panel
        Me.expectedBarcodesSlaveEditor = New BarcodeDemo.ParameterSlaveEditorControl
        Me.scanIntervalSlaveEditor = New BarcodeDemo.ParameterSlaveEditorControl
        Me.readerErodeCheckBox = New System.Windows.Forms.CheckBox
        Me.showProgressCheckBox = New System.Windows.Forms.CheckBox
        Me.showImageProcessingCheckBox = New System.Windows.Forms.CheckBox
        Me.automaticRecognitionCheckBox = New System.Windows.Forms.CheckBox
        Me.fileListGroupBox = New System.Windows.Forms.GroupBox
        Me.filesListTrackBar = New System.Windows.Forms.TrackBar
        Me.zoomImageCheckBox = New System.Windows.Forms.CheckBox
        Me.highThresholdGroupBox = New System.Windows.Forms.GroupBox
        Me.thresholdMaxTrackBar = New System.Windows.Forms.TrackBar
        Me.removePeasCheckBox = New System.Windows.Forms.CheckBox
        Me.invertColorsCheckBox = New System.Windows.Forms.CheckBox
        Me.readBarcodesButton = New System.Windows.Forms.Button
        Me.thresholdGroupBox = New System.Windows.Forms.GroupBox
        Me.thresholdMinTrackBar = New System.Windows.Forms.TrackBar
        Me.progressGroupBox = New System.Windows.Forms.GroupBox
        Me.progressBar = New System.Windows.Forms.ProgressBar
        Me.thresholdMethodGroupBox = New System.Windows.Forms.GroupBox
        Me.thresholdMethodAutoRadioButton = New System.Windows.Forms.RadioButton
        Me.thresholdIterationGroupBox = New System.Windows.Forms.GroupBox
        Me.thresholdIterationsTrackBar = New System.Windows.Forms.TrackBar
        Me.thresholdMethodIterationRadioButton = New System.Windows.Forms.RadioButton
        Me.thresholdMethodManualRadioButton = New System.Windows.Forms.RadioButton
        Me.saveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.colorDialog = New System.Windows.Forms.ColorDialog
        Me.fontDialog = New System.Windows.Forms.FontDialog
        Me.menuStrip1 = New System.Windows.Forms.MenuStrip
        Me.fileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.openToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.closeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.exitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.helpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.aboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.panel1.SuspendLayout()
        Me.panel3.SuspendLayout()
        Me.panel6.SuspendLayout()
        Me.tabControl.SuspendLayout()
        Me.readerTabPage.SuspendLayout()
        Me.splitContainer1.Panel1.SuspendLayout()
        Me.splitContainer1.Panel2.SuspendLayout()
        Me.splitContainer1.SuspendLayout()
        Me.panel7.SuspendLayout()
        Me.panel8.SuspendLayout()
        CType(Me.barcodeReaderPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel9.SuspendLayout()
        Me.tpSettings.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.demoVersionRestrictionsGroupBox.SuspendLayout()
        Me.tpResults.SuspendLayout()
        Me.writerTabPage.SuspendLayout()
        Me.splitContainer2.Panel1.SuspendLayout()
        Me.splitContainer2.Panel2.SuspendLayout()
        Me.splitContainer2.SuspendLayout()
        Me.panel4.SuspendLayout()
        CType(Me.writerPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel2.SuspendLayout()
        Me.readerTools.SuspendLayout()
        Me.fileListGroupBox.SuspendLayout()
        CType(Me.filesListTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.highThresholdGroupBox.SuspendLayout()
        CType(Me.thresholdMaxTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.thresholdGroupBox.SuspendLayout()
        CType(Me.thresholdMinTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.progressGroupBox.SuspendLayout()
        Me.thresholdMethodGroupBox.SuspendLayout()
        Me.thresholdIterationGroupBox.SuspendLayout()
        CType(Me.thresholdIterationsTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.menuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'openFileDialog1
        '
        Me.openFileDialog1.Filter = "All supported (*.pdf;*.bmp;*.jpg;*.jpeg;*.jpe;*.jfif;*.tif;*.tiff;*.png;*.gif;*.t" & _
            "ga;*.wmf;*.emf)|*.bmp;*.jpg;*.jpeg;*.jpe;*.jfif;*.tif;*.tiff;*.png;*.gif;*.tga;*" & _
            ".wmf;*.emf;*.pdf"
        '
        'panel1
        '
        Me.panel1.Controls.Add(Me.panel3)
        Me.panel1.Controls.Add(Me.readerTools)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel1.Location = New System.Drawing.Point(0, 24)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(784, 618)
        Me.panel1.TabIndex = 0
        '
        'panel3
        '
        Me.panel3.Controls.Add(Me.panel6)
        Me.panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel3.Location = New System.Drawing.Point(0, 0)
        Me.panel3.Name = "panel3"
        Me.panel3.Size = New System.Drawing.Size(784, 470)
        Me.panel3.TabIndex = 1
        '
        'panel6
        '
        Me.panel6.Controls.Add(Me.tabControl)
        Me.panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel6.Location = New System.Drawing.Point(0, 0)
        Me.panel6.Name = "panel6"
        Me.panel6.Size = New System.Drawing.Size(784, 470)
        Me.panel6.TabIndex = 2
        '
        'tabControl
        '
        Me.tabControl.Controls.Add(Me.readerTabPage)
        Me.tabControl.Controls.Add(Me.tpSettings)
        Me.tabControl.Controls.Add(Me.tpResults)
        Me.tabControl.Controls.Add(Me.writerTabPage)
        Me.tabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabControl.Location = New System.Drawing.Point(0, 0)
        Me.tabControl.Name = "tabControl"
        Me.tabControl.SelectedIndex = 0
        Me.tabControl.Size = New System.Drawing.Size(784, 470)
        Me.tabControl.TabIndex = 0
        '
        'readerTabPage
        '
        Me.readerTabPage.Controls.Add(Me.splitContainer1)
        Me.readerTabPage.Location = New System.Drawing.Point(4, 22)
        Me.readerTabPage.Name = "readerTabPage"
        Me.readerTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.readerTabPage.Size = New System.Drawing.Size(776, 444)
        Me.readerTabPage.TabIndex = 0
        Me.readerTabPage.Text = "Reader"
        Me.readerTabPage.UseVisualStyleBackColor = True
        '
        'splitContainer1
        '
        Me.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.splitContainer1.Location = New System.Drawing.Point(3, 3)
        Me.splitContainer1.Name = "splitContainer1"
        '
        'splitContainer1.Panel1
        '
        Me.splitContainer1.Panel1.Controls.Add(Me.panel7)
        '
        'splitContainer1.Panel2
        '
        Me.splitContainer1.Panel2.Controls.Add(Me.outputTextRichTextBox)
        Me.splitContainer1.Size = New System.Drawing.Size(770, 438)
        Me.splitContainer1.SplitterDistance = 528
        Me.splitContainer1.TabIndex = 0
        '
        'panel7
        '
        Me.panel7.Controls.Add(Me.panel8)
        Me.panel7.Controls.Add(Me.panel9)
        Me.panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel7.Location = New System.Drawing.Point(0, 0)
        Me.panel7.Name = "panel7"
        Me.panel7.Size = New System.Drawing.Size(528, 438)
        Me.panel7.TabIndex = 2
        '
        'panel8
        '
        Me.panel8.AutoScroll = True
        Me.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel8.Controls.Add(Me.barcodeReaderPictureBox)
        Me.panel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel8.Location = New System.Drawing.Point(0, 0)
        Me.panel8.Name = "panel8"
        Me.panel8.Size = New System.Drawing.Size(528, 418)
        Me.panel8.TabIndex = 3
        '
        'barcodeReaderPictureBox
        '
        Me.barcodeReaderPictureBox.Location = New System.Drawing.Point(0, 0)
        Me.barcodeReaderPictureBox.Name = "barcodeReaderPictureBox"
        Me.barcodeReaderPictureBox.Size = New System.Drawing.Size(190, 187)
        Me.barcodeReaderPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.barcodeReaderPictureBox.TabIndex = 5
        Me.barcodeReaderPictureBox.TabStop = False
        '
        'panel9
        '
        Me.panel9.BackColor = System.Drawing.SystemColors.Control
        Me.panel9.Controls.Add(Me.currentBarcodeInfo)
        Me.panel9.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel9.Location = New System.Drawing.Point(0, 418)
        Me.panel9.Name = "panel9"
        Me.panel9.Size = New System.Drawing.Size(528, 20)
        Me.panel9.TabIndex = 2
        '
        'currentBarcodeInfo
        '
        Me.currentBarcodeInfo.AutoSize = True
        Me.currentBarcodeInfo.Location = New System.Drawing.Point(5, 3)
        Me.currentBarcodeInfo.Name = "currentBarcodeInfo"
        Me.currentBarcodeInfo.Size = New System.Drawing.Size(28, 13)
        Me.currentBarcodeInfo.TabIndex = 0
        Me.currentBarcodeInfo.Text = "(0,0)"
        '
        'outputTextRichTextBox
        '
        Me.outputTextRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.outputTextRichTextBox.Location = New System.Drawing.Point(0, 0)
        Me.outputTextRichTextBox.Name = "outputTextRichTextBox"
        Me.outputTextRichTextBox.ReadOnly = True
        Me.outputTextRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.outputTextRichTextBox.Size = New System.Drawing.Size(238, 438)
        Me.outputTextRichTextBox.TabIndex = 0
        Me.outputTextRichTextBox.Text = ""
        '
        'tpSettings
        '
        Me.tpSettings.Controls.Add(Me.advancedReaderSettings)
        Me.tpSettings.Controls.Add(Me.readerBarcodeTypes)
        Me.tpSettings.Controls.Add(Me.GroupBox6)
        Me.tpSettings.Location = New System.Drawing.Point(4, 22)
        Me.tpSettings.Name = "tpSettings"
        Me.tpSettings.Size = New System.Drawing.Size(776, 444)
        Me.tpSettings.TabIndex = 2
        Me.tpSettings.Text = "Reader settings"
        Me.tpSettings.UseVisualStyleBackColor = True
        '
        'advancedReaderSettings
        '
        Me.advancedReaderSettings.BarcodeTypesReaderSettings = Me.readerBarcodeTypes
        Me.advancedReaderSettings.InterpretEciCharacters = False
        Me.advancedReaderSettings.Location = New System.Drawing.Point(498, 0)
        Me.advancedReaderSettings.Name = "advancedReaderSettings"
        Me.advancedReaderSettings.Size = New System.Drawing.Size(275, 244)
        Me.advancedReaderSettings.TabIndex = 25
        '
        'readerBarcodeTypes
        '
        Me.readerBarcodeTypes.Location = New System.Drawing.Point(1, 0)
        Me.readerBarcodeTypes.Name = "readerBarcodeTypes"
        Me.readerBarcodeTypes.Size = New System.Drawing.Size(492, 244)
        Me.readerBarcodeTypes.TabIndex = 24
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.scanIntervalEditor)
        Me.GroupBox6.Controls.Add(Me.expectedBarcodesEditor)
        Me.GroupBox6.Controls.Add(Me.scanDirectionEditor)
        Me.GroupBox6.Controls.Add(Me.maxThreadsCountEditor)
        Me.GroupBox6.Controls.Add(Me.minConfidenceEditor)
        Me.GroupBox6.Controls.Add(Me.resetSettingsButton)
        Me.GroupBox6.Controls.Add(Me.demoVersionRestrictionsGroupBox)
        Me.GroupBox6.Location = New System.Drawing.Point(0, 243)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(773, 206)
        Me.GroupBox6.TabIndex = 22
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Barcode read parameters"
        '
        'scanIntervalEditor
        '
        Me.scanIntervalEditor.Location = New System.Drawing.Point(6, 17)
        Me.scanIntervalEditor.Maximum = 25
        Me.scanIntervalEditor.Minimum = 1
        Me.scanIntervalEditor.Name = "scanIntervalEditor"
        Me.scanIntervalEditor.Size = New System.Drawing.Size(240, 75)
        Me.scanIntervalEditor.TabIndex = 34
        Me.scanIntervalEditor.TickFrequency = 1
        Me.scanIntervalEditor.Title = "Scan interval"
        Me.scanIntervalEditor.Value = 5
        '
        'expectedBarcodesEditor
        '
        Me.expectedBarcodesEditor.Location = New System.Drawing.Point(259, 17)
        Me.expectedBarcodesEditor.Maximum = 72
        Me.expectedBarcodesEditor.Minimum = 1
        Me.expectedBarcodesEditor.Name = "expectedBarcodesEditor"
        Me.expectedBarcodesEditor.Size = New System.Drawing.Size(252, 75)
        Me.expectedBarcodesEditor.TabIndex = 33
        Me.expectedBarcodesEditor.TickFrequency = 2
        Me.expectedBarcodesEditor.Title = "Expected barcodes"
        Me.expectedBarcodesEditor.Value = 1
        '
        'scanDirectionEditor
        '
        Me.scanDirectionEditor.Location = New System.Drawing.Point(260, 100)
        Me.scanDirectionEditor.Name = "scanDirectionEditor"
        Me.scanDirectionEditor.Size = New System.Drawing.Size(252, 97)
        Me.scanDirectionEditor.TabIndex = 32
        '
        'maxThreadsCountEditor
        '
        Me.maxThreadsCountEditor.Location = New System.Drawing.Point(6, 99)
        Me.maxThreadsCountEditor.Maximum = 8
        Me.maxThreadsCountEditor.Minimum = 1
        Me.maxThreadsCountEditor.Name = "maxThreadsCountEditor"
        Me.maxThreadsCountEditor.Size = New System.Drawing.Size(240, 97)
        Me.maxThreadsCountEditor.TabIndex = 31
        Me.maxThreadsCountEditor.TickFrequency = 1
        Me.maxThreadsCountEditor.Title = "Max threads count"
        Me.maxThreadsCountEditor.Value = 4
        '
        'minConfidenceEditor
        '
        Me.minConfidenceEditor.Location = New System.Drawing.Point(525, 16)
        Me.minConfidenceEditor.Maximum = 100
        Me.minConfidenceEditor.Minimum = 0
        Me.minConfidenceEditor.Name = "minConfidenceEditor"
        Me.minConfidenceEditor.Size = New System.Drawing.Size(237, 77)
        Me.minConfidenceEditor.TabIndex = 30
        Me.minConfidenceEditor.TickFrequency = 2
        Me.minConfidenceEditor.Title = "Min Confidence"
        Me.minConfidenceEditor.Value = 95
        '
        'resetSettingsButton
        '
        Me.resetSettingsButton.Location = New System.Drawing.Point(586, 172)
        Me.resetSettingsButton.Name = "resetSettingsButton"
        Me.resetSettingsButton.Size = New System.Drawing.Size(101, 23)
        Me.resetSettingsButton.TabIndex = 29
        Me.resetSettingsButton.Text = "Reset settings"
        Me.resetSettingsButton.UseVisualStyleBackColor = True
        '
        'demoVersionRestrictionsGroupBox
        '
        Me.demoVersionRestrictionsGroupBox.Controls.Add(Me.unregistredRestrictionsLabel)
        Me.demoVersionRestrictionsGroupBox.Location = New System.Drawing.Point(525, 100)
        Me.demoVersionRestrictionsGroupBox.Name = "demoVersionRestrictionsGroupBox"
        Me.demoVersionRestrictionsGroupBox.Size = New System.Drawing.Size(240, 67)
        Me.demoVersionRestrictionsGroupBox.TabIndex = 28
        Me.demoVersionRestrictionsGroupBox.TabStop = False
        Me.demoVersionRestrictionsGroupBox.Text = "Unregistered version restrictions"
        Me.demoVersionRestrictionsGroupBox.Visible = False
        '
        'unregistredRestrictionsLabel
        '
        Me.unregistredRestrictionsLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.unregistredRestrictionsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.unregistredRestrictionsLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.unregistredRestrictionsLabel.Location = New System.Drawing.Point(3, 16)
        Me.unregistredRestrictionsLabel.Name = "unregistredRestrictionsLabel"
        Me.unregistredRestrictionsLabel.Size = New System.Drawing.Size(234, 48)
        Me.unregistredRestrictionsLabel.TabIndex = 29
        Me.unregistredRestrictionsLabel.Text = "Barcode value in evaluation version will be replaced to the ""*DEMO*"" string for Q" & _
            "R, RSS(GS1) and Intelligent Mail barcodes."
        '
        'tpResults
        '
        Me.tpResults.Controls.Add(Me.barcodeReaderResultsControl1)
        Me.tpResults.Location = New System.Drawing.Point(4, 22)
        Me.tpResults.Name = "tpResults"
        Me.tpResults.Padding = New System.Windows.Forms.Padding(3)
        Me.tpResults.Size = New System.Drawing.Size(776, 444)
        Me.tpResults.TabIndex = 1
        Me.tpResults.Text = "Reader results"
        Me.tpResults.UseVisualStyleBackColor = True
        '
        'barcodeReaderResultsControl1
        '
        Me.barcodeReaderResultsControl1.BarcodeImage = Nothing
        Me.barcodeReaderResultsControl1.BarcodeInfoIndex = 0
        Me.barcodeReaderResultsControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.barcodeReaderResultsControl1.InterpretEciCharacters = False
        Me.barcodeReaderResultsControl1.InvertBarcodeImage = False
        Me.barcodeReaderResultsControl1.Location = New System.Drawing.Point(3, 3)
        Me.barcodeReaderResultsControl1.Name = "barcodeReaderResultsControl1"
        Me.barcodeReaderResultsControl1.RecognizedBarcodes = Nothing
        Me.barcodeReaderResultsControl1.Size = New System.Drawing.Size(770, 438)
        Me.barcodeReaderResultsControl1.TabIndex = 0
        '
        'writerTabPage
        '
        Me.writerTabPage.Controls.Add(Me.splitContainer2)
        Me.writerTabPage.Location = New System.Drawing.Point(4, 22)
        Me.writerTabPage.Name = "writerTabPage"
        Me.writerTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.writerTabPage.Size = New System.Drawing.Size(776, 444)
        Me.writerTabPage.TabIndex = 3
        Me.writerTabPage.Text = "Writer"
        Me.writerTabPage.UseVisualStyleBackColor = True
        '
        'splitContainer2
        '
        Me.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.splitContainer2.IsSplitterFixed = True
        Me.splitContainer2.Location = New System.Drawing.Point(3, 3)
        Me.splitContainer2.Name = "splitContainer2"
        '
        'splitContainer2.Panel1
        '
        Me.splitContainer2.Panel1.Controls.Add(Me.panel4)
        Me.splitContainer2.Panel1.Controls.Add(Me.panel2)
        '
        'splitContainer2.Panel2
        '
        Me.splitContainer2.Panel2.Controls.Add(Me.barcodeWriterSettingsControl1)
        Me.splitContainer2.Size = New System.Drawing.Size(770, 438)
        Me.splitContainer2.SplitterDistance = 501
        Me.splitContainer2.TabIndex = 0
        '
        'panel4
        '
        Me.panel4.AutoScroll = True
        Me.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel4.Controls.Add(Me.barcodeWriterErrorText)
        Me.panel4.Controls.Add(Me.writerPictureBox)
        Me.panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel4.Location = New System.Drawing.Point(0, 0)
        Me.panel4.Name = "panel4"
        Me.panel4.Size = New System.Drawing.Size(501, 290)
        Me.panel4.TabIndex = 1
        '
        'barcodeWriterErrorText
        '
        Me.barcodeWriterErrorText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.barcodeWriterErrorText.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.barcodeWriterErrorText.ForeColor = System.Drawing.Color.DarkRed
        Me.barcodeWriterErrorText.Location = New System.Drawing.Point(0, 0)
        Me.barcodeWriterErrorText.Name = "barcodeWriterErrorText"
        Me.barcodeWriterErrorText.Size = New System.Drawing.Size(499, 288)
        Me.barcodeWriterErrorText.TabIndex = 1
        Me.barcodeWriterErrorText.Text = "Barcode Writing Error"
        Me.barcodeWriterErrorText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.barcodeWriterErrorText.Visible = False
        '
        'writerPictureBox
        '
        Me.writerPictureBox.Location = New System.Drawing.Point(0, 0)
        Me.writerPictureBox.Name = "writerPictureBox"
        Me.writerPictureBox.Size = New System.Drawing.Size(100, 100)
        Me.writerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.writerPictureBox.TabIndex = 0
        Me.writerPictureBox.TabStop = False
        '
        'panel2
        '
        Me.panel2.BackColor = System.Drawing.SystemColors.Control
        Me.panel2.Controls.Add(Me.barcodeWriterBarcodeInformation)
        Me.panel2.Controls.Add(Me.clearWriterImageButton)
        Me.panel2.Controls.Add(Me.saveWriterImageButton)
        Me.panel2.Controls.Add(Me.readBarcodeFromWriterImageButton)
        Me.panel2.Controls.Add(Me.createWriterImageButton)
        Me.panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel2.Location = New System.Drawing.Point(0, 290)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(501, 148)
        Me.panel2.TabIndex = 0
        '
        'barcodeWriterBarcodeInformation
        '
        Me.barcodeWriterBarcodeInformation.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.barcodeWriterBarcodeInformation.Location = New System.Drawing.Point(178, 3)
        Me.barcodeWriterBarcodeInformation.Multiline = True
        Me.barcodeWriterBarcodeInformation.Name = "barcodeWriterBarcodeInformation"
        Me.barcodeWriterBarcodeInformation.ReadOnly = True
        Me.barcodeWriterBarcodeInformation.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.barcodeWriterBarcodeInformation.Size = New System.Drawing.Size(321, 141)
        Me.barcodeWriterBarcodeInformation.TabIndex = 4
        '
        'clearWriterImageButton
        '
        Me.clearWriterImageButton.Enabled = False
        Me.clearWriterImageButton.Location = New System.Drawing.Point(2, 113)
        Me.clearWriterImageButton.Name = "clearWriterImageButton"
        Me.clearWriterImageButton.Size = New System.Drawing.Size(167, 29)
        Me.clearWriterImageButton.TabIndex = 4
        Me.clearWriterImageButton.Text = "Clear image"
        Me.clearWriterImageButton.UseVisualStyleBackColor = True
        '
        'saveWriterImageButton
        '
        Me.saveWriterImageButton.Enabled = False
        Me.saveWriterImageButton.Location = New System.Drawing.Point(2, 78)
        Me.saveWriterImageButton.Name = "saveWriterImageButton"
        Me.saveWriterImageButton.Size = New System.Drawing.Size(168, 29)
        Me.saveWriterImageButton.TabIndex = 2
        Me.saveWriterImageButton.Text = "Save as..."
        Me.saveWriterImageButton.UseVisualStyleBackColor = True
        '
        'readBarcodeFromWriterImageButton
        '
        Me.readBarcodeFromWriterImageButton.Enabled = False
        Me.readBarcodeFromWriterImageButton.Location = New System.Drawing.Point(2, 42)
        Me.readBarcodeFromWriterImageButton.Name = "readBarcodeFromWriterImageButton"
        Me.readBarcodeFromWriterImageButton.Size = New System.Drawing.Size(167, 30)
        Me.readBarcodeFromWriterImageButton.TabIndex = 1
        Me.readBarcodeFromWriterImageButton.Text = "Read barcode"
        Me.readBarcodeFromWriterImageButton.UseVisualStyleBackColor = True
        '
        'createWriterImageButton
        '
        Me.createWriterImageButton.Location = New System.Drawing.Point(2, 5)
        Me.createWriterImageButton.Name = "createWriterImageButton"
        Me.createWriterImageButton.Size = New System.Drawing.Size(167, 30)
        Me.createWriterImageButton.TabIndex = 0
        Me.createWriterImageButton.Text = "Write barcode"
        Me.createWriterImageButton.UseVisualStyleBackColor = True
        '
        'barcodeWriterSettingsControl1
        '
        Me.barcodeWriterSettingsControl1.BarcodeWriterSettings = Nothing
        Me.barcodeWriterSettingsControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.barcodeWriterSettingsControl1.Location = New System.Drawing.Point(0, 0)
        Me.barcodeWriterSettingsControl1.Name = "barcodeWriterSettingsControl1"
        Me.barcodeWriterSettingsControl1.SelectedBarcodeSubset = Nothing
        Me.barcodeWriterSettingsControl1.Size = New System.Drawing.Size(265, 438)
        Me.barcodeWriterSettingsControl1.TabIndex = 0
        '
        'readerTools
        '
        Me.readerTools.Controls.Add(Me.expectedBarcodesSlaveEditor)
        Me.readerTools.Controls.Add(Me.scanIntervalSlaveEditor)
        Me.readerTools.Controls.Add(Me.readerErodeCheckBox)
        Me.readerTools.Controls.Add(Me.showProgressCheckBox)
        Me.readerTools.Controls.Add(Me.showImageProcessingCheckBox)
        Me.readerTools.Controls.Add(Me.automaticRecognitionCheckBox)
        Me.readerTools.Controls.Add(Me.fileListGroupBox)
        Me.readerTools.Controls.Add(Me.zoomImageCheckBox)
        Me.readerTools.Controls.Add(Me.highThresholdGroupBox)
        Me.readerTools.Controls.Add(Me.removePeasCheckBox)
        Me.readerTools.Controls.Add(Me.invertColorsCheckBox)
        Me.readerTools.Controls.Add(Me.readBarcodesButton)
        Me.readerTools.Controls.Add(Me.thresholdGroupBox)
        Me.readerTools.Controls.Add(Me.progressGroupBox)
        Me.readerTools.Controls.Add(Me.thresholdMethodGroupBox)
        Me.readerTools.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.readerTools.Location = New System.Drawing.Point(0, 470)
        Me.readerTools.Name = "readerTools"
        Me.readerTools.Size = New System.Drawing.Size(784, 148)
        Me.readerTools.TabIndex = 0
        '
        'expectedBarcodesSlaveEditor
        '
        Me.expectedBarcodesSlaveEditor.Location = New System.Drawing.Point(186, 9)
        Me.expectedBarcodesSlaveEditor.MasterParameterEditor = Me.expectedBarcodesEditor
        Me.expectedBarcodesSlaveEditor.Maximum = 72
        Me.expectedBarcodesSlaveEditor.Minimum = 1
        Me.expectedBarcodesSlaveEditor.Name = "expectedBarcodesSlaveEditor"
        Me.expectedBarcodesSlaveEditor.Size = New System.Drawing.Size(288, 97)
        Me.expectedBarcodesSlaveEditor.TabIndex = 30
        Me.expectedBarcodesSlaveEditor.TickFrequency = 2
        Me.expectedBarcodesSlaveEditor.Title = "Expected barcodes"
        Me.expectedBarcodesSlaveEditor.Value = 1
        '
        'scanIntervalSlaveEditor
        '
        Me.scanIntervalSlaveEditor.Location = New System.Drawing.Point(484, 9)
        Me.scanIntervalSlaveEditor.MasterParameterEditor = Me.scanIntervalEditor
        Me.scanIntervalSlaveEditor.Maximum = 25
        Me.scanIntervalSlaveEditor.Minimum = 1
        Me.scanIntervalSlaveEditor.Name = "scanIntervalSlaveEditor"
        Me.scanIntervalSlaveEditor.Size = New System.Drawing.Size(288, 97)
        Me.scanIntervalSlaveEditor.TabIndex = 1
        Me.scanIntervalSlaveEditor.TickFrequency = 1
        Me.scanIntervalSlaveEditor.Title = "Scan interval"
        Me.scanIntervalSlaveEditor.Value = 5
        '
        'readerErodeCheckBox
        '
        Me.readerErodeCheckBox.Location = New System.Drawing.Point(598, 120)
        Me.readerErodeCheckBox.Name = "readerErodeCheckBox"
        Me.readerErodeCheckBox.Size = New System.Drawing.Size(62, 17)
        Me.readerErodeCheckBox.TabIndex = 29
        Me.readerErodeCheckBox.Text = "Erode"
        Me.readerErodeCheckBox.UseVisualStyleBackColor = True
        '
        'showProgressCheckBox
        '
        Me.showProgressCheckBox.Checked = True
        Me.showProgressCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.showProgressCheckBox.Location = New System.Drawing.Point(410, 120)
        Me.showProgressCheckBox.Name = "showProgressCheckBox"
        Me.showProgressCheckBox.Size = New System.Drawing.Size(101, 17)
        Me.showProgressCheckBox.TabIndex = 28
        Me.showProgressCheckBox.Text = "Show progress"
        Me.showProgressCheckBox.UseVisualStyleBackColor = True
        '
        'showImageProcessingCheckBox
        '
        Me.showImageProcessingCheckBox.Location = New System.Drawing.Point(279, 120)
        Me.showImageProcessingCheckBox.Name = "showImageProcessingCheckBox"
        Me.showImageProcessingCheckBox.Size = New System.Drawing.Size(125, 17)
        Me.showImageProcessingCheckBox.TabIndex = 12
        Me.showImageProcessingCheckBox.Text = "Show preprocessing"
        Me.showImageProcessingCheckBox.UseVisualStyleBackColor = True
        '
        'automaticRecognitionCheckBox
        '
        Me.automaticRecognitionCheckBox.BackColor = System.Drawing.SystemColors.Control
        Me.automaticRecognitionCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.automaticRecognitionCheckBox.ForeColor = System.Drawing.Color.DarkGreen
        Me.automaticRecognitionCheckBox.Location = New System.Drawing.Point(21, 57)
        Me.automaticRecognitionCheckBox.Name = "automaticRecognitionCheckBox"
        Me.automaticRecognitionCheckBox.Size = New System.Drawing.Size(151, 17)
        Me.automaticRecognitionCheckBox.TabIndex = 24
        Me.automaticRecognitionCheckBox.Text = "Automatic recognition"
        Me.automaticRecognitionCheckBox.UseVisualStyleBackColor = False
        '
        'fileListGroupBox
        '
        Me.fileListGroupBox.Controls.Add(Me.filesListTrackBar)
        Me.fileListGroupBox.Location = New System.Drawing.Point(10, 89)
        Me.fileListGroupBox.Name = "fileListGroupBox"
        Me.fileListGroupBox.Size = New System.Drawing.Size(169, 48)
        Me.fileListGroupBox.TabIndex = 22
        Me.fileListGroupBox.TabStop = False
        Me.fileListGroupBox.Text = "File X of YY"
        '
        'filesListTrackBar
        '
        Me.filesListTrackBar.AutoSize = False
        Me.filesListTrackBar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.filesListTrackBar.LargeChange = 50
        Me.filesListTrackBar.Location = New System.Drawing.Point(3, 16)
        Me.filesListTrackBar.Maximum = 1
        Me.filesListTrackBar.Minimum = 1
        Me.filesListTrackBar.Name = "filesListTrackBar"
        Me.filesListTrackBar.Size = New System.Drawing.Size(163, 29)
        Me.filesListTrackBar.TabIndex = 0
        Me.filesListTrackBar.Value = 1
        '
        'zoomImageCheckBox
        '
        Me.zoomImageCheckBox.Location = New System.Drawing.Point(185, 119)
        Me.zoomImageCheckBox.Name = "zoomImageCheckBox"
        Me.zoomImageCheckBox.Size = New System.Drawing.Size(88, 17)
        Me.zoomImageCheckBox.TabIndex = 21
        Me.zoomImageCheckBox.Text = "Zoom image"
        Me.zoomImageCheckBox.UseVisualStyleBackColor = True
        '
        'highThresholdGroupBox
        '
        Me.highThresholdGroupBox.Controls.Add(Me.thresholdMaxTrackBar)
        Me.highThresholdGroupBox.Location = New System.Drawing.Point(345, 63)
        Me.highThresholdGroupBox.Name = "highThresholdGroupBox"
        Me.highThresholdGroupBox.Size = New System.Drawing.Size(427, 47)
        Me.highThresholdGroupBox.TabIndex = 19
        Me.highThresholdGroupBox.TabStop = False
        Me.highThresholdGroupBox.Text = "High threshold"
        Me.highThresholdGroupBox.Visible = False
        '
        'thresholdMaxTrackBar
        '
        Me.thresholdMaxTrackBar.AutoSize = False
        Me.thresholdMaxTrackBar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.thresholdMaxTrackBar.LargeChange = 50
        Me.thresholdMaxTrackBar.Location = New System.Drawing.Point(3, 14)
        Me.thresholdMaxTrackBar.Maximum = 765
        Me.thresholdMaxTrackBar.Name = "thresholdMaxTrackBar"
        Me.thresholdMaxTrackBar.Size = New System.Drawing.Size(421, 30)
        Me.thresholdMaxTrackBar.TabIndex = 0
        Me.thresholdMaxTrackBar.TickFrequency = 25
        Me.thresholdMaxTrackBar.Value = 150
        '
        'removePeasCheckBox
        '
        Me.removePeasCheckBox.Checked = True
        Me.removePeasCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.removePeasCheckBox.Location = New System.Drawing.Point(666, 113)
        Me.removePeasCheckBox.Name = "removePeasCheckBox"
        Me.removePeasCheckBox.Size = New System.Drawing.Size(106, 17)
        Me.removePeasCheckBox.TabIndex = 16
        Me.removePeasCheckBox.Text = "Remove ""peas"""
        Me.removePeasCheckBox.UseVisualStyleBackColor = True
        '
        'invertColorsCheckBox
        '
        Me.invertColorsCheckBox.Location = New System.Drawing.Point(666, 129)
        Me.invertColorsCheckBox.Name = "invertColorsCheckBox"
        Me.invertColorsCheckBox.Size = New System.Drawing.Size(92, 17)
        Me.invertColorsCheckBox.TabIndex = 14
        Me.invertColorsCheckBox.Text = "Invert colors"
        Me.invertColorsCheckBox.UseVisualStyleBackColor = True
        '
        'readBarcodesButton
        '
        Me.readBarcodesButton.Enabled = False
        Me.readBarcodesButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.readBarcodesButton.Location = New System.Drawing.Point(10, 10)
        Me.readBarcodesButton.Name = "readBarcodesButton"
        Me.readBarcodesButton.Size = New System.Drawing.Size(169, 42)
        Me.readBarcodesButton.TabIndex = 1
        Me.readBarcodesButton.Text = "Read barcodes"
        Me.readBarcodesButton.UseVisualStyleBackColor = True
        '
        'thresholdGroupBox
        '
        Me.thresholdGroupBox.Controls.Add(Me.thresholdMinTrackBar)
        Me.thresholdGroupBox.Enabled = False
        Me.thresholdGroupBox.Location = New System.Drawing.Point(345, 8)
        Me.thresholdGroupBox.Name = "thresholdGroupBox"
        Me.thresholdGroupBox.Size = New System.Drawing.Size(427, 47)
        Me.thresholdGroupBox.TabIndex = 18
        Me.thresholdGroupBox.TabStop = False
        Me.thresholdGroupBox.Text = "Threshold"
        '
        'thresholdMinTrackBar
        '
        Me.thresholdMinTrackBar.AutoSize = False
        Me.thresholdMinTrackBar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.thresholdMinTrackBar.LargeChange = 50
        Me.thresholdMinTrackBar.Location = New System.Drawing.Point(3, 14)
        Me.thresholdMinTrackBar.Maximum = 765
        Me.thresholdMinTrackBar.Name = "thresholdMinTrackBar"
        Me.thresholdMinTrackBar.Size = New System.Drawing.Size(421, 30)
        Me.thresholdMinTrackBar.TabIndex = 0
        Me.thresholdMinTrackBar.TickFrequency = 25
        Me.thresholdMinTrackBar.Value = 150
        '
        'progressGroupBox
        '
        Me.progressGroupBox.Controls.Add(Me.progressBar)
        Me.progressGroupBox.Location = New System.Drawing.Point(10, 89)
        Me.progressGroupBox.Name = "progressGroupBox"
        Me.progressGroupBox.Size = New System.Drawing.Size(169, 48)
        Me.progressGroupBox.TabIndex = 21
        Me.progressGroupBox.TabStop = False
        Me.progressGroupBox.Text = "0%; 0 barcodes found"
        Me.progressGroupBox.Visible = False
        '
        'progressBar
        '
        Me.progressBar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.progressBar.Location = New System.Drawing.Point(3, 16)
        Me.progressBar.Name = "progressBar"
        Me.progressBar.Size = New System.Drawing.Size(163, 29)
        Me.progressBar.TabIndex = 0
        '
        'thresholdMethodGroupBox
        '
        Me.thresholdMethodGroupBox.Controls.Add(Me.thresholdMethodAutoRadioButton)
        Me.thresholdMethodGroupBox.Controls.Add(Me.thresholdIterationGroupBox)
        Me.thresholdMethodGroupBox.Controls.Add(Me.thresholdMethodIterationRadioButton)
        Me.thresholdMethodGroupBox.Controls.Add(Me.thresholdMethodManualRadioButton)
        Me.thresholdMethodGroupBox.Enabled = False
        Me.thresholdMethodGroupBox.Location = New System.Drawing.Point(185, 8)
        Me.thresholdMethodGroupBox.Name = "thresholdMethodGroupBox"
        Me.thresholdMethodGroupBox.Size = New System.Drawing.Size(157, 102)
        Me.thresholdMethodGroupBox.TabIndex = 20
        Me.thresholdMethodGroupBox.TabStop = False
        Me.thresholdMethodGroupBox.Text = "Threshold mode"
        '
        'thresholdMethodAutoRadioButton
        '
        Me.thresholdMethodAutoRadioButton.Location = New System.Drawing.Point(79, 14)
        Me.thresholdMethodAutoRadioButton.Name = "thresholdMethodAutoRadioButton"
        Me.thresholdMethodAutoRadioButton.Size = New System.Drawing.Size(75, 17)
        Me.thresholdMethodAutoRadioButton.TabIndex = 20
        Me.thresholdMethodAutoRadioButton.TabStop = True
        Me.thresholdMethodAutoRadioButton.Text = "Automatic"
        Me.thresholdMethodAutoRadioButton.UseVisualStyleBackColor = True
        '
        'thresholdIterationGroupBox
        '
        Me.thresholdIterationGroupBox.Controls.Add(Me.thresholdIterationsTrackBar)
        Me.thresholdIterationGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.thresholdIterationGroupBox.Location = New System.Drawing.Point(3, 51)
        Me.thresholdIterationGroupBox.Name = "thresholdIterationGroupBox"
        Me.thresholdIterationGroupBox.Size = New System.Drawing.Size(151, 48)
        Me.thresholdIterationGroupBox.TabIndex = 19
        Me.thresholdIterationGroupBox.TabStop = False
        Me.thresholdIterationGroupBox.Text = "Iteration count - xx"
        Me.thresholdIterationGroupBox.Visible = False
        '
        'thresholdIterationsTrackBar
        '
        Me.thresholdIterationsTrackBar.AutoSize = False
        Me.thresholdIterationsTrackBar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.thresholdIterationsTrackBar.LargeChange = 50
        Me.thresholdIterationsTrackBar.Location = New System.Drawing.Point(3, 11)
        Me.thresholdIterationsTrackBar.Maximum = 20
        Me.thresholdIterationsTrackBar.Minimum = 2
        Me.thresholdIterationsTrackBar.Name = "thresholdIterationsTrackBar"
        Me.thresholdIterationsTrackBar.Size = New System.Drawing.Size(145, 34)
        Me.thresholdIterationsTrackBar.TabIndex = 0
        Me.thresholdIterationsTrackBar.Value = 2
        '
        'thresholdMethodIterationRadioButton
        '
        Me.thresholdMethodIterationRadioButton.Location = New System.Drawing.Point(9, 31)
        Me.thresholdMethodIterationRadioButton.Name = "thresholdMethodIterationRadioButton"
        Me.thresholdMethodIterationRadioButton.Size = New System.Drawing.Size(63, 17)
        Me.thresholdMethodIterationRadioButton.TabIndex = 2
        Me.thresholdMethodIterationRadioButton.TabStop = True
        Me.thresholdMethodIterationRadioButton.Text = "Iteration"
        Me.thresholdMethodIterationRadioButton.UseVisualStyleBackColor = True
        '
        'thresholdMethodManualRadioButton
        '
        Me.thresholdMethodManualRadioButton.Location = New System.Drawing.Point(9, 14)
        Me.thresholdMethodManualRadioButton.Name = "thresholdMethodManualRadioButton"
        Me.thresholdMethodManualRadioButton.Size = New System.Drawing.Size(60, 17)
        Me.thresholdMethodManualRadioButton.TabIndex = 0
        Me.thresholdMethodManualRadioButton.TabStop = True
        Me.thresholdMethodManualRadioButton.Text = "Manual"
        Me.thresholdMethodManualRadioButton.UseVisualStyleBackColor = True
        '
        'saveFileDialog1
        '
        Me.saveFileDialog1.DefaultExt = "png"
        Me.saveFileDialog1.Filter = "PNG (*.png)|*.png"
        '
        'menuStrip1
        '
        Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.fileToolStripMenuItem, Me.helpToolStripMenuItem})
        Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip1.Name = "menuStrip1"
        Me.menuStrip1.Size = New System.Drawing.Size(784, 24)
        Me.menuStrip1.TabIndex = 1
        Me.menuStrip1.Text = "menuStrip1"
        '
        'fileToolStripMenuItem
        '
        Me.fileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.openToolStripMenuItem, Me.closeToolStripMenuItem, Me.toolStripSeparator1, Me.exitToolStripMenuItem})
        Me.fileToolStripMenuItem.Name = "fileToolStripMenuItem"
        Me.fileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.fileToolStripMenuItem.Text = "File"
        '
        'openToolStripMenuItem
        '
        Me.openToolStripMenuItem.Name = "openToolStripMenuItem"
        Me.openToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.openToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.openToolStripMenuItem.Text = "Open Image..."
        '
        'closeToolStripMenuItem
        '
        Me.closeToolStripMenuItem.Name = "closeToolStripMenuItem"
        Me.closeToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.closeToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.closeToolStripMenuItem.Text = "Close Image"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(188, 6)
        '
        'exitToolStripMenuItem
        '
        Me.exitToolStripMenuItem.Name = "exitToolStripMenuItem"
        Me.exitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.exitToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.exitToolStripMenuItem.Text = "Exit"
        '
        'helpToolStripMenuItem
        '
        Me.helpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.aboutToolStripMenuItem})
        Me.helpToolStripMenuItem.Name = "helpToolStripMenuItem"
        Me.helpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.helpToolStripMenuItem.Text = "Help"
        '
        'aboutToolStripMenuItem
        '
        Me.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem"
        Me.aboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.aboutToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.aboutToolStripMenuItem.Text = "About..."
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 642)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.menuStrip1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.menuStrip1
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.panel1.ResumeLayout(False)
        Me.panel3.ResumeLayout(False)
        Me.panel6.ResumeLayout(False)
        Me.tabControl.ResumeLayout(False)
        Me.readerTabPage.ResumeLayout(False)
        Me.splitContainer1.Panel1.ResumeLayout(False)
        Me.splitContainer1.Panel2.ResumeLayout(False)
        Me.splitContainer1.ResumeLayout(False)
        Me.panel7.ResumeLayout(False)
        Me.panel8.ResumeLayout(False)
        Me.panel8.PerformLayout()
        CType(Me.barcodeReaderPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel9.ResumeLayout(False)
        Me.panel9.PerformLayout()
        Me.tpSettings.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.demoVersionRestrictionsGroupBox.ResumeLayout(False)
        Me.tpResults.ResumeLayout(False)
        Me.writerTabPage.ResumeLayout(False)
        Me.splitContainer2.Panel1.ResumeLayout(False)
        Me.splitContainer2.Panel2.ResumeLayout(False)
        Me.splitContainer2.ResumeLayout(False)
        Me.panel4.ResumeLayout(False)
        Me.panel4.PerformLayout()
        CType(Me.writerPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel2.ResumeLayout(False)
        Me.panel2.PerformLayout()
        Me.readerTools.ResumeLayout(False)
        Me.fileListGroupBox.ResumeLayout(False)
        CType(Me.filesListTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.highThresholdGroupBox.ResumeLayout(False)
        CType(Me.thresholdMaxTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.thresholdGroupBox.ResumeLayout(False)
        CType(Me.thresholdMinTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.progressGroupBox.ResumeLayout(False)
        Me.thresholdMethodGroupBox.ResumeLayout(False)
        Me.thresholdIterationGroupBox.ResumeLayout(False)
        CType(Me.thresholdIterationsTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.menuStrip1.ResumeLayout(False)
        Me.menuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

	#End Region

	Private WithEvents openFileDialog1 As System.Windows.Forms.OpenFileDialog
	Private WithEvents panel1 As System.Windows.Forms.Panel
	Private WithEvents panel3 As System.Windows.Forms.Panel
	Private WithEvents readerTools As System.Windows.Forms.Panel
	Private WithEvents readBarcodesButton As System.Windows.Forms.Button
	Private WithEvents showImageProcessingCheckBox As System.Windows.Forms.CheckBox
	Private WithEvents invertColorsCheckBox As System.Windows.Forms.CheckBox
	Private WithEvents removePeasCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents thresholdGroupBox As System.Windows.Forms.GroupBox
	Friend WithEvents thresholdMinTrackBar As System.Windows.Forms.TrackBar
	Private WithEvents panel6 As System.Windows.Forms.Panel
	Private WithEvents tabControl As System.Windows.Forms.TabControl
	Private WithEvents readerTabPage As System.Windows.Forms.TabPage
	Private WithEvents tpSettings As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents highThresholdGroupBox As System.Windows.Forms.GroupBox
	Friend WithEvents thresholdMaxTrackBar As System.Windows.Forms.TrackBar
	Private WithEvents splitContainer1 As System.Windows.Forms.SplitContainer
	Private WithEvents panel7 As System.Windows.Forms.Panel
	Private WithEvents panel8 As System.Windows.Forms.Panel
	Private WithEvents barcodeReaderPictureBox As System.Windows.Forms.PictureBox
	Private WithEvents panel9 As System.Windows.Forms.Panel
	Private WithEvents currentBarcodeInfo As System.Windows.Forms.Label
    Private WithEvents thresholdMethodGroupBox As System.Windows.Forms.GroupBox
	Private WithEvents thresholdMethodIterationRadioButton As System.Windows.Forms.RadioButton
	Private WithEvents thresholdMethodManualRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents thresholdIterationGroupBox As System.Windows.Forms.GroupBox
	Friend WithEvents thresholdIterationsTrackBar As System.Windows.Forms.TrackBar
	Private WithEvents zoomImageCheckBox As System.Windows.Forms.CheckBox
	Private WithEvents thresholdMethodAutoRadioButton As System.Windows.Forms.RadioButton
	Private WithEvents outputTextRichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents fileListGroupBox As System.Windows.Forms.GroupBox
	Friend WithEvents filesListTrackBar As System.Windows.Forms.TrackBar
	Private WithEvents writerTabPage As System.Windows.Forms.TabPage
	Private WithEvents splitContainer2 As System.Windows.Forms.SplitContainer
	Private WithEvents panel4 As System.Windows.Forms.Panel
	Private WithEvents panel2 As System.Windows.Forms.Panel
	Private WithEvents writerPictureBox As System.Windows.Forms.PictureBox
	Private WithEvents createWriterImageButton As System.Windows.Forms.Button
	Private WithEvents saveWriterImageButton As System.Windows.Forms.Button
	Private WithEvents readBarcodeFromWriterImageButton As System.Windows.Forms.Button
	Private WithEvents clearWriterImageButton As System.Windows.Forms.Button
	Private WithEvents saveFileDialog1 As System.Windows.Forms.SaveFileDialog
	Private WithEvents colorDialog As System.Windows.Forms.ColorDialog
    Private WithEvents fontDialog As System.Windows.Forms.FontDialog
	Private WithEvents barcodeWriterErrorText As System.Windows.Forms.Label
	Private WithEvents automaticRecognitionCheckBox As System.Windows.Forms.CheckBox
    Private WithEvents demoVersionRestrictionsGroupBox As System.Windows.Forms.GroupBox
	Friend WithEvents unregistredRestrictionsLabel As System.Windows.Forms.Label
	Private WithEvents barcodeWriterBarcodeInformation As System.Windows.Forms.TextBox
    Private WithEvents progressGroupBox As System.Windows.Forms.GroupBox
	Private WithEvents progressBar As System.Windows.Forms.ProgressBar
	Private WithEvents showProgressCheckBox As System.Windows.Forms.CheckBox
	Private WithEvents readerErodeCheckBox As System.Windows.Forms.CheckBox
	Private WithEvents resetSettingsButton As System.Windows.Forms.Button
    Private WithEvents readerBarcodeTypes As BarcodeTypesReaderSettingsControl
    Private WithEvents advancedReaderSettings As AdvancedReaderSettingsControl
    Private WithEvents minConfidenceEditor As MinConfidenceEditorControl
    Private WithEvents maxThreadsCountEditor As BarcodeDemo.MaxThreadsCountEditorControl
	Private WithEvents tpResults As System.Windows.Forms.TabPage
    Private WithEvents barcodeReaderResultsControl1 As BarcodeReaderResultsControl
    Private WithEvents scanDirectionEditor As BarcodeDemo.ScanDirectionEditorControl
    Private WithEvents expectedBarcodesEditor As BarcodeDemo.ExpectedBarcodesEditorControl
    Private WithEvents scanIntervalEditor As BarcodeDemo.ScanIntervalEditorControl
    Private WithEvents scanIntervalSlaveEditor As BarcodeDemo.ParameterSlaveEditorControl
    Private WithEvents expectedBarcodesSlaveEditor As BarcodeDemo.ParameterSlaveEditorControl
    Private WithEvents barcodeWriterSettingsControl1 As BarcodeDemo.Controls.BarcodeWriterSettingsControl
	Private WithEvents menuStrip1 As System.Windows.Forms.MenuStrip
	Private WithEvents fileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents openToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents closeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
	Private WithEvents exitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents helpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents aboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class

