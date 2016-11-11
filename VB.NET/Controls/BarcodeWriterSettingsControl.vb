Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Collections.Generic

Imports Vintasoft.Barcode
Imports Vintasoft.Barcode.BarcodeInfo
Imports Vintasoft.Barcode.SymbologySubsets
Imports Vintasoft.Barcode.SymbologySubsets.GS1
Imports Vintasoft.Barcode.SymbologySubsets.RoyalMailMailmark
Imports Vintasoft.Barcode.GS1


Namespace Controls
    Partial Public Class BarcodeWriterSettingsControl
        Inherits UserControl

#Region "Fields"

        Private _lastWidth As Single = 6
        Private _lastWidthUnits As UnitOfMeasure = UnitOfMeasure.Centimeters

        Private _lastHeight As Single = 3
        Private _lastHeightUnits As UnitOfMeasure = UnitOfMeasure.Centimeters

        Private _GS1ApplicationIdentifierValues As GS1ApplicationIdentifierValue()

        Private _mailmarkCmdmValueItem As New MailmarkCmdmValueItem()

        Private _ppnBarcodeValue As New PpnBarcodeValue()

#End Region



#Region "Constructor"

        Public Sub New()
            InitializeComponent()

            ' default GS1 value
            _GS1ApplicationIdentifierValues = New GS1ApplicationIdentifierValue() {New GS1ApplicationIdentifierValue(GS1ApplicationIdentifiers.FindApplicationIdentifier("01"), "0123456789012C")}

            ' barcode image pixel formats
            AddEnumValues(pixelFormatComboBox, GetType(BarcodeImagePixelFormat))

            ' linear
            linearBarcodeTypeComboBox.Items.Add(BarcodeType.Code128)
            linearBarcodeTypeComboBox.Items.Add(BarcodeSymbologySubsets.SSCC18)
            linearBarcodeTypeComboBox.Items.Add(BarcodeSymbologySubsets.SwissPostParcel)
            linearBarcodeTypeComboBox.Items.Add(BarcodeSymbologySubsets.FedExGround96)
            linearBarcodeTypeComboBox.Items.Add(BarcodeSymbologySubsets.VicsBol)
            linearBarcodeTypeComboBox.Items.Add(BarcodeSymbologySubsets.VicsScacPro)
            linearBarcodeTypeComboBox.Items.Add(BarcodeType.Code16K)
            linearBarcodeTypeComboBox.Items.Add(BarcodeType.Code93)
            linearBarcodeTypeComboBox.Items.Add(BarcodeType.Code39)
            linearBarcodeTypeComboBox.Items.Add(BarcodeSymbologySubsets.Code39Extended)
            linearBarcodeTypeComboBox.Items.Add(BarcodeSymbologySubsets.Code32)
            linearBarcodeTypeComboBox.Items.Add(BarcodeSymbologySubsets.VIN)
            linearBarcodeTypeComboBox.Items.Add(BarcodeSymbologySubsets.PZN)
            linearBarcodeTypeComboBox.Items.Add(BarcodeSymbologySubsets.NumlyNumber)
            linearBarcodeTypeComboBox.Items.Add(BarcodeSymbologySubsets.DhlAwb)
            linearBarcodeTypeComboBox.Items.Add(BarcodeType.Code11)
            linearBarcodeTypeComboBox.Items.Add(BarcodeType.Codabar)
            linearBarcodeTypeComboBox.Items.Add(BarcodeType.EAN13)
            linearBarcodeTypeComboBox.Items.Add(BarcodeType.EAN13Plus2)
            linearBarcodeTypeComboBox.Items.Add(BarcodeType.EAN13Plus5)
            linearBarcodeTypeComboBox.Items.Add(BarcodeSymbologySubsets.JAN13)
            linearBarcodeTypeComboBox.Items.Add(BarcodeSymbologySubsets.JAN13Plus2)
            linearBarcodeTypeComboBox.Items.Add(BarcodeSymbologySubsets.JAN13Plus5)
            linearBarcodeTypeComboBox.Items.Add(BarcodeType.EAN8)
            linearBarcodeTypeComboBox.Items.Add(BarcodeType.EAN8Plus2)
            linearBarcodeTypeComboBox.Items.Add(BarcodeType.EAN8Plus5)
            linearBarcodeTypeComboBox.Items.Add(BarcodeSymbologySubsets.JAN8)
            linearBarcodeTypeComboBox.Items.Add(BarcodeSymbologySubsets.JAN8Plus2)
            linearBarcodeTypeComboBox.Items.Add(BarcodeSymbologySubsets.JAN8Plus5)
            linearBarcodeTypeComboBox.Items.Add(BarcodeSymbologySubsets.EANVelocity)
            linearBarcodeTypeComboBox.Items.Add(BarcodeSymbologySubsets.ISBN)
            linearBarcodeTypeComboBox.Items.Add(BarcodeSymbologySubsets.ISBNPlus2)
            linearBarcodeTypeComboBox.Items.Add(BarcodeSymbologySubsets.ISBNPlus5)
            linearBarcodeTypeComboBox.Items.Add(BarcodeSymbologySubsets.ISMN)
            linearBarcodeTypeComboBox.Items.Add(BarcodeSymbologySubsets.ISMNPlus2)
            linearBarcodeTypeComboBox.Items.Add(BarcodeSymbologySubsets.ISMNPlus5)
            linearBarcodeTypeComboBox.Items.Add(BarcodeSymbologySubsets.ISSN)
            linearBarcodeTypeComboBox.Items.Add(BarcodeSymbologySubsets.ISSNPlus2)
            linearBarcodeTypeComboBox.Items.Add(BarcodeSymbologySubsets.ISSNPlus5)
            linearBarcodeTypeComboBox.Items.Add(BarcodeType.Interleaved2of5)
            linearBarcodeTypeComboBox.Items.Add(BarcodeSymbologySubsets.OPC)
            linearBarcodeTypeComboBox.Items.Add(BarcodeSymbologySubsets.DeutschePostIdentcode)
            linearBarcodeTypeComboBox.Items.Add(BarcodeSymbologySubsets.DeutschePostLeitcode)
            linearBarcodeTypeComboBox.Items.Add(BarcodeType.MSI)
            linearBarcodeTypeComboBox.Items.Add(BarcodeType.PatchCode)
            linearBarcodeTypeComboBox.Items.Add(BarcodeType.Pharmacode)
            linearBarcodeTypeComboBox.Items.Add(BarcodeType.RSS14)
            linearBarcodeTypeComboBox.Items.Add(BarcodeType.RSS14Stacked)
            linearBarcodeTypeComboBox.Items.Add(BarcodeType.RSSLimited)
            linearBarcodeTypeComboBox.Items.Add(BarcodeType.RSSExpanded)
            linearBarcodeTypeComboBox.Items.Add(BarcodeType.RSSExpandedStacked)
            linearBarcodeTypeComboBox.Items.Add(BarcodeType.Standard2of5)
            linearBarcodeTypeComboBox.Items.Add(BarcodeType.IATA2of5)
            linearBarcodeTypeComboBox.Items.Add(BarcodeType.Matrix2of5)
            linearBarcodeTypeComboBox.Items.Add(BarcodeType.Telepen)
            linearBarcodeTypeComboBox.Items.Add(BarcodeType.UPCA)
            linearBarcodeTypeComboBox.Items.Add(BarcodeType.UPCAPlus2)
            linearBarcodeTypeComboBox.Items.Add(BarcodeType.UPCAPlus5)
            linearBarcodeTypeComboBox.Items.Add(BarcodeType.UPCE)
            linearBarcodeTypeComboBox.Items.Add(BarcodeType.UPCEPlus2)
            linearBarcodeTypeComboBox.Items.Add(BarcodeType.UPCEPlus5)
            linearBarcodeTypeComboBox.Items.Add(BarcodeType.AustralianPost)
            linearBarcodeTypeComboBox.Items.Add(BarcodeType.IntelligentMail)
            linearBarcodeTypeComboBox.Items.Add(BarcodeType.Planet)
            linearBarcodeTypeComboBox.Items.Add(BarcodeType.Postnet)
            linearBarcodeTypeComboBox.Items.Add(BarcodeType.DutchKIX)
            linearBarcodeTypeComboBox.Items.Add(BarcodeType.RoyalMail)
            linearBarcodeTypeComboBox.Items.Add(BarcodeType.Mailmark4StateC)
            linearBarcodeTypeComboBox.Items.Add(BarcodeType.Mailmark4StateL)
            linearBarcodeTypeComboBox.Items.Add(BarcodeSymbologySubsets.GS1DataBar)
            linearBarcodeTypeComboBox.Items.Add(BarcodeSymbologySubsets.GS1_128)
            linearBarcodeTypeComboBox.Items.Add(BarcodeSymbologySubsets.GS1DataBarStacked)
            linearBarcodeTypeComboBox.Items.Add(BarcodeSymbologySubsets.GS1DataBarLimited)
            linearBarcodeTypeComboBox.Items.Add(BarcodeSymbologySubsets.GS1DataBarExpanded)
            linearBarcodeTypeComboBox.Items.Add(BarcodeSymbologySubsets.GS1DataBarExpandedStacked)
            linearBarcodeTypeComboBox.Items.Add(BarcodeSymbologySubsets.ITF14)

            ' sort supported barcode list
            Dim barcodes As Object() = New Object(linearBarcodeTypeComboBox.Items.Count - 1) {}
            linearBarcodeTypeComboBox.Items.CopyTo(barcodes, 0)
            Dim names As String() = New String(barcodes.Length - 1) {}
            For i As Integer = 0 To barcodes.Length - 1
                names(i) = barcodes(i).ToString()
            Next
            Array.Sort(names, barcodes)
            linearBarcodeTypeComboBox.Items.Clear()
            linearBarcodeTypeComboBox.Items.AddRange(barcodes)

            linearBarcodeTypeComboBox.SelectedItem = BarcodeType.Code128

            ' 2D
            twoDimensionalBarcodeComboBox.Items.Add(BarcodeType.Aztec)
            twoDimensionalBarcodeComboBox.Items.Add(BarcodeType.DataMatrix)
            twoDimensionalBarcodeComboBox.Items.Add(BarcodeType.PDF417)
            twoDimensionalBarcodeComboBox.Items.Add(BarcodeType.MicroPDF417)
            twoDimensionalBarcodeComboBox.Items.Add(BarcodeType.HanXinCode)
            twoDimensionalBarcodeComboBox.Items.Add(BarcodeType.QR)
            twoDimensionalBarcodeComboBox.Items.Add(BarcodeType.MicroQR)
            twoDimensionalBarcodeComboBox.Items.Add(BarcodeType.MaxiCode)
            twoDimensionalBarcodeComboBox.Items.Add(BarcodeSymbologySubsets.GS1Aztec)
            twoDimensionalBarcodeComboBox.Items.Add(BarcodeSymbologySubsets.GS1DataMatrix)
            twoDimensionalBarcodeComboBox.Items.Add(BarcodeSymbologySubsets.GS1QR)
            twoDimensionalBarcodeComboBox.Items.Add(BarcodeSymbologySubsets.MailmarkCmdmType7)
            twoDimensionalBarcodeComboBox.Items.Add(BarcodeSymbologySubsets.MailmarkCmdmType9)
            twoDimensionalBarcodeComboBox.Items.Add(BarcodeSymbologySubsets.MailmarkCmdmType29)
            twoDimensionalBarcodeComboBox.Items.Add(BarcodeSymbologySubsets.PPN)
            twoDimensionalBarcodeComboBox.Items.Add(BarcodeSymbologySubsets.XFACompressedAztec)
            twoDimensionalBarcodeComboBox.Items.Add(BarcodeSymbologySubsets.XFACompressedDataMatrix)
            twoDimensionalBarcodeComboBox.Items.Add(BarcodeSymbologySubsets.XFACompressedPDF417)
            twoDimensionalBarcodeComboBox.Items.Add(BarcodeSymbologySubsets.XFACompressedQRCode)
            twoDimensionalBarcodeComboBox.SelectedItem = BarcodeType.DataMatrix

            ' fonts
            For Each fontFamily__1 As FontFamily In FontFamily.Families
                fontSelector.Items.Add(fontFamily__1.Name)
            Next

            ' MSI checksum
            msiChecksumComboBox.Items.Add(MSIChecksumType.Mod10)
            msiChecksumComboBox.Items.Add(MSIChecksumType.Mod10Mod10)
            msiChecksumComboBox.Items.Add(MSIChecksumType.Mod11)
            msiChecksumComboBox.Items.Add(MSIChecksumType.Mod11Mod10)

            ' Code 128 encoding mode
            code128ModeComboBox.Items.Add(Code128EncodingMode.Undefined)
            code128ModeComboBox.Items.Add(Code128EncodingMode.ModeA)
            code128ModeComboBox.Items.Add(Code128EncodingMode.ModeB)
            code128ModeComboBox.Items.Add(Code128EncodingMode.ModeC)


            ' RSS
            For i As Integer = 2 To 20 Step 2
                rssExpandedStackedSegmentPerRow.Items.Add(i)
            Next

            ' Postal
            AddEnumValues(australianPostCustomInfoComboBox, GetType(AustralianPostCustomerInfoFormat))


            ' Aztec
            AddEnumValues(aztecSymbolComboBox, GetType(AztecSymbolType))
            For i As Integer = 0 To 32
                aztecLayersCountComboBox.Items.Add(i)
            Next
            aztecEncodingModeComboBox.Items.Add(AztecEncodingMode.Undefined)
            aztecEncodingModeComboBox.Items.Add(AztecEncodingMode.Text)
            aztecEncodingModeComboBox.Items.Add(AztecEncodingMode.[Byte])

            ' DataMatrix
            AddEnumValues(datamatrixEncodingModeComboBox, GetType(DataMatrixEncodingMode))
            AddEnumValues(datamatrixSymbolSizeComboBox, GetType(DataMatrixSymbolType))

            ' QR Code
            AddEnumValues(qrEncodingModeComboBox, GetType(QREncodingMode))
            qrSymbolSizeComboBox.Items.Add(QRSymbolVersion.Undefined)
            For i As Integer = 1 To 40
                qrSymbolSizeComboBox.Items.Add(DirectCast(i, QRSymbolVersion))
            Next
            AddEnumValues(qrECCLevelComboBox, GetType(QRErrorCorrectionLevel))


            ' Micro QR Code
            AddEnumValues(microQrEncodingModeComboBox, GetType(QREncodingMode))
            microQrSymbolSizeComboBox.Items.Add(QRSymbolVersion.Undefined)
            microQrSymbolSizeComboBox.Items.Add(QRSymbolVersion.VersionM1)
            microQrSymbolSizeComboBox.Items.Add(QRSymbolVersion.VersionM2)
            microQrSymbolSizeComboBox.Items.Add(QRSymbolVersion.VersionM3)
            microQrSymbolSizeComboBox.Items.Add(QRSymbolVersion.VersionM4)
            microQrECCLevelComboBox.Items.Add(QRErrorCorrectionLevel.L)
            microQrECCLevelComboBox.Items.Add(QRErrorCorrectionLevel.M)
            microQrECCLevelComboBox.Items.Add(QRErrorCorrectionLevel.Q)

            ' MaxiCode
            maxiCodeEncodingModeComboBox.Items.Add(MaxiCodeEncodingMode.Mode2)
            maxiCodeEncodingModeComboBox.Items.Add(MaxiCodeEncodingMode.Mode3)
            maxiCodeEncodingModeComboBox.Items.Add(MaxiCodeEncodingMode.Mode4)
            maxiCodeEncodingModeComboBox.Items.Add(MaxiCodeEncodingMode.Mode5)
            maxiCodeEncodingModeComboBox.Items.Add(MaxiCodeEncodingMode.Mode6)

            ' PDF417
            AddEnumValues(pdf417EncodingModeComboBox, GetType(PDF417EncodingMode))
            AddEnumValues(pdf417ErrorCorrectionComboBox, GetType(PDF417ErrorCorrectionLevel))

            ' MicroPDF417
            AddEnumValues(microPDF417EncodingModeComboBox, GetType(PDF417EncodingMode))
            AddEnumValues(microPDF417SymbolSizeComboBox, GetType(MicroPDF417SymbolType))

            ' ECI
            Dim eciCharacterEncodings As EciCharacterEncoding() = EciCharacterEncoding.GetEciCharacterEncodings()
            For Each characterEncoding As EciCharacterEncoding In eciCharacterEncodings
                encodingInfoComboBox.Items.Add(characterEncoding)
                If characterEncoding.EciAssignmentNumber = 3 Then
                    encodingInfoComboBox.SelectedItem = characterEncoding
                End If
            Next

            ' PPN
            _ppnBarcodeValue.PharmacyProductNumber = "110375286414"
            _ppnBarcodeValue.BatchNumber = "12345ABCD"
            _ppnBarcodeValue.ExpiryDate = "150617"
            _ppnBarcodeValue.SerialNumber = "12345ABCDEF98765"

            ' Code 16K
            code16KRowsComboBox.Items.Add(0)
            For i As Integer = 2 To 16
                code16KRowsComboBox.Items.Add(i)
            Next
            code16KEncodingModeComboBox.Items.Add(Code128EncodingMode.Undefined)
            code16KEncodingModeComboBox.Items.Add(Code128EncodingMode.ModeA)
            code16KEncodingModeComboBox.Items.Add(Code128EncodingMode.ModeB)
            code16KEncodingModeComboBox.Items.Add(Code128EncodingMode.ModeC)
            code16KEncodingModeComboBox.Items.Add(Code128EncodingMode.Code16K_Mode3)
            code16KEncodingModeComboBox.Items.Add(Code128EncodingMode.Code16K_Mode4)
            code16KEncodingModeComboBox.Items.Add(Code128EncodingMode.Code16K_Mode5)
            code16KEncodingModeComboBox.Items.Add(Code128EncodingMode.Code16K_Mode6)

            ' Han Xin Code
            AddEnumValues(hanXinCodeEncodingModeComboBox, GetType(HanXinCodeEncodingMode))
            hanXinCodeSymbolVersionComboBox.Items.Add(HanXinCodeSymbolVersion.Undefined)
            For i As Integer = 1 To 84
                hanXinCodeSymbolVersionComboBox.Items.Add(DirectCast(i, HanXinCodeSymbolVersion))
            Next
            AddEnumValues(hanXinCodeECCLevelComboBox, GetType(HanXinCodeErrorCorrectionLevel))
        End Sub

#End Region



#Region "Properties"

        Private _selectedBarcodeSubset As BarcodeSymbologySubset = Nothing
        ''' <summary>
        ''' Gets or sets a selected barcode subset.
        ''' </summary>
        Public Property SelectedBarcodeSubset() As BarcodeSymbologySubset
            Get
                Return _selectedBarcodeSubset
            End Get
            Set(ByVal value As BarcodeSymbologySubset)
                _selectedBarcodeSubset = Value
                UpdateUI()
            End Set
        End Property

        Private _barcodeWriterSettings As WriterSettings = New WriterSettings
        ''' <summary>
        ''' Gest or sets a writer settings.
        ''' </summary>
        Public Property BarcodeWriterSettings() As WriterSettings
            Get
                If Not _barcodeWriterSettings Is Nothing Then
                    _barcodeWriterSettings = New WriterSettings
                End If

                Return _barcodeWriterSettings
            End Get
            Set(ByVal value As WriterSettings)
                _barcodeWriterSettings = Value

                If (BarcodeGlobalSettings.SDKPackage And SDKPackage.Writer1D) <> 0 Then
                    If value IsNot Nothing Then
                        mainPanel.Enabled = True

                        linearBarcodeTypeComboBox.SelectedItem = value.Barcode

                        barcodeValueTextBox.Text = value.Value
                        foregroundColorPanel.BackColor = value.ForeColor
                        backgroundColorPanel.BackColor = value.BackColor
                        pixelFormatComboBox.SelectedItem = value.PixelFormat
                        If barcodeWidthPanel.Visible Then
                            minWidthNumericUpDown.Value = value.MinWidth
                        End If
                        paddingNumericUpDown.Value = value.Padding
                        widthAdjustNumericUpDown.Value = CDec(value.BarsWidthAdjustment * 10)
                        linearBarcodeHeight.Value = value.Height
                        valueAutoLetterSpacingCheckBox.Checked = value.ValueAutoLetterSpacing
                        If barcodeGroupsTabControl.SelectedTab Is linearBarcodesTabPage Then
                            valueVisibleCheckBox.Checked = value.ValueVisible
                        Else
                            valueVisibleCheckBox.Checked = value.Value2DVisible
                        End If
                        valueGapNumericUpDown.Value = value.ValueGap
                        fontSelector.SelectedItem = value.ValueFont.Name
                        valueFontSizeNumericUpDown.Value = CDec(value.ValueFont.SizeInPoints)
                        msiChecksumComboBox.SelectedItem = value.MSIChecksum
                        code128ModeComboBox.SelectedItem = value.Code128EncodingMode
                        postalADMiltiplierNumericUpDown.Value = CDec(value.PostBarcodesADMultiplier * 10.0)
                        australianPostCustomInfoComboBox.SelectedItem = value.AustralianPostCustomerInfoFormat
                        aztecSymbolComboBox.SelectedItem = value.AztecSymbol
                        aztecLayersCountComboBox.SelectedIndex = value.AztecDataLayers
                        aztecEncodingModeComboBox.SelectedItem = value.AztecEncodingMode
                        aztecErrorCorrectionNumericUpDown.Value = CDec(value.AztecErrorCorrectionDataPercent)
                        datamatrixEncodingModeComboBox.SelectedItem = value.DataMatrixEncodingMode
                        datamatrixSymbolSizeComboBox.SelectedItem = value.DataMatrixSymbol
                        qrEncodingModeComboBox.SelectedItem = value.QREncodingMode
                        qrSymbolSizeComboBox.SelectedItem = value.QRSymbol
                        qrECCLevelComboBox.SelectedItem = value.QRErrorCorrectionLevel
                        microQrEncodingModeComboBox.SelectedItem = value.QREncodingMode
                        microQrSymbolSizeComboBox.SelectedItem = value.QRSymbol
                        microQrECCLevelComboBox.SelectedItem = value.QRErrorCorrectionLevel
                        maxiCodeResolutonNumericUpDown.Value = CDec(value.MaxiCodeResolution)
                        maxiCodeEncodingModeComboBox.SelectedItem = value.MaxiCodeEncodingMode
                        pdf417EncodingModeComboBox.SelectedItem = value.PDF417EncodingMode
                        pdf417ErrorCorrectionComboBox.SelectedItem = value.PDF417ErrorCorrectionLevel
                        pdf417RowsNumericUpDown.Value = value.PDF417Rows
                        pdf417ColsNumericUpDown.Value = value.PDF417Columns
                        pdf417RowHeightNumericUpDown.Value = value.PDF417RowHeight
                        microPDF417ColumnsNumericUpDown.Value = value.MicroPDF417Columns
                        microPDF417EncodingModeComboBox.SelectedItem = value.MicroPDF417EncodingMode
                        microPDF417SymbolSizeComboBox.SelectedItem = value.MicroPDF417Symbol
                        microPED417RowHeightNumericUpDown.Value = value.MicroPDF417RowHeight
                        rss14StackedOmni.Checked = value.RSS14StackedOmnidirectional
                        rssExpandedStackedSegmentPerRow.SelectedItem = value.RSSExpandedStackedSegmentPerRow
                        rssLinkageFlag.Checked = value.RSSLinkageFlag
                        useOptionalCheckSum.Checked = value.OptionalCheckSum
                        enableTelepenNumericMode.Checked = value.EnableTelepenNumericMode
                        code16KRowsComboBox.SelectedItem = value.Code16KRows
                        code16KEncodingModeComboBox.SelectedItem = value.Code16KEncodingMode
                        hanXinCodeEncodingModeComboBox.SelectedItem = value.HanXinCodeEncodingMode
                        hanXinCodeSymbolVersionComboBox.SelectedItem = value.HanXinCodeSymbol
                        hanXinCodeECCLevelComboBox.SelectedItem = value.HanXinCodeErrorCorrectionLevel
                    Else
                        mainPanel.Enabled = False
                    End If
                End If
            End Set
        End Property

        ''' <summary>
        ''' Gets a barcode image.
        ''' </summary>
        Public WriteOnly Property BarcodeImage() As Image
            Set(ByVal value As Image)
                If Value Is Nothing Then
                    barcodeImageLabel.Visible = False
                    barcodeImageSizeLabel.Visible = False
                Else
                    barcodeImageLabel.Visible = True
                    barcodeImageSizeLabel.Visible = True
                    barcodeImageSizeLabel.Text = String.Format("{0}x{1} px; {2}x{3} DPI", Value.Width, Value.Height, Value.HorizontalResolution, Value.VerticalResolution)
                End If
            End Set
        End Property

        Private _canChangeBarcodeSize As Boolean = True
        ''' <summary>
        ''' Gets or sets a value that indicating when can change barcode size.
        ''' </summary>
        <DefaultValue(True)> _
        Public Property CanChangeBarcodeSize() As Boolean
            Get
                Return _canChangeBarcodeSize
            End Get
            Set(ByVal value As Boolean)
                _canChangeBarcodeSize = Value
                barcodeWidthPanel.Visible = Value
                linearBarcodeHeight.Visible = Value
                linearBarcodeHeightButton.Visible = Value
                linearBarcodeHeightLabel.Visible = Value
            End Set
        End Property

        ''' <summary>
        ''' Gets a value that indicating when need encode ECI character.
        ''' </summary>
        Public ReadOnly Property EncodeEciCharacter() As Boolean
            Get
                Return encodingInfoCheckBox.Checked AndAlso encodingInfoCheckBox.Enabled
            End Get
        End Property

#End Region



#Region "Methods"

#Region "INTERNAL"

        Friend Sub UpdateBarcodeWriterSettings()
            If barcodeWidthPanel.Visible Then
                minWidthNumericUpDown.Value = Math.Max(BarcodeWriterSettings.MinWidth, minWidthNumericUpDown.Minimum)
            End If
        End Sub

#End Region


#Region "PRIVATE"

#Region "Common"

        Private Sub selectForegroundColorLabel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles selectForegroundColorLabel.Click, foregroundColorPanel.Click
            colorDialog1.Color = foregroundColorPanel.BackColor

            If colorDialog1.ShowDialog() = DialogResult.OK Then
                foregroundColorPanel.BackColor = colorDialog1.Color
            End If

            If BarcodeWriterSettings.ForeColor <> foregroundColorPanel.BackColor Then
                BarcodeWriterSettings.ForeColor = foregroundColorPanel.BackColor
            End If
        End Sub

        Private Sub selectBackgroundColorButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles selectBackgroundColorButton.Click, backgroundColorPanel.Click
            colorDialog1.Color = backgroundColorPanel.BackColor

            If colorDialog1.ShowDialog() = DialogResult.OK Then
                backgroundColorPanel.BackColor = colorDialog1.Color
            End If

            If BarcodeWriterSettings.BackColor <> backgroundColorPanel.BackColor Then
                BarcodeWriterSettings.BackColor = backgroundColorPanel.BackColor
            End If
        End Sub

        Private Sub pixelFormatComboBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles pixelFormatComboBox.SelectedIndexChanged
            If Not BarcodeWriterSettings Is Nothing Then
                BarcodeWriterSettings.PixelFormat = DirectCast(pixelFormatComboBox.SelectedItem, BarcodeImagePixelFormat)
            End If
        End Sub

        Private Sub minWidthNumericUpDown_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles minWidthNumericUpDown.ValueChanged
            If barcodeWidthPanel.Visible Then
                If Not BarcodeWriterSettings Is Nothing Then
                    BarcodeWriterSettings.MinWidth = CInt(Math.Truncate(minWidthNumericUpDown.Value))
                End If
            End If
        End Sub

        Private Sub paddingNumericUpDown_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles paddingNumericUpDown.ValueChanged
            If Not BarcodeWriterSettings Is Nothing Then
                BarcodeWriterSettings.Padding = CInt(Math.Truncate(paddingNumericUpDown.Value))
            End If
        End Sub

        Private Sub widthAdjustNumericUpDown_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles widthAdjustNumericUpDown.ValueChanged
            If Not BarcodeWriterSettings Is Nothing Then
                BarcodeWriterSettings.BarsWidthAdjustment = CDbl(widthAdjustNumericUpDown.Value) * 0.1
            End If
        End Sub

        Private Sub barcodeValueTextBox_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles barcodeValueTextBox.TextChanged
            EncodeValue()
        End Sub

        ''' <summary>
        ''' Encodes the barcode value.
        ''' </summary>
        Public Function EncodeValue() As Boolean
            If BarcodeWriterSettings Is Nothing Then
                Return False
            End If
            Dim oldValue As String = BarcodeWriterSettings.Value
            Try
                If TypeOf SelectedBarcodeSubset Is GS1BarcodeSymbologySubset Then
                    '  encode GS1 barcode value
                    SelectedBarcodeSubset.Encode(New GS1ValueItem(_GS1ApplicationIdentifierValues), BarcodeWriterSettings)
                ElseIf TypeOf SelectedBarcodeSubset Is MailmarkCmdmBarcodeSymbology Then
                    '  encode Mailmark barcode value
                    SelectedBarcodeSubset.Encode(_mailmarkCmdmValueItem, BarcodeWriterSettings)
                ElseIf TypeOf SelectedBarcodeSubset Is PpnBarcodeSymbology Then
                    '  encode PPN barcode value
                    SelectedBarcodeSubset.Encode(_ppnBarcodeValue, BarcodeWriterSettings)
                ElseIf SelectedBarcodeSubset IsNot Nothing Then
                    SelectedBarcodeSubset.Encode(barcodeValueTextBox.Text, BarcodeWriterSettings)
                Else
                    If encodingInfoCheckBox.Checked AndAlso encodingInfoCheckBox.Enabled Then
                        Dim encoder As New EciCharacterEncoder(BarcodeWriterSettings.Barcode)
                        encoder.AppendText(DirectCast(encodingInfoComboBox.SelectedItem, EciCharacterEncoding), barcodeValueTextBox.Text)
                        BarcodeWriterSettings.ValueItems = encoder.ToValueItems()
                        BarcodeWriterSettings.PrintableValue = barcodeValueTextBox.Text
                    Else
                        BarcodeWriterSettings.PrintableValue = ""
                        BarcodeWriterSettings.Value = barcodeValueTextBox.Text
                    End If
                End If
            Catch exc As WriterSettingsException
                OnWriterException(exc)
                Return False
            End Try
            Return True
        End Function


        Private Sub linearBarcodeTypeComboBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles linearBarcodeTypeComboBox.SelectedIndexChanged
            If BarcodeWriterSettings Is Nothing Then
                Return
            End If
            Dim oldBarcodeType As BarcodeType = BarcodeWriterSettings.Barcode
            Try
                BarcodeWriterSettings.BeginInit()
                If TypeOf linearBarcodeTypeComboBox.SelectedItem Is BarcodeSymbologySubset Then
                    SelectedBarcodeSubset = DirectCast(linearBarcodeTypeComboBox.SelectedItem, BarcodeSymbologySubset)
                Else
                    SelectedBarcodeSubset = Nothing
                    BarcodeWriterSettings.Barcode = DirectCast(linearBarcodeTypeComboBox.SelectedItem, BarcodeType)
                End If
                EncodeValue()
                BarcodeWriterSettings.EndInit()
            Catch exc As WriterSettingsException
                BarcodeWriterSettings.EndInit()
                OnWriterException(exc)
                BarcodeWriterSettings.Barcode = oldBarcodeType
                linearBarcodeTypeComboBox.SelectedItem = oldBarcodeType
            End Try

            australianPostCustomInfoPanel.Visible = False
            msiChecksumPanel.Visible = False
            code128ModePanel.Visible = False
            postalADMiltiplierPanel.Visible = False
            barsRatioPanel.Visible = False
            useOptionalCheckSumPanel.Visible = False
            enableTelepenNumericModePanel.Visible = False
            rssLinkageFlagPanel.Visible = False
            rss14StackedOmniPanel.Visible = False
            rssExpandedStackedSegmentPerRowPanel.Visible = False
            code16KEncodeingModePanel.Visible = False
            code16KRowsPanel.Visible = False
            If SelectedBarcodeSubset Is Nothing Then
                Select Case BarcodeWriterSettings.Barcode
                    Case BarcodeType.MSI
                        barsRatioPanel.Visible = True
                        msiChecksumPanel.Visible = True
                        Exit Select

                    Case BarcodeType.Code128
                        code128ModePanel.Visible = True
                        Exit Select
                    Case BarcodeType.Code16K
                        code16KEncodeingModePanel.Visible = True
                        code16KRowsPanel.Visible = True
                        Exit Select
                    Case BarcodeType.AustralianPost
                        postalADMiltiplierPanel.Visible = True
                        australianPostCustomInfoPanel.Visible = True
                        Exit Select
                    Case BarcodeType.RoyalMail, BarcodeType.DutchKIX, BarcodeType.IntelligentMail, BarcodeType.Postnet, BarcodeType.Planet
                        postalADMiltiplierPanel.Visible = True
                        Exit Select

                    Case BarcodeType.Code11, BarcodeType.Codabar
                        barsRatioPanel.Visible = True
                        Exit Select

                    Case BarcodeType.Interleaved2of5
                        useOptionalCheckSumPanel.Visible = True
                        barsRatioPanel.Visible = True
                        Exit Select

                    Case BarcodeType.Standard2of5
                        useOptionalCheckSumPanel.Visible = True
                        barsRatioPanel.Visible = True
                        Exit Select

                    Case BarcodeType.Matrix2of5
                        useOptionalCheckSumPanel.Visible = True
                        barsRatioPanel.Visible = True
                        Exit Select

                    Case BarcodeType.IATA2of5
                        barsRatioPanel.Visible = True
                        Exit Select

                    Case BarcodeType.Code39
                        barsRatioPanel.Visible = True
                        useOptionalCheckSumPanel.Visible = True
                        Exit Select

                    Case BarcodeType.Telepen
                        enableTelepenNumericModePanel.Visible = True
                        barsRatioPanel.Visible = True
                        Exit Select

                    Case BarcodeType.RSS14, BarcodeType.RSS14Stacked, BarcodeType.RSSExpanded, BarcodeType.RSSExpandedStacked, BarcodeType.RSSLimited
                        rssLinkageFlagPanel.Visible = True
                        If BarcodeWriterSettings.Barcode = BarcodeType.RSS14Stacked Then
                            rss14StackedOmniPanel.Visible = True
                        ElseIf BarcodeWriterSettings.Barcode = BarcodeType.RSSExpandedStacked Then
                            rssExpandedStackedSegmentPerRowPanel.Visible = True
                        End If
                        Exit Select

                End Select
            Else
                Select Case SelectedBarcodeSubset.BaseType

                    Case BarcodeType.MSI, BarcodeType.Code11, BarcodeType.Codabar, BarcodeType.Interleaved2of5, BarcodeType.Standard2of5, BarcodeType.Matrix2of5, _
                     BarcodeType.IATA2of5, BarcodeType.Code39, BarcodeType.Telepen
                        barsRatioPanel.Visible = True
                        Exit Select

                    Case BarcodeType.RSS14, BarcodeType.RSS14Stacked, BarcodeType.RSSExpanded, BarcodeType.RSSExpandedStacked, BarcodeType.RSSLimited
                        rssLinkageFlagPanel.Visible = True
                        If BarcodeWriterSettings.Barcode = BarcodeType.RSS14Stacked Then
                            rss14StackedOmniPanel.Visible = True
                        ElseIf BarcodeWriterSettings.Barcode = BarcodeType.RSSExpandedStacked Then
                            rssExpandedStackedSegmentPerRowPanel.Visible = True
                        End If
                        Exit Select

                End Select
                If TypeOf SelectedBarcodeSubset Is Code39ExtendedBarcodeSymbology Then
                    useOptionalCheckSumPanel.Visible = True
                End If
            End If
        End Sub

        Private Sub linearBarcodeHeight_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles linearBarcodeHeight.ValueChanged
            BarcodeWriterSettings.Height = CInt(Math.Truncate(linearBarcodeHeight.Value))
        End Sub

        Private Sub valueAutoLetterSpacingCheckBox_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles valueAutoLetterSpacingCheckBox.CheckedChanged
            If Not BarcodeWriterSettings Is Nothing Then
                BarcodeWriterSettings.ValueAutoLetterSpacing = valueAutoLetterSpacingCheckBox.Checked
            End If
        End Sub

        Private Sub valueVisibleCheckBox_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles valueVisibleCheckBox.CheckedChanged
            Dim enabled As Boolean = valueVisibleCheckBox.Checked
            valueAutoLetterSpacingCheckBox.Enabled = enabled
            valueGapNumericUpDown.Enabled = enabled
            valueFontSizeNumericUpDown.Enabled = enabled
            fontSelector.Enabled = enabled
            If Not BarcodeWriterSettings Is Nothing Then
                If barcodeGroupsTabControl.SelectedTab Is linearBarcodesTabPage Then
                    BarcodeWriterSettings.ValueVisible = valueVisibleCheckBox.Checked
                Else
                    BarcodeWriterSettings.Value2DVisible = valueVisibleCheckBox.Checked
                End If
            End If
        End Sub

        Private Sub valueGapNumericUpDown_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles valueGapNumericUpDown.ValueChanged
            BarcodeWriterSettings.ValueGap = CInt(Math.Truncate(valueGapNumericUpDown.Value))
        End Sub

        Private Sub fontSelector_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles valueFontSizeNumericUpDown.ValueChanged, fontSelector.SelectedIndexChanged
            If fontSelector.SelectedItem IsNot Nothing Then
                BarcodeWriterSettings.ValueFont = New Font(fontSelector.SelectedItem.ToString(), CSng(valueFontSizeNumericUpDown.Value))
            End If
        End Sub

        Private Sub setHeightButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles linearBarcodeHeightButton.Click
            Dim getSize As New GetSizeForm("Height", _lastHeight, CInt(BarcodeWriterSettings.Resolution), _lastHeightUnits)
            If getSize.ShowDialog() = DialogResult.OK Then

                BarcodeWriterSettings.BeginInit()
                BarcodeWriterSettings.Resolution = getSize.Resolution
                BarcodeWriterSettings.SetHeight(getSize.Value, getSize.Units)
                BarcodeWriterSettings.EndInit()

                linearBarcodeHeight.Value = Math.Max(BarcodeWriterSettings.Height, linearBarcodeHeight.Minimum)
                _lastHeight = getSize.Value
                _lastHeightUnits = getSize.Units
            End If
        End Sub

        Private Sub setWidthButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles setWidthButton.Click
            Dim getSize As New GetSizeForm("Width", _lastWidth, CInt(BarcodeWriterSettings.Resolution), _lastWidthUnits)
            If getSize.ShowDialog() = DialogResult.OK Then
                BarcodeWriterSettings.BeginInit()
                BarcodeWriterSettings.Resolution = getSize.Resolution
                BarcodeWriterSettings.SetWidth(getSize.Value, getSize.Units)
                BarcodeWriterSettings.EndInit()

                _lastWidth = getSize.Value
                _lastWidthUnits = getSize.Units
            End If
        End Sub

        Private Sub barcodeGroupsTabPages_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles barcodeGroupsTabControl.SelectedIndexChanged
            barcodeWidthPanel.Visible = CanChangeBarcodeSize
            SelectedBarcodeSubset = Nothing
            Dim oldValue As BarcodeType = BarcodeWriterSettings.Barcode
            Try

                BarcodeWriterSettings.BeginInit()
                If barcodeGroupsTabControl.SelectedTab Is linearBarcodesTabPage Then
                    If TypeOf linearBarcodeTypeComboBox.SelectedItem Is BarcodeSymbologySubset Then
                        SelectedBarcodeSubset = DirectCast(linearBarcodeTypeComboBox.SelectedItem, BarcodeSymbologySubset)
                    Else
                        BarcodeWriterSettings.Barcode = DirectCast(linearBarcodeTypeComboBox.SelectedItem, BarcodeType)
                    End If
                    valueVisibleCheckBox.Checked = BarcodeWriterSettings.ValueVisible
                    barcodeValueTextBox.Enabled = True
                Else
                    Dim barcodeSubset As BarcodeSymbologySubset = TryCast(twoDimensionalBarcodeComboBox.SelectedItem, BarcodeSymbologySubset)
                    Dim baseBarcodeType As BarcodeType
                    If barcodeSubset IsNot Nothing Then
                        baseBarcodeType = barcodeSubset.BaseType
                    Else
                        baseBarcodeType = DirectCast(twoDimensionalBarcodeComboBox.SelectedItem, BarcodeType)
                    End If

                    If baseBarcodeType = BarcodeType.PDF417 Then
                        If pdf417CompactCheckBox.Checked Then
                            BarcodeWriterSettings.Barcode = BarcodeType.PDF417Compact
                        Else
                            BarcodeWriterSettings.Barcode = BarcodeType.PDF417
                        End If
                    ElseIf baseBarcodeType = BarcodeType.MicroPDF417 Then
                        BarcodeWriterSettings.Barcode = BarcodeType.MicroPDF417
                    ElseIf baseBarcodeType = BarcodeType.DataMatrix Then
                        BarcodeWriterSettings.Barcode = BarcodeType.DataMatrix
                        datamatrixSymbolSizeComboBox_SelectedIndexChanged(Me, EventArgs.Empty)
                    ElseIf baseBarcodeType = BarcodeType.Aztec Then
                        BarcodeWriterSettings.Barcode = BarcodeType.Aztec
                    ElseIf baseBarcodeType = BarcodeType.QR Then
                        BarcodeWriterSettings.Barcode = BarcodeType.QR
                        BarcodeWriterSettings.QRSymbol = DirectCast(qrSymbolSizeComboBox.SelectedItem, QRSymbolVersion)
                    ElseIf baseBarcodeType = BarcodeType.MicroQR Then
                        BarcodeWriterSettings.Barcode = BarcodeType.MicroQR
                        BarcodeWriterSettings.QRSymbol = DirectCast(microQrSymbolSizeComboBox.SelectedItem, QRSymbolVersion)
                    ElseIf baseBarcodeType = BarcodeType.MaxiCode Then
                        BarcodeWriterSettings.Barcode = BarcodeType.MaxiCode
                        barcodeWidthPanel.Visible = False
                    ElseIf baseBarcodeType = BarcodeType.HanXinCode Then
                        BarcodeWriterSettings.Barcode = BarcodeType.HanXinCode
                    End If

                    valueVisibleCheckBox.Checked = BarcodeWriterSettings.Value2DVisible
                End If
                UpdateUI()
                EncodeValue()
                BarcodeWriterSettings.EndInit()
            Catch exc As WriterSettingsException
                OnWriterException(exc)
                BarcodeWriterSettings.Barcode = oldValue
                BarcodeWriterSettings.EndInit()
            End Try
        End Sub

        Private Sub UpdateUI()
            If BarcodeWriterSettings Is Nothing Then
                Return
            End If
            Dim canEncodeECI As Boolean = False
            If SelectedBarcodeSubset Is Nothing Then
                Select Case BarcodeWriterSettings.Barcode
                    Case BarcodeType.Aztec, BarcodeType.DataMatrix, BarcodeType.QR, BarcodeType.PDF417, BarcodeType.PDF417Compact, BarcodeType.MicroPDF417, _
                     BarcodeType.HanXinCode
                        canEncodeECI = True
                        Exit Select
                End Select
            End If
            encodingInfoCheckBox.Enabled = canEncodeECI
            encodingInfoComboBox.Enabled = canEncodeECI AndAlso encodingInfoCheckBox.Checked
            Dim useCustomValueDialog As Boolean = False
            If SelectedBarcodeSubset IsNot Nothing AndAlso TypeOf SelectedBarcodeSubset Is GS1BarcodeSymbologySubset OrElse TypeOf SelectedBarcodeSubset Is MailmarkCmdmBarcodeSymbology OrElse TypeOf SelectedBarcodeSubset Is PpnBarcodeSymbology Then
                useCustomValueDialog = True
            End If
            subsetBarcodeValueButton.Visible = useCustomValueDialog
            barcodeValueTextBox.Visible = Not useCustomValueDialog
        End Sub

        Private Sub writerGS1ValueButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles subsetBarcodeValueButton.Click
            If TypeOf SelectedBarcodeSubset Is GS1BarcodeSymbologySubset Then
                Using gs1Editor As New GS1ValueEditorForm(_GS1ApplicationIdentifierValues, False)
                    If gs1Editor.ShowDialog() = DialogResult.OK Then
                        _GS1ApplicationIdentifierValues = gs1Editor.GS1ApplicationIdentifierValues
                        EncodeValue()
                    End If
                End Using
            ElseIf TypeOf SelectedBarcodeSubset Is MailmarkCmdmBarcodeSymbology Then
                Using form As New PropertyGridForm(_mailmarkCmdmValueItem, "Mailmark CMDM value", False)
                    form.PropertyGrid.PropertySort = PropertySort.NoSort
                    If form.ShowDialog() = DialogResult.OK Then
                        EncodeValue()
                    End If
                End Using
            ElseIf TypeOf SelectedBarcodeSubset Is PpnBarcodeSymbology Then
                Using form As New PropertyGridForm(_ppnBarcodeValue, "PPN value", False)
                    form.PropertyGrid.PropertySort = PropertySort.NoSort
                    If form.ShowDialog() = DialogResult.OK Then
                        EncodeValue()
                    End If
                End Using
            Else
                Throw New NotImplementedException()
            End If
        End Sub

        Private Sub encodingInfoComboBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles encodingInfoComboBox.SelectedIndexChanged
            EncodeValue()
        End Sub

        Private Sub barsRatioNumericUpDown_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles barsRatioNumericUpDown.ValueChanged
            BarcodeWriterSettings.BarsRatio = CDbl(barsRatioNumericUpDown.Value) / 10.0
        End Sub

        Private Sub encodingInfoCheckBox_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles encodingInfoCheckBox.CheckedChanged
            encodingInfoComboBox.Enabled = encodingInfoCheckBox.Checked
            EncodeValue()
        End Sub

#End Region


#Region "Common"

        Private Sub useOptionalCheckSum_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles useOptionalCheckSum.CheckedChanged
            BarcodeWriterSettings.OptionalCheckSum = useOptionalCheckSum.Checked
        End Sub

        Private Sub twoDimensionalBarcodeComboBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles twoDimensionalBarcodeComboBox.SelectedIndexChanged
            aztecSettingsPanel.Visible = False
            qrSettingsPanel.Visible = False
            microPDF417SettingsPanel.Visible = False
            pdf417SettingsPanel.Visible = False
            microQrSettingsPanel.Visible = False
            dataMatrixSettingsPanel.Visible = False
            maxiCodeSettingsPanel.Visible = False
            hanXinCodeSettingsPanel.Visible = False


            Dim barcodeSubset As BarcodeSymbologySubset = TryCast(twoDimensionalBarcodeComboBox.SelectedItem, BarcodeSymbologySubset)
            Dim baseBarcodeType As BarcodeType
            If barcodeSubset IsNot Nothing Then
                baseBarcodeType = barcodeSubset.BaseType
            Else
                baseBarcodeType = DirectCast(twoDimensionalBarcodeComboBox.SelectedItem, BarcodeType)
            End If

            SelectedBarcodeSubset = barcodeSubset

            Try
                If BarcodeWriterSettings IsNot Nothing Then
                    If SelectedBarcodeSubset Is Nothing Then
                        BarcodeWriterSettings.BeginInit()
                        BarcodeWriterSettings.Barcode = baseBarcodeType
                    End If
                End If

                UpdateUI()

                ' select settings panel
                Select Case baseBarcodeType
                    Case BarcodeType.Aztec
                        aztecSettingsPanel.Visible = True
                        Exit Select
                    Case BarcodeType.QR
                        qrSettingsPanel.Visible = True
                        Exit Select
                    Case BarcodeType.MicroQR
                        microQrSettingsPanel.Visible = True
                        Exit Select
                    Case BarcodeType.PDF417
                        pdf417SettingsPanel.Visible = True
                        Exit Select
                    Case BarcodeType.MicroPDF417
                        microPDF417SettingsPanel.Visible = True
                        Exit Select
                    Case BarcodeType.DataMatrix
                        If Not (TypeOf SelectedBarcodeSubset Is MailmarkCmdmBarcodeSymbology) Then
                            dataMatrixSettingsPanel.Visible = True
                            datamatrixSymbolSizeComboBox_SelectedIndexChanged(Me, EventArgs.Empty)
                        End If
                        Exit Select
                    Case BarcodeType.HanXinCode
                        hanXinCodeSettingsPanel.Visible = True
                        Exit Select
                    Case BarcodeType.MaxiCode
                        maxiCodeSettingsPanel.Visible = True
                        Exit Select
                End Select
                EncodeValue()
            Finally
                If SelectedBarcodeSubset Is Nothing Then
                    If BarcodeWriterSettings IsNot Nothing Then
                        BarcodeWriterSettings.EndInit()
                    End If
                End If
            End Try
        End Sub

#End Region


#Region "MSI"

        Private Sub msiChecksumComboBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles msiChecksumComboBox.SelectedIndexChanged
            BarcodeWriterSettings.MSIChecksum = DirectCast(msiChecksumComboBox.SelectedItem, MSIChecksumType)
        End Sub

#End Region


#Region "Code128"

        Private Sub code128ModeComboBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles code128ModeComboBox.SelectedIndexChanged
            BarcodeWriterSettings.Code128EncodingMode = DirectCast(code128ModeComboBox.SelectedItem, Code128EncodingMode)
        End Sub

#End Region


#Region "Telepen"

        Private Sub enableTelepenNumericMode_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles enableTelepenNumericMode.CheckedChanged
            BarcodeWriterSettings.EnableTelepenNumericMode = enableTelepenNumericMode.Checked
        End Sub

#End Region


#Region "RSS"

        Private Sub rssLinkageFlag_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rssLinkageFlag.CheckedChanged
            BarcodeWriterSettings.RSSLinkageFlag = rssLinkageFlag.Checked
        End Sub

        Private Sub rss14StackedOmni_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rss14StackedOmni.CheckedChanged
            BarcodeWriterSettings.RSS14StackedOmnidirectional = rss14StackedOmni.Checked
        End Sub

        Private Sub rssExpandedStackedSegmentPerRow_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rssExpandedStackedSegmentPerRow.SelectedIndexChanged
            BarcodeWriterSettings.RSSExpandedStackedSegmentPerRow = CInt(rssExpandedStackedSegmentPerRow.SelectedItem)
        End Sub


#End Region


#Region "Postal"

        Private Sub postalADMiltiplierNumericUpDown_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles postalADMiltiplierNumericUpDown.ValueChanged
            BarcodeWriterSettings.PostBarcodesADMultiplier = CDbl(postalADMiltiplierNumericUpDown.Value) / 10.0
        End Sub

        Private Sub australianPostCustomInfoComboBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles australianPostCustomInfoComboBox.SelectedIndexChanged
            BarcodeWriterSettings.AustralianPostCustomerInfoFormat = DirectCast(australianPostCustomInfoComboBox.SelectedItem, AustralianPostCustomerInfoFormat)
        End Sub

#End Region


#Region "Aztec"

        Private Sub aztecSymbolComboBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles aztecSymbolComboBox.SelectedIndexChanged
            Dim oldValue As AztecSymbolType = BarcodeWriterSettings.AztecSymbol
            Try
                BarcodeWriterSettings.AztecSymbol = DirectCast(aztecSymbolComboBox.SelectedItem, AztecSymbolType)
            Catch exc As WriterSettingsException
                OnWriterException(exc)
                BarcodeWriterSettings.AztecSymbol = oldValue
                aztecSymbolComboBox.SelectedItem = oldValue
            End Try
        End Sub

        Private Sub aztecLayersCountComboBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles aztecLayersCountComboBox.SelectedIndexChanged
            Dim oldValue As Integer = BarcodeWriterSettings.AztecDataLayers
            Try
                BarcodeWriterSettings.AztecDataLayers = aztecLayersCountComboBox.SelectedIndex
            Catch exc As WriterSettingsException
                OnWriterException(exc)
                BarcodeWriterSettings.AztecDataLayers = oldValue
                aztecLayersCountComboBox.SelectedIndex = oldValue
            End Try
        End Sub

        Private Sub aztecEncodingModeComboBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles aztecEncodingModeComboBox.SelectedIndexChanged
            If Not BarcodeWriterSettings Is Nothing Then
                BarcodeWriterSettings.AztecEncodingMode = DirectCast(aztecEncodingModeComboBox.SelectedItem, AztecEncodingMode)
            End If
        End Sub

        Private Sub aztecErrorCorrectionNumericUpDown_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles aztecErrorCorrectionNumericUpDown.ValueChanged
            If Not BarcodeWriterSettings Is Nothing Then
                BarcodeWriterSettings.AztecErrorCorrectionDataPercent = CDbl(aztecErrorCorrectionNumericUpDown.Value)
            End If
        End Sub

#End Region


#Region "DataMatrix"

        Private Sub datamatrixEncodingModeComboBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles datamatrixEncodingModeComboBox.SelectedIndexChanged
            If Not BarcodeWriterSettings Is Nothing Then
                BarcodeWriterSettings.DataMatrixEncodingMode = DirectCast(datamatrixEncodingModeComboBox.SelectedItem, DataMatrixEncodingMode)
            End If
        End Sub

        Private Sub datamatrixSymbolSizeComboBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles datamatrixSymbolSizeComboBox.SelectedIndexChanged
            If Not BarcodeWriterSettings Is Nothing Then
                Dim oldValue As DataMatrixSymbolType = BarcodeWriterSettings.DataMatrixSymbol
                Try
                    If Not datamatrixSymbolSizeComboBox.SelectedItem Is Nothing Then
                        BarcodeWriterSettings.DataMatrixSymbol = DirectCast(datamatrixSymbolSizeComboBox.SelectedItem, DataMatrixSymbolType)
                    End If
                Catch exc As WriterSettingsException
                    OnWriterException(exc)
                    BarcodeWriterSettings.DataMatrixSymbol = oldValue
                    datamatrixSymbolSizeComboBox.SelectedItem = oldValue
                End Try
            End If
        End Sub

#End Region


#Region "QR"

        Private Sub qrEncodingModeComboBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles qrEncodingModeComboBox.SelectedIndexChanged
            If Not BarcodeWriterSettings Is Nothing Then
                Dim oldValue As QREncodingMode = BarcodeWriterSettings.QREncodingMode
                Try
                    BarcodeWriterSettings.BeginInit()
                    Try
                        BarcodeWriterSettings.QREncodingMode = DirectCast(qrEncodingModeComboBox.SelectedItem, QREncodingMode)
                        EncodeValue()
                    Finally
                        BarcodeWriterSettings.EndInit()
                    End Try
                Catch exc As WriterSettingsException
                    OnWriterException(exc)
                    BarcodeWriterSettings.QREncodingMode = oldValue
                    qrEncodingModeComboBox.SelectedItem = oldValue
                End Try
            End If
        End Sub

        Private Sub qrSymbolSizeComboBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles qrSymbolSizeComboBox.SelectedIndexChanged
            If Not BarcodeWriterSettings Is Nothing Then
                BarcodeWriterSettings.QRSymbol = DirectCast(qrSymbolSizeComboBox.SelectedItem, QRSymbolVersion)
            End If
        End Sub

        Private Sub qrECCLevelComboBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles qrECCLevelComboBox.SelectedIndexChanged
            If Not BarcodeWriterSettings Is Nothing Then
                BarcodeWriterSettings.QRErrorCorrectionLevel = DirectCast(qrECCLevelComboBox.SelectedItem, QRErrorCorrectionLevel)
            End If
        End Sub

#End Region


#Region "MicroQR"

        Private Sub microQrEncodingModeComboBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles microQrEncodingModeComboBox.SelectedIndexChanged
            If Not BarcodeWriterSettings Is Nothing Then
                BarcodeWriterSettings.QREncodingMode = DirectCast(microQrEncodingModeComboBox.SelectedItem, QREncodingMode)
            End If
        End Sub

        Private Sub microQrSymbolSizeComboBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles microQrSymbolSizeComboBox.SelectedIndexChanged
            If Not BarcodeWriterSettings Is Nothing Then
                Dim oldValue As QRSymbolVersion = BarcodeWriterSettings.QRSymbol
                Try
                    BarcodeWriterSettings.QRSymbol = DirectCast(microQrSymbolSizeComboBox.SelectedItem, QRSymbolVersion)
                Catch exc As WriterSettingsException
                    OnWriterException(exc)
                    BarcodeWriterSettings.QRSymbol = oldValue
                    microQrSymbolSizeComboBox.SelectedItem = oldValue
                End Try
            End If
        End Sub

        Private Sub microQrECCLevelComboBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles microQrECCLevelComboBox.SelectedIndexChanged
            If Not BarcodeWriterSettings Is Nothing Then
                BarcodeWriterSettings.QRErrorCorrectionLevel = DirectCast(microQrECCLevelComboBox.SelectedItem, QRErrorCorrectionLevel)
            End If
        End Sub

#End Region


#Region "MaxiCode"

        Private Sub maxiCodeResolutonNumericUpDown_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles maxiCodeResolutonNumericUpDown.ValueChanged
            If Not BarcodeWriterSettings Is Nothing Then
                BarcodeWriterSettings.MaxiCodeResolution = CDbl(maxiCodeResolutonNumericUpDown.Value)
            End If
        End Sub

        Private Sub maxiCodeEncodingModeComboBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles maxiCodeEncodingModeComboBox.SelectedIndexChanged
            Dim oldValue As MaxiCodeEncodingMode = BarcodeWriterSettings.MaxiCodeEncodingMode
            Try
                BarcodeWriterSettings.MaxiCodeEncodingMode = DirectCast(maxiCodeEncodingModeComboBox.SelectedItem, MaxiCodeEncodingMode)
            Catch exc As WriterSettingsException
                OnWriterException(exc)
                BarcodeWriterSettings.MaxiCodeEncodingMode = oldValue
                maxiCodeEncodingModeComboBox.SelectedItem = oldValue
            End Try
        End Sub

#End Region


#Region "PDF417"

        Private Sub pdf417EncodingModeComboBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles pdf417EncodingModeComboBox.SelectedIndexChanged
            If Not BarcodeWriterSettings Is Nothing Then
                BarcodeWriterSettings.PDF417EncodingMode = DirectCast(pdf417EncodingModeComboBox.SelectedItem, PDF417EncodingMode)
            End If
        End Sub

        Private Sub pdf417ErrorCorrectionComboBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles pdf417ErrorCorrectionComboBox.SelectedIndexChanged
            If Not BarcodeWriterSettings Is Nothing Then
                BarcodeWriterSettings.PDF417ErrorCorrectionLevel = DirectCast(pdf417ErrorCorrectionComboBox.SelectedItem, PDF417ErrorCorrectionLevel)
            End If
        End Sub

        Private Sub pdf417RowsNumericUpDown_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles pdf417RowsNumericUpDown.ValueChanged
            If Not BarcodeWriterSettings Is Nothing Then
                BarcodeWriterSettings.PDF417Rows = CInt(Math.Truncate(pdf417RowsNumericUpDown.Value))
            End If
        End Sub

        Private Sub pdf417ColsNumericUpDown_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles pdf417ColsNumericUpDown.ValueChanged
            If Not BarcodeWriterSettings Is Nothing Then
                Dim oldValue As Integer = BarcodeWriterSettings.PDF417Columns
                Try
                    BarcodeWriterSettings.PDF417Columns = CInt(Math.Truncate(pdf417ColsNumericUpDown.Value))
                Catch exc As WriterSettingsException
                    OnWriterException(exc)
                    BarcodeWriterSettings.PDF417Columns = oldValue
                    pdf417ColsNumericUpDown.Value = oldValue
                End Try
            End If
        End Sub

        Private Sub pdf417RowHeightNumericUpDown_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles pdf417RowHeightNumericUpDown.ValueChanged
            If Not BarcodeWriterSettings Is Nothing Then
                BarcodeWriterSettings.PDF417RowHeight = CInt(Math.Truncate(pdf417RowHeightNumericUpDown.Value))
            End If
        End Sub

        Private Sub pdf417CompactCheckBox_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles pdf417CompactCheckBox.CheckedChanged
            If Not BarcodeWriterSettings Is Nothing Then
                If pdf417CompactCheckBox.Checked Then
                    BarcodeWriterSettings.Barcode = BarcodeType.PDF417Compact
                Else
                    BarcodeWriterSettings.Barcode = BarcodeType.PDF417
                End If
            End If
        End Sub

#End Region


#Region "Micro PDF417"

        Private Sub microPDF417EncodingModeComboBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles microPDF417EncodingModeComboBox.SelectedIndexChanged
            If Not BarcodeWriterSettings Is Nothing Then
                BarcodeWriterSettings.MicroPDF417EncodingMode = DirectCast(microPDF417EncodingModeComboBox.SelectedItem, PDF417EncodingMode)
            End If
        End Sub

        Private Sub micropDF417SymbolSizeComboBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles microPDF417SymbolSizeComboBox.SelectedIndexChanged
            If Not BarcodeWriterSettings Is Nothing Then
                BarcodeWriterSettings.MicroPDF417Symbol = DirectCast(microPDF417SymbolSizeComboBox.SelectedItem, MicroPDF417SymbolType)
            End If
        End Sub

        Private Sub microPDF417ColumnsNumericUpDown_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles microPDF417ColumnsNumericUpDown.ValueChanged
            If Not BarcodeWriterSettings Is Nothing Then
                BarcodeWriterSettings.MicroPDF417Columns = CInt(Math.Truncate(microPDF417ColumnsNumericUpDown.Value))
            End If
        End Sub

        Private Sub microPED417RowHeightNumericUpDown_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles microPED417RowHeightNumericUpDown.ValueChanged
            If Not BarcodeWriterSettings Is Nothing Then
                BarcodeWriterSettings.MicroPDF417RowHeight = CInt(Math.Truncate(microPED417RowHeightNumericUpDown.Value))
            End If
        End Sub

#End Region


#Region "Code 16K"

        Private Sub code16KEncodingModeComboBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles code16KEncodingModeComboBox.SelectedIndexChanged
            If Not BarcodeWriterSettings Is Nothing Then
                BarcodeWriterSettings.Code16KEncodingMode = DirectCast(code16KEncodingModeComboBox.SelectedItem, Code128EncodingMode)
            End If
        End Sub

        Private Sub code16KRowsComboBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles code16KRowsComboBox.SelectedIndexChanged
            If Not BarcodeWriterSettings Is Nothing Then
                BarcodeWriterSettings.Code16KRows = CInt(code16KRowsComboBox.SelectedItem)
            End If
        End Sub


#End Region


#Region "Han Xin Code"

        Private Sub hanXinCodeEncodingModeComboBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles hanXinCodeEncodingModeComboBox.SelectedIndexChanged
            If Not BarcodeWriterSettings Is Nothing Then
                Dim oldValue As HanXinCodeEncodingMode = BarcodeWriterSettings.HanXinCodeEncodingMode
                Try
                    BarcodeWriterSettings.BeginInit()
                    Try
                        BarcodeWriterSettings.HanXinCodeEncodingMode = DirectCast(hanXinCodeEncodingModeComboBox.SelectedItem, HanXinCodeEncodingMode)
                        EncodeValue()
                    Finally
                        BarcodeWriterSettings.EndInit()
                    End Try
                Catch exc As WriterSettingsException
                    OnWriterException(exc)
                    BarcodeWriterSettings.HanXinCodeEncodingMode = oldValue
                    hanXinCodeEncodingModeComboBox.SelectedItem = oldValue
                End Try
            End If
        End Sub

        Private Sub hanXinCodeSymbolVersionComboBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles hanXinCodeSymbolVersionComboBox.SelectedIndexChanged
            If Not BarcodeWriterSettings Is Nothing Then
                BarcodeWriterSettings.HanXinCodeSymbol = DirectCast(hanXinCodeSymbolVersionComboBox.SelectedItem, HanXinCodeSymbolVersion)
            End If
        End Sub

        Private Sub hanXinCodeECCLevelComboBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles hanXinCodeECCLevelComboBox.SelectedIndexChanged
            If Not BarcodeWriterSettings Is Nothing Then
                BarcodeWriterSettings.HanXinCodeErrorCorrectionLevel = DirectCast(hanXinCodeECCLevelComboBox.SelectedItem, HanXinCodeErrorCorrectionLevel)
            End If
        End Sub

#End Region


#Region "Tools"

        ''' <summary>
        ''' Add a enum values to ComboBox items.
        ''' </summary>
        Private Shared Sub AddEnumValues(ByVal comboBox As ComboBox, ByVal type As Type)
            Dim values As Array = [Enum].GetValues(type)
            For i As Integer = 0 To values.Length - 1
                comboBox.Items.Add(values.GetValue(i))
            Next
        End Sub

        ''' <summary>
        ''' Called when writer exception occurs.
        ''' </summary>
        ''' <param name="exception">The exception.</param>
        Private Sub OnWriterException(ByVal ex As WriterSettingsException)
            If WriterExceptionEvent IsNot Nothing Then
                RaiseEvent WriterException(Me, New ExceptionEventArgs(ex))
            Else
                MessageBox.Show(ex.Message, ex.[GetType]().Name, MessageBoxButtons.OK, MessageBoxIcon.[Error])
            End If
        End Sub

#End Region

#End Region

#End Region



#Region "Events"

        ''' <summary>
        ''' Occurs when writer throws exception.        
        ''' </summary>
        Public Event WriterException As EventHandler(Of ExceptionEventArgs)

#End Region

    End Class
End Namespace
