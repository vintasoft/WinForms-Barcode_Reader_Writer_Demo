Partial Class AdvancedReaderSettingsControl
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
        Me.groupBox5 = New System.Windows.Forms.GroupBox
        Me.label1 = New System.Windows.Forms.Label
        Me.DataMatrixLPatternMaxErasuresNumericUpDown = New System.Windows.Forms.NumericUpDown
        Me.interpretEciCharactersCheckBox = New System.Windows.Forms.CheckBox
        Me.groupBox11 = New System.Windows.Forms.GroupBox
        Me.barcodeCharacteristicSmallBarcodesCheckBox = New System.Windows.Forms.CheckBox
        Me.barcodeReaderMSIGroupBox = New System.Windows.Forms.GroupBox
        Me.barcodeReaderMSIChecksumComboBox = New System.Windows.Forms.ComboBox
        Me.useCode128ExtendedDecodeTableCheckBox = New System.Windows.Forms.CheckBox
        Me.collectQualityTestInformationCheckBox = New System.Windows.Forms.CheckBox
        Me.telepenEnableNumericModeCheckBox = New System.Windows.Forms.CheckBox
        Me.searchDistortedQRBarcodesCheckBox = New System.Windows.Forms.CheckBox
        Me.searchDistortedDataMatrixBarcodesCheckBox = New System.Windows.Forms.CheckBox
        Me.optionalChecksumCheckBox = New System.Windows.Forms.CheckBox
        Me.groupAustralianPostCustomInfo = New System.Windows.Forms.GroupBox
        Me.barcodeReaderAustralianCustomInfoComboBox = New System.Windows.Forms.ComboBox
        Me.groupBox5.SuspendLayout()
        CType(Me.DataMatrixLPatternMaxErasuresNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox11.SuspendLayout()
        Me.barcodeReaderMSIGroupBox.SuspendLayout()
        Me.groupAustralianPostCustomInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'groupBox5
        '
        Me.groupBox5.Controls.Add(Me.label1)
        Me.groupBox5.Controls.Add(Me.DataMatrixLPatternMaxErasuresNumericUpDown)
        Me.groupBox5.Controls.Add(Me.interpretEciCharactersCheckBox)
        Me.groupBox5.Controls.Add(Me.groupBox11)
        Me.groupBox5.Controls.Add(Me.barcodeReaderMSIGroupBox)
        Me.groupBox5.Controls.Add(Me.useCode128ExtendedDecodeTableCheckBox)
        Me.groupBox5.Controls.Add(Me.collectQualityTestInformationCheckBox)
        Me.groupBox5.Controls.Add(Me.telepenEnableNumericModeCheckBox)
        Me.groupBox5.Controls.Add(Me.searchDistortedQRBarcodesCheckBox)
        Me.groupBox5.Controls.Add(Me.searchDistortedDataMatrixBarcodesCheckBox)
        Me.groupBox5.Controls.Add(Me.optionalChecksumCheckBox)
        Me.groupBox5.Controls.Add(Me.groupAustralianPostCustomInfo)
        Me.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.groupBox5.Location = New System.Drawing.Point(0, 0)
        Me.groupBox5.Name = "groupBox5"
        Me.groupBox5.Size = New System.Drawing.Size(276, 245)
        Me.groupBox5.TabIndex = 24
        Me.groupBox5.TabStop = False
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(23, 86)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(139, 26)
        Me.label1.TabIndex = 44
        Me.label1.Text = "Max erasures in ""L"" pattern " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "of DataMatrix barcodes"
        '
        'DataMatrixLPatternMaxErasuresNumericUpDown
        '
        Me.DataMatrixLPatternMaxErasuresNumericUpDown.Location = New System.Drawing.Point(169, 90)
        Me.DataMatrixLPatternMaxErasuresNumericUpDown.Maximum = New Decimal(New Integer() {150, 0, 0, 0})
        Me.DataMatrixLPatternMaxErasuresNumericUpDown.Name = "DataMatrixLPatternMaxErasuresNumericUpDown"
        Me.DataMatrixLPatternMaxErasuresNumericUpDown.Size = New System.Drawing.Size(99, 20)
        Me.DataMatrixLPatternMaxErasuresNumericUpDown.TabIndex = 43
        '
        'interpretEciCharactersCheckBox
        '
        Me.interpretEciCharactersCheckBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.interpretEciCharactersCheckBox.Location = New System.Drawing.Point(7, 184)
        Me.interpretEciCharactersCheckBox.Name = "interpretEciCharactersCheckBox"
        Me.interpretEciCharactersCheckBox.Size = New System.Drawing.Size(241, 17)
        Me.interpretEciCharactersCheckBox.TabIndex = 42
        Me.interpretEciCharactersCheckBox.Text = "Interpret ECI characters (text encoding info)"
        Me.interpretEciCharactersCheckBox.UseVisualStyleBackColor = True
        '
        'groupBox11
        '
        Me.groupBox11.Controls.Add(Me.barcodeCharacteristicSmallBarcodesCheckBox)
        Me.groupBox11.Location = New System.Drawing.Point(6, 200)
        Me.groupBox11.Name = "groupBox11"
        Me.groupBox11.Size = New System.Drawing.Size(264, 40)
        Me.groupBox11.TabIndex = 41
        Me.groupBox11.TabStop = False
        Me.groupBox11.Text = "Barcode Characteristics"
        '
        'barcodeCharacteristicSmallBarcodesCheckBox
        '
        Me.barcodeCharacteristicSmallBarcodesCheckBox.Location = New System.Drawing.Point(6, 17)
        Me.barcodeCharacteristicSmallBarcodesCheckBox.Name = "barcodeCharacteristicSmallBarcodesCheckBox"
        Me.barcodeCharacteristicSmallBarcodesCheckBox.Size = New System.Drawing.Size(106, 17)
        Me.barcodeCharacteristicSmallBarcodesCheckBox.TabIndex = 42
        Me.barcodeCharacteristicSmallBarcodesCheckBox.Text = "Small bacodes"
        Me.barcodeCharacteristicSmallBarcodesCheckBox.UseVisualStyleBackColor = True
        '
        'barcodeReaderMSIGroupBox
        '
        Me.barcodeReaderMSIGroupBox.Controls.Add(Me.barcodeReaderMSIChecksumComboBox)
        Me.barcodeReaderMSIGroupBox.Location = New System.Drawing.Point(145, 10)
        Me.barcodeReaderMSIGroupBox.Name = "barcodeReaderMSIGroupBox"
        Me.barcodeReaderMSIGroupBox.Size = New System.Drawing.Size(126, 42)
        Me.barcodeReaderMSIGroupBox.TabIndex = 33
        Me.barcodeReaderMSIGroupBox.TabStop = False
        Me.barcodeReaderMSIGroupBox.Text = "MSI Checksum"
        '
        'barcodeReaderMSIChecksumComboBox
        '
        Me.barcodeReaderMSIChecksumComboBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.barcodeReaderMSIChecksumComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.barcodeReaderMSIChecksumComboBox.FormattingEnabled = True
        Me.barcodeReaderMSIChecksumComboBox.Location = New System.Drawing.Point(3, 16)
        Me.barcodeReaderMSIChecksumComboBox.Name = "barcodeReaderMSIChecksumComboBox"
        Me.barcodeReaderMSIChecksumComboBox.Size = New System.Drawing.Size(120, 21)
        Me.barcodeReaderMSIChecksumComboBox.TabIndex = 0
        '
        'useCode128ExtendedDecodeTableCheckBox
        '
        Me.useCode128ExtendedDecodeTableCheckBox.Location = New System.Drawing.Point(7, 168)
        Me.useCode128ExtendedDecodeTableCheckBox.Name = "useCode128ExtendedDecodeTableCheckBox"
        Me.useCode128ExtendedDecodeTableCheckBox.Size = New System.Drawing.Size(241, 17)
        Me.useCode128ExtendedDecodeTableCheckBox.TabIndex = 40
        Me.useCode128ExtendedDecodeTableCheckBox.Text = "Code128: use extended ASCII (FNC4 shift)"
        Me.useCode128ExtendedDecodeTableCheckBox.UseVisualStyleBackColor = True
        '
        'collectQualityTestInformationCheckBox
        '
        Me.collectQualityTestInformationCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.collectQualityTestInformationCheckBox.Location = New System.Drawing.Point(7, 151)
        Me.collectQualityTestInformationCheckBox.Name = "collectQualityTestInformationCheckBox"
        Me.collectQualityTestInformationCheckBox.Size = New System.Drawing.Size(236, 17)
        Me.collectQualityTestInformationCheckBox.TabIndex = 39
        Me.collectQualityTestInformationCheckBox.Text = "Collect quality test information"
        Me.collectQualityTestInformationCheckBox.UseVisualStyleBackColor = True
        '
        'telepenEnableNumericModeCheckBox
        '
        Me.telepenEnableNumericModeCheckBox.Location = New System.Drawing.Point(7, 134)
        Me.telepenEnableNumericModeCheckBox.Name = "telepenEnableNumericModeCheckBox"
        Me.telepenEnableNumericModeCheckBox.Size = New System.Drawing.Size(236, 17)
        Me.telepenEnableNumericModeCheckBox.TabIndex = 37
        Me.telepenEnableNumericModeCheckBox.Text = "Enable Numeric mode in Telepen barcode"
        Me.telepenEnableNumericModeCheckBox.UseVisualStyleBackColor = True
        '
        'searchDistortedQRBarcodesCheckBox
        '
        Me.searchDistortedQRBarcodesCheckBox.Location = New System.Drawing.Point(7, 118)
        Me.searchDistortedQRBarcodesCheckBox.Name = "searchDistortedQRBarcodesCheckBox"
        Me.searchDistortedQRBarcodesCheckBox.Size = New System.Drawing.Size(211, 17)
        Me.searchDistortedQRBarcodesCheckBox.TabIndex = 36
        Me.searchDistortedQRBarcodesCheckBox.Text = "Search distorted QR barcodes"
        Me.searchDistortedQRBarcodesCheckBox.UseVisualStyleBackColor = True
        '
        'searchDistortedDataMatrixBarcodesCheckBox
        '
        Me.searchDistortedDataMatrixBarcodesCheckBox.Location = New System.Drawing.Point(7, 70)
        Me.searchDistortedDataMatrixBarcodesCheckBox.Name = "searchDistortedDataMatrixBarcodesCheckBox"
        Me.searchDistortedDataMatrixBarcodesCheckBox.Size = New System.Drawing.Size(225, 17)
        Me.searchDistortedDataMatrixBarcodesCheckBox.TabIndex = 35
        Me.searchDistortedDataMatrixBarcodesCheckBox.Text = "Search distorted DataMatrix barcodes"
        Me.searchDistortedDataMatrixBarcodesCheckBox.UseVisualStyleBackColor = True
        '
        'optionalChecksumCheckBox
        '
        Me.optionalChecksumCheckBox.Location = New System.Drawing.Point(7, 54)
        Me.optionalChecksumCheckBox.Name = "optionalChecksumCheckBox"
        Me.optionalChecksumCheckBox.Size = New System.Drawing.Size(169, 17)
        Me.optionalChecksumCheckBox.TabIndex = 33
        Me.optionalChecksumCheckBox.Text = "Optional checksum"
        Me.optionalChecksumCheckBox.UseVisualStyleBackColor = True
        '
        'groupAustralianPostCustomInfo
        '
        Me.groupAustralianPostCustomInfo.Controls.Add(Me.barcodeReaderAustralianCustomInfoComboBox)
        Me.groupAustralianPostCustomInfo.Location = New System.Drawing.Point(7, 10)
        Me.groupAustralianPostCustomInfo.Name = "groupAustralianPostCustomInfo"
        Me.groupAustralianPostCustomInfo.Size = New System.Drawing.Size(135, 42)
        Me.groupAustralianPostCustomInfo.TabIndex = 32
        Me.groupAustralianPostCustomInfo.TabStop = False
        Me.groupAustralianPostCustomInfo.Text = "Australian custom info"
        '
        'barcodeReaderAustralianCustomInfoComboBox
        '
        Me.barcodeReaderAustralianCustomInfoComboBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.barcodeReaderAustralianCustomInfoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.barcodeReaderAustralianCustomInfoComboBox.FormattingEnabled = True
        Me.barcodeReaderAustralianCustomInfoComboBox.Location = New System.Drawing.Point(3, 16)
        Me.barcodeReaderAustralianCustomInfoComboBox.Name = "barcodeReaderAustralianCustomInfoComboBox"
        Me.barcodeReaderAustralianCustomInfoComboBox.Size = New System.Drawing.Size(129, 21)
        Me.barcodeReaderAustralianCustomInfoComboBox.TabIndex = 1
        '
        'AdvancedReaderSettingsControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.groupBox5)
        Me.Name = "AdvancedReaderSettingsControl"
        Me.Size = New System.Drawing.Size(276, 245)
        Me.groupBox5.ResumeLayout(False)
        Me.groupBox5.PerformLayout()
        CType(Me.DataMatrixLPatternMaxErasuresNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox11.ResumeLayout(False)
        Me.barcodeReaderMSIGroupBox.ResumeLayout(False)
        Me.groupAustralianPostCustomInfo.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

	#End Region

	Private WithEvents groupBox5 As System.Windows.Forms.GroupBox
	Private WithEvents groupBox11 As System.Windows.Forms.GroupBox
	Friend WithEvents barcodeCharacteristicSmallBarcodesCheckBox As System.Windows.Forms.CheckBox
	Private WithEvents barcodeReaderMSIChecksumComboBox As System.Windows.Forms.ComboBox
	Friend WithEvents useCode128ExtendedDecodeTableCheckBox As System.Windows.Forms.CheckBox
	Friend WithEvents collectQualityTestInformationCheckBox As System.Windows.Forms.CheckBox
	Friend WithEvents telepenEnableNumericModeCheckBox As System.Windows.Forms.CheckBox
	Friend WithEvents searchDistortedQRBarcodesCheckBox As System.Windows.Forms.CheckBox
	Friend WithEvents searchDistortedDataMatrixBarcodesCheckBox As System.Windows.Forms.CheckBox
	Friend WithEvents optionalChecksumCheckBox As System.Windows.Forms.CheckBox
	Private WithEvents barcodeReaderAustralianCustomInfoComboBox As System.Windows.Forms.ComboBox
	Private WithEvents barcodeReaderMSIGroupBox As System.Windows.Forms.GroupBox
	Private WithEvents groupAustralianPostCustomInfo As System.Windows.Forms.GroupBox
	Friend WithEvents interpretEciCharactersCheckBox As System.Windows.Forms.CheckBox
	Private WithEvents label1 As System.Windows.Forms.Label
	Private WithEvents DataMatrixLPatternMaxErasuresNumericUpDown As System.Windows.Forms.NumericUpDown
End Class
