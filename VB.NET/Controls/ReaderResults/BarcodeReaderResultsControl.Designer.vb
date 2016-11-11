Partial Class BarcodeReaderResultsControl
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

	#Region "Component Designer generated code"

	''' <summary> 
	''' Required method for Designer support - do not modify 
	''' the contents of this method with the code editor.
	''' </summary>
	Private Sub InitializeComponent()
        Me.panel12 = New System.Windows.Forms.Panel
        Me.panel16 = New System.Windows.Forms.Panel
        Me.panel18 = New System.Windows.Forms.Panel
        Me.groupBox9 = New System.Windows.Forms.GroupBox
        Me.panel13 = New System.Windows.Forms.Panel
        Me.panel24 = New System.Windows.Forms.Panel
        Me.readerTextEncodingPanel = New System.Windows.Forms.Panel
        Me.label48 = New System.Windows.Forms.Label
        Me.panel14 = New System.Windows.Forms.Panel
        Me.panel17 = New System.Windows.Forms.Panel
        Me.groupBox10 = New System.Windows.Forms.GroupBox
        Me.barcodeValueTextBox = New System.Windows.Forms.TextBox
        Me.readerTextEncodingComboBox = New System.Windows.Forms.ComboBox
        Me.showNonDataFlagsCheckBox = New System.Windows.Forms.CheckBox
        Me.barcodeValueAsGS1RadioButton = New System.Windows.Forms.RadioButton
        Me.showGS1DecoderButton = New System.Windows.Forms.Button
        Me.barcodeValueAsHexRadioButton = New System.Windows.Forms.RadioButton
        Me.barcodeValueAsBinaryRadioButton = New System.Windows.Forms.RadioButton
        Me.barcodeValueAsTextRadioButton = New System.Windows.Forms.RadioButton
        Me.valueItemsDataGridView = New System.Windows.Forms.DataGridView
        Me.Number = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FieldHEXValue = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.panel10 = New System.Windows.Forms.Panel
        Me.panel11 = New System.Windows.Forms.Panel
        Me.panel20 = New System.Windows.Forms.Panel
        Me.panel19 = New System.Windows.Forms.Panel
        Me.groupBox8 = New System.Windows.Forms.GroupBox
        Me.panel5 = New System.Windows.Forms.Panel
        Me.label42 = New System.Windows.Forms.Label
        Me.barcodePictureBox = New System.Windows.Forms.PictureBox
        Me.extendedInfoDataGridView = New System.Windows.Forms.DataGridView
        Me.FieldName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FieldValue = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ISO15416QualityTestButton = New System.Windows.Forms.Button
        Me.structureAppendLabel = New System.Windows.Forms.Label
        Me.ISO15415QualityTestButton = New System.Windows.Forms.Button
        Me.totalBarcodesLabel = New System.Windows.Forms.Label
        Me.label33 = New System.Windows.Forms.Label
        Me.boundRectnalgeLabel = New System.Windows.Forms.Label
        Me.label34 = New System.Windows.Forms.Label
        Me.barcodeTypeLabel = New System.Windows.Forms.Label
        Me.thresholdLabel = New System.Windows.Forms.Label
        Me.label35 = New System.Windows.Forms.Label
        Me.rotationAngleLabel = New System.Windows.Forms.Label
        Me.confidenceLabel = New System.Windows.Forms.Label
        Me.label40 = New System.Windows.Forms.Label
        Me.readingQualityLabel = New System.Windows.Forms.Label
        Me.label39 = New System.Windows.Forms.Label
        Me.label37 = New System.Windows.Forms.Label
        Me.label38 = New System.Windows.Forms.Label
        Me.label36 = New System.Windows.Forms.Label
        Me.directionLabel = New System.Windows.Forms.Label
        Me.panel1 = New System.Windows.Forms.Panel
        Me.panel2 = New System.Windows.Forms.Panel
        Me.panel3 = New System.Windows.Forms.Panel
        Me.panel4 = New System.Windows.Forms.Panel
        Me.groupBox1 = New System.Windows.Forms.GroupBox
        Me.panel6 = New System.Windows.Forms.Panel
        Me.label2 = New System.Windows.Forms.Label
        Me.selectedBarcodeNumericUpDown = New System.Windows.Forms.NumericUpDown
        Me.panel7 = New System.Windows.Forms.Panel
        Me.panel8 = New System.Windows.Forms.Panel
        Me.panel9 = New System.Windows.Forms.Panel
        Me.groupBox2 = New System.Windows.Forms.GroupBox
        Me.panel15 = New System.Windows.Forms.Panel
        Me.panel21 = New System.Windows.Forms.Panel
        Me.panel22 = New System.Windows.Forms.Panel
        Me.label19 = New System.Windows.Forms.Label
        Me.panel23 = New System.Windows.Forms.Panel
        Me.panel25 = New System.Windows.Forms.Panel
        Me.groupBox3 = New System.Windows.Forms.GroupBox
        Me.panel12.SuspendLayout()
        Me.panel16.SuspendLayout()
        Me.panel18.SuspendLayout()
        Me.groupBox9.SuspendLayout()
        Me.panel13.SuspendLayout()
        Me.readerTextEncodingPanel.SuspendLayout()
        Me.panel17.SuspendLayout()
        CType(Me.valueItemsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel10.SuspendLayout()
        Me.panel11.SuspendLayout()
        Me.panel19.SuspendLayout()
        Me.panel5.SuspendLayout()
        CType(Me.barcodePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.extendedInfoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel1.SuspendLayout()
        Me.panel2.SuspendLayout()
        Me.panel3.SuspendLayout()
        Me.panel4.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        Me.panel6.SuspendLayout()
        CType(Me.selectedBarcodeNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel7.SuspendLayout()
        Me.panel8.SuspendLayout()
        Me.panel9.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        Me.panel15.SuspendLayout()
        Me.panel21.SuspendLayout()
        Me.panel22.SuspendLayout()
        Me.panel23.SuspendLayout()
        Me.panel25.SuspendLayout()
        Me.groupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel12
        '
        Me.panel12.Controls.Add(Me.panel16)
        Me.panel12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel12.Location = New System.Drawing.Point(335, 3)
        Me.panel12.Name = "panel12"
        Me.panel12.Padding = New System.Windows.Forms.Padding(1)
        Me.panel12.Size = New System.Drawing.Size(438, 444)
        Me.panel12.TabIndex = 22
        '
        'panel16
        '
        Me.panel16.Controls.Add(Me.panel18)
        Me.panel16.Controls.Add(Me.panel17)
        Me.panel16.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel16.Location = New System.Drawing.Point(1, 1)
        Me.panel16.Name = "panel16"
        Me.panel16.Size = New System.Drawing.Size(436, 442)
        Me.panel16.TabIndex = 8
        '
        'panel18
        '
        Me.panel18.Controls.Add(Me.groupBox9)
        Me.panel18.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel18.Location = New System.Drawing.Point(0, 0)
        Me.panel18.Name = "panel18"
        Me.panel18.Size = New System.Drawing.Size(436, 267)
        Me.panel18.TabIndex = 1
        '
        'groupBox9
        '
        Me.groupBox9.Controls.Add(Me.panel13)
        Me.groupBox9.Controls.Add(Me.panel14)
        Me.groupBox9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.groupBox9.Location = New System.Drawing.Point(0, 0)
        Me.groupBox9.Name = "groupBox9"
        Me.groupBox9.Padding = New System.Windows.Forms.Padding(5)
        Me.groupBox9.Size = New System.Drawing.Size(436, 267)
        Me.groupBox9.TabIndex = 5
        Me.groupBox9.TabStop = False
        Me.groupBox9.Text = "Value"
        '
        'panel13
        '
        Me.panel13.Controls.Add(Me.panel24)
        Me.panel13.Controls.Add(Me.readerTextEncodingPanel)
        Me.panel13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel13.Location = New System.Drawing.Point(5, 70)
        Me.panel13.Name = "panel13"
        Me.panel13.Size = New System.Drawing.Size(426, 192)
        Me.panel13.TabIndex = 2
        '
        'panel24
        '
        Me.panel24.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel24.Location = New System.Drawing.Point(0, 0)
        Me.panel24.Name = "panel24"
        Me.panel24.Size = New System.Drawing.Size(426, 166)
        Me.panel24.TabIndex = 1
        '
        'readerTextEncodingPanel
        '
        Me.readerTextEncodingPanel.Controls.Add(Me.label48)
        Me.readerTextEncodingPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.readerTextEncodingPanel.Location = New System.Drawing.Point(0, 166)
        Me.readerTextEncodingPanel.Name = "readerTextEncodingPanel"
        Me.readerTextEncodingPanel.Size = New System.Drawing.Size(426, 26)
        Me.readerTextEncodingPanel.TabIndex = 0
        '
        'label48
        '
        Me.label48.AutoSize = True
        Me.label48.Location = New System.Drawing.Point(3, 5)
        Me.label48.Name = "label48"
        Me.label48.Size = New System.Drawing.Size(75, 13)
        Me.label48.TabIndex = 40
        Me.label48.Text = "Text encoding"
        '
        'panel14
        '
        Me.panel14.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel14.Location = New System.Drawing.Point(5, 18)
        Me.panel14.Name = "panel14"
        Me.panel14.Size = New System.Drawing.Size(426, 52)
        Me.panel14.TabIndex = 1
        '
        'panel17
        '
        Me.panel17.Controls.Add(Me.groupBox10)
        Me.panel17.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel17.Location = New System.Drawing.Point(0, 267)
        Me.panel17.Name = "panel17"
        Me.panel17.Size = New System.Drawing.Size(436, 175)
        Me.panel17.TabIndex = 0
        '
        'groupBox10
        '
        Me.groupBox10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.groupBox10.Location = New System.Drawing.Point(0, 0)
        Me.groupBox10.Name = "groupBox10"
        Me.groupBox10.Padding = New System.Windows.Forms.Padding(5)
        Me.groupBox10.Size = New System.Drawing.Size(436, 175)
        Me.groupBox10.TabIndex = 6
        Me.groupBox10.TabStop = False
        Me.groupBox10.Text = "Value items"
        '
        'barcodeValueTextBox
        '
        Me.barcodeValueTextBox.BackColor = System.Drawing.Color.White
        Me.barcodeValueTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.barcodeValueTextBox.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.barcodeValueTextBox.Location = New System.Drawing.Point(0, 0)
        Me.barcodeValueTextBox.Multiline = True
        Me.barcodeValueTextBox.Name = "barcodeValueTextBox"
        Me.barcodeValueTextBox.ReadOnly = True
        Me.barcodeValueTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.barcodeValueTextBox.Size = New System.Drawing.Size(432, 172)
        Me.barcodeValueTextBox.TabIndex = 0
        '
        'readerTextEncodingComboBox
        '
        Me.readerTextEncodingComboBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.readerTextEncodingComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.readerTextEncodingComboBox.FormattingEnabled = True
        Me.readerTextEncodingComboBox.Location = New System.Drawing.Point(84, 2)
        Me.readerTextEncodingComboBox.Name = "readerTextEncodingComboBox"
        Me.readerTextEncodingComboBox.Size = New System.Drawing.Size(348, 21)
        Me.readerTextEncodingComboBox.TabIndex = 39
        '
        'showNonDataFlagsCheckBox
        '
        Me.showNonDataFlagsCheckBox.Location = New System.Drawing.Point(3, 27)
        Me.showNonDataFlagsCheckBox.Name = "showNonDataFlagsCheckBox"
        Me.showNonDataFlagsCheckBox.Size = New System.Drawing.Size(134, 17)
        Me.showNonDataFlagsCheckBox.TabIndex = 38
        Me.showNonDataFlagsCheckBox.Text = "Show Non-data Flags"
        Me.showNonDataFlagsCheckBox.UseVisualStyleBackColor = True
        '
        'barcodeValueAsGS1RadioButton
        '
        Me.barcodeValueAsGS1RadioButton.AutoSize = True
        Me.barcodeValueAsGS1RadioButton.Location = New System.Drawing.Point(350, 7)
        Me.barcodeValueAsGS1RadioButton.Name = "barcodeValueAsGS1RadioButton"
        Me.barcodeValueAsGS1RadioButton.Size = New System.Drawing.Size(46, 17)
        Me.barcodeValueAsGS1RadioButton.TabIndex = 17
        Me.barcodeValueAsGS1RadioButton.Text = "GS1"
        Me.barcodeValueAsGS1RadioButton.UseVisualStyleBackColor = True
        '
        'showGS1DecoderButton
        '
        Me.showGS1DecoderButton.Location = New System.Drawing.Point(322, 27)
        Me.showGS1DecoderButton.Name = "showGS1DecoderButton"
        Me.showGS1DecoderButton.Size = New System.Drawing.Size(101, 22)
        Me.showGS1DecoderButton.TabIndex = 16
        Me.showGS1DecoderButton.Text = "GS1 Decoder..."
        Me.showGS1DecoderButton.UseVisualStyleBackColor = True
        '
        'barcodeValueAsHexRadioButton
        '
        Me.barcodeValueAsHexRadioButton.AutoSize = True
        Me.barcodeValueAsHexRadioButton.Location = New System.Drawing.Point(77, 6)
        Me.barcodeValueAsHexRadioButton.Name = "barcodeValueAsHexRadioButton"
        Me.barcodeValueAsHexRadioButton.Size = New System.Drawing.Size(47, 17)
        Me.barcodeValueAsHexRadioButton.TabIndex = 2
        Me.barcodeValueAsHexRadioButton.Text = "HEX"
        Me.barcodeValueAsHexRadioButton.UseVisualStyleBackColor = True
        '
        'barcodeValueAsBinaryRadioButton
        '
        Me.barcodeValueAsBinaryRadioButton.AutoSize = True
        Me.barcodeValueAsBinaryRadioButton.Location = New System.Drawing.Point(148, 6)
        Me.barcodeValueAsBinaryRadioButton.Name = "barcodeValueAsBinaryRadioButton"
        Me.barcodeValueAsBinaryRadioButton.Size = New System.Drawing.Size(65, 17)
        Me.barcodeValueAsBinaryRadioButton.TabIndex = 1
        Me.barcodeValueAsBinaryRadioButton.Text = "BINARY"
        Me.barcodeValueAsBinaryRadioButton.UseVisualStyleBackColor = True
        '
        'barcodeValueAsTextRadioButton
        '
        Me.barcodeValueAsTextRadioButton.AutoSize = True
        Me.barcodeValueAsTextRadioButton.Checked = True
        Me.barcodeValueAsTextRadioButton.Location = New System.Drawing.Point(3, 6)
        Me.barcodeValueAsTextRadioButton.Name = "barcodeValueAsTextRadioButton"
        Me.barcodeValueAsTextRadioButton.Size = New System.Drawing.Size(53, 17)
        Me.barcodeValueAsTextRadioButton.TabIndex = 0
        Me.barcodeValueAsTextRadioButton.TabStop = True
        Me.barcodeValueAsTextRadioButton.Text = "TEXT"
        Me.barcodeValueAsTextRadioButton.UseVisualStyleBackColor = True
        '
        'valueItemsDataGridView
        '
        Me.valueItemsDataGridView.AllowUserToAddRows = False
        Me.valueItemsDataGridView.AllowUserToDeleteRows = False
        Me.valueItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.valueItemsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Number, Me.dataGridViewTextBoxColumn1, Me.dataGridViewTextBoxColumn2, Me.FieldHEXValue})
        Me.valueItemsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.valueItemsDataGridView.Location = New System.Drawing.Point(5, 18)
        Me.valueItemsDataGridView.Name = "valueItemsDataGridView"
        Me.valueItemsDataGridView.ReadOnly = True
        Me.valueItemsDataGridView.RowHeadersVisible = False
        Me.valueItemsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.valueItemsDataGridView.Size = New System.Drawing.Size(432, 152)
        Me.valueItemsDataGridView.TabIndex = 0
        '
        'Number
        '
        Me.Number.HeaderText = "№"
        Me.Number.Name = "Number"
        Me.Number.ReadOnly = True
        Me.Number.Width = 30
        '
        'dataGridViewTextBoxColumn1
        '
        Me.dataGridViewTextBoxColumn1.HeaderText = "Type"
        Me.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1"
        Me.dataGridViewTextBoxColumn1.ReadOnly = True
        '
        'dataGridViewTextBoxColumn2
        '
        Me.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dataGridViewTextBoxColumn2.HeaderText = "Value"
        Me.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2"
        Me.dataGridViewTextBoxColumn2.ReadOnly = True
        Me.dataGridViewTextBoxColumn2.Width = 250
        '
        'FieldHEXValue
        '
        Me.FieldHEXValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FieldHEXValue.HeaderText = "HEX"
        Me.FieldHEXValue.Name = "FieldHEXValue"
        Me.FieldHEXValue.ReadOnly = True
        Me.FieldHEXValue.Width = 54
        '
        'panel10
        '
        Me.panel10.Controls.Add(Me.panel11)
        Me.panel10.Controls.Add(Me.panel5)
        Me.panel10.Dock = System.Windows.Forms.DockStyle.Left
        Me.panel10.Location = New System.Drawing.Point(3, 3)
        Me.panel10.Name = "panel10"
        Me.panel10.Padding = New System.Windows.Forms.Padding(1)
        Me.panel10.Size = New System.Drawing.Size(332, 444)
        Me.panel10.TabIndex = 21
        '
        'panel11
        '
        Me.panel11.Controls.Add(Me.panel20)
        Me.panel11.Controls.Add(Me.panel19)
        Me.panel11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel11.Location = New System.Drawing.Point(1, 152)
        Me.panel11.Name = "panel11"
        Me.panel11.Size = New System.Drawing.Size(330, 291)
        Me.panel11.TabIndex = 21
        '
        'panel20
        '
        Me.panel20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel20.Location = New System.Drawing.Point(0, 0)
        Me.panel20.Name = "panel20"
        Me.panel20.Padding = New System.Windows.Forms.Padding(1)
        Me.panel20.Size = New System.Drawing.Size(330, 116)
        Me.panel20.TabIndex = 1
        '
        'panel19
        '
        Me.panel19.Controls.Add(Me.groupBox8)
        Me.panel19.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel19.Location = New System.Drawing.Point(0, 116)
        Me.panel19.Name = "panel19"
        Me.panel19.Size = New System.Drawing.Size(330, 175)
        Me.panel19.TabIndex = 0
        '
        'groupBox8
        '
        Me.groupBox8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.groupBox8.Location = New System.Drawing.Point(0, 0)
        Me.groupBox8.Name = "groupBox8"
        Me.groupBox8.Padding = New System.Windows.Forms.Padding(5)
        Me.groupBox8.Size = New System.Drawing.Size(330, 175)
        Me.groupBox8.TabIndex = 3
        Me.groupBox8.TabStop = False
        Me.groupBox8.Text = "Extended information"
        '
        'panel5
        '
        Me.panel5.Controls.Add(Me.label42)
        Me.panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel5.Location = New System.Drawing.Point(1, 1)
        Me.panel5.Name = "panel5"
        Me.panel5.Size = New System.Drawing.Size(330, 151)
        Me.panel5.TabIndex = 20
        '
        'label42
        '
        Me.label42.AutoSize = True
        Me.label42.Location = New System.Drawing.Point(186, 5)
        Me.label42.Name = "label42"
        Me.label42.Size = New System.Drawing.Size(12, 13)
        Me.label42.TabIndex = 25
        Me.label42.Text = "/"
        '
        'barcodePictureBox
        '
        Me.barcodePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.barcodePictureBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.barcodePictureBox.Location = New System.Drawing.Point(1, 1)
        Me.barcodePictureBox.Name = "barcodePictureBox"
        Me.barcodePictureBox.Size = New System.Drawing.Size(328, 120)
        Me.barcodePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.barcodePictureBox.TabIndex = 0
        Me.barcodePictureBox.TabStop = False
        '
        'extendedInfoDataGridView
        '
        Me.extendedInfoDataGridView.AllowUserToAddRows = False
        Me.extendedInfoDataGridView.AllowUserToDeleteRows = False
        Me.extendedInfoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.extendedInfoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FieldName, Me.FieldValue})
        Me.extendedInfoDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.extendedInfoDataGridView.Location = New System.Drawing.Point(5, 18)
        Me.extendedInfoDataGridView.Name = "extendedInfoDataGridView"
        Me.extendedInfoDataGridView.ReadOnly = True
        Me.extendedInfoDataGridView.RowHeadersVisible = False
        Me.extendedInfoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.extendedInfoDataGridView.Size = New System.Drawing.Size(320, 152)
        Me.extendedInfoDataGridView.TabIndex = 0
        '
        'FieldName
        '
        Me.FieldName.HeaderText = "Name"
        Me.FieldName.Name = "FieldName"
        Me.FieldName.ReadOnly = True
        Me.FieldName.Width = 200
        '
        'FieldValue
        '
        Me.FieldValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.FieldValue.HeaderText = "Value"
        Me.FieldValue.Name = "FieldValue"
        Me.FieldValue.ReadOnly = True
        '
        'ISO15416QualityTestButton
        '
        Me.ISO15416QualityTestButton.Enabled = False
        Me.ISO15416QualityTestButton.Location = New System.Drawing.Point(189, 67)
        Me.ISO15416QualityTestButton.Name = "ISO15416QualityTestButton"
        Me.ISO15416QualityTestButton.Size = New System.Drawing.Size(138, 22)
        Me.ISO15416QualityTestButton.TabIndex = 27
        Me.ISO15416QualityTestButton.Text = "ISO15416 Quality Test..."
        Me.ISO15416QualityTestButton.UseVisualStyleBackColor = True
        '
        'structureAppendLabel
        '
        Me.structureAppendLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.structureAppendLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.structureAppendLabel.ForeColor = System.Drawing.Color.Green
        Me.structureAppendLabel.Location = New System.Drawing.Point(189, 117)
        Me.structureAppendLabel.Name = "structureAppendLabel"
        Me.structureAppendLabel.Size = New System.Drawing.Size(138, 28)
        Me.structureAppendLabel.TabIndex = 26
        Me.structureAppendLabel.Text = "Used Structured Append:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "symbol 0 of 0"
        Me.structureAppendLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.structureAppendLabel.Visible = False
        '
        'ISO15415QualityTestButton
        '
        Me.ISO15415QualityTestButton.Enabled = False
        Me.ISO15415QualityTestButton.Location = New System.Drawing.Point(189, 45)
        Me.ISO15415QualityTestButton.Name = "ISO15415QualityTestButton"
        Me.ISO15415QualityTestButton.Size = New System.Drawing.Size(138, 22)
        Me.ISO15415QualityTestButton.TabIndex = 18
        Me.ISO15415QualityTestButton.Text = "ISO15415 Quality Test..."
        Me.ISO15415QualityTestButton.UseVisualStyleBackColor = True
        '
        'totalBarcodesLabel
        '
        Me.totalBarcodesLabel.AutoSize = True
        Me.totalBarcodesLabel.Location = New System.Drawing.Point(197, 5)
        Me.totalBarcodesLabel.Name = "totalBarcodesLabel"
        Me.totalBarcodesLabel.Size = New System.Drawing.Size(13, 13)
        Me.totalBarcodesLabel.TabIndex = 23
        Me.totalBarcodesLabel.Text = "0"
        '
        'label33
        '
        Me.label33.AutoSize = True
        Me.label33.Location = New System.Drawing.Point(6, 6)
        Me.label33.Name = "label33"
        Me.label33.Size = New System.Drawing.Size(87, 13)
        Me.label33.TabIndex = 22
        Me.label33.Text = "Barcode Number"
        '
        'boundRectnalgeLabel
        '
        Me.boundRectnalgeLabel.AutoSize = True
        Me.boundRectnalgeLabel.ForeColor = System.Drawing.Color.Black
        Me.boundRectnalgeLabel.Location = New System.Drawing.Point(117, 97)
        Me.boundRectnalgeLabel.Name = "boundRectnalgeLabel"
        Me.boundRectnalgeLabel.Size = New System.Drawing.Size(13, 13)
        Me.boundRectnalgeLabel.TabIndex = 15
        Me.boundRectnalgeLabel.Text = "[]"
        '
        'label34
        '
        Me.label34.AutoSize = True
        Me.label34.Location = New System.Drawing.Point(4, 29)
        Me.label34.Name = "label34"
        Me.label34.Size = New System.Drawing.Size(74, 13)
        Me.label34.TabIndex = 6
        Me.label34.Text = "Barcode Type"
        '
        'barcodeTypeLabel
        '
        Me.barcodeTypeLabel.AutoSize = True
        Me.barcodeTypeLabel.Location = New System.Drawing.Point(117, 29)
        Me.barcodeTypeLabel.Name = "barcodeTypeLabel"
        Me.barcodeTypeLabel.Size = New System.Drawing.Size(13, 13)
        Me.barcodeTypeLabel.TabIndex = 7
        Me.barcodeTypeLabel.Text = "[]"
        '
        'thresholdLabel
        '
        Me.thresholdLabel.AutoSize = True
        Me.thresholdLabel.Location = New System.Drawing.Point(117, 131)
        Me.thresholdLabel.Name = "thresholdLabel"
        Me.thresholdLabel.Size = New System.Drawing.Size(13, 13)
        Me.thresholdLabel.TabIndex = 19
        Me.thresholdLabel.Text = "[]"
        '
        'label35
        '
        Me.label35.AutoSize = True
        Me.label35.Location = New System.Drawing.Point(4, 46)
        Me.label35.Name = "label35"
        Me.label35.Size = New System.Drawing.Size(61, 13)
        Me.label35.TabIndex = 8
        Me.label35.Text = "Confidence"
        '
        'rotationAngleLabel
        '
        Me.rotationAngleLabel.AutoSize = True
        Me.rotationAngleLabel.Location = New System.Drawing.Point(117, 114)
        Me.rotationAngleLabel.Name = "rotationAngleLabel"
        Me.rotationAngleLabel.Size = New System.Drawing.Size(13, 13)
        Me.rotationAngleLabel.TabIndex = 18
        Me.rotationAngleLabel.Text = "[]"
        '
        'confidenceLabel
        '
        Me.confidenceLabel.AutoSize = True
        Me.confidenceLabel.Location = New System.Drawing.Point(117, 46)
        Me.confidenceLabel.Name = "confidenceLabel"
        Me.confidenceLabel.Size = New System.Drawing.Size(13, 13)
        Me.confidenceLabel.TabIndex = 9
        Me.confidenceLabel.Text = "[]"
        '
        'label40
        '
        Me.label40.AutoSize = True
        Me.label40.Location = New System.Drawing.Point(4, 131)
        Me.label40.Name = "label40"
        Me.label40.Size = New System.Drawing.Size(103, 13)
        Me.label40.TabIndex = 17
        Me.label40.Text = "Detection Threshold"
        '
        'readingQualityLabel
        '
        Me.readingQualityLabel.AutoSize = True
        Me.readingQualityLabel.Location = New System.Drawing.Point(117, 63)
        Me.readingQualityLabel.Name = "readingQualityLabel"
        Me.readingQualityLabel.Size = New System.Drawing.Size(13, 13)
        Me.readingQualityLabel.TabIndex = 10
        Me.readingQualityLabel.Text = "[]"
        '
        'label39
        '
        Me.label39.AutoSize = True
        Me.label39.Location = New System.Drawing.Point(4, 114)
        Me.label39.Name = "label39"
        Me.label39.Size = New System.Drawing.Size(77, 13)
        Me.label39.TabIndex = 16
        Me.label39.Text = "Rotation Angle"
        '
        'label37
        '
        Me.label37.AutoSize = True
        Me.label37.Location = New System.Drawing.Point(4, 63)
        Me.label37.Name = "label37"
        Me.label37.Size = New System.Drawing.Size(82, 13)
        Me.label37.TabIndex = 11
        Me.label37.Text = "Reading Quality"
        '
        'label38
        '
        Me.label38.AutoSize = True
        Me.label38.Location = New System.Drawing.Point(4, 80)
        Me.label38.Name = "label38"
        Me.label38.Size = New System.Drawing.Size(49, 13)
        Me.label38.TabIndex = 12
        Me.label38.Text = "Direction"
        '
        'label36
        '
        Me.label36.AutoSize = True
        Me.label36.Location = New System.Drawing.Point(4, 97)
        Me.label36.Name = "label36"
        Me.label36.Size = New System.Drawing.Size(90, 13)
        Me.label36.TabIndex = 14
        Me.label36.Text = "Bound Rectangle"
        '
        'directionLabel
        '
        Me.directionLabel.AutoSize = True
        Me.directionLabel.Location = New System.Drawing.Point(117, 80)
        Me.directionLabel.Name = "directionLabel"
        Me.directionLabel.Size = New System.Drawing.Size(13, 13)
        Me.directionLabel.TabIndex = 13
        Me.directionLabel.Text = "[]"
        '
        'panel1
        '
        Me.panel1.Controls.Add(Me.panel2)
        Me.panel1.Controls.Add(Me.panel6)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.panel1.Location = New System.Drawing.Point(0, 0)
        Me.panel1.Name = "panel1"
        Me.panel1.Padding = New System.Windows.Forms.Padding(1)
        Me.panel1.Size = New System.Drawing.Size(332, 450)
        Me.panel1.TabIndex = 22
        '
        'panel2
        '
        Me.panel2.Controls.Add(Me.panel3)
        Me.panel2.Controls.Add(Me.panel4)
        Me.panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel2.Location = New System.Drawing.Point(1, 152)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(330, 297)
        Me.panel2.TabIndex = 21
        '
        'panel3
        '
        Me.panel3.Controls.Add(Me.barcodePictureBox)
        Me.panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel3.Location = New System.Drawing.Point(0, 0)
        Me.panel3.Name = "panel3"
        Me.panel3.Padding = New System.Windows.Forms.Padding(1)
        Me.panel3.Size = New System.Drawing.Size(330, 122)
        Me.panel3.TabIndex = 1
        '
        'panel4
        '
        Me.panel4.Controls.Add(Me.groupBox1)
        Me.panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel4.Location = New System.Drawing.Point(0, 122)
        Me.panel4.Name = "panel4"
        Me.panel4.Size = New System.Drawing.Size(330, 175)
        Me.panel4.TabIndex = 0
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.extendedInfoDataGridView)
        Me.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.groupBox1.Location = New System.Drawing.Point(0, 0)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Padding = New System.Windows.Forms.Padding(5)
        Me.groupBox1.Size = New System.Drawing.Size(330, 175)
        Me.groupBox1.TabIndex = 3
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Extended information"
        '
        'panel6
        '
        Me.panel6.Controls.Add(Me.ISO15416QualityTestButton)
        Me.panel6.Controls.Add(Me.structureAppendLabel)
        Me.panel6.Controls.Add(Me.ISO15415QualityTestButton)
        Me.panel6.Controls.Add(Me.label2)
        Me.panel6.Controls.Add(Me.selectedBarcodeNumericUpDown)
        Me.panel6.Controls.Add(Me.totalBarcodesLabel)
        Me.panel6.Controls.Add(Me.label33)
        Me.panel6.Controls.Add(Me.boundRectnalgeLabel)
        Me.panel6.Controls.Add(Me.label34)
        Me.panel6.Controls.Add(Me.barcodeTypeLabel)
        Me.panel6.Controls.Add(Me.thresholdLabel)
        Me.panel6.Controls.Add(Me.label35)
        Me.panel6.Controls.Add(Me.rotationAngleLabel)
        Me.panel6.Controls.Add(Me.confidenceLabel)
        Me.panel6.Controls.Add(Me.label40)
        Me.panel6.Controls.Add(Me.readingQualityLabel)
        Me.panel6.Controls.Add(Me.label39)
        Me.panel6.Controls.Add(Me.label37)
        Me.panel6.Controls.Add(Me.label38)
        Me.panel6.Controls.Add(Me.label36)
        Me.panel6.Controls.Add(Me.directionLabel)
        Me.panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel6.Location = New System.Drawing.Point(1, 1)
        Me.panel6.Name = "panel6"
        Me.panel6.Size = New System.Drawing.Size(330, 151)
        Me.panel6.TabIndex = 20
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(186, 5)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(12, 13)
        Me.label2.TabIndex = 25
        Me.label2.Text = "/"
        '
        'selectedBarcodeNumericUpDown
        '
        Me.selectedBarcodeNumericUpDown.Location = New System.Drawing.Point(120, 3)
        Me.selectedBarcodeNumericUpDown.Maximum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.selectedBarcodeNumericUpDown.Name = "selectedBarcodeNumericUpDown"
        Me.selectedBarcodeNumericUpDown.Size = New System.Drawing.Size(60, 20)
        Me.selectedBarcodeNumericUpDown.TabIndex = 24
        '
        'panel7
        '
        Me.panel7.Controls.Add(Me.panel8)
        Me.panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel7.Location = New System.Drawing.Point(332, 0)
        Me.panel7.Name = "panel7"
        Me.panel7.Padding = New System.Windows.Forms.Padding(1)
        Me.panel7.Size = New System.Drawing.Size(444, 450)
        Me.panel7.TabIndex = 23
        '
        'panel8
        '
        Me.panel8.Controls.Add(Me.panel9)
        Me.panel8.Controls.Add(Me.panel25)
        Me.panel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel8.Location = New System.Drawing.Point(1, 1)
        Me.panel8.Name = "panel8"
        Me.panel8.Size = New System.Drawing.Size(442, 448)
        Me.panel8.TabIndex = 8
        '
        'panel9
        '
        Me.panel9.Controls.Add(Me.groupBox2)
        Me.panel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel9.Location = New System.Drawing.Point(0, 0)
        Me.panel9.Name = "panel9"
        Me.panel9.Size = New System.Drawing.Size(442, 273)
        Me.panel9.TabIndex = 1
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.panel15)
        Me.groupBox2.Controls.Add(Me.panel23)
        Me.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.groupBox2.Location = New System.Drawing.Point(0, 0)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Padding = New System.Windows.Forms.Padding(5)
        Me.groupBox2.Size = New System.Drawing.Size(442, 273)
        Me.groupBox2.TabIndex = 5
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "Value"
        '
        'panel15
        '
        Me.panel15.Controls.Add(Me.panel21)
        Me.panel15.Controls.Add(Me.panel22)
        Me.panel15.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel15.Location = New System.Drawing.Point(5, 70)
        Me.panel15.Name = "panel15"
        Me.panel15.Size = New System.Drawing.Size(432, 198)
        Me.panel15.TabIndex = 2
        '
        'panel21
        '
        Me.panel21.Controls.Add(Me.barcodeValueTextBox)
        Me.panel21.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel21.Location = New System.Drawing.Point(0, 0)
        Me.panel21.Name = "panel21"
        Me.panel21.Size = New System.Drawing.Size(432, 172)
        Me.panel21.TabIndex = 1
        '
        'panel22
        '
        Me.panel22.Controls.Add(Me.label19)
        Me.panel22.Controls.Add(Me.readerTextEncodingComboBox)
        Me.panel22.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel22.Location = New System.Drawing.Point(0, 172)
        Me.panel22.Name = "panel22"
        Me.panel22.Size = New System.Drawing.Size(432, 26)
        Me.panel22.TabIndex = 0
        '
        'label19
        '
        Me.label19.AutoSize = True
        Me.label19.Location = New System.Drawing.Point(3, 5)
        Me.label19.Name = "label19"
        Me.label19.Size = New System.Drawing.Size(75, 13)
        Me.label19.TabIndex = 40
        Me.label19.Text = "Text encoding"
        '
        'panel23
        '
        Me.panel23.Controls.Add(Me.showNonDataFlagsCheckBox)
        Me.panel23.Controls.Add(Me.barcodeValueAsGS1RadioButton)
        Me.panel23.Controls.Add(Me.showGS1DecoderButton)
        Me.panel23.Controls.Add(Me.barcodeValueAsHexRadioButton)
        Me.panel23.Controls.Add(Me.barcodeValueAsBinaryRadioButton)
        Me.panel23.Controls.Add(Me.barcodeValueAsTextRadioButton)
        Me.panel23.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel23.Location = New System.Drawing.Point(5, 18)
        Me.panel23.Name = "panel23"
        Me.panel23.Size = New System.Drawing.Size(432, 52)
        Me.panel23.TabIndex = 1
        '
        'panel25
        '
        Me.panel25.Controls.Add(Me.groupBox3)
        Me.panel25.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel25.Location = New System.Drawing.Point(0, 273)
        Me.panel25.Name = "panel25"
        Me.panel25.Size = New System.Drawing.Size(442, 175)
        Me.panel25.TabIndex = 0
        '
        'groupBox3
        '
        Me.groupBox3.Controls.Add(Me.valueItemsDataGridView)
        Me.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.groupBox3.Location = New System.Drawing.Point(0, 0)
        Me.groupBox3.Name = "groupBox3"
        Me.groupBox3.Padding = New System.Windows.Forms.Padding(5)
        Me.groupBox3.Size = New System.Drawing.Size(442, 175)
        Me.groupBox3.TabIndex = 6
        Me.groupBox3.TabStop = False
        Me.groupBox3.Text = "Value items"
        '
        'BarcodeReaderResultsControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.panel7)
        Me.Controls.Add(Me.panel1)
        Me.Name = "BarcodeReaderResultsControl"
        Me.Size = New System.Drawing.Size(776, 450)
        Me.panel12.ResumeLayout(False)
        Me.panel16.ResumeLayout(False)
        Me.panel18.ResumeLayout(False)
        Me.groupBox9.ResumeLayout(False)
        Me.panel13.ResumeLayout(False)
        Me.readerTextEncodingPanel.ResumeLayout(False)
        Me.readerTextEncodingPanel.PerformLayout()
        Me.panel17.ResumeLayout(False)
        CType(Me.valueItemsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel10.ResumeLayout(False)
        Me.panel11.ResumeLayout(False)
        Me.panel19.ResumeLayout(False)
        Me.panel5.ResumeLayout(False)
        Me.panel5.PerformLayout()
        CType(Me.barcodePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.extendedInfoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel1.ResumeLayout(False)
        Me.panel2.ResumeLayout(False)
        Me.panel3.ResumeLayout(False)
        Me.panel4.ResumeLayout(False)
        Me.groupBox1.ResumeLayout(False)
        Me.panel6.ResumeLayout(False)
        Me.panel6.PerformLayout()
        CType(Me.selectedBarcodeNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel7.ResumeLayout(False)
        Me.panel8.ResumeLayout(False)
        Me.panel9.ResumeLayout(False)
        Me.groupBox2.ResumeLayout(False)
        Me.panel15.ResumeLayout(False)
        Me.panel21.ResumeLayout(False)
        Me.panel21.PerformLayout()
        Me.panel22.ResumeLayout(False)
        Me.panel22.PerformLayout()
        Me.panel23.ResumeLayout(False)
        Me.panel23.PerformLayout()
        Me.panel25.ResumeLayout(False)
        Me.groupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

	#End Region

	Private WithEvents panel12 As System.Windows.Forms.Panel
	Private WithEvents panel16 As System.Windows.Forms.Panel
	Private WithEvents panel18 As System.Windows.Forms.Panel
    Private WithEvents groupBox9 As System.Windows.Forms.GroupBox
	Private WithEvents panel13 As System.Windows.Forms.Panel
	Private WithEvents panel24 As System.Windows.Forms.Panel
	Private WithEvents readerTextEncodingPanel As System.Windows.Forms.Panel
	Private WithEvents label48 As System.Windows.Forms.Label
	Private WithEvents panel14 As System.Windows.Forms.Panel
	Private WithEvents panel17 As System.Windows.Forms.Panel
    Private WithEvents groupBox10 As System.Windows.Forms.GroupBox
	Private WithEvents panel10 As System.Windows.Forms.Panel
	Private WithEvents panel11 As System.Windows.Forms.Panel
	Private WithEvents panel20 As System.Windows.Forms.Panel
	Private WithEvents panel19 As System.Windows.Forms.Panel
    Private WithEvents groupBox8 As System.Windows.Forms.GroupBox
	Private WithEvents panel5 As System.Windows.Forms.Panel
	Private WithEvents label42 As System.Windows.Forms.Label
	Private WithEvents panel1 As System.Windows.Forms.Panel
	Private WithEvents panel2 As System.Windows.Forms.Panel
	Private WithEvents panel3 As System.Windows.Forms.Panel
	Private WithEvents barcodePictureBox As System.Windows.Forms.PictureBox
	Private WithEvents panel4 As System.Windows.Forms.Panel
    Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents extendedInfoDataGridView As System.Windows.Forms.DataGridView
	Private WithEvents panel7 As System.Windows.Forms.Panel
	Private WithEvents panel8 As System.Windows.Forms.Panel
	Private WithEvents panel9 As System.Windows.Forms.Panel
    Private WithEvents groupBox2 As System.Windows.Forms.GroupBox
	Private WithEvents panel15 As System.Windows.Forms.Panel
	Private WithEvents panel21 As System.Windows.Forms.Panel
	Private WithEvents barcodeValueTextBox As System.Windows.Forms.TextBox
	Private WithEvents panel22 As System.Windows.Forms.Panel
	Private WithEvents label19 As System.Windows.Forms.Label
	Private WithEvents readerTextEncodingComboBox As System.Windows.Forms.ComboBox
	Private WithEvents panel23 As System.Windows.Forms.Panel
	Friend WithEvents showNonDataFlagsCheckBox As System.Windows.Forms.CheckBox
	Private WithEvents barcodeValueAsGS1RadioButton As System.Windows.Forms.RadioButton
	Private WithEvents showGS1DecoderButton As System.Windows.Forms.Button
	Private WithEvents barcodeValueAsHexRadioButton As System.Windows.Forms.RadioButton
	Private WithEvents barcodeValueAsBinaryRadioButton As System.Windows.Forms.RadioButton
	Private WithEvents barcodeValueAsTextRadioButton As System.Windows.Forms.RadioButton
	Private WithEvents panel25 As System.Windows.Forms.Panel
    Private WithEvents groupBox3 As System.Windows.Forms.GroupBox
    Private WithEvents valueItemsDataGridView As System.Windows.Forms.DataGridView
	Private WithEvents panel6 As System.Windows.Forms.Panel
	Private WithEvents ISO15416QualityTestButton As System.Windows.Forms.Button
	Private WithEvents structureAppendLabel As System.Windows.Forms.Label
	Private WithEvents ISO15415QualityTestButton As System.Windows.Forms.Button
	Private WithEvents label2 As System.Windows.Forms.Label
	Private WithEvents selectedBarcodeNumericUpDown As System.Windows.Forms.NumericUpDown
	Private WithEvents totalBarcodesLabel As System.Windows.Forms.Label
	Private WithEvents label33 As System.Windows.Forms.Label
	Private WithEvents boundRectnalgeLabel As System.Windows.Forms.Label
	Private WithEvents label34 As System.Windows.Forms.Label
	Private WithEvents barcodeTypeLabel As System.Windows.Forms.Label
	Private WithEvents thresholdLabel As System.Windows.Forms.Label
	Private WithEvents label35 As System.Windows.Forms.Label
	Private WithEvents rotationAngleLabel As System.Windows.Forms.Label
	Private WithEvents confidenceLabel As System.Windows.Forms.Label
	Private WithEvents label40 As System.Windows.Forms.Label
	Private WithEvents readingQualityLabel As System.Windows.Forms.Label
	Private WithEvents label39 As System.Windows.Forms.Label
	Private WithEvents label37 As System.Windows.Forms.Label
	Private WithEvents label38 As System.Windows.Forms.Label
	Private WithEvents label36 As System.Windows.Forms.Label
	Private WithEvents directionLabel As System.Windows.Forms.Label
	Private WithEvents FieldName As System.Windows.Forms.DataGridViewTextBoxColumn
	Private WithEvents FieldValue As System.Windows.Forms.DataGridViewTextBoxColumn
	Private WithEvents Number As System.Windows.Forms.DataGridViewTextBoxColumn
	Private WithEvents dataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
	Private WithEvents dataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
	Private WithEvents FieldHEXValue As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
