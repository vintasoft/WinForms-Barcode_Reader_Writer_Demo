Namespace Controls
	Partial Class BarcodeWriterSettingsControl
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
            Me.label1 = New System.Windows.Forms.Label
            Me.barcodeValueTextBox = New System.Windows.Forms.TextBox
            Me.valueVisibleCheckBox = New System.Windows.Forms.CheckBox
            Me.fontSelector = New System.Windows.Forms.ComboBox
            Me.label2 = New System.Windows.Forms.Label
            Me.label3 = New System.Windows.Forms.Label
            Me.label4 = New System.Windows.Forms.Label
            Me.valueAutoLetterSpacingCheckBox = New System.Windows.Forms.CheckBox
            Me.label6 = New System.Windows.Forms.Label
            Me.label7 = New System.Windows.Forms.Label
            Me.barcodeImageLabel = New System.Windows.Forms.Label
            Me.barcodeImageSizeLabel = New System.Windows.Forms.Label
            Me.pixelFormatComboBox = New System.Windows.Forms.ComboBox
            Me.valueFontSizeNumericUpDown = New System.Windows.Forms.NumericUpDown
            Me.valueGapNumericUpDown = New System.Windows.Forms.NumericUpDown
            Me.minWidthNumericUpDown = New System.Windows.Forms.NumericUpDown
            Me.setWidthButton = New System.Windows.Forms.Button
            Me.label10 = New System.Windows.Forms.Label
            Me.label11 = New System.Windows.Forms.Label
            Me.paddingNumericUpDown = New System.Windows.Forms.NumericUpDown
            Me.widthAdjustNumericUpDown = New System.Windows.Forms.NumericUpDown
            Me.aztecErrorCorrectionNumericUpDown = New System.Windows.Forms.NumericUpDown
            Me.label22 = New System.Windows.Forms.Label
            Me.aztecEncodingModeComboBox = New System.Windows.Forms.ComboBox
            Me.aztecLayersCountComboBox = New System.Windows.Forms.ComboBox
            Me.aztecSymbolComboBox = New System.Windows.Forms.ComboBox
            Me.label19 = New System.Windows.Forms.Label
            Me.label20 = New System.Windows.Forms.Label
            Me.label21 = New System.Windows.Forms.Label
            Me.pdf417CompactCheckBox = New System.Windows.Forms.CheckBox
            Me.pdf417RowHeightNumericUpDown = New System.Windows.Forms.NumericUpDown
            Me.label37 = New System.Windows.Forms.Label
            Me.pdf417ColsNumericUpDown = New System.Windows.Forms.NumericUpDown
            Me.label36 = New System.Windows.Forms.Label
            Me.pdf417RowsNumericUpDown = New System.Windows.Forms.NumericUpDown
            Me.label35 = New System.Windows.Forms.Label
            Me.pdf417ErrorCorrectionComboBox = New System.Windows.Forms.ComboBox
            Me.pdf417EncodingModeComboBox = New System.Windows.Forms.ComboBox
            Me.label33 = New System.Windows.Forms.Label
            Me.label34 = New System.Windows.Forms.Label
            Me.label38 = New System.Windows.Forms.Label
            Me.microPDF417SymbolSizeComboBox = New System.Windows.Forms.ComboBox
            Me.label13 = New System.Windows.Forms.Label
            Me.microPED417RowHeightNumericUpDown = New System.Windows.Forms.NumericUpDown
            Me.label5 = New System.Windows.Forms.Label
            Me.microPDF417ColumnsNumericUpDown = New System.Windows.Forms.NumericUpDown
            Me.microPDF417EncodingModeComboBox = New System.Windows.Forms.ComboBox
            Me.label39 = New System.Windows.Forms.Label
            Me.qrECCLevelComboBox = New System.Windows.Forms.ComboBox
            Me.qrSymbolSizeComboBox = New System.Windows.Forms.ComboBox
            Me.qrEncodingModeComboBox = New System.Windows.Forms.ComboBox
            Me.label27 = New System.Windows.Forms.Label
            Me.label28 = New System.Windows.Forms.Label
            Me.label29 = New System.Windows.Forms.Label
            Me.microQrECCLevelComboBox = New System.Windows.Forms.ComboBox
            Me.microQrSymbolSizeComboBox = New System.Windows.Forms.ComboBox
            Me.microQrEncodingModeComboBox = New System.Windows.Forms.ComboBox
            Me.label30 = New System.Windows.Forms.Label
            Me.label31 = New System.Windows.Forms.Label
            Me.label32 = New System.Windows.Forms.Label
            Me.datamatrixSymbolSizeComboBox = New System.Windows.Forms.ComboBox
            Me.datamatrixEncodingModeComboBox = New System.Windows.Forms.ComboBox
            Me.label23 = New System.Windows.Forms.Label
            Me.label24 = New System.Windows.Forms.Label
            Me.maxiCodeResolutonNumericUpDown = New System.Windows.Forms.NumericUpDown
            Me.label26 = New System.Windows.Forms.Label
            Me.maxiCodeEncodingModeComboBox = New System.Windows.Forms.ComboBox
            Me.label25 = New System.Windows.Forms.Label
            Me.msiChecksumPanel = New System.Windows.Forms.Panel
            Me.msiChecksumComboBox = New System.Windows.Forms.ComboBox
            Me.label16 = New System.Windows.Forms.Label
            Me.rssExpandedStackedSegmentPerRowPanel = New System.Windows.Forms.Panel
            Me.barcodeWriterRSSExpandedStackedSegmentPerRowLabel = New System.Windows.Forms.Label
            Me.rssExpandedStackedSegmentPerRow = New System.Windows.Forms.ComboBox
            Me.rss14StackedOmniPanel = New System.Windows.Forms.Panel
            Me.rss14StackedOmni = New System.Windows.Forms.CheckBox
            Me.rssLinkageFlagPanel = New System.Windows.Forms.Panel
            Me.rssLinkageFlag = New System.Windows.Forms.CheckBox
            Me.enableTelepenNumericModePanel = New System.Windows.Forms.Panel
            Me.enableTelepenNumericMode = New System.Windows.Forms.CheckBox
            Me.useOptionalCheckSumPanel = New System.Windows.Forms.Panel
            Me.useOptionalCheckSum = New System.Windows.Forms.CheckBox
            Me.barsRatioPanel = New System.Windows.Forms.Panel
            Me.barsRatioNumericUpDown = New System.Windows.Forms.NumericUpDown
            Me.label14 = New System.Windows.Forms.Label
            Me.code128ModePanel = New System.Windows.Forms.Panel
            Me.code128ModeComboBox = New System.Windows.Forms.ComboBox
            Me.label17 = New System.Windows.Forms.Label
            Me.australianPostCustomInfoPanel = New System.Windows.Forms.Panel
            Me.australianPostCustomInfoComboBox = New System.Windows.Forms.ComboBox
            Me.label15 = New System.Windows.Forms.Label
            Me.postalADMiltiplierPanel = New System.Windows.Forms.Panel
            Me.postalADMiltiplierNumericUpDown = New System.Windows.Forms.NumericUpDown
            Me.label9 = New System.Windows.Forms.Label
            Me.linearBarcodeHeightButton = New System.Windows.Forms.Button
            Me.linearBarcodeTypeComboBox = New System.Windows.Forms.ComboBox
            Me.linearBarcodeHeight = New System.Windows.Forms.NumericUpDown
            Me.linearBarcodeHeightLabel = New System.Windows.Forms.Label
            Me.colorDialog1 = New System.Windows.Forms.ColorDialog
            Me.foregroundColorPanel = New System.Windows.Forms.Panel
            Me.selectForegroundColorLabel = New System.Windows.Forms.Button
            Me.backgroundColorPanel = New System.Windows.Forms.Panel
            Me.selectBackgroundColorButton = New System.Windows.Forms.Button
            Me.barcodeWidthPanel = New System.Windows.Forms.Panel
            Me.subsetBarcodeValueButton = New System.Windows.Forms.Button
            Me.mainPanel = New System.Windows.Forms.Panel
            Me.barcodeGroupsTabControl = New System.Windows.Forms.TabControl
            Me.linearBarcodesTabPage = New System.Windows.Forms.TabPage
            Me.code16KEncodeingModePanel = New System.Windows.Forms.Panel
            Me.label12 = New System.Windows.Forms.Label
            Me.code16KEncodingModeComboBox = New System.Windows.Forms.ComboBox
            Me.code16KRowsPanel = New System.Windows.Forms.Panel
            Me.label8 = New System.Windows.Forms.Label
            Me.code16KRowsComboBox = New System.Windows.Forms.ComboBox
            Me.barcodes2DTabPage = New System.Windows.Forms.TabPage
            Me.twoDimensionalBarcodeComboBox = New System.Windows.Forms.ComboBox
            Me.hanXinCodeSettingsPanel = New System.Windows.Forms.Panel
            Me.hanXinCodeECCLevelComboBox = New System.Windows.Forms.ComboBox
            Me.hanXinCodeEncodingModeComboBox = New System.Windows.Forms.ComboBox
            Me.hanXinCodeSymbolVersionComboBox = New System.Windows.Forms.ComboBox
            Me.label18 = New System.Windows.Forms.Label
            Me.label40 = New System.Windows.Forms.Label
            Me.label41 = New System.Windows.Forms.Label
            Me.microQrSettingsPanel = New System.Windows.Forms.Panel
            Me.qrSettingsPanel = New System.Windows.Forms.Panel
            Me.microPDF417SettingsPanel = New System.Windows.Forms.Panel
            Me.pdf417SettingsPanel = New System.Windows.Forms.Panel
            Me.aztecSettingsPanel = New System.Windows.Forms.Panel
            Me.maxiCodeSettingsPanel = New System.Windows.Forms.Panel
            Me.dataMatrixSettingsPanel = New System.Windows.Forms.Panel
            Me.encodingInfoComboBox = New System.Windows.Forms.ComboBox
            Me.encodingInfoCheckBox = New System.Windows.Forms.CheckBox
            Me.Button1 = New System.Windows.Forms.Button
            CType(Me.valueFontSizeNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.valueGapNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.minWidthNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.paddingNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.widthAdjustNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.aztecErrorCorrectionNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pdf417RowHeightNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pdf417ColsNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pdf417RowsNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.microPED417RowHeightNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.microPDF417ColumnsNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.maxiCodeResolutonNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.msiChecksumPanel.SuspendLayout()
            Me.rssExpandedStackedSegmentPerRowPanel.SuspendLayout()
            Me.rss14StackedOmniPanel.SuspendLayout()
            Me.rssLinkageFlagPanel.SuspendLayout()
            Me.enableTelepenNumericModePanel.SuspendLayout()
            Me.useOptionalCheckSumPanel.SuspendLayout()
            Me.barsRatioPanel.SuspendLayout()
            CType(Me.barsRatioNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.code128ModePanel.SuspendLayout()
            Me.australianPostCustomInfoPanel.SuspendLayout()
            Me.postalADMiltiplierPanel.SuspendLayout()
            CType(Me.postalADMiltiplierNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.linearBarcodeHeight, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.barcodeWidthPanel.SuspendLayout()
            Me.mainPanel.SuspendLayout()
            Me.barcodeGroupsTabControl.SuspendLayout()
            Me.linearBarcodesTabPage.SuspendLayout()
            Me.code16KEncodeingModePanel.SuspendLayout()
            Me.code16KRowsPanel.SuspendLayout()
            Me.barcodes2DTabPage.SuspendLayout()
            Me.hanXinCodeSettingsPanel.SuspendLayout()
            Me.microQrSettingsPanel.SuspendLayout()
            Me.qrSettingsPanel.SuspendLayout()
            Me.microPDF417SettingsPanel.SuspendLayout()
            Me.pdf417SettingsPanel.SuspendLayout()
            Me.aztecSettingsPanel.SuspendLayout()
            Me.maxiCodeSettingsPanel.SuspendLayout()
            Me.dataMatrixSettingsPanel.SuspendLayout()
            Me.SuspendLayout()
            '
            'label1
            '
            Me.label1.AutoSize = True
            Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
            Me.label1.Location = New System.Drawing.Point(7, 7)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(39, 13)
            Me.label1.TabIndex = 0
            Me.label1.Text = "Value"
            '
            'barcodeValueTextBox
            '
            Me.barcodeValueTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.barcodeValueTextBox.Location = New System.Drawing.Point(52, 3)
            Me.barcodeValueTextBox.Name = "barcodeValueTextBox"
            Me.barcodeValueTextBox.Size = New System.Drawing.Size(211, 20)
            Me.barcodeValueTextBox.TabIndex = 1
            '
            'valueVisibleCheckBox
            '
            Me.valueVisibleCheckBox.AutoSize = True
            Me.valueVisibleCheckBox.Checked = True
            Me.valueVisibleCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
            Me.valueVisibleCheckBox.Location = New System.Drawing.Point(7, 52)
            Me.valueVisibleCheckBox.Name = "valueVisibleCheckBox"
            Me.valueVisibleCheckBox.Size = New System.Drawing.Size(80, 17)
            Me.valueVisibleCheckBox.TabIndex = 2
            Me.valueVisibleCheckBox.Text = "Draw value"
            Me.valueVisibleCheckBox.UseVisualStyleBackColor = True
            '
            'fontSelector
            '
            Me.fontSelector.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.fontSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.fontSelector.FormattingEnabled = True
            Me.fontSelector.Location = New System.Drawing.Point(111, 49)
            Me.fontSelector.Name = "fontSelector"
            Me.fontSelector.Size = New System.Drawing.Size(152, 21)
            Me.fontSelector.TabIndex = 3
            '
            'label2
            '
            Me.label2.AutoSize = True
            Me.label2.Location = New System.Drawing.Point(7, 74)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(76, 13)
            Me.label2.TabIndex = 4
            Me.label2.Text = "Value font size"
            '
            'label3
            '
            Me.label3.AutoSize = True
            Me.label3.Location = New System.Drawing.Point(7, 96)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(55, 13)
            Me.label3.TabIndex = 5
            Me.label3.Text = "Value gap"
            '
            'label4
            '
            Me.label4.AutoSize = True
            Me.label4.Location = New System.Drawing.Point(7, 144)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(84, 13)
            Me.label4.TabIndex = 6
            Me.label4.Text = "Fore/Back color"
            '
            'valueAutoLetterSpacingCheckBox
            '
            Me.valueAutoLetterSpacingCheckBox.AutoSize = True
            Me.valueAutoLetterSpacingCheckBox.Checked = True
            Me.valueAutoLetterSpacingCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
            Me.valueAutoLetterSpacingCheckBox.Location = New System.Drawing.Point(7, 120)
            Me.valueAutoLetterSpacingCheckBox.Name = "valueAutoLetterSpacingCheckBox"
            Me.valueAutoLetterSpacingCheckBox.Size = New System.Drawing.Size(143, 17)
            Me.valueAutoLetterSpacingCheckBox.TabIndex = 9
            Me.valueAutoLetterSpacingCheckBox.Text = "Value auto letter spacing"
            Me.valueAutoLetterSpacingCheckBox.UseVisualStyleBackColor = True
            '
            'label6
            '
            Me.label6.AutoSize = True
            Me.label6.Location = New System.Drawing.Point(7, 171)
            Me.label6.Name = "label6"
            Me.label6.Size = New System.Drawing.Size(61, 13)
            Me.label6.TabIndex = 11
            Me.label6.Text = "Pixel format"
            '
            'label7
            '
            Me.label7.AutoSize = True
            Me.label7.Location = New System.Drawing.Point(0, 5)
            Me.label7.Name = "label7"
            Me.label7.Size = New System.Drawing.Size(91, 13)
            Me.label7.TabIndex = 12
            Me.label7.Text = "Min bar/cell width"
            '
            'barcodeImageLabel
            '
            Me.barcodeImageLabel.AutoSize = True
            Me.barcodeImageLabel.Location = New System.Drawing.Point(7, 217)
            Me.barcodeImageLabel.Name = "barcodeImageLabel"
            Me.barcodeImageLabel.Size = New System.Drawing.Size(81, 13)
            Me.barcodeImageLabel.TabIndex = 13
            Me.barcodeImageLabel.Text = "Barcode image:"
            Me.barcodeImageLabel.Visible = False
            '
            'barcodeImageSizeLabel
            '
            Me.barcodeImageSizeLabel.AutoSize = True
            Me.barcodeImageSizeLabel.Location = New System.Drawing.Point(108, 217)
            Me.barcodeImageSizeLabel.Name = "barcodeImageSizeLabel"
            Me.barcodeImageSizeLabel.Size = New System.Drawing.Size(53, 13)
            Me.barcodeImageSizeLabel.TabIndex = 14
            Me.barcodeImageSizeLabel.Text = "0x0 pixels"
            Me.barcodeImageSizeLabel.Visible = False
            '
            'pixelFormatComboBox
            '
            Me.pixelFormatComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.pixelFormatComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.pixelFormatComboBox.FormattingEnabled = True
            Me.pixelFormatComboBox.Location = New System.Drawing.Point(111, 167)
            Me.pixelFormatComboBox.Name = "pixelFormatComboBox"
            Me.pixelFormatComboBox.Size = New System.Drawing.Size(152, 21)
            Me.pixelFormatComboBox.TabIndex = 17
            '
            'valueFontSizeNumericUpDown
            '
            Me.valueFontSizeNumericUpDown.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.valueFontSizeNumericUpDown.Location = New System.Drawing.Point(111, 72)
            Me.valueFontSizeNumericUpDown.Maximum = New Decimal(New Integer() {512, 0, 0, 0})
            Me.valueFontSizeNumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
            Me.valueFontSizeNumericUpDown.Name = "valueFontSizeNumericUpDown"
            Me.valueFontSizeNumericUpDown.Size = New System.Drawing.Size(152, 20)
            Me.valueFontSizeNumericUpDown.TabIndex = 19
            Me.valueFontSizeNumericUpDown.Value = New Decimal(New Integer() {12, 0, 0, 0})
            '
            'valueGapNumericUpDown
            '
            Me.valueGapNumericUpDown.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.valueGapNumericUpDown.Location = New System.Drawing.Point(111, 96)
            Me.valueGapNumericUpDown.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
            Me.valueGapNumericUpDown.Name = "valueGapNumericUpDown"
            Me.valueGapNumericUpDown.Size = New System.Drawing.Size(152, 20)
            Me.valueGapNumericUpDown.TabIndex = 20
            '
            'minWidthNumericUpDown
            '
            Me.minWidthNumericUpDown.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.minWidthNumericUpDown.Location = New System.Drawing.Point(104, 0)
            Me.minWidthNumericUpDown.Maximum = New Decimal(New Integer() {1024, 0, 0, 0})
            Me.minWidthNumericUpDown.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
            Me.minWidthNumericUpDown.Name = "minWidthNumericUpDown"
            Me.minWidthNumericUpDown.Size = New System.Drawing.Size(73, 20)
            Me.minWidthNumericUpDown.TabIndex = 21
            Me.minWidthNumericUpDown.Value = New Decimal(New Integer() {3, 0, 0, 0})
            '
            'setWidthButton
            '
            Me.setWidthButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.setWidthButton.Location = New System.Drawing.Point(183, 0)
            Me.setWidthButton.Name = "setWidthButton"
            Me.setWidthButton.Size = New System.Drawing.Size(70, 22)
            Me.setWidthButton.TabIndex = 22
            Me.setWidthButton.Text = "Width..."
            Me.setWidthButton.UseVisualStyleBackColor = True
            '
            'label10
            '
            Me.label10.AutoSize = True
            Me.label10.Location = New System.Drawing.Point(7, 241)
            Me.label10.Name = "label10"
            Me.label10.Size = New System.Drawing.Size(49, 13)
            Me.label10.TabIndex = 23
            Me.label10.Text = "Padding:"
            '
            'label11
            '
            Me.label11.AutoSize = True
            Me.label11.Location = New System.Drawing.Point(7, 265)
            Me.label11.Name = "label11"
            Me.label11.Size = New System.Drawing.Size(98, 13)
            Me.label11.TabIndex = 24
            Me.label11.Text = "Width adjust (x0.1):"
            '
            'paddingNumericUpDown
            '
            Me.paddingNumericUpDown.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.paddingNumericUpDown.Location = New System.Drawing.Point(111, 237)
            Me.paddingNumericUpDown.Maximum = New Decimal(New Integer() {128, 0, 0, 0})
            Me.paddingNumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
            Me.paddingNumericUpDown.Name = "paddingNumericUpDown"
            Me.paddingNumericUpDown.Size = New System.Drawing.Size(152, 20)
            Me.paddingNumericUpDown.TabIndex = 25
            Me.paddingNumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
            '
            'widthAdjustNumericUpDown
            '
            Me.widthAdjustNumericUpDown.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.widthAdjustNumericUpDown.Location = New System.Drawing.Point(111, 261)
            Me.widthAdjustNumericUpDown.Maximum = New Decimal(New Integer() {3, 0, 0, 0})
            Me.widthAdjustNumericUpDown.Minimum = New Decimal(New Integer() {3, 0, 0, -2147483648})
            Me.widthAdjustNumericUpDown.Name = "widthAdjustNumericUpDown"
            Me.widthAdjustNumericUpDown.Size = New System.Drawing.Size(152, 20)
            Me.widthAdjustNumericUpDown.TabIndex = 26
            '
            'aztecErrorCorrectionNumericUpDown
            '
            Me.aztecErrorCorrectionNumericUpDown.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.aztecErrorCorrectionNumericUpDown.Location = New System.Drawing.Point(127, 87)
            Me.aztecErrorCorrectionNumericUpDown.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
            Me.aztecErrorCorrectionNumericUpDown.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
            Me.aztecErrorCorrectionNumericUpDown.Name = "aztecErrorCorrectionNumericUpDown"
            Me.aztecErrorCorrectionNumericUpDown.Size = New System.Drawing.Size(114, 20)
            Me.aztecErrorCorrectionNumericUpDown.TabIndex = 25
            Me.aztecErrorCorrectionNumericUpDown.Value = New Decimal(New Integer() {25, 0, 0, 0})
            '
            'label22
            '
            Me.label22.AutoSize = True
            Me.label22.Location = New System.Drawing.Point(3, 88)
            Me.label22.Name = "label22"
            Me.label22.Size = New System.Drawing.Size(96, 13)
            Me.label22.TabIndex = 24
            Me.label22.Text = "Error correction (%)"
            '
            'aztecEncodingModeComboBox
            '
            Me.aztecEncodingModeComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.aztecEncodingModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.aztecEncodingModeComboBox.FormattingEnabled = True
            Me.aztecEncodingModeComboBox.Location = New System.Drawing.Point(127, 60)
            Me.aztecEncodingModeComboBox.Name = "aztecEncodingModeComboBox"
            Me.aztecEncodingModeComboBox.Size = New System.Drawing.Size(114, 21)
            Me.aztecEncodingModeComboBox.TabIndex = 23
            '
            'aztecLayersCountComboBox
            '
            Me.aztecLayersCountComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.aztecLayersCountComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.aztecLayersCountComboBox.FormattingEnabled = True
            Me.aztecLayersCountComboBox.Location = New System.Drawing.Point(127, 33)
            Me.aztecLayersCountComboBox.Name = "aztecLayersCountComboBox"
            Me.aztecLayersCountComboBox.Size = New System.Drawing.Size(114, 21)
            Me.aztecLayersCountComboBox.TabIndex = 22
            '
            'aztecSymbolComboBox
            '
            Me.aztecSymbolComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.aztecSymbolComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.aztecSymbolComboBox.FormattingEnabled = True
            Me.aztecSymbolComboBox.Location = New System.Drawing.Point(127, 6)
            Me.aztecSymbolComboBox.Name = "aztecSymbolComboBox"
            Me.aztecSymbolComboBox.Size = New System.Drawing.Size(114, 21)
            Me.aztecSymbolComboBox.TabIndex = 21
            '
            'label19
            '
            Me.label19.AutoSize = True
            Me.label19.Location = New System.Drawing.Point(3, 61)
            Me.label19.Name = "label19"
            Me.label19.Size = New System.Drawing.Size(81, 13)
            Me.label19.TabIndex = 20
            Me.label19.Text = "Encoding mode"
            '
            'label20
            '
            Me.label20.AutoSize = True
            Me.label20.Location = New System.Drawing.Point(3, 34)
            Me.label20.Name = "label20"
            Me.label20.Size = New System.Drawing.Size(68, 13)
            Me.label20.TabIndex = 19
            Me.label20.Text = "Layers count"
            '
            'label21
            '
            Me.label21.AutoSize = True
            Me.label21.Location = New System.Drawing.Point(3, 9)
            Me.label21.Name = "label21"
            Me.label21.Size = New System.Drawing.Size(41, 13)
            Me.label21.TabIndex = 18
            Me.label21.Text = "Symbol"
            '
            'pdf417CompactCheckBox
            '
            Me.pdf417CompactCheckBox.AutoSize = True
            Me.pdf417CompactCheckBox.Location = New System.Drawing.Point(126, 138)
            Me.pdf417CompactCheckBox.Name = "pdf417CompactCheckBox"
            Me.pdf417CompactCheckBox.Size = New System.Drawing.Size(110, 17)
            Me.pdf417CompactCheckBox.TabIndex = 28
            Me.pdf417CompactCheckBox.Text = "PDF417 Compact"
            Me.pdf417CompactCheckBox.UseVisualStyleBackColor = True
            '
            'pdf417RowHeightNumericUpDown
            '
            Me.pdf417RowHeightNumericUpDown.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.pdf417RowHeightNumericUpDown.Location = New System.Drawing.Point(127, 112)
            Me.pdf417RowHeightNumericUpDown.Maximum = New Decimal(New Integer() {64, 0, 0, 0})
            Me.pdf417RowHeightNumericUpDown.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
            Me.pdf417RowHeightNumericUpDown.Name = "pdf417RowHeightNumericUpDown"
            Me.pdf417RowHeightNumericUpDown.Size = New System.Drawing.Size(114, 20)
            Me.pdf417RowHeightNumericUpDown.TabIndex = 27
            Me.pdf417RowHeightNumericUpDown.Value = New Decimal(New Integer() {4, 0, 0, 0})
            '
            'label37
            '
            Me.label37.AutoSize = True
            Me.label37.Location = New System.Drawing.Point(2, 116)
            Me.label37.Name = "label37"
            Me.label37.Size = New System.Drawing.Size(61, 13)
            Me.label37.TabIndex = 26
            Me.label37.Text = "Row height"
            '
            'pdf417ColsNumericUpDown
            '
            Me.pdf417ColsNumericUpDown.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.pdf417ColsNumericUpDown.Location = New System.Drawing.Point(127, 86)
            Me.pdf417ColsNumericUpDown.Maximum = New Decimal(New Integer() {30, 0, 0, 0})
            Me.pdf417ColsNumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
            Me.pdf417ColsNumericUpDown.Name = "pdf417ColsNumericUpDown"
            Me.pdf417ColsNumericUpDown.Size = New System.Drawing.Size(114, 20)
            Me.pdf417ColsNumericUpDown.TabIndex = 25
            Me.pdf417ColsNumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, -2147483648})
            '
            'label36
            '
            Me.label36.AutoSize = True
            Me.label36.Location = New System.Drawing.Point(3, 88)
            Me.label36.Name = "label36"
            Me.label36.Size = New System.Drawing.Size(27, 13)
            Me.label36.TabIndex = 24
            Me.label36.Text = "Cols"
            '
            'pdf417RowsNumericUpDown
            '
            Me.pdf417RowsNumericUpDown.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.pdf417RowsNumericUpDown.Location = New System.Drawing.Point(127, 60)
            Me.pdf417RowsNumericUpDown.Maximum = New Decimal(New Integer() {90, 0, 0, 0})
            Me.pdf417RowsNumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
            Me.pdf417RowsNumericUpDown.Name = "pdf417RowsNumericUpDown"
            Me.pdf417RowsNumericUpDown.Size = New System.Drawing.Size(114, 20)
            Me.pdf417RowsNumericUpDown.TabIndex = 23
            Me.pdf417RowsNumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, -2147483648})
            '
            'label35
            '
            Me.label35.AutoSize = True
            Me.label35.Location = New System.Drawing.Point(2, 64)
            Me.label35.Name = "label35"
            Me.label35.Size = New System.Drawing.Size(34, 13)
            Me.label35.TabIndex = 22
            Me.label35.Text = "Rows"
            '
            'pdf417ErrorCorrectionComboBox
            '
            Me.pdf417ErrorCorrectionComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.pdf417ErrorCorrectionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.pdf417ErrorCorrectionComboBox.FormattingEnabled = True
            Me.pdf417ErrorCorrectionComboBox.Location = New System.Drawing.Point(127, 33)
            Me.pdf417ErrorCorrectionComboBox.Name = "pdf417ErrorCorrectionComboBox"
            Me.pdf417ErrorCorrectionComboBox.Size = New System.Drawing.Size(114, 21)
            Me.pdf417ErrorCorrectionComboBox.TabIndex = 20
            '
            'pdf417EncodingModeComboBox
            '
            Me.pdf417EncodingModeComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.pdf417EncodingModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.pdf417EncodingModeComboBox.FormattingEnabled = True
            Me.pdf417EncodingModeComboBox.Location = New System.Drawing.Point(127, 6)
            Me.pdf417EncodingModeComboBox.Name = "pdf417EncodingModeComboBox"
            Me.pdf417EncodingModeComboBox.Size = New System.Drawing.Size(114, 21)
            Me.pdf417EncodingModeComboBox.TabIndex = 19
            '
            'label33
            '
            Me.label33.AutoSize = True
            Me.label33.Location = New System.Drawing.Point(2, 37)
            Me.label33.Name = "label33"
            Me.label33.Size = New System.Drawing.Size(79, 13)
            Me.label33.TabIndex = 18
            Me.label33.Text = "Error correction"
            '
            'label34
            '
            Me.label34.AutoSize = True
            Me.label34.Location = New System.Drawing.Point(2, 9)
            Me.label34.Name = "label34"
            Me.label34.Size = New System.Drawing.Size(81, 13)
            Me.label34.TabIndex = 17
            Me.label34.Text = "Encoding mode"
            '
            'label38
            '
            Me.label38.AutoSize = True
            Me.label38.Location = New System.Drawing.Point(2, 63)
            Me.label38.Name = "label38"
            Me.label38.Size = New System.Drawing.Size(47, 13)
            Me.label38.TabIndex = 40
            Me.label38.Text = "Columns"
            '
            'microPDF417SymbolSizeComboBox
            '
            Me.microPDF417SymbolSizeComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.microPDF417SymbolSizeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.microPDF417SymbolSizeComboBox.FormattingEnabled = True
            Me.microPDF417SymbolSizeComboBox.Location = New System.Drawing.Point(127, 33)
            Me.microPDF417SymbolSizeComboBox.Name = "microPDF417SymbolSizeComboBox"
            Me.microPDF417SymbolSizeComboBox.Size = New System.Drawing.Size(114, 21)
            Me.microPDF417SymbolSizeComboBox.TabIndex = 39
            '
            'label13
            '
            Me.label13.AutoSize = True
            Me.label13.Location = New System.Drawing.Point(2, 36)
            Me.label13.Name = "label13"
            Me.label13.Size = New System.Drawing.Size(62, 13)
            Me.label13.TabIndex = 38
            Me.label13.Text = "Symbol size"
            '
            'microPED417RowHeightNumericUpDown
            '
            Me.microPED417RowHeightNumericUpDown.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.microPED417RowHeightNumericUpDown.Location = New System.Drawing.Point(127, 87)
            Me.microPED417RowHeightNumericUpDown.Maximum = New Decimal(New Integer() {64, 0, 0, 0})
            Me.microPED417RowHeightNumericUpDown.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
            Me.microPED417RowHeightNumericUpDown.Name = "microPED417RowHeightNumericUpDown"
            Me.microPED417RowHeightNumericUpDown.Size = New System.Drawing.Size(114, 20)
            Me.microPED417RowHeightNumericUpDown.TabIndex = 37
            Me.microPED417RowHeightNumericUpDown.Value = New Decimal(New Integer() {2, 0, 0, 0})
            '
            'label5
            '
            Me.label5.AutoSize = True
            Me.label5.Location = New System.Drawing.Point(2, 91)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(61, 13)
            Me.label5.TabIndex = 36
            Me.label5.Text = "Row height"
            '
            'microPDF417ColumnsNumericUpDown
            '
            Me.microPDF417ColumnsNumericUpDown.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.microPDF417ColumnsNumericUpDown.Location = New System.Drawing.Point(127, 61)
            Me.microPDF417ColumnsNumericUpDown.Maximum = New Decimal(New Integer() {4, 0, 0, 0})
            Me.microPDF417ColumnsNumericUpDown.Name = "microPDF417ColumnsNumericUpDown"
            Me.microPDF417ColumnsNumericUpDown.Size = New System.Drawing.Size(114, 20)
            Me.microPDF417ColumnsNumericUpDown.TabIndex = 35
            '
            'microPDF417EncodingModeComboBox
            '
            Me.microPDF417EncodingModeComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.microPDF417EncodingModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.microPDF417EncodingModeComboBox.FormattingEnabled = True
            Me.microPDF417EncodingModeComboBox.Location = New System.Drawing.Point(127, 6)
            Me.microPDF417EncodingModeComboBox.Name = "microPDF417EncodingModeComboBox"
            Me.microPDF417EncodingModeComboBox.Size = New System.Drawing.Size(114, 21)
            Me.microPDF417EncodingModeComboBox.TabIndex = 30
            '
            'label39
            '
            Me.label39.AutoSize = True
            Me.label39.Location = New System.Drawing.Point(2, 9)
            Me.label39.Name = "label39"
            Me.label39.Size = New System.Drawing.Size(81, 13)
            Me.label39.TabIndex = 28
            Me.label39.Text = "Encoding mode"
            '
            'qrECCLevelComboBox
            '
            Me.qrECCLevelComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.qrECCLevelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.qrECCLevelComboBox.FormattingEnabled = True
            Me.qrECCLevelComboBox.Location = New System.Drawing.Point(127, 60)
            Me.qrECCLevelComboBox.Name = "qrECCLevelComboBox"
            Me.qrECCLevelComboBox.Size = New System.Drawing.Size(114, 21)
            Me.qrECCLevelComboBox.TabIndex = 35
            '
            'qrSymbolSizeComboBox
            '
            Me.qrSymbolSizeComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.qrSymbolSizeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.qrSymbolSizeComboBox.FormattingEnabled = True
            Me.qrSymbolSizeComboBox.Location = New System.Drawing.Point(127, 33)
            Me.qrSymbolSizeComboBox.Name = "qrSymbolSizeComboBox"
            Me.qrSymbolSizeComboBox.Size = New System.Drawing.Size(114, 21)
            Me.qrSymbolSizeComboBox.TabIndex = 34
            '
            'qrEncodingModeComboBox
            '
            Me.qrEncodingModeComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.qrEncodingModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.qrEncodingModeComboBox.FormattingEnabled = True
            Me.qrEncodingModeComboBox.Location = New System.Drawing.Point(127, 6)
            Me.qrEncodingModeComboBox.Name = "qrEncodingModeComboBox"
            Me.qrEncodingModeComboBox.Size = New System.Drawing.Size(114, 21)
            Me.qrEncodingModeComboBox.TabIndex = 33
            '
            'label27
            '
            Me.label27.AutoSize = True
            Me.label27.Location = New System.Drawing.Point(2, 64)
            Me.label27.Name = "label27"
            Me.label27.Size = New System.Drawing.Size(104, 13)
            Me.label27.TabIndex = 32
            Me.label27.Text = "Error correction level"
            '
            'label28
            '
            Me.label28.AutoSize = True
            Me.label28.Location = New System.Drawing.Point(2, 37)
            Me.label28.Name = "label28"
            Me.label28.Size = New System.Drawing.Size(62, 13)
            Me.label28.TabIndex = 31
            Me.label28.Text = "Symbol size"
            '
            'label29
            '
            Me.label29.AutoSize = True
            Me.label29.Location = New System.Drawing.Point(2, 9)
            Me.label29.Name = "label29"
            Me.label29.Size = New System.Drawing.Size(81, 13)
            Me.label29.TabIndex = 30
            Me.label29.Text = "Encoding mode"
            '
            'microQrECCLevelComboBox
            '
            Me.microQrECCLevelComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.microQrECCLevelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.microQrECCLevelComboBox.FormattingEnabled = True
            Me.microQrECCLevelComboBox.Location = New System.Drawing.Point(128, 60)
            Me.microQrECCLevelComboBox.Name = "microQrECCLevelComboBox"
            Me.microQrECCLevelComboBox.Size = New System.Drawing.Size(114, 21)
            Me.microQrECCLevelComboBox.TabIndex = 23
            '
            'microQrSymbolSizeComboBox
            '
            Me.microQrSymbolSizeComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.microQrSymbolSizeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.microQrSymbolSizeComboBox.FormattingEnabled = True
            Me.microQrSymbolSizeComboBox.Location = New System.Drawing.Point(128, 33)
            Me.microQrSymbolSizeComboBox.Name = "microQrSymbolSizeComboBox"
            Me.microQrSymbolSizeComboBox.Size = New System.Drawing.Size(114, 21)
            Me.microQrSymbolSizeComboBox.TabIndex = 22
            '
            'microQrEncodingModeComboBox
            '
            Me.microQrEncodingModeComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.microQrEncodingModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.microQrEncodingModeComboBox.FormattingEnabled = True
            Me.microQrEncodingModeComboBox.Location = New System.Drawing.Point(128, 6)
            Me.microQrEncodingModeComboBox.Name = "microQrEncodingModeComboBox"
            Me.microQrEncodingModeComboBox.Size = New System.Drawing.Size(114, 21)
            Me.microQrEncodingModeComboBox.TabIndex = 21
            '
            'label30
            '
            Me.label30.AutoSize = True
            Me.label30.Location = New System.Drawing.Point(3, 64)
            Me.label30.Name = "label30"
            Me.label30.Size = New System.Drawing.Size(104, 13)
            Me.label30.TabIndex = 20
            Me.label30.Text = "Error correction level"
            '
            'label31
            '
            Me.label31.AutoSize = True
            Me.label31.Location = New System.Drawing.Point(3, 37)
            Me.label31.Name = "label31"
            Me.label31.Size = New System.Drawing.Size(62, 13)
            Me.label31.TabIndex = 19
            Me.label31.Text = "Symbol size"
            '
            'label32
            '
            Me.label32.AutoSize = True
            Me.label32.Location = New System.Drawing.Point(3, 9)
            Me.label32.Name = "label32"
            Me.label32.Size = New System.Drawing.Size(81, 13)
            Me.label32.TabIndex = 18
            Me.label32.Text = "Encoding mode"
            '
            'datamatrixSymbolSizeComboBox
            '
            Me.datamatrixSymbolSizeComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.datamatrixSymbolSizeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.datamatrixSymbolSizeComboBox.FormattingEnabled = True
            Me.datamatrixSymbolSizeComboBox.Location = New System.Drawing.Point(128, 33)
            Me.datamatrixSymbolSizeComboBox.Name = "datamatrixSymbolSizeComboBox"
            Me.datamatrixSymbolSizeComboBox.Size = New System.Drawing.Size(114, 21)
            Me.datamatrixSymbolSizeComboBox.TabIndex = 21
            '
            'datamatrixEncodingModeComboBox
            '
            Me.datamatrixEncodingModeComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.datamatrixEncodingModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.datamatrixEncodingModeComboBox.FormattingEnabled = True
            Me.datamatrixEncodingModeComboBox.Location = New System.Drawing.Point(128, 6)
            Me.datamatrixEncodingModeComboBox.Name = "datamatrixEncodingModeComboBox"
            Me.datamatrixEncodingModeComboBox.Size = New System.Drawing.Size(114, 21)
            Me.datamatrixEncodingModeComboBox.TabIndex = 20
            '
            'label23
            '
            Me.label23.AutoSize = True
            Me.label23.Location = New System.Drawing.Point(3, 37)
            Me.label23.Name = "label23"
            Me.label23.Size = New System.Drawing.Size(62, 13)
            Me.label23.TabIndex = 19
            Me.label23.Text = "Symbol size"
            '
            'label24
            '
            Me.label24.AutoSize = True
            Me.label24.Location = New System.Drawing.Point(3, 9)
            Me.label24.Name = "label24"
            Me.label24.Size = New System.Drawing.Size(81, 13)
            Me.label24.TabIndex = 17
            Me.label24.Text = "Encoding mode"
            '
            'maxiCodeResolutonNumericUpDown
            '
            Me.maxiCodeResolutonNumericUpDown.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.maxiCodeResolutonNumericUpDown.Increment = New Decimal(New Integer() {50, 0, 0, 0})
            Me.maxiCodeResolutonNumericUpDown.Location = New System.Drawing.Point(128, 7)
            Me.maxiCodeResolutonNumericUpDown.Maximum = New Decimal(New Integer() {2400, 0, 0, 0})
            Me.maxiCodeResolutonNumericUpDown.Minimum = New Decimal(New Integer() {200, 0, 0, 0})
            Me.maxiCodeResolutonNumericUpDown.Name = "maxiCodeResolutonNumericUpDown"
            Me.maxiCodeResolutonNumericUpDown.Size = New System.Drawing.Size(114, 20)
            Me.maxiCodeResolutonNumericUpDown.TabIndex = 23
            Me.maxiCodeResolutonNumericUpDown.Value = New Decimal(New Integer() {300, 0, 0, 0})
            '
            'label26
            '
            Me.label26.AutoSize = True
            Me.label26.Location = New System.Drawing.Point(3, 9)
            Me.label26.Name = "label26"
            Me.label26.Size = New System.Drawing.Size(57, 13)
            Me.label26.TabIndex = 22
            Me.label26.Text = "Resolution"
            '
            'maxiCodeEncodingModeComboBox
            '
            Me.maxiCodeEncodingModeComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.maxiCodeEncodingModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.maxiCodeEncodingModeComboBox.FormattingEnabled = True
            Me.maxiCodeEncodingModeComboBox.Location = New System.Drawing.Point(128, 33)
            Me.maxiCodeEncodingModeComboBox.Name = "maxiCodeEncodingModeComboBox"
            Me.maxiCodeEncodingModeComboBox.Size = New System.Drawing.Size(114, 21)
            Me.maxiCodeEncodingModeComboBox.TabIndex = 18
            '
            'label25
            '
            Me.label25.AutoSize = True
            Me.label25.Location = New System.Drawing.Point(3, 36)
            Me.label25.Name = "label25"
            Me.label25.Size = New System.Drawing.Size(70, 13)
            Me.label25.TabIndex = 17
            Me.label25.Text = "Symbol mode"
            '
            'msiChecksumPanel
            '
            Me.msiChecksumPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.msiChecksumPanel.Controls.Add(Me.msiChecksumComboBox)
            Me.msiChecksumPanel.Controls.Add(Me.label16)
            Me.msiChecksumPanel.Location = New System.Drawing.Point(0, 107)
            Me.msiChecksumPanel.Name = "msiChecksumPanel"
            Me.msiChecksumPanel.Size = New System.Drawing.Size(246, 27)
            Me.msiChecksumPanel.TabIndex = 38
            Me.msiChecksumPanel.Visible = False
            '
            'msiChecksumComboBox
            '
            Me.msiChecksumComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.msiChecksumComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.msiChecksumComboBox.FormattingEnabled = True
            Me.msiChecksumComboBox.Location = New System.Drawing.Point(115, 3)
            Me.msiChecksumComboBox.Name = "msiChecksumComboBox"
            Me.msiChecksumComboBox.Size = New System.Drawing.Size(125, 21)
            Me.msiChecksumComboBox.TabIndex = 34
            '
            'label16
            '
            Me.label16.AutoSize = True
            Me.label16.Location = New System.Drawing.Point(3, 7)
            Me.label16.Name = "label16"
            Me.label16.Size = New System.Drawing.Size(57, 13)
            Me.label16.TabIndex = 33
            Me.label16.Text = "Checksum"
            '
            'rssExpandedStackedSegmentPerRowPanel
            '
            Me.rssExpandedStackedSegmentPerRowPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.rssExpandedStackedSegmentPerRowPanel.Controls.Add(Me.barcodeWriterRSSExpandedStackedSegmentPerRowLabel)
            Me.rssExpandedStackedSegmentPerRowPanel.Controls.Add(Me.rssExpandedStackedSegmentPerRow)
            Me.rssExpandedStackedSegmentPerRowPanel.Location = New System.Drawing.Point(0, 108)
            Me.rssExpandedStackedSegmentPerRowPanel.Name = "rssExpandedStackedSegmentPerRowPanel"
            Me.rssExpandedStackedSegmentPerRowPanel.Size = New System.Drawing.Size(246, 27)
            Me.rssExpandedStackedSegmentPerRowPanel.TabIndex = 45
            Me.rssExpandedStackedSegmentPerRowPanel.Visible = False
            '
            'barcodeWriterRSSExpandedStackedSegmentPerRowLabel
            '
            Me.barcodeWriterRSSExpandedStackedSegmentPerRowLabel.Location = New System.Drawing.Point(3, 8)
            Me.barcodeWriterRSSExpandedStackedSegmentPerRowLabel.Name = "barcodeWriterRSSExpandedStackedSegmentPerRowLabel"
            Me.barcodeWriterRSSExpandedStackedSegmentPerRowLabel.Size = New System.Drawing.Size(105, 13)
            Me.barcodeWriterRSSExpandedStackedSegmentPerRowLabel.TabIndex = 45
            Me.barcodeWriterRSSExpandedStackedSegmentPerRowLabel.Text = "Segments per row"
            '
            'rssExpandedStackedSegmentPerRow
            '
            Me.rssExpandedStackedSegmentPerRow.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.rssExpandedStackedSegmentPerRow.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.rssExpandedStackedSegmentPerRow.FormattingEnabled = True
            Me.rssExpandedStackedSegmentPerRow.Location = New System.Drawing.Point(114, 3)
            Me.rssExpandedStackedSegmentPerRow.Name = "rssExpandedStackedSegmentPerRow"
            Me.rssExpandedStackedSegmentPerRow.Size = New System.Drawing.Size(125, 21)
            Me.rssExpandedStackedSegmentPerRow.TabIndex = 46
            '
            'rss14StackedOmniPanel
            '
            Me.rss14StackedOmniPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.rss14StackedOmniPanel.Controls.Add(Me.rss14StackedOmni)
            Me.rss14StackedOmniPanel.Location = New System.Drawing.Point(0, 107)
            Me.rss14StackedOmniPanel.Name = "rss14StackedOmniPanel"
            Me.rss14StackedOmniPanel.Size = New System.Drawing.Size(246, 27)
            Me.rss14StackedOmniPanel.TabIndex = 44
            Me.rss14StackedOmniPanel.Visible = False
            '
            'rss14StackedOmni
            '
            Me.rss14StackedOmni.Location = New System.Drawing.Point(3, 5)
            Me.rss14StackedOmni.Name = "rss14StackedOmni"
            Me.rss14StackedOmni.Size = New System.Drawing.Size(170, 17)
            Me.rss14StackedOmni.TabIndex = 44
            Me.rss14StackedOmni.Text = "Omnidirectional"
            Me.rss14StackedOmni.UseVisualStyleBackColor = True
            '
            'rssLinkageFlagPanel
            '
            Me.rssLinkageFlagPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.rssLinkageFlagPanel.Controls.Add(Me.rssLinkageFlag)
            Me.rssLinkageFlagPanel.Location = New System.Drawing.Point(0, 79)
            Me.rssLinkageFlagPanel.Name = "rssLinkageFlagPanel"
            Me.rssLinkageFlagPanel.Size = New System.Drawing.Size(246, 27)
            Me.rssLinkageFlagPanel.TabIndex = 43
            Me.rssLinkageFlagPanel.Visible = False
            '
            'rssLinkageFlag
            '
            Me.rssLinkageFlag.Location = New System.Drawing.Point(3, 6)
            Me.rssLinkageFlag.Name = "rssLinkageFlag"
            Me.rssLinkageFlag.Size = New System.Drawing.Size(170, 17)
            Me.rssLinkageFlag.TabIndex = 43
            Me.rssLinkageFlag.Text = "Linkage flag"
            Me.rssLinkageFlag.UseVisualStyleBackColor = True
            '
            'enableTelepenNumericModePanel
            '
            Me.enableTelepenNumericModePanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.enableTelepenNumericModePanel.Controls.Add(Me.enableTelepenNumericMode)
            Me.enableTelepenNumericModePanel.Location = New System.Drawing.Point(0, 107)
            Me.enableTelepenNumericModePanel.Name = "enableTelepenNumericModePanel"
            Me.enableTelepenNumericModePanel.Size = New System.Drawing.Size(246, 27)
            Me.enableTelepenNumericModePanel.TabIndex = 42
            Me.enableTelepenNumericModePanel.Visible = False
            '
            'enableTelepenNumericMode
            '
            Me.enableTelepenNumericMode.Location = New System.Drawing.Point(3, 6)
            Me.enableTelepenNumericMode.Name = "enableTelepenNumericMode"
            Me.enableTelepenNumericMode.Size = New System.Drawing.Size(186, 17)
            Me.enableTelepenNumericMode.TabIndex = 41
            Me.enableTelepenNumericMode.Text = "Enable Telepen numeric mode"
            Me.enableTelepenNumericMode.UseVisualStyleBackColor = True
            '
            'useOptionalCheckSumPanel
            '
            Me.useOptionalCheckSumPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.useOptionalCheckSumPanel.Controls.Add(Me.useOptionalCheckSum)
            Me.useOptionalCheckSumPanel.Location = New System.Drawing.Point(0, 135)
            Me.useOptionalCheckSumPanel.Name = "useOptionalCheckSumPanel"
            Me.useOptionalCheckSumPanel.Size = New System.Drawing.Size(246, 27)
            Me.useOptionalCheckSumPanel.TabIndex = 40
            Me.useOptionalCheckSumPanel.Visible = False
            '
            'useOptionalCheckSum
            '
            Me.useOptionalCheckSum.Location = New System.Drawing.Point(3, 4)
            Me.useOptionalCheckSum.Name = "useOptionalCheckSum"
            Me.useOptionalCheckSum.Size = New System.Drawing.Size(187, 17)
            Me.useOptionalCheckSum.TabIndex = 41
            Me.useOptionalCheckSum.Text = "Add optional cheksum"
            Me.useOptionalCheckSum.UseVisualStyleBackColor = True
            '
            'barsRatioPanel
            '
            Me.barsRatioPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.barsRatioPanel.Controls.Add(Me.barsRatioNumericUpDown)
            Me.barsRatioPanel.Controls.Add(Me.label14)
            Me.barsRatioPanel.Location = New System.Drawing.Point(0, 79)
            Me.barsRatioPanel.Name = "barsRatioPanel"
            Me.barsRatioPanel.Size = New System.Drawing.Size(246, 27)
            Me.barsRatioPanel.TabIndex = 38
            Me.barsRatioPanel.Visible = False
            '
            'barsRatioNumericUpDown
            '
            Me.barsRatioNumericUpDown.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.barsRatioNumericUpDown.Location = New System.Drawing.Point(114, 4)
            Me.barsRatioNumericUpDown.Maximum = New Decimal(New Integer() {30, 0, 0, 0})
            Me.barsRatioNumericUpDown.Minimum = New Decimal(New Integer() {15, 0, 0, 0})
            Me.barsRatioNumericUpDown.Name = "barsRatioNumericUpDown"
            Me.barsRatioNumericUpDown.Size = New System.Drawing.Size(125, 20)
            Me.barsRatioNumericUpDown.TabIndex = 33
            Me.barsRatioNumericUpDown.Value = New Decimal(New Integer() {20, 0, 0, 0})
            '
            'label14
            '
            Me.label14.AutoSize = True
            Me.label14.Location = New System.Drawing.Point(2, 7)
            Me.label14.Name = "label14"
            Me.label14.Size = New System.Drawing.Size(80, 13)
            Me.label14.TabIndex = 32
            Me.label14.Text = "Bars ratio (x0.1)"
            '
            'code128ModePanel
            '
            Me.code128ModePanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.code128ModePanel.Controls.Add(Me.code128ModeComboBox)
            Me.code128ModePanel.Controls.Add(Me.label17)
            Me.code128ModePanel.Location = New System.Drawing.Point(0, 135)
            Me.code128ModePanel.Name = "code128ModePanel"
            Me.code128ModePanel.Size = New System.Drawing.Size(246, 27)
            Me.code128ModePanel.TabIndex = 40
            '
            'code128ModeComboBox
            '
            Me.code128ModeComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.code128ModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.code128ModeComboBox.FormattingEnabled = True
            Me.code128ModeComboBox.Location = New System.Drawing.Point(115, 3)
            Me.code128ModeComboBox.Name = "code128ModeComboBox"
            Me.code128ModeComboBox.Size = New System.Drawing.Size(125, 21)
            Me.code128ModeComboBox.TabIndex = 33
            '
            'label17
            '
            Me.label17.AutoSize = True
            Me.label17.Location = New System.Drawing.Point(3, 7)
            Me.label17.Name = "label17"
            Me.label17.Size = New System.Drawing.Size(81, 13)
            Me.label17.TabIndex = 12
            Me.label17.Text = "Encoding mode"
            '
            'australianPostCustomInfoPanel
            '
            Me.australianPostCustomInfoPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.australianPostCustomInfoPanel.Controls.Add(Me.australianPostCustomInfoComboBox)
            Me.australianPostCustomInfoPanel.Controls.Add(Me.label15)
            Me.australianPostCustomInfoPanel.Location = New System.Drawing.Point(0, 79)
            Me.australianPostCustomInfoPanel.Name = "australianPostCustomInfoPanel"
            Me.australianPostCustomInfoPanel.Size = New System.Drawing.Size(246, 27)
            Me.australianPostCustomInfoPanel.TabIndex = 37
            Me.australianPostCustomInfoPanel.Visible = False
            '
            'australianPostCustomInfoComboBox
            '
            Me.australianPostCustomInfoComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.australianPostCustomInfoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.australianPostCustomInfoComboBox.FormattingEnabled = True
            Me.australianPostCustomInfoComboBox.Location = New System.Drawing.Point(115, 3)
            Me.australianPostCustomInfoComboBox.Name = "australianPostCustomInfoComboBox"
            Me.australianPostCustomInfoComboBox.Size = New System.Drawing.Size(125, 21)
            Me.australianPostCustomInfoComboBox.TabIndex = 33
            '
            'label15
            '
            Me.label15.AutoSize = True
            Me.label15.Location = New System.Drawing.Point(3, 7)
            Me.label15.Name = "label15"
            Me.label15.Size = New System.Drawing.Size(62, 13)
            Me.label15.TabIndex = 32
            Me.label15.Text = "Custom info"
            '
            'postalADMiltiplierPanel
            '
            Me.postalADMiltiplierPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.postalADMiltiplierPanel.Controls.Add(Me.postalADMiltiplierNumericUpDown)
            Me.postalADMiltiplierPanel.Controls.Add(Me.label9)
            Me.postalADMiltiplierPanel.Location = New System.Drawing.Point(0, 54)
            Me.postalADMiltiplierPanel.Name = "postalADMiltiplierPanel"
            Me.postalADMiltiplierPanel.Size = New System.Drawing.Size(246, 24)
            Me.postalADMiltiplierPanel.TabIndex = 36
            Me.postalADMiltiplierPanel.Visible = False
            '
            'postalADMiltiplierNumericUpDown
            '
            Me.postalADMiltiplierNumericUpDown.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.postalADMiltiplierNumericUpDown.Location = New System.Drawing.Point(115, 1)
            Me.postalADMiltiplierNumericUpDown.Maximum = New Decimal(New Integer() {17, 0, 0, 0})
            Me.postalADMiltiplierNumericUpDown.Minimum = New Decimal(New Integer() {5, 0, 0, 0})
            Me.postalADMiltiplierNumericUpDown.Name = "postalADMiltiplierNumericUpDown"
            Me.postalADMiltiplierNumericUpDown.Size = New System.Drawing.Size(125, 20)
            Me.postalADMiltiplierNumericUpDown.TabIndex = 32
            Me.postalADMiltiplierNumericUpDown.Value = New Decimal(New Integer() {10, 0, 0, 0})
            '
            'label9
            '
            Me.label9.AutoSize = True
            Me.label9.Location = New System.Drawing.Point(3, 5)
            Me.label9.Name = "label9"
            Me.label9.Size = New System.Drawing.Size(99, 13)
            Me.label9.TabIndex = 31
            Me.label9.Text = "A/D multiplier (x0.1)"
            '
            'linearBarcodeHeightButton
            '
            Me.linearBarcodeHeightButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.linearBarcodeHeightButton.Location = New System.Drawing.Point(172, 30)
            Me.linearBarcodeHeightButton.Name = "linearBarcodeHeightButton"
            Me.linearBarcodeHeightButton.Size = New System.Drawing.Size(73, 23)
            Me.linearBarcodeHeightButton.TabIndex = 29
            Me.linearBarcodeHeightButton.Text = "Height..."
            Me.linearBarcodeHeightButton.UseVisualStyleBackColor = True
            '
            'linearBarcodeTypeComboBox
            '
            Me.linearBarcodeTypeComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.linearBarcodeTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.linearBarcodeTypeComboBox.FormattingEnabled = True
            Me.linearBarcodeTypeComboBox.Location = New System.Drawing.Point(6, 4)
            Me.linearBarcodeTypeComboBox.Name = "linearBarcodeTypeComboBox"
            Me.linearBarcodeTypeComboBox.Size = New System.Drawing.Size(239, 21)
            Me.linearBarcodeTypeComboBox.TabIndex = 28
            '
            'linearBarcodeHeight
            '
            Me.linearBarcodeHeight.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.linearBarcodeHeight.Location = New System.Drawing.Point(102, 31)
            Me.linearBarcodeHeight.Maximum = New Decimal(New Integer() {4096, 0, 0, 0})
            Me.linearBarcodeHeight.Minimum = New Decimal(New Integer() {3, 0, 0, 0})
            Me.linearBarcodeHeight.Name = "linearBarcodeHeight"
            Me.linearBarcodeHeight.Size = New System.Drawing.Size(63, 20)
            Me.linearBarcodeHeight.TabIndex = 28
            Me.linearBarcodeHeight.Value = New Decimal(New Integer() {10, 0, 0, 0})
            '
            'linearBarcodeHeightLabel
            '
            Me.linearBarcodeHeightLabel.AutoSize = True
            Me.linearBarcodeHeightLabel.Location = New System.Drawing.Point(3, 33)
            Me.linearBarcodeHeightLabel.Name = "linearBarcodeHeightLabel"
            Me.linearBarcodeHeightLabel.Size = New System.Drawing.Size(79, 13)
            Me.linearBarcodeHeightLabel.TabIndex = 8
            Me.linearBarcodeHeightLabel.Text = "Barcode height"
            '
            'foregroundColorPanel
            '
            Me.foregroundColorPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.foregroundColorPanel.BackColor = System.Drawing.Color.Black
            Me.foregroundColorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.foregroundColorPanel.Location = New System.Drawing.Point(111, 141)
            Me.foregroundColorPanel.Name = "foregroundColorPanel"
            Me.foregroundColorPanel.Size = New System.Drawing.Size(33, 20)
            Me.foregroundColorPanel.TabIndex = 28
            '
            'selectForegroundColorLabel
            '
            Me.selectForegroundColorLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.selectForegroundColorLabel.Location = New System.Drawing.Point(146, 140)
            Me.selectForegroundColorLabel.Name = "selectForegroundColorLabel"
            Me.selectForegroundColorLabel.Size = New System.Drawing.Size(33, 22)
            Me.selectForegroundColorLabel.TabIndex = 29
            Me.selectForegroundColorLabel.Text = "..."
            Me.selectForegroundColorLabel.UseVisualStyleBackColor = True
            '
            'backgroundColorPanel
            '
            Me.backgroundColorPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.backgroundColorPanel.BackColor = System.Drawing.Color.White
            Me.backgroundColorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.backgroundColorPanel.Location = New System.Drawing.Point(196, 141)
            Me.backgroundColorPanel.Name = "backgroundColorPanel"
            Me.backgroundColorPanel.Size = New System.Drawing.Size(33, 20)
            Me.backgroundColorPanel.TabIndex = 29
            '
            'selectBackgroundColorButton
            '
            Me.selectBackgroundColorButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.selectBackgroundColorButton.Location = New System.Drawing.Point(230, 140)
            Me.selectBackgroundColorButton.Name = "selectBackgroundColorButton"
            Me.selectBackgroundColorButton.Size = New System.Drawing.Size(33, 22)
            Me.selectBackgroundColorButton.TabIndex = 30
            Me.selectBackgroundColorButton.Text = "..."
            Me.selectBackgroundColorButton.UseVisualStyleBackColor = True
            '
            'barcodeWidthPanel
            '
            Me.barcodeWidthPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.barcodeWidthPanel.Controls.Add(Me.label7)
            Me.barcodeWidthPanel.Controls.Add(Me.minWidthNumericUpDown)
            Me.barcodeWidthPanel.Controls.Add(Me.setWidthButton)
            Me.barcodeWidthPanel.Location = New System.Drawing.Point(7, 193)
            Me.barcodeWidthPanel.Name = "barcodeWidthPanel"
            Me.barcodeWidthPanel.Size = New System.Drawing.Size(255, 21)
            Me.barcodeWidthPanel.TabIndex = 31
            '
            'subsetBarcodeValueButton
            '
            Me.subsetBarcodeValueButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.subsetBarcodeValueButton.Location = New System.Drawing.Point(52, 3)
            Me.subsetBarcodeValueButton.Name = "subsetBarcodeValueButton"
            Me.subsetBarcodeValueButton.Size = New System.Drawing.Size(211, 21)
            Me.subsetBarcodeValueButton.TabIndex = 33
            Me.subsetBarcodeValueButton.Text = "Edit Value..."
            Me.subsetBarcodeValueButton.UseVisualStyleBackColor = True
            Me.subsetBarcodeValueButton.Visible = False
            '
            'mainPanel
            '
            Me.mainPanel.Controls.Add(Me.barcodeGroupsTabControl)
            Me.mainPanel.Controls.Add(Me.encodingInfoComboBox)
            Me.mainPanel.Controls.Add(Me.encodingInfoCheckBox)
            Me.mainPanel.Controls.Add(Me.label1)
            Me.mainPanel.Controls.Add(Me.barcodeWidthPanel)
            Me.mainPanel.Controls.Add(Me.selectBackgroundColorButton)
            Me.mainPanel.Controls.Add(Me.valueVisibleCheckBox)
            Me.mainPanel.Controls.Add(Me.backgroundColorPanel)
            Me.mainPanel.Controls.Add(Me.fontSelector)
            Me.mainPanel.Controls.Add(Me.selectForegroundColorLabel)
            Me.mainPanel.Controls.Add(Me.label2)
            Me.mainPanel.Controls.Add(Me.foregroundColorPanel)
            Me.mainPanel.Controls.Add(Me.label3)
            Me.mainPanel.Controls.Add(Me.label4)
            Me.mainPanel.Controls.Add(Me.widthAdjustNumericUpDown)
            Me.mainPanel.Controls.Add(Me.valueAutoLetterSpacingCheckBox)
            Me.mainPanel.Controls.Add(Me.paddingNumericUpDown)
            Me.mainPanel.Controls.Add(Me.label11)
            Me.mainPanel.Controls.Add(Me.label6)
            Me.mainPanel.Controls.Add(Me.label10)
            Me.mainPanel.Controls.Add(Me.barcodeImageLabel)
            Me.mainPanel.Controls.Add(Me.valueGapNumericUpDown)
            Me.mainPanel.Controls.Add(Me.barcodeImageSizeLabel)
            Me.mainPanel.Controls.Add(Me.valueFontSizeNumericUpDown)
            Me.mainPanel.Controls.Add(Me.pixelFormatComboBox)
            Me.mainPanel.Controls.Add(Me.subsetBarcodeValueButton)
            Me.mainPanel.Controls.Add(Me.barcodeValueTextBox)
            Me.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.mainPanel.Location = New System.Drawing.Point(0, 0)
            Me.mainPanel.Name = "mainPanel"
            Me.mainPanel.Size = New System.Drawing.Size(265, 530)
            Me.mainPanel.TabIndex = 34
            '
            'barcodeGroupsTabControl
            '
            Me.barcodeGroupsTabControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.barcodeGroupsTabControl.Controls.Add(Me.linearBarcodesTabPage)
            Me.barcodeGroupsTabControl.Controls.Add(Me.barcodes2DTabPage)
            Me.barcodeGroupsTabControl.Location = New System.Drawing.Point(3, 287)
            Me.barcodeGroupsTabControl.Name = "barcodeGroupsTabControl"
            Me.barcodeGroupsTabControl.SelectedIndex = 0
            Me.barcodeGroupsTabControl.Size = New System.Drawing.Size(259, 240)
            Me.barcodeGroupsTabControl.TabIndex = 36
            '
            'linearBarcodesTabPage
            '
            Me.linearBarcodesTabPage.Controls.Add(Me.Button1)
            Me.linearBarcodesTabPage.Controls.Add(Me.code16KEncodeingModePanel)
            Me.linearBarcodesTabPage.Controls.Add(Me.rssExpandedStackedSegmentPerRowPanel)
            Me.linearBarcodesTabPage.Controls.Add(Me.code16KRowsPanel)
            Me.linearBarcodesTabPage.Controls.Add(Me.msiChecksumPanel)
            Me.linearBarcodesTabPage.Controls.Add(Me.linearBarcodeHeightLabel)
            Me.linearBarcodesTabPage.Controls.Add(Me.rss14StackedOmniPanel)
            Me.linearBarcodesTabPage.Controls.Add(Me.linearBarcodeHeight)
            Me.linearBarcodesTabPage.Controls.Add(Me.rssLinkageFlagPanel)
            Me.linearBarcodesTabPage.Controls.Add(Me.linearBarcodeTypeComboBox)
            Me.linearBarcodesTabPage.Controls.Add(Me.enableTelepenNumericModePanel)
            Me.linearBarcodesTabPage.Controls.Add(Me.linearBarcodeHeightButton)
            Me.linearBarcodesTabPage.Controls.Add(Me.useOptionalCheckSumPanel)
            Me.linearBarcodesTabPage.Controls.Add(Me.postalADMiltiplierPanel)
            Me.linearBarcodesTabPage.Controls.Add(Me.australianPostCustomInfoPanel)
            Me.linearBarcodesTabPage.Controls.Add(Me.barsRatioPanel)
            Me.linearBarcodesTabPage.Controls.Add(Me.code128ModePanel)
            Me.linearBarcodesTabPage.Location = New System.Drawing.Point(4, 22)
            Me.linearBarcodesTabPage.Name = "linearBarcodesTabPage"
            Me.linearBarcodesTabPage.Padding = New System.Windows.Forms.Padding(3)
            Me.linearBarcodesTabPage.Size = New System.Drawing.Size(251, 214)
            Me.linearBarcodesTabPage.TabIndex = 0
            Me.linearBarcodesTabPage.Text = "1D"
            Me.linearBarcodesTabPage.UseVisualStyleBackColor = True
            '
            'code16KEncodeingModePanel
            '
            Me.code16KEncodeingModePanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.code16KEncodeingModePanel.Controls.Add(Me.label12)
            Me.code16KEncodeingModePanel.Controls.Add(Me.code16KEncodingModeComboBox)
            Me.code16KEncodeingModePanel.Location = New System.Drawing.Point(0, 80)
            Me.code16KEncodeingModePanel.Name = "code16KEncodeingModePanel"
            Me.code16KEncodeingModePanel.Size = New System.Drawing.Size(246, 27)
            Me.code16KEncodeingModePanel.TabIndex = 48
            Me.code16KEncodeingModePanel.Visible = False
            '
            'label12
            '
            Me.label12.Location = New System.Drawing.Point(3, 8)
            Me.label12.Name = "label12"
            Me.label12.Size = New System.Drawing.Size(105, 13)
            Me.label12.TabIndex = 45
            Me.label12.Text = "Encoding Mode"
            '
            'code16KEncodingModeComboBox
            '
            Me.code16KEncodingModeComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.code16KEncodingModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.code16KEncodingModeComboBox.FormattingEnabled = True
            Me.code16KEncodingModeComboBox.Location = New System.Drawing.Point(114, 3)
            Me.code16KEncodingModeComboBox.Name = "code16KEncodingModeComboBox"
            Me.code16KEncodingModeComboBox.Size = New System.Drawing.Size(125, 21)
            Me.code16KEncodingModeComboBox.TabIndex = 46
            '
            'code16KRowsPanel
            '
            Me.code16KRowsPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.code16KRowsPanel.Controls.Add(Me.label8)
            Me.code16KRowsPanel.Controls.Add(Me.code16KRowsComboBox)
            Me.code16KRowsPanel.Location = New System.Drawing.Point(0, 53)
            Me.code16KRowsPanel.Name = "code16KRowsPanel"
            Me.code16KRowsPanel.Size = New System.Drawing.Size(246, 27)
            Me.code16KRowsPanel.TabIndex = 47
            Me.code16KRowsPanel.Visible = False
            '
            'label8
            '
            Me.label8.Location = New System.Drawing.Point(3, 8)
            Me.label8.Name = "label8"
            Me.label8.Size = New System.Drawing.Size(105, 13)
            Me.label8.TabIndex = 45
            Me.label8.Text = "Rows"
            '
            'code16KRowsComboBox
            '
            Me.code16KRowsComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.code16KRowsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.code16KRowsComboBox.FormattingEnabled = True
            Me.code16KRowsComboBox.Location = New System.Drawing.Point(114, 3)
            Me.code16KRowsComboBox.Name = "code16KRowsComboBox"
            Me.code16KRowsComboBox.Size = New System.Drawing.Size(125, 21)
            Me.code16KRowsComboBox.TabIndex = 46
            '
            'barcodes2DTabPage
            '
            Me.barcodes2DTabPage.Controls.Add(Me.twoDimensionalBarcodeComboBox)
            Me.barcodes2DTabPage.Controls.Add(Me.hanXinCodeSettingsPanel)
            Me.barcodes2DTabPage.Controls.Add(Me.microQrSettingsPanel)
            Me.barcodes2DTabPage.Controls.Add(Me.qrSettingsPanel)
            Me.barcodes2DTabPage.Controls.Add(Me.microPDF417SettingsPanel)
            Me.barcodes2DTabPage.Controls.Add(Me.pdf417SettingsPanel)
            Me.barcodes2DTabPage.Controls.Add(Me.aztecSettingsPanel)
            Me.barcodes2DTabPage.Controls.Add(Me.maxiCodeSettingsPanel)
            Me.barcodes2DTabPage.Controls.Add(Me.dataMatrixSettingsPanel)
            Me.barcodes2DTabPage.Location = New System.Drawing.Point(4, 22)
            Me.barcodes2DTabPage.Name = "barcodes2DTabPage"
            Me.barcodes2DTabPage.Padding = New System.Windows.Forms.Padding(3)
            Me.barcodes2DTabPage.Size = New System.Drawing.Size(251, 214)
            Me.barcodes2DTabPage.TabIndex = 1
            Me.barcodes2DTabPage.Text = "2D"
            Me.barcodes2DTabPage.UseVisualStyleBackColor = True
            '
            'twoDimensionalBarcodeComboBox
            '
            Me.twoDimensionalBarcodeComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.twoDimensionalBarcodeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.twoDimensionalBarcodeComboBox.FormattingEnabled = True
            Me.twoDimensionalBarcodeComboBox.Location = New System.Drawing.Point(6, 4)
            Me.twoDimensionalBarcodeComboBox.Name = "twoDimensionalBarcodeComboBox"
            Me.twoDimensionalBarcodeComboBox.Size = New System.Drawing.Size(239, 21)
            Me.twoDimensionalBarcodeComboBox.TabIndex = 29
            '
            'hanXinCodeSettingsPanel
            '
            Me.hanXinCodeSettingsPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.hanXinCodeSettingsPanel.Controls.Add(Me.hanXinCodeECCLevelComboBox)
            Me.hanXinCodeSettingsPanel.Controls.Add(Me.hanXinCodeEncodingModeComboBox)
            Me.hanXinCodeSettingsPanel.Controls.Add(Me.hanXinCodeSymbolVersionComboBox)
            Me.hanXinCodeSettingsPanel.Controls.Add(Me.label18)
            Me.hanXinCodeSettingsPanel.Controls.Add(Me.label40)
            Me.hanXinCodeSettingsPanel.Controls.Add(Me.label41)
            Me.hanXinCodeSettingsPanel.Location = New System.Drawing.Point(3, 31)
            Me.hanXinCodeSettingsPanel.Name = "hanXinCodeSettingsPanel"
            Me.hanXinCodeSettingsPanel.Size = New System.Drawing.Size(245, 180)
            Me.hanXinCodeSettingsPanel.TabIndex = 37
            Me.hanXinCodeSettingsPanel.Visible = False
            '
            'hanXinCodeECCLevelComboBox
            '
            Me.hanXinCodeECCLevelComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.hanXinCodeECCLevelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.hanXinCodeECCLevelComboBox.FormattingEnabled = True
            Me.hanXinCodeECCLevelComboBox.Location = New System.Drawing.Point(128, 60)
            Me.hanXinCodeECCLevelComboBox.Name = "hanXinCodeECCLevelComboBox"
            Me.hanXinCodeECCLevelComboBox.Size = New System.Drawing.Size(114, 21)
            Me.hanXinCodeECCLevelComboBox.TabIndex = 23
            '
            'hanXinCodeEncodingModeComboBox
            '
            Me.hanXinCodeEncodingModeComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.hanXinCodeEncodingModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.hanXinCodeEncodingModeComboBox.FormattingEnabled = True
            Me.hanXinCodeEncodingModeComboBox.Location = New System.Drawing.Point(128, 6)
            Me.hanXinCodeEncodingModeComboBox.Name = "hanXinCodeEncodingModeComboBox"
            Me.hanXinCodeEncodingModeComboBox.Size = New System.Drawing.Size(114, 21)
            Me.hanXinCodeEncodingModeComboBox.TabIndex = 21
            '
            'hanXinCodeSymbolVersionComboBox
            '
            Me.hanXinCodeSymbolVersionComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.hanXinCodeSymbolVersionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.hanXinCodeSymbolVersionComboBox.FormattingEnabled = True
            Me.hanXinCodeSymbolVersionComboBox.Location = New System.Drawing.Point(128, 33)
            Me.hanXinCodeSymbolVersionComboBox.Name = "hanXinCodeSymbolVersionComboBox"
            Me.hanXinCodeSymbolVersionComboBox.Size = New System.Drawing.Size(114, 21)
            Me.hanXinCodeSymbolVersionComboBox.TabIndex = 22
            '
            'label18
            '
            Me.label18.AutoSize = True
            Me.label18.Location = New System.Drawing.Point(3, 9)
            Me.label18.Name = "label18"
            Me.label18.Size = New System.Drawing.Size(81, 13)
            Me.label18.TabIndex = 18
            Me.label18.Text = "Encoding mode"
            '
            'label40
            '
            Me.label40.AutoSize = True
            Me.label40.Location = New System.Drawing.Point(3, 37)
            Me.label40.Name = "label40"
            Me.label40.Size = New System.Drawing.Size(78, 13)
            Me.label40.TabIndex = 19
            Me.label40.Text = "Symbol version"
            '
            'label41
            '
            Me.label41.AutoSize = True
            Me.label41.Location = New System.Drawing.Point(3, 64)
            Me.label41.Name = "label41"
            Me.label41.Size = New System.Drawing.Size(104, 13)
            Me.label41.TabIndex = 20
            Me.label41.Text = "Error correction level"
            '
            'microQrSettingsPanel
            '
            Me.microQrSettingsPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.microQrSettingsPanel.Controls.Add(Me.microQrECCLevelComboBox)
            Me.microQrSettingsPanel.Controls.Add(Me.microQrEncodingModeComboBox)
            Me.microQrSettingsPanel.Controls.Add(Me.microQrSymbolSizeComboBox)
            Me.microQrSettingsPanel.Controls.Add(Me.label32)
            Me.microQrSettingsPanel.Controls.Add(Me.label31)
            Me.microQrSettingsPanel.Controls.Add(Me.label30)
            Me.microQrSettingsPanel.Location = New System.Drawing.Point(3, 31)
            Me.microQrSettingsPanel.Name = "microQrSettingsPanel"
            Me.microQrSettingsPanel.Size = New System.Drawing.Size(245, 180)
            Me.microQrSettingsPanel.TabIndex = 28
            Me.microQrSettingsPanel.Visible = False
            '
            'qrSettingsPanel
            '
            Me.qrSettingsPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.qrSettingsPanel.Controls.Add(Me.label29)
            Me.qrSettingsPanel.Controls.Add(Me.qrECCLevelComboBox)
            Me.qrSettingsPanel.Controls.Add(Me.label28)
            Me.qrSettingsPanel.Controls.Add(Me.qrSymbolSizeComboBox)
            Me.qrSettingsPanel.Controls.Add(Me.label27)
            Me.qrSettingsPanel.Controls.Add(Me.qrEncodingModeComboBox)
            Me.qrSettingsPanel.Location = New System.Drawing.Point(4, 31)
            Me.qrSettingsPanel.Name = "qrSettingsPanel"
            Me.qrSettingsPanel.Size = New System.Drawing.Size(245, 183)
            Me.qrSettingsPanel.TabIndex = 32
            Me.qrSettingsPanel.Visible = False
            '
            'microPDF417SettingsPanel
            '
            Me.microPDF417SettingsPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.microPDF417SettingsPanel.Controls.Add(Me.label38)
            Me.microPDF417SettingsPanel.Controls.Add(Me.microPDF417EncodingModeComboBox)
            Me.microPDF417SettingsPanel.Controls.Add(Me.microPDF417SymbolSizeComboBox)
            Me.microPDF417SettingsPanel.Controls.Add(Me.label39)
            Me.microPDF417SettingsPanel.Controls.Add(Me.label13)
            Me.microPDF417SettingsPanel.Controls.Add(Me.microPED417RowHeightNumericUpDown)
            Me.microPDF417SettingsPanel.Controls.Add(Me.microPDF417ColumnsNumericUpDown)
            Me.microPDF417SettingsPanel.Controls.Add(Me.label5)
            Me.microPDF417SettingsPanel.Location = New System.Drawing.Point(4, 31)
            Me.microPDF417SettingsPanel.Name = "microPDF417SettingsPanel"
            Me.microPDF417SettingsPanel.Size = New System.Drawing.Size(245, 183)
            Me.microPDF417SettingsPanel.TabIndex = 25
            Me.microPDF417SettingsPanel.Visible = False
            '
            'pdf417SettingsPanel
            '
            Me.pdf417SettingsPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.pdf417SettingsPanel.Controls.Add(Me.pdf417CompactCheckBox)
            Me.pdf417SettingsPanel.Controls.Add(Me.pdf417EncodingModeComboBox)
            Me.pdf417SettingsPanel.Controls.Add(Me.pdf417RowHeightNumericUpDown)
            Me.pdf417SettingsPanel.Controls.Add(Me.label34)
            Me.pdf417SettingsPanel.Controls.Add(Me.label37)
            Me.pdf417SettingsPanel.Controls.Add(Me.label33)
            Me.pdf417SettingsPanel.Controls.Add(Me.pdf417ColsNumericUpDown)
            Me.pdf417SettingsPanel.Controls.Add(Me.pdf417ErrorCorrectionComboBox)
            Me.pdf417SettingsPanel.Controls.Add(Me.label36)
            Me.pdf417SettingsPanel.Controls.Add(Me.label35)
            Me.pdf417SettingsPanel.Controls.Add(Me.pdf417RowsNumericUpDown)
            Me.pdf417SettingsPanel.Location = New System.Drawing.Point(4, 31)
            Me.pdf417SettingsPanel.Name = "pdf417SettingsPanel"
            Me.pdf417SettingsPanel.Size = New System.Drawing.Size(245, 183)
            Me.pdf417SettingsPanel.TabIndex = 31
            Me.pdf417SettingsPanel.Visible = False
            '
            'aztecSettingsPanel
            '
            Me.aztecSettingsPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.aztecSettingsPanel.Controls.Add(Me.label21)
            Me.aztecSettingsPanel.Controls.Add(Me.aztecErrorCorrectionNumericUpDown)
            Me.aztecSettingsPanel.Controls.Add(Me.label20)
            Me.aztecSettingsPanel.Controls.Add(Me.label22)
            Me.aztecSettingsPanel.Controls.Add(Me.label19)
            Me.aztecSettingsPanel.Controls.Add(Me.aztecEncodingModeComboBox)
            Me.aztecSettingsPanel.Controls.Add(Me.aztecSymbolComboBox)
            Me.aztecSettingsPanel.Controls.Add(Me.aztecLayersCountComboBox)
            Me.aztecSettingsPanel.Location = New System.Drawing.Point(4, 31)
            Me.aztecSettingsPanel.Name = "aztecSettingsPanel"
            Me.aztecSettingsPanel.Size = New System.Drawing.Size(245, 183)
            Me.aztecSettingsPanel.TabIndex = 30
            Me.aztecSettingsPanel.Visible = False
            '
            'maxiCodeSettingsPanel
            '
            Me.maxiCodeSettingsPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.maxiCodeSettingsPanel.Controls.Add(Me.maxiCodeResolutonNumericUpDown)
            Me.maxiCodeSettingsPanel.Controls.Add(Me.label26)
            Me.maxiCodeSettingsPanel.Controls.Add(Me.label25)
            Me.maxiCodeSettingsPanel.Controls.Add(Me.maxiCodeEncodingModeComboBox)
            Me.maxiCodeSettingsPanel.Location = New System.Drawing.Point(3, 31)
            Me.maxiCodeSettingsPanel.Name = "maxiCodeSettingsPanel"
            Me.maxiCodeSettingsPanel.Size = New System.Drawing.Size(245, 183)
            Me.maxiCodeSettingsPanel.TabIndex = 25
            Me.maxiCodeSettingsPanel.Visible = False
            '
            'dataMatrixSettingsPanel
            '
            Me.dataMatrixSettingsPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.dataMatrixSettingsPanel.Controls.Add(Me.label24)
            Me.dataMatrixSettingsPanel.Controls.Add(Me.datamatrixSymbolSizeComboBox)
            Me.dataMatrixSettingsPanel.Controls.Add(Me.label23)
            Me.dataMatrixSettingsPanel.Controls.Add(Me.datamatrixEncodingModeComboBox)
            Me.dataMatrixSettingsPanel.Location = New System.Drawing.Point(3, 31)
            Me.dataMatrixSettingsPanel.Name = "dataMatrixSettingsPanel"
            Me.dataMatrixSettingsPanel.Size = New System.Drawing.Size(245, 183)
            Me.dataMatrixSettingsPanel.TabIndex = 24
            Me.dataMatrixSettingsPanel.Visible = False
            '
            'encodingInfoComboBox
            '
            Me.encodingInfoComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.encodingInfoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.encodingInfoComboBox.Enabled = False
            Me.encodingInfoComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
            Me.encodingInfoComboBox.FormattingEnabled = True
            Me.encodingInfoComboBox.Location = New System.Drawing.Point(111, 26)
            Me.encodingInfoComboBox.Name = "encodingInfoComboBox"
            Me.encodingInfoComboBox.Size = New System.Drawing.Size(152, 21)
            Me.encodingInfoComboBox.TabIndex = 35
            '
            'encodingInfoCheckBox
            '
            Me.encodingInfoCheckBox.AutoSize = True
            Me.encodingInfoCheckBox.Enabled = False
            Me.encodingInfoCheckBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.encodingInfoCheckBox.Location = New System.Drawing.Point(7, 29)
            Me.encodingInfoCheckBox.Name = "encodingInfoCheckBox"
            Me.encodingInfoCheckBox.Size = New System.Drawing.Size(91, 17)
            Me.encodingInfoCheckBox.TabIndex = 34
            Me.encodingInfoCheckBox.Text = "Encoding info"
            Me.encodingInfoCheckBox.UseVisualStyleBackColor = True
            '
            'Button1
            '
            Me.Button1.Location = New System.Drawing.Point(0, 0)
            Me.Button1.Name = "Button1"
            Me.Button1.Size = New System.Drawing.Size(75, 23)
            Me.Button1.TabIndex = 49
            Me.Button1.Text = "Button1"
            Me.Button1.UseVisualStyleBackColor = True
            '
            'BarcodeWriterSettingsControl
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.mainPanel)
            Me.Name = "BarcodeWriterSettingsControl"
            Me.Size = New System.Drawing.Size(265, 530)
            CType(Me.valueFontSizeNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.valueGapNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.minWidthNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.paddingNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.widthAdjustNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.aztecErrorCorrectionNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pdf417RowHeightNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pdf417ColsNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pdf417RowsNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.microPED417RowHeightNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.microPDF417ColumnsNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.maxiCodeResolutonNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
            Me.msiChecksumPanel.ResumeLayout(False)
            Me.msiChecksumPanel.PerformLayout()
            Me.rssExpandedStackedSegmentPerRowPanel.ResumeLayout(False)
            Me.rss14StackedOmniPanel.ResumeLayout(False)
            Me.rssLinkageFlagPanel.ResumeLayout(False)
            Me.enableTelepenNumericModePanel.ResumeLayout(False)
            Me.useOptionalCheckSumPanel.ResumeLayout(False)
            Me.barsRatioPanel.ResumeLayout(False)
            Me.barsRatioPanel.PerformLayout()
            CType(Me.barsRatioNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
            Me.code128ModePanel.ResumeLayout(False)
            Me.code128ModePanel.PerformLayout()
            Me.australianPostCustomInfoPanel.ResumeLayout(False)
            Me.australianPostCustomInfoPanel.PerformLayout()
            Me.postalADMiltiplierPanel.ResumeLayout(False)
            Me.postalADMiltiplierPanel.PerformLayout()
            CType(Me.postalADMiltiplierNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.linearBarcodeHeight, System.ComponentModel.ISupportInitialize).EndInit()
            Me.barcodeWidthPanel.ResumeLayout(False)
            Me.barcodeWidthPanel.PerformLayout()
            Me.mainPanel.ResumeLayout(False)
            Me.mainPanel.PerformLayout()
            Me.barcodeGroupsTabControl.ResumeLayout(False)
            Me.linearBarcodesTabPage.ResumeLayout(False)
            Me.linearBarcodesTabPage.PerformLayout()
            Me.code16KEncodeingModePanel.ResumeLayout(False)
            Me.code16KRowsPanel.ResumeLayout(False)
            Me.barcodes2DTabPage.ResumeLayout(False)
            Me.hanXinCodeSettingsPanel.ResumeLayout(False)
            Me.hanXinCodeSettingsPanel.PerformLayout()
            Me.microQrSettingsPanel.ResumeLayout(False)
            Me.microQrSettingsPanel.PerformLayout()
            Me.qrSettingsPanel.ResumeLayout(False)
            Me.qrSettingsPanel.PerformLayout()
            Me.microPDF417SettingsPanel.ResumeLayout(False)
            Me.microPDF417SettingsPanel.PerformLayout()
            Me.pdf417SettingsPanel.ResumeLayout(False)
            Me.pdf417SettingsPanel.PerformLayout()
            Me.aztecSettingsPanel.ResumeLayout(False)
            Me.aztecSettingsPanel.PerformLayout()
            Me.maxiCodeSettingsPanel.ResumeLayout(False)
            Me.maxiCodeSettingsPanel.PerformLayout()
            Me.dataMatrixSettingsPanel.ResumeLayout(False)
            Me.dataMatrixSettingsPanel.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

		#End Region

        Private WithEvents label1 As System.Windows.Forms.Label
        Private WithEvents barcodeValueTextBox As System.Windows.Forms.TextBox
        Private WithEvents valueVisibleCheckBox As System.Windows.Forms.CheckBox
        Private WithEvents fontSelector As System.Windows.Forms.ComboBox
        Private WithEvents label2 As System.Windows.Forms.Label
        Private WithEvents label3 As System.Windows.Forms.Label
        Private WithEvents label4 As System.Windows.Forms.Label
        Private WithEvents valueAutoLetterSpacingCheckBox As System.Windows.Forms.CheckBox
        Private WithEvents label6 As System.Windows.Forms.Label
        Private WithEvents label7 As System.Windows.Forms.Label
        Private WithEvents barcodeImageLabel As System.Windows.Forms.Label
        Private WithEvents barcodeImageSizeLabel As System.Windows.Forms.Label
        Private WithEvents pixelFormatComboBox As System.Windows.Forms.ComboBox
        Private WithEvents valueFontSizeNumericUpDown As System.Windows.Forms.NumericUpDown
        Private WithEvents valueGapNumericUpDown As System.Windows.Forms.NumericUpDown
        Private WithEvents minWidthNumericUpDown As System.Windows.Forms.NumericUpDown
        Private WithEvents setWidthButton As System.Windows.Forms.Button
        Private WithEvents label10 As System.Windows.Forms.Label
        Private WithEvents label11 As System.Windows.Forms.Label
        Private WithEvents paddingNumericUpDown As System.Windows.Forms.NumericUpDown
        Private WithEvents widthAdjustNumericUpDown As System.Windows.Forms.NumericUpDown
        Private WithEvents code128ModeComboBox As System.Windows.Forms.ComboBox
        Private WithEvents linearBarcodeHeightButton As System.Windows.Forms.Button
        Private WithEvents linearBarcodeTypeComboBox As System.Windows.Forms.ComboBox
        Private WithEvents linearBarcodeHeight As System.Windows.Forms.NumericUpDown
        Private WithEvents label17 As System.Windows.Forms.Label
        Private WithEvents linearBarcodeHeightLabel As System.Windows.Forms.Label
        Private WithEvents aztecErrorCorrectionNumericUpDown As System.Windows.Forms.NumericUpDown
        Private WithEvents label22 As System.Windows.Forms.Label
        Private WithEvents aztecEncodingModeComboBox As System.Windows.Forms.ComboBox
        Private WithEvents aztecLayersCountComboBox As System.Windows.Forms.ComboBox
        Private WithEvents aztecSymbolComboBox As System.Windows.Forms.ComboBox
        Private WithEvents label19 As System.Windows.Forms.Label
        Private WithEvents label20 As System.Windows.Forms.Label
        Private WithEvents label21 As System.Windows.Forms.Label
        Private WithEvents datamatrixSymbolSizeComboBox As System.Windows.Forms.ComboBox
        Private WithEvents datamatrixEncodingModeComboBox As System.Windows.Forms.ComboBox
        Private WithEvents label23 As System.Windows.Forms.Label
        Private WithEvents label24 As System.Windows.Forms.Label
        Private WithEvents maxiCodeResolutonNumericUpDown As System.Windows.Forms.NumericUpDown
        Private WithEvents label26 As System.Windows.Forms.Label
        Private WithEvents maxiCodeEncodingModeComboBox As System.Windows.Forms.ComboBox
        Private WithEvents label25 As System.Windows.Forms.Label
        Private WithEvents microQrECCLevelComboBox As System.Windows.Forms.ComboBox
        Private WithEvents microQrSymbolSizeComboBox As System.Windows.Forms.ComboBox
        Private WithEvents microQrEncodingModeComboBox As System.Windows.Forms.ComboBox
        Private WithEvents label30 As System.Windows.Forms.Label
        Private WithEvents label31 As System.Windows.Forms.Label
        Private WithEvents label32 As System.Windows.Forms.Label
        Private WithEvents pdf417EncodingModeComboBox As System.Windows.Forms.ComboBox
        Private WithEvents label34 As System.Windows.Forms.Label
        Private WithEvents pdf417CompactCheckBox As System.Windows.Forms.CheckBox
        Private WithEvents pdf417RowHeightNumericUpDown As System.Windows.Forms.NumericUpDown
        Private WithEvents label37 As System.Windows.Forms.Label
        Private WithEvents pdf417ColsNumericUpDown As System.Windows.Forms.NumericUpDown
        Private WithEvents label36 As System.Windows.Forms.Label
        Private WithEvents colorDialog1 As System.Windows.Forms.ColorDialog
        Private WithEvents foregroundColorPanel As System.Windows.Forms.Panel
        Private WithEvents selectForegroundColorLabel As System.Windows.Forms.Button
        Private WithEvents backgroundColorPanel As System.Windows.Forms.Panel
        Private WithEvents selectBackgroundColorButton As System.Windows.Forms.Button
        Private WithEvents qrECCLevelComboBox As System.Windows.Forms.ComboBox
        Private WithEvents qrSymbolSizeComboBox As System.Windows.Forms.ComboBox
        Private WithEvents qrEncodingModeComboBox As System.Windows.Forms.ComboBox
        Private WithEvents label27 As System.Windows.Forms.Label
        Private WithEvents label28 As System.Windows.Forms.Label
        Private WithEvents label29 As System.Windows.Forms.Label
        Private WithEvents code128ModePanel As System.Windows.Forms.Panel
        Private WithEvents msiChecksumPanel As System.Windows.Forms.Panel
        Private WithEvents msiChecksumComboBox As System.Windows.Forms.ComboBox
        Private WithEvents label16 As System.Windows.Forms.Label
        Private WithEvents australianPostCustomInfoPanel As System.Windows.Forms.Panel
        Private WithEvents australianPostCustomInfoComboBox As System.Windows.Forms.ComboBox
        Private WithEvents label15 As System.Windows.Forms.Label
        Private WithEvents postalADMiltiplierNumericUpDown As System.Windows.Forms.NumericUpDown
        Private WithEvents label9 As System.Windows.Forms.Label
        Private WithEvents postalADMiltiplierPanel As System.Windows.Forms.Panel
        Private WithEvents barcodeWidthPanel As System.Windows.Forms.Panel
        Private WithEvents subsetBarcodeValueButton As System.Windows.Forms.Button
        Private WithEvents mainPanel As System.Windows.Forms.Panel
        Private WithEvents barsRatioPanel As System.Windows.Forms.Panel
        Private WithEvents barsRatioNumericUpDown As System.Windows.Forms.NumericUpDown
        Private WithEvents label14 As System.Windows.Forms.Label
        Private WithEvents encodingInfoCheckBox As System.Windows.Forms.CheckBox
        Private WithEvents encodingInfoComboBox As System.Windows.Forms.ComboBox
        Private WithEvents microPED417RowHeightNumericUpDown As System.Windows.Forms.NumericUpDown
        Private WithEvents label5 As System.Windows.Forms.Label
        Private WithEvents microPDF417ColumnsNumericUpDown As System.Windows.Forms.NumericUpDown
        Private WithEvents microPDF417EncodingModeComboBox As System.Windows.Forms.ComboBox
        Private WithEvents label39 As System.Windows.Forms.Label
        Private WithEvents pdf417RowsNumericUpDown As System.Windows.Forms.NumericUpDown
        Private WithEvents label35 As System.Windows.Forms.Label
        Private WithEvents pdf417ErrorCorrectionComboBox As System.Windows.Forms.ComboBox
        Private WithEvents label33 As System.Windows.Forms.Label
        Private WithEvents label38 As System.Windows.Forms.Label
        Private WithEvents microPDF417SymbolSizeComboBox As System.Windows.Forms.ComboBox
        Private WithEvents label13 As System.Windows.Forms.Label
        Private WithEvents useOptionalCheckSumPanel As System.Windows.Forms.Panel
        Private WithEvents useOptionalCheckSum As System.Windows.Forms.CheckBox
        Private WithEvents enableTelepenNumericModePanel As System.Windows.Forms.Panel
        Private WithEvents enableTelepenNumericMode As System.Windows.Forms.CheckBox
        Private WithEvents rssLinkageFlagPanel As System.Windows.Forms.Panel
        Private WithEvents rssLinkageFlag As System.Windows.Forms.CheckBox
        Private WithEvents rss14StackedOmniPanel As System.Windows.Forms.Panel
        Private WithEvents rss14StackedOmni As System.Windows.Forms.CheckBox
        Private WithEvents rssExpandedStackedSegmentPerRowPanel As System.Windows.Forms.Panel
        Private WithEvents barcodeWriterRSSExpandedStackedSegmentPerRowLabel As System.Windows.Forms.Label
        Private WithEvents rssExpandedStackedSegmentPerRow As System.Windows.Forms.ComboBox
        Private WithEvents barcodeGroupsTabControl As System.Windows.Forms.TabControl
        Private WithEvents linearBarcodesTabPage As System.Windows.Forms.TabPage
        Private WithEvents barcodes2DTabPage As System.Windows.Forms.TabPage
        Private WithEvents twoDimensionalBarcodeComboBox As System.Windows.Forms.ComboBox
        Private WithEvents microQrSettingsPanel As System.Windows.Forms.Panel
        Private WithEvents maxiCodeSettingsPanel As System.Windows.Forms.Panel
        Private WithEvents dataMatrixSettingsPanel As System.Windows.Forms.Panel
        Private WithEvents qrSettingsPanel As System.Windows.Forms.Panel
        Private WithEvents microPDF417SettingsPanel As System.Windows.Forms.Panel
        Private WithEvents pdf417SettingsPanel As System.Windows.Forms.Panel
        Private WithEvents aztecSettingsPanel As System.Windows.Forms.Panel
        Private WithEvents code16KRowsPanel As System.Windows.Forms.Panel
        Private WithEvents label8 As System.Windows.Forms.Label
        Private WithEvents code16KRowsComboBox As System.Windows.Forms.ComboBox
        Private WithEvents code16KEncodeingModePanel As System.Windows.Forms.Panel
        Private WithEvents label12 As System.Windows.Forms.Label
        Private WithEvents code16KEncodingModeComboBox As System.Windows.Forms.ComboBox
        Private WithEvents hanXinCodeSettingsPanel As System.Windows.Forms.Panel
        Private WithEvents hanXinCodeECCLevelComboBox As System.Windows.Forms.ComboBox
        Private WithEvents hanXinCodeEncodingModeComboBox As System.Windows.Forms.ComboBox
        Private WithEvents hanXinCodeSymbolVersionComboBox As System.Windows.Forms.ComboBox
        Private WithEvents label18 As System.Windows.Forms.Label
        Private WithEvents label40 As System.Windows.Forms.Label
        Private WithEvents label41 As System.Windows.Forms.Label
        Friend WithEvents Button1 As System.Windows.Forms.Button
	End Class
End Namespace
