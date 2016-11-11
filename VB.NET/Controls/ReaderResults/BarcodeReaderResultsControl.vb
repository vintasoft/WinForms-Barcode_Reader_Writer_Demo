Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Globalization
Imports System.Text
Imports System.Windows.Forms

Imports Vintasoft.Barcode
Imports Vintasoft.Barcode.BarcodeInfo
Imports Vintasoft.Barcode.GS1
Imports Vintasoft.Barcode.SymbologySubsets
Imports Vintasoft.Barcode.SymbologySubsets.RoyalMailMailmark


Public Partial Class BarcodeReaderResultsControl
	Inherits UserControl

	#Region "Fields"

	Private _disableShowingValue As Boolean = False

	#End Region



	#Region "Constructor"

	Public Sub New()
		InitializeComponent()

		readerTextEncodingComboBox.Items.Add("Default")
		Dim encodings As EncodingInfo() = Encoding.GetEncodings()
		For i As Integer = 0 To encodings.Length - 1
			readerTextEncodingComboBox.Items.Add(String.Format("{0}: {1} [{2}]", encodings(i).CodePage, encodings(i).DisplayName, encodings(i).Name))
		Next
		readerTextEncodingComboBox.SelectedIndex = 0
	End Sub

	#End Region



	#Region "Properties"

	Private _recognizedBarcodes As IBarcodeInfo()
	Public Property RecognizedBarcodes() As IBarcodeInfo()
		Get
			Return _recognizedBarcodes
		End Get
		Set
			_recognizedBarcodes = value

			ResetUI()
		End Set
	End Property

	Private _barcodeInfoIndex As Integer = 0
	Public Property BarcodeInfoIndex() As Integer
		Get
			Return _barcodeInfoIndex
		End Get
		Set
			_barcodeInfoIndex = value

			ResetUI()
		End Set
	End Property

	Private _barcodeImage As Image
	Public Property BarcodeImage() As Image
		Get
			Return _barcodeImage
		End Get
		Set
			_barcodeImage = value
		End Set
	End Property

	Private _invertBarcodeImage As Boolean = False
	Public Property InvertBarcodeImage() As Boolean
		Get
			Return _invertBarcodeImage
		End Get
		Set
			_invertBarcodeImage = value
		End Set
	End Property

	Private _interpretEciCharacters As Boolean = False
	Public Property InterpretEciCharacters() As Boolean
		Get
			Return _interpretEciCharacters
		End Get
		Set
			_interpretEciCharacters = value
		End Set
	End Property

	#End Region



	#Region "Methods"

	''' <summary>
	''' Resets an user interface.
	''' </summary>
	Private Sub ResetUI()
		If _recognizedBarcodes Is Nothing OrElse _recognizedBarcodes.Length <= _barcodeInfoIndex Then
			_barcodeInfoIndex = 0
		End If
		If _recognizedBarcodes Is Nothing OrElse _recognizedBarcodes.Length = 0 Then
			selectedBarcodeNumericUpDown.Minimum = 0
			selectedBarcodeNumericUpDown.Maximum = 0
			selectedBarcodeNumericUpDown.Value = 0
			ShowBarcodeInformation(Nothing)
			totalBarcodesLabel.Text = "0"
		Else
			_disableShowingValue = True
			selectedBarcodeNumericUpDown.Minimum = 1
			selectedBarcodeNumericUpDown.Maximum = _recognizedBarcodes.Length
			selectedBarcodeNumericUpDown.Value = _barcodeInfoIndex + 1
			_disableShowingValue = False
			MoveToBarcode(_barcodeInfoIndex)
			totalBarcodesLabel.Text = _recognizedBarcodes.Length.ToString()
		End If
	End Sub

	''' <summary>
	''' Removes a special charactes from specified string.
	''' </summary>
	Private Function RemoveSpecialCharacters(text As String) As String
		Dim sb As New StringBuilder()
		If text IsNot Nothing Then
			For i As Integer = 0 To text.Length - 1
				If text(i) >= " "C OrElse text(i) = ControlChars.Lf OrElse text(i) = ControlChars.Cr OrElse text(i) = ControlChars.Tab Then
					sb.Append(text(i))
				Else
					sb.Append("?"C)
				End If
			Next
		End If
		Return sb.ToString()
	End Function

	''' <summary>
	''' Displays specified barcode info.
	''' </summary>
	Private Sub ShowBarcodeInformation(info As IBarcodeInfo)
		If info Is Nothing Then
			barcodeTypeLabel.Text = ""
			confidenceLabel.Text = ""
			readingQualityLabel.Text = ""
			directionLabel.Text = ""
			boundRectnalgeLabel.Text = ""
			rotationAngleLabel.Text = ""
			thresholdLabel.Text = ""
			barcodeValueAsGS1RadioButton.Enabled = InlineAssignHelper(showGS1DecoderButton.Enabled, False)
			structureAppendLabel.Visible = False
		Else
			If TypeOf info Is BarcodeSubsetInfo Then
				barcodeTypeLabel.Text = DirectCast(info, BarcodeSubsetInfo).BarcodeSubset.ToString()
			Else
				barcodeTypeLabel.Text = info.BarcodeType.ToString()
			End If
			If info.Confidence = ReaderSettings.ConfidenceNotAvailable Then
				confidenceLabel.Text = "N/A"
				confidenceLabel.ForeColor = Color.Black
			Else
				confidenceLabel.Text = info.Confidence.ToString() & "%"
				If info.Confidence < 95 Then
					confidenceLabel.ForeColor = Color.Red
				Else
					confidenceLabel.ForeColor = Color.Green
				End If
			End If
			readingQualityLabel.Text = info.ReadingQuality.ToString("F3")
			If info.ReadingQuality <= 0.5 Then
				readingQualityLabel.ForeColor = Color.Red
			ElseIf info.ReadingQuality <= 0.7 Then
				readingQualityLabel.ForeColor = Color.DarkRed
			Else
				readingQualityLabel.ForeColor = Color.Green
			End If
			directionLabel.Text = info.Direction.ToString()
			boundRectnalgeLabel.Text = info.Region.Rectangle.ToString()
			rotationAngleLabel.Text = info.Region.Angle.ToString("F3") + "°"
			thresholdLabel.Text = info.Threshold.ToString()
			info.ShowNonDataFlagsInValue = True
			Dim isGSValue As Boolean = TypeOf info Is GS1BarcodeInfo
			barcodeValueAsGS1RadioButton.Enabled = InlineAssignHelper(showGS1DecoderButton.Enabled, isGSValue)
			If Not isGSValue AndAlso barcodeValueAsGS1RadioButton.Checked Then
				barcodeValueAsGS1RadioButton.Checked = False
				barcodeValueAsTextRadioButton.Checked = True
			End If

			ISO15415QualityTestButton.Enabled = info.BarcodeType = BarcodeType.DataMatrix OrElse info.BarcodeType = BarcodeType.QR OrElse info.BarcodeType = BarcodeType.MicroQR OrElse info.BarcodeType = BarcodeType.PDF417 OrElse info.BarcodeType = BarcodeType.PDF417Compact OrElse info.BarcodeType = BarcodeType.MicroPDF417 OrElse info.BarcodeType = BarcodeType.Aztec

			ISO15416QualityTestButton.Enabled = info.BarcodeType = BarcodeType.EAN13 OrElse info.BarcodeType = BarcodeType.EAN8 OrElse info.BarcodeType = BarcodeType.UPCA OrElse info.BarcodeType = BarcodeType.UPCE OrElse info.BarcodeType = BarcodeType.Interleaved2of5 OrElse info.BarcodeType = BarcodeType.Standard2of5 OrElse info.BarcodeType = BarcodeType.IATA2of5 OrElse info.BarcodeType = BarcodeType.Matrix2of5 OrElse info.BarcodeType = BarcodeType.Code11 OrElse info.BarcodeType = BarcodeType.Code39 OrElse info.BarcodeType = BarcodeType.Telepen OrElse info.BarcodeType = BarcodeType.MSI OrElse info.BarcodeType = BarcodeType.Pharmacode OrElse info.BarcodeType = BarcodeType.Code93 OrElse info.BarcodeType = BarcodeType.Codabar OrElse info.BarcodeType = BarcodeType.Code128 OrElse info.BarcodeType = BarcodeType.RSS14 OrElse info.BarcodeType = BarcodeType.RSS14Stacked OrElse info.BarcodeType = BarcodeType.RSSExpanded OrElse info.BarcodeType = BarcodeType.RSSLimited OrElse info.BarcodeType = BarcodeType.RSSExpandedStacked

			If info.ValueItems IsNot Nothing AndAlso info.ValueItems.Length > 0 AndAlso TypeOf info.ValueItems(0) Is StructuredAppendCharacter Then
				Dim saItem As StructuredAppendCharacter = DirectCast(info.ValueItems(0), StructuredAppendCharacter)
				structureAppendLabel.Text = String.Format("Used Structured Append:" & vbLf & "symbol {0} of {1}", saItem.SymbolPosition, saItem.SymbolCount)
				structureAppendLabel.Visible = True
			Else
				structureAppendLabel.Visible = False
			End If
		End If
		ShowBarcodeValue(info)

		If TypeOf info Is BarcodeSubsetInfo Then
			info = DirectCast(info, BarcodeSubsetInfo).BaseBarcodeInfo
		End If
		ShowBarcodeExtendedInformation(info)
		ShowBarcodeValueItems(info)
		ShowBarcodeImage(info)
	End Sub

	''' <summary>
	''' Displays a barcode image of specified barcode info.
	''' </summary>
	Private Sub ShowBarcodeImage(info As IBarcodeInfo)
		Dim lastImage As Image = barcodePictureBox.Image
		If info Is Nothing Then
			barcodePictureBox.Image = Nothing
		Else
			Dim rect As Rectangle = info.Region.Rectangle
			Dim p As Integer = 1
			rect.X = Math.Max(0, rect.X - p)
			rect.Y = Math.Max(0, rect.Y - p)
			rect.Width = Math.Min(rect.Width + p * 2, _barcodeImage.Width - rect.X)
			rect.Height = Math.Min(rect.Height + p * 2, _barcodeImage.Height - rect.Y)
			Dim barcodeImage As New Bitmap(rect.Width, rect.Height, PixelFormat.Format24bppRgb)
			Using g As Graphics = Graphics.FromImage(barcodeImage)
				g.DrawImage(_barcodeImage, New Rectangle(0, 0, rect.Width, rect.Height), rect, GraphicsUnit.Pixel)
			End Using
			barcodePictureBox.Image = barcodeImage
		End If
		If lastImage IsNot Nothing Then
			lastImage.Dispose()
		End If
	End Sub

	''' <summary>
	''' Displays a barcode value of current barcode info.
	''' </summary>
	Private Sub ShowBarcodeValue()
		readerTextEncodingPanel.Visible = barcodeValueAsTextRadioButton.Checked
		If _recognizedBarcodes Is Nothing Then
			Return
		End If
		ShowBarcodeValue(_recognizedBarcodes(_barcodeInfoIndex))
	End Sub

	''' <summary>
	''' Displays a barcode value of specified barcode info.
	''' </summary>
	Private Sub ShowBarcodeValue(info As IBarcodeInfo)
		If info Is Nothing Then
			barcodeValueTextBox.Text = ""
			Return
		End If

		info.ShowNonDataFlagsInValue = showNonDataFlagsCheckBox.Checked

		Dim infoValue As String
		If InterpretEciCharacters Then
			infoValue = EciCharacterDecoder.Decode(info.ValueItems)
		Else
			infoValue = info.Value
		End If

		If barcodeValueAsTextRadioButton.Checked Then
			barcodeValueTextBox.WordWrap = True
			If TypeOf info Is UnknownLinearBarcodeInfo Then
				Dim value As New StringBuilder()
				value.AppendLine("Normalized bars:")
				value.AppendLine(info.Value)
				value.AppendLine("Normalized[unnormalized]:")
				Dim barcodeLine As Double() = DirectCast(info, UnknownLinearBarcodeInfo).BarcodeLine
				Dim normalizedBarcodeLine As Integer() = DirectCast(info, UnknownLinearBarcodeInfo).NormalizedBarcodeLine
				For i As Integer = 0 To barcodeLine.Length - 1
					value.Append(String.Format("{0}[{1}] ", normalizedBarcodeLine(i), barcodeLine(i).ToString("F1", CultureInfo.InvariantCulture)))
				Next
				barcodeValueTextBox.Text = value.ToString()
			ElseIf TypeOf info Is MailmarkCmdmBarcodeInfo Then
				Dim sb As New StringBuilder()

				sb.Append(String.Format("{0} decoded value: ", DirectCast(info, BarcodeSubsetInfo).BarcodeSubset))
				sb.Append(Environment.NewLine)
				sb.Append(Environment.NewLine)

				Dim mailmarkCmdmValue As MailmarkCmdmValueItem = DirectCast(info, MailmarkCmdmBarcodeInfo).DecodedValue

				sb.Append(String.Format("UPU Country ID:            '{0}'", mailmarkCmdmValue.UpuCountryId))
				sb.Append(Environment.NewLine)
				sb.Append(String.Format("Information Type ID:       '{0}'", mailmarkCmdmValue.InformationTypeId))
				sb.Append(Environment.NewLine)
				sb.Append(String.Format("Version ID:                '{0}'", mailmarkCmdmValue.VersionId))
				sb.Append(Environment.NewLine)
				sb.Append(String.Format("Class:                     '{0}'", mailmarkCmdmValue.[Class]))
				sb.Append(Environment.NewLine)
				sb.Append(String.Format("Supply Chain ID:           '{0}'", mailmarkCmdmValue.SupplyChainId))
				sb.Append(Environment.NewLine)
				sb.Append(String.Format("Item ID:                   '{0}'", mailmarkCmdmValue.ItemId))
				sb.Append(Environment.NewLine)
				sb.Append(String.Format("DPS:                       '{0}'", mailmarkCmdmValue.Dps))
				sb.Append(Environment.NewLine)
				sb.Append(String.Format("RTS Flag:                  '{0}'", mailmarkCmdmValue.RtsFlag))
				sb.Append(Environment.NewLine)
				sb.Append(String.Format("Return To Sender Post Code:'{0}'", mailmarkCmdmValue.ReturnToSenderPostCode))
				sb.Append(Environment.NewLine)
				sb.Append(String.Format("Reserved:                  '{0}'", mailmarkCmdmValue.Reserved))
				sb.Append(Environment.NewLine)
				sb.Append(String.Format("Customer Content:          '{0}'", mailmarkCmdmValue.CustomerContent))

				barcodeValueTextBox.Text = sb.ToString()
			ElseIf TypeOf info Is GS1BarcodeInfo Then
				Dim sb As New StringBuilder()
				Dim subsetName As String = DirectCast(info, GS1BarcodeInfo).BarcodeSubset.Name

				sb.Append(String.Format("{0} transmited data: ", subsetName))
				sb.Append(Environment.NewLine)
				sb.Append(DirectCast(info, GS1BarcodeInfo).TransmittedData)
				sb.Append(Environment.NewLine)

				sb.Append(Environment.NewLine)

				sb.Append(String.Format("{0} printable value: ", subsetName))
				sb.Append(Environment.NewLine)
				sb.Append(DirectCast(info, GS1BarcodeInfo).PrintableValue)
				sb.Append(Environment.NewLine)

				sb.Append(Environment.NewLine)

				sb.Append(String.Format("{0} value: ", DirectCast(info, BarcodeSubsetInfo).BaseBarcodeInfo.BarcodeType))
				sb.Append(Environment.NewLine)
				sb.Append(DirectCast(info, BarcodeSubsetInfo).BaseBarcodeInfo.Value)
				sb.Append(Environment.NewLine)

				sb.Append(Environment.NewLine)
				sb.Append("GS1 decoded value:")
				sb.Append(Environment.NewLine)
				For Each aiv As GS1ApplicationIdentifierValue In DirectCast(info, GS1BarcodeInfo).ApplicationIdentifierValues
					sb.Append(String.Format("{0}: {1}", aiv.ApplicationIdentifier.DataTitle.PadRight(20), aiv.Value))
					sb.Append(Environment.NewLine)
				Next

				barcodeValueTextBox.Text = sb.ToString()
			ElseIf TypeOf info Is PpnBarcodeInfo Then
				Dim sb As New StringBuilder()

				Dim ppnValue As PpnBarcodeValue = DirectCast(info, PpnBarcodeInfo).PpnValue
				If ppnValue.PharmacyProductNumber IsNot Nothing Then
					sb.AppendFormat("PPN:                 {0}", ppnValue.PharmacyProductNumber)
					sb.AppendLine()
				End If
				If ppnValue.BatchNumber IsNot Nothing Then
					sb.AppendFormat("Batch:               {0}", ppnValue.BatchNumber)
					sb.AppendLine()
				End If
				If ppnValue.ExpiryDate IsNot Nothing Then
					sb.AppendFormat("Expiry Date:         {0} (YYMMDD)", ppnValue.ExpiryDate)
					sb.AppendLine()
				End If
				If ppnValue.SerialNumber IsNot Nothing Then
					sb.AppendFormat("Serial Number:       {0}", ppnValue.SerialNumber)
					sb.AppendLine()
				End If
				If ppnValue.DateOfManufacture IsNot Nothing Then
					sb.AppendFormat("Date of Manufacture: {0} (YYYMMDD)", ppnValue.DateOfManufacture)
					sb.AppendLine()
				End If
				If ppnValue.GTIN IsNot Nothing Then
					sb.AppendFormat("GTIN:                {0}", ppnValue.GTIN)
					sb.AppendLine()
				End If
				sb.AppendFormat("Is German PPN:       {0}", ppnValue.IsGermanMarketPpn)
				sb.AppendLine()

				sb.Append(Environment.NewLine)

				sb.Append(String.Format("{0} value: ", DirectCast(info, BarcodeSubsetInfo).BaseBarcodeInfo.BarcodeType))
				sb.Append(Environment.NewLine)
				sb.Append(DirectCast(info, BarcodeSubsetInfo).BaseBarcodeInfo.Value)
				barcodeValueTextBox.Text = sb.ToString()
			ElseIf TypeOf info Is BarcodeSubsetInfo Then
				Dim sb As New StringBuilder()

				sb.Append(String.Format("{0} decoded value: ", DirectCast(info, BarcodeSubsetInfo).BarcodeSubset.Name))
				sb.Append(Environment.NewLine)
				sb.Append(info.Value)
				sb.Append(Environment.NewLine)

				sb.Append(Environment.NewLine)

				sb.Append(String.Format("{0} base type value: ", DirectCast(info, BarcodeSubsetInfo).BaseBarcodeInfo.BarcodeType))
				sb.Append(Environment.NewLine)
				sb.Append(DirectCast(info, BarcodeSubsetInfo).BaseBarcodeInfo.Value)

				barcodeValueTextBox.Text = sb.ToString()
			ElseIf info.BarcodeType = BarcodeType.Mailmark4StateC OrElse info.BarcodeType = BarcodeType.Mailmark4StateL Then
				Dim item As Mailmark4StateValueItem = DirectCast(info.ValueItems(0), Mailmark4StateValueItem)

				Dim sb As New StringBuilder()

				sb.Append(String.Format("Barcode value:   '{0}'", info.Value))
				sb.Append(Environment.NewLine)
				sb.Append(Environment.NewLine)
				sb.Append("Decoded value:")
				sb.Append(Environment.NewLine)
				sb.Append(String.Format("Format:          '{0}'", item.Format))
				sb.Append(Environment.NewLine)
				sb.Append(String.Format("Version ID:      '{0}'", item.VersionId))
				sb.Append(Environment.NewLine)
				sb.Append(String.Format("Class:           '{0}'", item.[Class]))
				sb.Append(Environment.NewLine)
				sb.Append(String.Format("Supply Chain ID: '{0}'", item.SupplyChainId))
				sb.Append(Environment.NewLine)
				sb.Append(String.Format("Item ID:         '{0}'", item.ItemId))
				sb.Append(Environment.NewLine)
				sb.Append(String.Format("DPS:             '{0}'", item.Dps))
				sb.Append(Environment.NewLine)

				barcodeValueTextBox.Text = sb.ToString()
			Else
				Dim value As String = SetEncoding(infoValue)
				barcodeValueTextBox.Text = RemoveSpecialCharacters(value)
			End If
		ElseIf barcodeValueAsBinaryRadioButton.Checked Then
			barcodeValueTextBox.WordWrap = False
			barcodeValueTextBox.Text = StringToBinary(infoValue, 16)
		ElseIf barcodeValueAsHexRadioButton.Checked Then
			barcodeValueTextBox.WordWrap = False
			barcodeValueTextBox.Text = StringToHex(infoValue, 16)
		ElseIf barcodeValueAsGS1RadioButton.Checked Then
			barcodeValueTextBox.Text = DecodeGS1BarcodeValue(DirectCast(info, GS1BarcodeInfo).TransmittedData)
		End If

		info.ShowNonDataFlagsInValue = True
	End Sub

	''' <summary>
	''' Sets current encoding of specified string.
	''' </summary>
	Private Function SetEncoding(value As String) As String
		If readerTextEncodingComboBox.SelectedIndex = 0 Then
			Return value
		End If

		Dim encodings As EncodingInfo() = Encoding.GetEncodings()
		Dim newEncoding As Encoding = encodings(readerTextEncodingComboBox.SelectedIndex - 1).GetEncoding()

		Return SetEncoding(value, newEncoding)
	End Function


	''' <summary>
	''' Sets encoding of specified string.
	''' </summary>
	Private Function SetEncoding(value As String, newEncoding As Encoding) As String
		Dim singleByteEncoding As Boolean = True
		For i As Integer = 0 To value.Length - 1
            If CType(AscW(value(i)), Int32) > 255 Then
                singleByteEncoding = False
                Exit For
            End If
		Next

		Dim bytes As Byte()
		If singleByteEncoding Then
			bytes = New Byte(value.Length - 1) {}
			For i As Integer = 0 To value.Length - 1
				bytes(i) = CByte(AscW(value(i)))
			Next
		Else
			bytes = Encoding.[Default].GetBytes(value)
		End If

		Return newEncoding.GetString(bytes)
	End Function

	''' <summary>
	''' Returns barcode value as GS1 value.
	''' </summary>
	Private Function GetGS1BarcodeValue(value As String) As String
		Try
			Dim ai As GS1ApplicationIdentifierValue() = GS1Codec.Decode(value)
			If ai Is Nothing Then
				Return Nothing
			End If
			Dim sb As New StringBuilder()
			For i As Integer = 0 To ai.Length - 1
				sb.Append(ai(i).ToString())
			Next
			Return sb.ToString()
		Catch
			Return "GS1 Decoding Error."
		End Try
	End Function

	''' <summary>
	''' Decodes GS1 barcode value.
	''' </summary>
	Private Function DecodeGS1BarcodeValue(value As String) As String
		Try
			Dim ai As GS1ApplicationIdentifierValue() = GS1Codec.Decode(value)
			Dim sb As New StringBuilder()
			sb.Append("Symbology Format : " & GS1Codec.GetSymbologyFormat(value))
			sb.Append(Environment.NewLine)
			sb.Append("Value            : " & GetGS1BarcodeValue(value))
			Return sb.ToString()
		Catch
			Return "GS1 Decoding Error."
		End Try
	End Function

	''' <summary>
	''' Converts a string to binnary format.
	''' </summary>
	Private Function StringToBinary(data As String, line As Integer) As String
		Dim sb As New StringBuilder()
		For i As Integer = 0 To data.Length - 1
			If i Mod line = 0 Then
				If i <> 0 Then
					For j As Integer = i - line To i - 1
						Dim val As Char = data(j)

						If val >= ChrW(32) AndAlso val <= ChrW(127) Then
							sb.Append(val)
						Else
							sb.Append("?"C)
						End If
					Next
					sb.AppendLine()
				End If
				sb.Append(String.Format("0x{0} ", i.ToString("X4")))
			End If
			If (i Mod line <> 0) AndAlso (i Mod (line \ 2) = 0) Then
				sb.Append("| ")
			End If
			Dim d As Integer = 2
			If AscW(data(i)) > 255 Then
				d = 4
			End If
			sb.Append((AscW(data(i))).ToString("X" & d.ToString()) & " ")
		Next
		Return sb.ToString()
	End Function

	''' <summary>
	''' Add extended barcode infrmation.
	''' </summary>
	Private Sub AddBarcodeExtendedInformation(name As String, value As Object)
		Dim row As New DataGridViewRow()
		row.Cells.Add(New DataGridViewTextBoxCell())
		row.Cells.Add(New DataGridViewTextBoxCell())
		row.Cells(0).Value = name
		row.Cells(1).Value = value
		extendedInfoDataGridView.Rows.Add(row)
	End Sub

	''' <summary>
	''' Add information about barcode value item.
	''' </summary>
	Private Sub AddBarcodeValueItemInformation(number As Integer, itemType As String, value As String, hexValue As String)
		Dim row As New DataGridViewRow()
		row.Cells.Add(New DataGridViewTextBoxCell())
		row.Cells.Add(New DataGridViewTextBoxCell())
		row.Cells.Add(New DataGridViewTextBoxCell())
		row.Cells.Add(New DataGridViewTextBoxCell())
		row.Cells(0).Value = number
		row.Cells(1).Value = itemType
		row.Cells(2).Value = value
		row.Cells(3).Value = hexValue
		valueItemsDataGridView.Rows.Add(row)
	End Sub

	''' <summary>
	''' Displays extended information of specified barcode info.
	''' </summary>
	Private Sub ShowBarcodeExtendedInformation(info As IBarcodeInfo)
		extendedInfoDataGridView.Rows.Clear()
		If info Is Nothing Then
			Return
		End If
		If TypeOf info Is BarcodeInfo2D Then
			Dim info2D As BarcodeInfo2D = DirectCast(info, BarcodeInfo2D)
			AddBarcodeExtendedInformation("Matrix size", String.Format("{0} x {1}", info2D.MatrixWidth, info2D.MatrixHeight))
			AddBarcodeExtendedInformation("Cell size", String.Format(CultureInfo.InvariantCulture, "{0:f2} x {1:f2}", info2D.CellWidth, info2D.CellHeight))
			AddBarcodeExtendedInformation("Data codewords", info2D.TotalCodewordCount - info2D.ErrorCorrectionCodewordCount)
			AddBarcodeExtendedInformation("Error correction codewords", info2D.ErrorCorrectionCodewordCount)
			AddBarcodeExtendedInformation("Total codewords", info2D.TotalCodewordCount)
			AddBarcodeExtendedInformation("Corrected errors", info2D.CorrectedErrors)
		End If
		If TypeOf info Is BarcodeInfo1D Then
			Dim info1D As BarcodeInfo1D = DirectCast(info, BarcodeInfo1D)
			AddBarcodeExtendedInformation("Narrow bar count", info1D.NarrowBarCount)
			AddBarcodeExtendedInformation("Narrow bar size", info1D.NarrowBarSize)
		End If
		Select Case info.BarcodeType
			Case BarcodeType.PDF417, BarcodeType.PDF417Compact
				Dim pdf417Info As PDF417Info = DirectCast(info, PDF417Info)
				AddBarcodeExtendedInformation("Error correction level", pdf417Info.ErrorCorrectionLevel)
				AddBarcodeExtendedInformation("Row codewords count", pdf417Info.RowCodewordsCount)
				AddBarcodeExtendedInformation("Rows count", pdf417Info.RowsCount)
				Exit Select
			Case BarcodeType.MicroPDF417
				Dim microPdf417Info As MicroPDF417Info = DirectCast(info, MicroPDF417Info)
				AddBarcodeExtendedInformation("Symbol type", microPdf417Info.SymbolType)
				Exit Select
			Case BarcodeType.DataMatrix
				Dim dataMatrixInfo As DataMatrixInfo = DirectCast(info, DataMatrixInfo)
				AddBarcodeExtendedInformation("Symbol ECC type", dataMatrixInfo.Symbol.SymbolECCType)
				AddBarcodeExtendedInformation("Symbol type", dataMatrixInfo.Symbol.SymbolType)
				Exit Select
			Case BarcodeType.MicroQR, BarcodeType.QR
				Dim qrInfo As QRInfo = DirectCast(info, QRInfo)
				AddBarcodeExtendedInformation("Error correction level", qrInfo.ErrorCorrectionLevel)
				AddBarcodeExtendedInformation("Symbol version", qrInfo.Symbol.Version)
				Exit Select
			Case BarcodeType.Aztec
				Dim aztecInfo As AztecInfo = DirectCast(info, AztecInfo)
				AddBarcodeExtendedInformation("Error correction data (%)", aztecInfo.Symbol.ErrorCorrectionData.ToString("F3"))
				AddBarcodeExtendedInformation("Symbol type", aztecInfo.Symbol.SymbolType)
                AddBarcodeExtendedInformation("Data layers", aztecInfo.Symbol.DataLayers)
                AddBarcodeExtendedInformation("Bulleye center", aztecInfo.BulleyeCenter)
				Exit Select
			Case BarcodeType.MaxiCode
				Dim maxiCodeInfo As MaxiCodeInfo = DirectCast(info, MaxiCodeInfo)
				AddBarcodeExtendedInformation("Encoding mode", maxiCodeInfo.EncodingMode)
				Exit Select
			Case BarcodeType.RSS14, BarcodeType.RSS14Stacked, BarcodeType.RSSExpanded, BarcodeType.RSSExpandedStacked, BarcodeType.RSSLimited
				Dim rssInfo As RSSInfo = DirectCast(info, RSSInfo)
				AddBarcodeExtendedInformation("Segments count", rssInfo.SegmentsCount)
				AddBarcodeExtendedInformation("Rows count", rssInfo.RowsCount)
				AddBarcodeExtendedInformation("Segments in row", rssInfo.SegmentsInRow)
				AddBarcodeExtendedInformation("Linkage flag", rssInfo.LinkageFlag)
				Exit Select
			Case BarcodeType.IntelligentMail
				Dim intelligentMailInfo As IntelligentMailInfo = DirectCast(info, IntelligentMailInfo)
				AddBarcodeExtendedInformation("Barcode ID", intelligentMailInfo.BarcodeID)
				AddBarcodeExtendedInformation("Service Type ID", intelligentMailInfo.ServiceTypeID)
				AddBarcodeExtendedInformation("Mailer ID", intelligentMailInfo.MailerID)
				AddBarcodeExtendedInformation("Serial Number", intelligentMailInfo.SerialNumber)
				If intelligentMailInfo.RoutingZIPCode <> "" Then
					AddBarcodeExtendedInformation("Routing ZIP Code", intelligentMailInfo.RoutingZIPCode)
				End If
				Exit Select
			Case BarcodeType.Pharmacode
				Dim pharmacodeInfo As PharmacodeInfo = DirectCast(info, PharmacodeInfo)
				AddBarcodeExtendedInformation("Reverse read value", pharmacodeInfo.ReverseReadValue)
				Exit Select
			Case BarcodeType.UPCE
				Dim upcEANInfo As UPCEANInfo = DirectCast(info, UPCEANInfo)
				AddBarcodeExtendedInformation("UPCE value", upcEANInfo.UPCEValue)
				Exit Select
			Case BarcodeType.Codabar
				Dim codabarInfo As CodabarInfo = DirectCast(info, CodabarInfo)
				AddBarcodeExtendedInformation("Start symbol", codabarInfo.StartSymbol)
				AddBarcodeExtendedInformation("Stop symbol", codabarInfo.StopSymbol)
				Exit Select
		End Select
	End Sub

	''' <summary>
	''' Diplays a barcode value items.
	''' </summary>
	Private Sub ShowBarcodeValueItems(info As IBarcodeInfo)
		valueItemsDataGridView.Rows.Clear()
		If info Is Nothing OrElse info.ValueItems Is Nothing Then
			Return
		End If
		Dim items As ValueItemBase() = info.ValueItems
		If InterpretEciCharacters Then
			items = EciCharacterDecoder.DecodeEciItems(items)
		End If
		For i As Integer = 0 To items.Length - 1
			Dim hexValue As String = ""
			If TypeOf items(i) Is BinaryValueItem Then
				hexValue = BytesToHex(DirectCast(items(i), BinaryValueItem).Value)
			ElseIf items(i).DataType = ValueItemDataType.NumericData OrElse items(i).DataType = ValueItemDataType.TextData Then
				hexValue = StringToHex(items(i).ToString(), 0)
			End If
			AddBarcodeValueItemInformation(i, GetValueItemType(items(i)), GetValueItemValue(items(i)), hexValue)
		Next
	End Sub

	''' <summary>
	''' Returns a value of specified barcode value item.
	''' </summary>
	Private Function GetValueItemValue(item As ValueItemBase) As String
		If TypeOf item Is AztecStructuredAppendCharacter Then
			Dim aztecStructureAppend As AztecStructuredAppendCharacter = DirectCast(item, AztecStructuredAppendCharacter)
			Return String.Format("{0} (Symbol {1} of {2}; MessageID=""{3}"")", item, aztecStructureAppend.SymbolPosition, aztecStructureAppend.SymbolCount, aztecStructureAppend.MessageID)
		End If
		If TypeOf item Is DataMatrixStructuredAppendCharacter Then
			Dim dmStructureAppend As DataMatrixStructuredAppendCharacter = DirectCast(item, DataMatrixStructuredAppendCharacter)
			Return String.Format("{0} (Symbol {1} of {2}; FileID={3})", item, dmStructureAppend.SymbolPosition, dmStructureAppend.SymbolCount, dmStructureAppend.FileID)
		End If
		If TypeOf item Is QRStructuredAppendCharacter Then
			Dim qrStructureAppend As QRStructuredAppendCharacter = DirectCast(item, QRStructuredAppendCharacter)
			Return String.Format("{0} (Symbol {1} of {2}; Parity data={3})", item, qrStructureAppend.SymbolPosition, qrStructureAppend.SymbolCount, qrStructureAppend.ParityData)
		End If
		If TypeOf item Is PDF417StructuredAppendCharacter Then
			Dim pdfStructureAppend As PDF417StructuredAppendCharacter = DirectCast(item, PDF417StructuredAppendCharacter)
			Dim sb As New StringBuilder()
			sb.AppendFormat("{0} (Symbol {1} of {2}; FileID={3}", item, pdfStructureAppend.SymbolPosition, pdfStructureAppend.SymbolCount, pdfStructureAppend.FileID)
			If pdfStructureAppend.Addressee IsNot Nothing Then
				sb.AppendFormat("; Addresse={0}", pdfStructureAppend.Addressee)
			End If
			If pdfStructureAppend.Checksum >= 0 Then
				sb.AppendFormat("; Checksum={0}", pdfStructureAppend.Checksum)
			End If
			If pdfStructureAppend.FileName IsNot Nothing Then
				sb.AppendFormat("; FileName={0}", pdfStructureAppend.FileName)
			End If
			If pdfStructureAppend.FileSize >= 0 Then
				sb.AppendFormat("; FileSize={0}", pdfStructureAppend.FileSize)
			End If
			If pdfStructureAppend.Sender IsNot Nothing Then
				sb.AppendFormat("; Sender={0}", pdfStructureAppend.Sender)
			End If
			If pdfStructureAppend.TimeStamp >= 0 Then
				sb.AppendFormat("; TimeStamp={0}", pdfStructureAppend.TimeStamp)
			End If
			sb.Append(")")
			Return sb.ToString()
		End If
		Return RemoveSpecialCharacters(item.ToString())
	End Function

	''' <summary>
	''' Returns a type of specified value item.
	''' </summary>
	Private Function GetValueItemType(item As ValueItemBase) As String
		If TypeOf item Is EciCharacterValueItem Then
			Return "ECI character"
		End If
		If TypeOf item Is MacroCharacter Then
			Return "Macro character"
		End If
		If TypeOf item Is StructuredAppendCharacter Then
			Return "Structured Append character"
		End If
		If TypeOf item Is DataMatrixTextValueItem Then
			Return DirectCast(item, DataMatrixTextValueItem).Mode.ToString()
		End If
		If TypeOf item Is IQRValueItem Then
			Return DirectCast(item, IQRValueItem).Mode.ToString()
		End If
		If TypeOf item Is Code128ValueItem Then
			Return DirectCast(item, Code128ValueItem).Mode.ToString()
		End If
		Return item.DataType.ToString()
	End Function

	''' <summary>
	''' Convers string to HEX representation.
	''' </summary>
	Private Function StringToHex(value As String, row As Integer) As String
		Dim result As New StringBuilder()
		For i As Integer = 0 To value.Length - 1
			Dim ch As Integer = AscW(value(i))
			Dim d As Integer = 2
			If CInt(ch) > 255 Then
				d = 4
			End If
			If row > 0 AndAlso i Mod row = 0 AndAlso i <> 0 Then
				result.Append(Environment.NewLine)
			End If
			result.Append(ch.ToString("X" & d.ToString()))
			result.Append(" "C)
		Next
		Return result.ToString()
	End Function

	''' <summary>
	''' Convers array of byte to HEX representation.
	''' </summary>
	Private Function BytesToHex(value As Byte()) As String
		Dim result As New StringBuilder()
		For i As Integer = 0 To value.Length - 1
			result.Append(value(i).ToString("X2"))
			result.Append(" "C)
		Next
		Return result.ToString()
	End Function

	''' <summary>
	''' Changes current barcode info index to secified index.
	''' </summary>
	''' <param name="index"></param>
	Private Sub MoveToBarcode(index As Integer)
		If _disableShowingValue OrElse _recognizedBarcodes Is Nothing OrElse index < 0 OrElse index >= _recognizedBarcodes.Length Then
			Return
		End If
		_barcodeInfoIndex = index
		ShowBarcodeInformation(_recognizedBarcodes(_barcodeInfoIndex))
	End Sub

    Private Sub barcodeValueAs_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles showNonDataFlagsCheckBox.CheckedChanged, barcodeValueAsTextRadioButton.CheckedChanged, barcodeValueAsHexRadioButton.CheckedChanged, barcodeValueAsBinaryRadioButton.CheckedChanged
        ShowBarcodeValue()
    End Sub

    Private Sub readerTextEncodingComboBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles readerTextEncodingComboBox.SelectedIndexChanged
        ShowBarcodeValue()
    End Sub

    Private Sub selectedBarcodeNumericUpDown_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles selectedBarcodeNumericUpDown.ValueChanged
        MoveToBarcode(CInt(Math.Truncate(selectedBarcodeNumericUpDown.Value)) - 1)
    End Sub

    Private Sub showGS1DecoderButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles showGS1DecoderButton.Click
        Try
            Dim info As GS1BarcodeInfo = DirectCast(_recognizedBarcodes(_barcodeInfoIndex), GS1BarcodeInfo)
            Dim gs1Viewer As New GS1ValueEditorForm(info.ApplicationIdentifierValues, True)
            gs1Viewer.ShowDialog()
            gs1Viewer.Dispose()
        Catch
            MessageBox.Show("GS1 decoding error.")
        End Try
    End Sub

    Private Sub ISO15415QualityTestButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ISO15415QualityTestButton.Click
        If _barcodeInfoIndex >= 0 Then
            Try
                Dim info As IBarcodeInfo = _recognizedBarcodes(_barcodeInfoIndex)
                If TypeOf info Is BarcodeSubsetInfo Then
                    info = DirectCast(info, BarcodeSubsetInfo).BaseBarcodeInfo
                End If
                Dim formQualityTest As New ISO15415QualityTestForm(DirectCast(info, BarcodeInfo2D), _barcodeImage, _invertBarcodeImage)
                formQualityTest.ShowDialog()
                formQualityTest.Dispose()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
        End If
    End Sub

    Private Sub ISO15416QualityTestButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ISO15416QualityTestButton.Click
        If _barcodeInfoIndex >= 0 Then
            Try
                Dim info As IBarcodeInfo = _recognizedBarcodes(_barcodeInfoIndex)
                If TypeOf info Is BarcodeSubsetInfo Then
                    info = DirectCast(info, BarcodeSubsetInfo).BaseBarcodeInfo
                End If
                Dim formQualityTest As New ISO15416QualityTestForm(DirectCast(info, BarcodeInfo1D), _barcodeImage, _invertBarcodeImage)
                formQualityTest.ShowDialog()
                formQualityTest.Dispose()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
        End If
    End Sub
	Private Shared Function InlineAssignHelper(Of T)(ByRef target As T, value As T) As T
		target = value
		Return value
	End Function

	#End Region

End Class
