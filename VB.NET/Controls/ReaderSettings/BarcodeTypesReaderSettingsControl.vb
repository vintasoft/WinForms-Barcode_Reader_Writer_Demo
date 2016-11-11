Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Collections.Generic

Imports Vintasoft.Barcode
Imports Vintasoft.Barcode.SymbologySubsets.RoyalMailMailmark
Imports Vintasoft.Barcode.SymbologySubsets
Imports Vintasoft.Barcode.SymbologySubsets.GS1
Imports Vintasoft.Barcode.SymbologySubsets.XFACompressed

''' <summary>
''' Editor control of ReaderSettings.ScanBarcodeTypes property.
''' </summary>
Public Partial Class BarcodeTypesReaderSettingsControl
	Inherits ReaderSettingsEditorControl

	#Region "Fields"

	Private _enableSetSettings As Boolean = True

	#End Region



	#Region "Constructors"

	Public Sub New()
		InitializeComponent()
	End Sub

	#End Region



	#Region "Properties"

	Private _showUnknownLinearSettings As Boolean = True
	<DefaultValue(True)> _
	Public Property ShowUnknownLinearSettings() As Boolean
		Get
			Return _showUnknownLinearSettings
		End Get
		Set
			_showUnknownLinearSettings = value
			If value Then
				linearTabControl.TabPages.Add(unknownLinearTabPage)
			Else
				linearTabControl.TabPages.Remove(unknownLinearTabPage)
			End If
		End Set
	End Property

	Private _highlightOptionalChecksumBarcodes As Boolean = False
	<DefaultValue(False)> _
	Public Property HighlightOptionalChecksumBarcodes() As Boolean
		Get
			Return _highlightOptionalChecksumBarcodes
		End Get
		Set
			_highlightOptionalChecksumBarcodes = value
			Dim foreColor As Color
			If value Then
				foreColor = Color.Red
			Else
				foreColor = Color.Black
			End If
			barcodeI25CheckBox.ForeColor = foreColor
			barcodeS25CheckBox.ForeColor = foreColor
			barcodeCode39CheckBox.ForeColor = foreColor
			barcodeMatrix2of5CheckBox.ForeColor = foreColor
		End Set
	End Property

	#End Region



	#Region "Methods"

    Private Sub barcodeTypesAllOrClear_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button5.Click, button4.Click, button3.Click, button2.Click, button1.Click
        _enableSetSettings = False
        Dim controls As ControlCollection = DirectCast(DirectCast(sender, Button).Parent, TabPage).Controls
        Dim value As Boolean = False
        For Each c As Control In controls
            If TypeOf c Is CheckBox Then
                value = Not TryCast(c, CheckBox).Checked
                Exit For
            End If
        Next
        For Each c As Control In controls
            If TypeOf c Is CheckBox Then
                TryCast(c, CheckBox).Checked = value
            End If
        Next
        _enableSetSettings = True
        SetSettings()
    End Sub

    Private Sub barcodeTypeCheckBox_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles unknownLinearMinScanlinesNumericUpDown.ValueChanged, unknownLinearMinBarsNumericUpDown.ValueChanged, unknownLinearMaxBarWideNumericUpDown.ValueChanged, unknownLinearMaxBarsNumericUpDown.ValueChanged, barcodeXFACompressedQRCheckBox.CheckedChanged, barcodeXFACompressedPDF417CheckBox.CheckedChanged, barcodeXFACompressedDataMatrixCheckBox.CheckedChanged, barcodeXFACompressedAztecCheckBox.CheckedChanged, barcodeVinCheckBox.CheckedChanged, barcodeVicsScacProCheckBox.CheckedChanged, barcodeVicsBolCheckBox.CheckedChanged, barcodeUPCECheckBox.CheckedChanged, barcodeUPCACheckBox.CheckedChanged, barcodeUnknownLinearCheckBox.CheckedChanged, barcodeTelepenCheckBox.CheckedChanged, barcodeSwissPostParcelCheckBox.CheckedChanged, barcodeSscc18CheckBox.CheckedChanged, barcodeS25CheckBox.CheckedChanged, barcodeRSSLimitedCheckBox.CheckedChanged, barcodeRSSExpandedStackedCheckBox.CheckedChanged, barcodeRSSExpandedCheckBox.CheckedChanged, barcodeRSS14StackedCheckBox.CheckedChanged, barcodeRSS14CheckBox.CheckedChanged, barcodeRoyalMailCheckBox.CheckedChanged, barcodeQRCheckBox.CheckedChanged, barcodePznCheckBox.CheckedChanged, barcodePpnCheckBox.CheckedChanged, barcodePostnetCheckBox.CheckedChanged, barcodePlus5CheckBox.CheckedChanged, barcodePlus2CheckBox.CheckedChanged, barcodePlanetCheckBox.CheckedChanged, barcodePharmacodeCheckBox.CheckedChanged, barcodePDF417CheckBox.CheckedChanged, barcodePatchCodeCheckBox.CheckedChanged, barcodeOpcCheckBox.CheckedChanged, barcodeNumlyNumberCheckBox.CheckedChanged, barcodeMSICheckBox.CheckedChanged, barcodeMicroQRCheckBox.CheckedChanged, barcodeMicroPDF417CheckBox.CheckedChanged, barcodeMaxicodeCheckBox.CheckedChanged, barcodeMatrix2of5CheckBox.CheckedChanged, barcodeMailmarkCmdmType9CheckBox.CheckedChanged, barcodeMailmarkCmdmType7CheckBox.CheckedChanged, barcodeMailmarkCmdmType29CheckBox.CheckedChanged, barcodeMailmark4LCheckBox.CheckedChanged, barcodeMailmark4CCheckBox.CheckedChanged, barcodeJan8CheckBox.CheckedChanged, barcodeJan13CheckBox.CheckedChanged, barcodeItf14CheckBox.CheckedChanged, barcodeIssnCheckBox.CheckedChanged, barcodeIsmnCheckBox.CheckedChanged, barcodeIsbnCheckBox.CheckedChanged, barcodeIntelligentMailCheckBox.CheckedChanged, barcodeIata2of5CheckBox.CheckedChanged, barcodeI25CheckBox.CheckedChanged, barcodeHanXinCodeCheckBox.CheckedChanged, barcodeGs1QRCheckbox.CheckedChanged, barcodeGs1DataMatrixCheckBox.CheckedChanged, barcodeGs1DataBarStackedCheckBox.CheckedChanged, barcodeGs1DataBarLimitedCheckBox.CheckedChanged, barcodeGs1DataBarExpandedStackedCheckBox.CheckedChanged, barcodeGs1DataBarExpandedCheckBox.CheckedChanged, barcodeGs1DataBarCheckBox.CheckedChanged, barcodeGs1AztecCheckBox.CheckedChanged, barcodeGs1_128CheckBox.CheckedChanged, barcodeFedExGround96CheckBox.CheckedChanged, barcodeEanVelocityCheckBox.CheckedChanged, barcodeEAN8CheckBox.CheckedChanged, barcodeEAN13CheckBox.CheckedChanged, barcodeDutchKIXCheckBox.CheckedChanged, barcodeDhlAwbCheckBox.CheckedChanged, barcodeDeutschePostLeitcodeCheckBox.CheckedChanged, barcodeDeutschePostIdentcodeCheckBox.CheckedChanged, barcodeDataMatrixCheckBox.CheckedChanged, barcodeCode93CheckBox.CheckedChanged, barcodeCode39ExtendedCheckBox.CheckedChanged, barcodeCode39CheckBox.CheckedChanged, barcodeCode32CheckBox.CheckedChanged, barcodeCode16KCheckBox.CheckedChanged, barcodeCode128CheckBox.CheckedChanged, barcodeCode11CheckBox.CheckedChanged, barcodeCodabarCheckBox.CheckedChanged, barcodeAztecCheckBox.CheckedChanged, barcodeAustraliaPostCheckBox.CheckedChanged
        SetSettings()
    End Sub

	Private Sub unknownLinearNumericUpDown_ValueChanged(sender As Object, e As EventArgs)
		SetSettings()
	End Sub


	''' <summary>
	''' Updates the UI.
	''' </summary>
	Public Overrides Sub UpdateUI()
		_enableSetSettings = False

		' barcode types
		Dim scanBarcodeTypes As BarcodeType = BarcodeReaderSettings.ScanBarcodeTypes
		barcodeCode11CheckBox.Checked = (scanBarcodeTypes And BarcodeType.Code11) <> 0
		barcodeMSICheckBox.Checked = (scanBarcodeTypes And BarcodeType.MSI) <> 0
		barcodeCode39CheckBox.Checked = (scanBarcodeTypes And BarcodeType.Code39) <> 0
		barcodeCode93CheckBox.Checked = (scanBarcodeTypes And BarcodeType.Code93) <> 0
		barcodeCode128CheckBox.Checked = (scanBarcodeTypes And BarcodeType.Code128) <> 0
		barcodeCode16KCheckBox.Checked = (scanBarcodeTypes And BarcodeType.Code16K) <> 0
		barcodeCodabarCheckBox.Checked = (scanBarcodeTypes And BarcodeType.Codabar) <> 0
		barcodeEAN13CheckBox.Checked = (scanBarcodeTypes And BarcodeType.EAN13) <> 0
		barcodeEAN8CheckBox.Checked = (scanBarcodeTypes And BarcodeType.EAN8) <> 0
		barcodePlus5CheckBox.Checked = (scanBarcodeTypes And BarcodeType.Plus5) <> 0
		barcodePlus2CheckBox.Checked = (scanBarcodeTypes And BarcodeType.Plus2) <> 0
		barcodeI25CheckBox.Checked = (scanBarcodeTypes And BarcodeType.Interleaved2of5) <> 0
		barcodeS25CheckBox.Checked = (scanBarcodeTypes And BarcodeType.Standard2of5) <> 0
		barcodeIata2of5CheckBox.Checked = (scanBarcodeTypes And BarcodeType.IATA2of5) <> 0
		barcodeMatrix2of5CheckBox.Checked = (scanBarcodeTypes And BarcodeType.Matrix2of5) <> 0
		barcodeUPCACheckBox.Checked = (scanBarcodeTypes And BarcodeType.UPCA) <> 0
		barcodeUPCECheckBox.Checked = (scanBarcodeTypes And BarcodeType.UPCE) <> 0
		barcodeAustraliaPostCheckBox.Checked = (scanBarcodeTypes And BarcodeType.AustralianPost) <> 0
		barcodeTelepenCheckBox.Checked = (scanBarcodeTypes And BarcodeType.Telepen) <> 0
		barcodePlanetCheckBox.Checked = (scanBarcodeTypes And BarcodeType.Planet) <> 0
		barcodeIntelligentMailCheckBox.Checked = (scanBarcodeTypes And BarcodeType.IntelligentMail) <> 0
		barcodePostnetCheckBox.Checked = (scanBarcodeTypes And BarcodeType.Postnet) <> 0
		barcodeRoyalMailCheckBox.Checked = (scanBarcodeTypes And BarcodeType.RoyalMail) <> 0
		barcodeDutchKIXCheckBox.Checked = (scanBarcodeTypes And BarcodeType.DutchKIX) <> 0
		barcodePatchCodeCheckBox.Checked = (scanBarcodeTypes And BarcodeType.PatchCode) <> 0
		barcodePDF417CheckBox.Checked = ((scanBarcodeTypes And BarcodeType.PDF417) <> 0) OrElse ((scanBarcodeTypes And BarcodeType.PDF417Compact) <> 0)
		barcodeMicroPDF417CheckBox.Checked = (scanBarcodeTypes And BarcodeType.MicroPDF417) <> 0
		barcodeDataMatrixCheckBox.Checked = (scanBarcodeTypes And BarcodeType.DataMatrix) <> 0
		barcodeQRCheckBox.Checked = (scanBarcodeTypes And BarcodeType.QR) <> 0
		barcodeMicroQRCheckBox.Checked = (scanBarcodeTypes And BarcodeType.MicroQR) <> 0
		barcodeMaxicodeCheckBox.Checked = (scanBarcodeTypes And BarcodeType.MaxiCode) <> 0
		barcodeRSS14CheckBox.Checked = (scanBarcodeTypes And BarcodeType.RSS14) <> 0
		barcodeRSSLimitedCheckBox.Checked = (scanBarcodeTypes And BarcodeType.RSSLimited) <> 0
		barcodeRSSExpandedCheckBox.Checked = (scanBarcodeTypes And BarcodeType.RSSExpanded) <> 0
		barcodeRSS14StackedCheckBox.Checked = (scanBarcodeTypes And BarcodeType.RSS14Stacked) <> 0
		barcodeRSSExpandedStackedCheckBox.Checked = (scanBarcodeTypes And BarcodeType.RSSExpandedStacked) <> 0
		barcodeAztecCheckBox.Checked = (scanBarcodeTypes And BarcodeType.Aztec) <> 0
		barcodePharmacodeCheckBox.Checked = (scanBarcodeTypes And BarcodeType.Pharmacode) <> 0
		barcodeUnknownLinearCheckBox.Checked = (scanBarcodeTypes And BarcodeType.UnknownLinear) <> 0
		barcodeMailmark4CCheckBox.Checked = (scanBarcodeTypes And BarcodeType.Mailmark4StateC) <> 0
		barcodeMailmark4LCheckBox.Checked = (scanBarcodeTypes And BarcodeType.Mailmark4StateL) <> 0
		barcodeHanXinCodeCheckBox.Checked = (scanBarcodeTypes And BarcodeType.HanXinCode) <> 0

		' barcode subsets
		barcodeGs1_128CheckBox.Checked = False
		barcodeGs1DataBarCheckBox.Checked = False
		barcodeGs1DataBarExpandedCheckBox.Checked = False
		barcodeGs1DataBarExpandedStackedCheckBox.Checked = False
		barcodeGs1DataBarLimitedCheckBox.Checked = False
		barcodeGs1DataBarStackedCheckBox.Checked = False
		barcodeGs1QRCheckbox.Checked = False
		barcodeGs1DataMatrixCheckBox.Checked = False
		barcodeGs1AztecCheckBox.Checked = False
		barcodeMailmarkCmdmType7CheckBox.Checked = False
		barcodeMailmarkCmdmType9CheckBox.Checked = False
		barcodeMailmarkCmdmType29CheckBox.Checked = False
		For Each subset As BarcodeSymbologySubset In BarcodeReaderSettings.ScanBarcodeSubsets
			If TypeOf subset Is GS1_128BarcodeSymbology Then
				barcodeGs1_128CheckBox.Checked = True
			End If
			If TypeOf subset Is GS1DataBarBarcodeSymbology Then
				barcodeGs1DataBarCheckBox.Checked = True
			End If
			If TypeOf subset Is GS1DataBarExpandedBarcodeSymbology Then
				barcodeGs1DataBarExpandedCheckBox.Checked = True
			End If
			If TypeOf subset Is GS1DataBarExpandedStackedBarcodeSymbology Then
				barcodeGs1DataBarExpandedStackedCheckBox.Checked = True
			End If
			If TypeOf subset Is GS1DataBarLimitedBarcodeSymbology Then
				barcodeGs1DataBarLimitedCheckBox.Checked = True
			End If
			If TypeOf subset Is GS1DataBarStackedBarcodeSymbology Then
				barcodeGs1DataBarStackedCheckBox.Checked = True
			End If
			If TypeOf subset Is GS1QRBarcodeSymbology Then
				barcodeGs1QRCheckbox.Checked = True
			End If
			If TypeOf subset Is GS1DataMatrixBarcodeSymbology Then
				barcodeGs1DataMatrixCheckBox.Checked = True
			End If
			If TypeOf subset Is GS1AztecBarcodeSymbology Then
				barcodeGs1AztecCheckBox.Checked = True
			End If
			If TypeOf subset Is MailmarkCmdmType7BarcodeSymbology Then
				barcodeMailmarkCmdmType7CheckBox.Checked = True
			End If
			If TypeOf subset Is MailmarkCmdmType9BarcodeSymbology Then
				barcodeMailmarkCmdmType9CheckBox.Checked = True
			End If
			If TypeOf subset Is MailmarkCmdmType29BarcodeSymbology Then
				barcodeMailmarkCmdmType29CheckBox.Checked = True
			End If
			If TypeOf subset Is Code32BarcodeSymbology Then
				barcodeCode32CheckBox.Checked = True
			End If
			If TypeOf subset Is VinSymbology Then
				barcodeVinCheckBox.Checked = True
			End If
			If TypeOf subset Is PznBarcodeSymbology Then
				barcodePznCheckBox.Checked = True
			End If
			If TypeOf subset Is Code39ExtendedBarcodeSymbology Then
				barcodeCode39ExtendedCheckBox.Checked = True
			End If
			If TypeOf subset Is OpcBarcodeSymbology Then
				barcodeOpcCheckBox.Checked = True
			End If
			If TypeOf subset Is Itf14BarcodeSymbology Then
				barcodeItf14CheckBox.Checked = True
			End If
			If TypeOf subset Is DeutschePostIdentcodeBarcodeSymbology Then
				barcodeDeutschePostIdentcodeCheckBox.Checked = True
			End If
			If TypeOf subset Is DeutschePostLeitcodeBarcodeSymbology Then
				barcodeDeutschePostLeitcodeCheckBox.Checked = True
			End If
			If TypeOf subset Is Sscc18BarcodeSymbology Then
				barcodeSscc18CheckBox.Checked = True
			End If
			If TypeOf subset Is Jan13BarcodeSymbology Then
				barcodeJan13CheckBox.Checked = True
			End If
			If TypeOf subset Is Jan8BarcodeSymbology Then
				barcodeJan8CheckBox.Checked = True
			End If
			If TypeOf subset Is Jan13Plus5BarcodeSymbology Then
				barcodeJan13CheckBox.Checked = True
				barcodePlus5CheckBox.Checked = True
			End If
			If TypeOf subset Is Jan13Plus2BarcodeSymbology Then
				barcodeJan13CheckBox.Checked = True
				barcodePlus2CheckBox.Checked = True
			End If
			If TypeOf subset Is Jan8BarcodeSymbology Then
				barcodeJan8CheckBox.Checked = True
			End If
			If TypeOf subset Is Jan8Plus5BarcodeSymbology Then
				barcodeJan8CheckBox.Checked = True
				barcodePlus5CheckBox.Checked = True
			End If
			If TypeOf subset Is Jan8Plus2BarcodeSymbology Then
				barcodeJan8CheckBox.Checked = True
				barcodePlus2CheckBox.Checked = True
			End If
			If TypeOf subset Is IsbnBarcodeSymbology Then
				barcodeIsbnCheckBox.Checked = True
			End If
			If TypeOf subset Is IsbnPlus2BarcodeSymbology Then
				barcodeIsbnCheckBox.Checked = True
				barcodePlus2CheckBox.Checked = True
			End If
			If TypeOf subset Is IsbnPlus5BarcodeSymbology Then
				barcodeIsbnCheckBox.Checked = True
				barcodePlus5CheckBox.Checked = True
			End If
			If TypeOf subset Is IsmnBarcodeSymbology Then
				barcodeIsmnCheckBox.Checked = True
			End If
			If TypeOf subset Is IsmnPlus2BarcodeSymbology Then
				barcodeIsmnCheckBox.Checked = True
				barcodePlus2CheckBox.Checked = True
			End If
			If TypeOf subset Is IsmnPlus5BarcodeSymbology Then
				barcodeIsmnCheckBox.Checked = True
				barcodePlus5CheckBox.Checked = True
			End If
			If TypeOf subset Is IssnBarcodeSymbology Then
				barcodeIssnCheckBox.Checked = True
			End If
			If TypeOf subset Is IssnPlus2BarcodeSymbology Then
				barcodeIssnCheckBox.Checked = True
				barcodePlus2CheckBox.Checked = True
			End If
			If TypeOf subset Is IssnPlus5BarcodeSymbology Then
				barcodeIssnCheckBox.Checked = True
				barcodePlus5CheckBox.Checked = True
			End If
			If TypeOf subset Is SwissPostParcelBarcodeSymbology Then
				barcodeSwissPostParcelCheckBox.Checked = True
			End If
			If TypeOf subset Is PpnBarcodeSymbology Then
				barcodePpnCheckBox.Checked = True
			End If
			If TypeOf subset Is EanVelocityBarcodeSymbology Then
				barcodeEanVelocityCheckBox.Checked = True
			End If
			If TypeOf subset Is NumlyNumberBarcodeSymbology Then
				barcodeNumlyNumberCheckBox.Checked = True
			End If
			If TypeOf subset Is FedExGround96BarcodeSymbology Then
				barcodeFedExGround96CheckBox.Checked = True
			End If
			If TypeOf subset Is VicsBolBarcodeSymbology Then
				barcodeVicsBolCheckBox.Checked = True
			End If
			If TypeOf subset Is VicsScacProBarcodeSymbology Then
				barcodeVicsScacProCheckBox.Checked = True
			End If
			If TypeOf subset Is DhlAwbBarcodeSymbology Then
				barcodeDhlAwbCheckBox.Checked = True
			End If
			If TypeOf subset Is XFACompressedAztecBarcodeSymbology Then
				barcodeXFACompressedAztecCheckBox.Checked = True
			End If
			If TypeOf subset Is XFACompressedDataMatrixBarcodeSymbology Then
				barcodeXFACompressedDataMatrixCheckBox.Checked = True
			End If
			If TypeOf subset Is XFACompressedPDF417BarcodeSymbology Then
				barcodeXFACompressedPDF417CheckBox.Checked = True
			End If
			If TypeOf subset Is XFACompressedQRCodeBarcodeSymbology Then
				barcodeXFACompressedQRCheckBox.Checked = True
			End If
		Next

		unknownLinearMaxBarsNumericUpDown.Value = BarcodeReaderSettings.UnknownLinearMaxBars
		unknownLinearMinBarsNumericUpDown.Value = BarcodeReaderSettings.UnknownLinearMinBars
		unknownLinearMaxBarWideNumericUpDown.Value = BarcodeReaderSettings.UnknownLinearMaxBarWide
		unknownLinearMinScanlinesNumericUpDown.Value = BarcodeReaderSettings.UnknownLinearMinScanlines

		_enableSetSettings = True
	End Sub

	Private Sub SetSettings()
		If Not _enableSetSettings Then
			Return
		End If

		Dim scanBarcodeTypes As BarcodeType = BarcodeType.None
		If barcodeCode11CheckBox.Checked Then
			scanBarcodeTypes = scanBarcodeTypes Or BarcodeType.Code11
		End If
		If barcodeMSICheckBox.Checked Then
			scanBarcodeTypes = scanBarcodeTypes Or BarcodeType.MSI
		End If
		If barcodeCode39CheckBox.Checked Then
			scanBarcodeTypes = scanBarcodeTypes Or BarcodeType.Code39
		End If
		If barcodeCode93CheckBox.Checked Then
			scanBarcodeTypes = scanBarcodeTypes Or BarcodeType.Code93
		End If
		If barcodeCode128CheckBox.Checked Then
			scanBarcodeTypes = scanBarcodeTypes Or BarcodeType.Code128
		End If
		If barcodeCode16KCheckBox.Checked Then
			scanBarcodeTypes = scanBarcodeTypes Or BarcodeType.Code16K
		End If
		If barcodeCodabarCheckBox.Checked Then
			scanBarcodeTypes = scanBarcodeTypes Or BarcodeType.Codabar
		End If
		If barcodeEAN13CheckBox.Checked Then
			scanBarcodeTypes = scanBarcodeTypes Or BarcodeType.EAN13
		End If
		If barcodeEAN8CheckBox.Checked Then
			scanBarcodeTypes = scanBarcodeTypes Or BarcodeType.EAN8
		End If
		If barcodePlus5CheckBox.Checked Then
			scanBarcodeTypes = scanBarcodeTypes Or BarcodeType.Plus5
		End If
		If barcodePlus2CheckBox.Checked Then
			scanBarcodeTypes = scanBarcodeTypes Or BarcodeType.Plus2
		End If
		If barcodeI25CheckBox.Checked Then
			scanBarcodeTypes = scanBarcodeTypes Or BarcodeType.Interleaved2of5
		End If
		If barcodeS25CheckBox.Checked Then
			scanBarcodeTypes = scanBarcodeTypes Or BarcodeType.Standard2of5
		End If
		If barcodeIata2of5CheckBox.Checked Then
			scanBarcodeTypes = scanBarcodeTypes Or BarcodeType.IATA2of5
		End If
		If barcodeMatrix2of5CheckBox.Checked Then
			scanBarcodeTypes = scanBarcodeTypes Or BarcodeType.Matrix2of5
		End If
		If barcodeUPCACheckBox.Checked Then
			scanBarcodeTypes = scanBarcodeTypes Or BarcodeType.UPCA
		End If
		If barcodeUPCECheckBox.Checked Then
			scanBarcodeTypes = scanBarcodeTypes Or BarcodeType.UPCE
		End If
		If barcodeTelepenCheckBox.Checked Then
			scanBarcodeTypes = scanBarcodeTypes Or BarcodeType.Telepen
		End If
		If barcodeUnknownLinearCheckBox.Checked Then
			scanBarcodeTypes = scanBarcodeTypes Or BarcodeType.UnknownLinear
		End If
		If barcodePlanetCheckBox.Checked Then
			scanBarcodeTypes = scanBarcodeTypes Or BarcodeType.Planet
		End If
		If barcodeIntelligentMailCheckBox.Checked Then
			scanBarcodeTypes = scanBarcodeTypes Or BarcodeType.IntelligentMail
		End If
		If barcodePostnetCheckBox.Checked Then
			scanBarcodeTypes = scanBarcodeTypes Or BarcodeType.Postnet
		End If
		If barcodeRoyalMailCheckBox.Checked Then
			scanBarcodeTypes = scanBarcodeTypes Or BarcodeType.RoyalMail
		End If
		If barcodeDutchKIXCheckBox.Checked Then
			scanBarcodeTypes = scanBarcodeTypes Or BarcodeType.DutchKIX
		End If
		If barcodePatchCodeCheckBox.Checked Then
			scanBarcodeTypes = scanBarcodeTypes Or BarcodeType.PatchCode
		End If
		If barcodePharmacodeCheckBox.Checked Then
			scanBarcodeTypes = scanBarcodeTypes Or BarcodeType.Pharmacode
		End If
		If barcodePDF417CheckBox.Checked Then
			scanBarcodeTypes = scanBarcodeTypes Or BarcodeType.PDF417 Or BarcodeType.PDF417Compact
		End If
		If barcodeMicroPDF417CheckBox.Checked Then
			scanBarcodeTypes = scanBarcodeTypes Or BarcodeType.MicroPDF417
		End If
		If barcodeDataMatrixCheckBox.Checked Then
			scanBarcodeTypes = scanBarcodeTypes Or BarcodeType.DataMatrix
		End If
		If barcodeQRCheckBox.Checked Then
			scanBarcodeTypes = scanBarcodeTypes Or BarcodeType.QR
		End If
		If barcodeMicroQRCheckBox.Checked Then
			scanBarcodeTypes = scanBarcodeTypes Or BarcodeType.MicroQR
		End If
		If barcodeMaxicodeCheckBox.Checked Then
			scanBarcodeTypes = scanBarcodeTypes Or BarcodeType.MaxiCode
		End If
		If barcodeRSS14CheckBox.Checked Then
			scanBarcodeTypes = scanBarcodeTypes Or BarcodeType.RSS14
		End If
		If barcodeRSSLimitedCheckBox.Checked Then
			scanBarcodeTypes = scanBarcodeTypes Or BarcodeType.RSSLimited
		End If
		If barcodeRSSExpandedCheckBox.Checked Then
			scanBarcodeTypes = scanBarcodeTypes Or BarcodeType.RSSExpanded
		End If
		If barcodeRSSExpandedStackedCheckBox.Checked Then
			scanBarcodeTypes = scanBarcodeTypes Or BarcodeType.RSSExpandedStacked
		End If
		If barcodeRSS14StackedCheckBox.Checked Then
			scanBarcodeTypes = scanBarcodeTypes Or BarcodeType.RSS14Stacked
		End If
		If barcodeAztecCheckBox.Checked Then
			scanBarcodeTypes = scanBarcodeTypes Or BarcodeType.Aztec
		End If
		If barcodeRSS14StackedCheckBox.Checked Then
			scanBarcodeTypes = scanBarcodeTypes Or BarcodeType.RSS14Stacked
		End If
		If barcodeAustraliaPostCheckBox.Checked Then
			scanBarcodeTypes = scanBarcodeTypes Or BarcodeType.AustralianPost
		End If
		If barcodeMailmark4CCheckBox.Checked Then
			scanBarcodeTypes = scanBarcodeTypes Or BarcodeType.Mailmark4StateC
		End If
		If barcodeMailmark4LCheckBox.Checked Then
			scanBarcodeTypes = scanBarcodeTypes Or BarcodeType.Mailmark4StateL
		End If
		If barcodeHanXinCodeCheckBox.Checked Then
			scanBarcodeTypes = scanBarcodeTypes Or BarcodeType.HanXinCode
		End If

		BarcodeReaderSettings.ScanBarcodeTypes = scanBarcodeTypes

		BarcodeReaderSettings.ScanBarcodeSubsets.Clear()
		If barcodeGs1_128CheckBox.Checked Then
			BarcodeReaderSettings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.GS1_128)
		End If
		If barcodeGs1DataBarCheckBox.Checked Then
			BarcodeReaderSettings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.GS1DataBar)
		End If
		If barcodeGs1DataBarExpandedCheckBox.Checked Then
			BarcodeReaderSettings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.GS1DataBarExpanded)
		End If
		If barcodeGs1DataBarExpandedStackedCheckBox.Checked Then
			BarcodeReaderSettings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.GS1DataBarExpandedStacked)
		End If
		If barcodeGs1DataBarLimitedCheckBox.Checked Then
			BarcodeReaderSettings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.GS1DataBarLimited)
		End If
		If barcodeGs1DataBarStackedCheckBox.Checked Then
			BarcodeReaderSettings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.GS1DataBarStacked)
		End If
		If barcodeGs1QRCheckbox.Checked Then
			BarcodeReaderSettings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.GS1QR)
		End If
		If barcodeGs1DataMatrixCheckBox.Checked Then
			BarcodeReaderSettings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.GS1DataMatrix)
		End If
		If barcodeGs1AztecCheckBox.Checked Then
			BarcodeReaderSettings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.GS1Aztec)
		End If
		If barcodeMailmarkCmdmType7CheckBox.Checked Then
			BarcodeReaderSettings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.MailmarkCmdmType7)
		End If
		If barcodeMailmarkCmdmType9CheckBox.Checked Then
			BarcodeReaderSettings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.MailmarkCmdmType9)
		End If
		If barcodeMailmarkCmdmType29CheckBox.Checked Then
			BarcodeReaderSettings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.MailmarkCmdmType29)
		End If
		If barcodeCode32CheckBox.Checked Then
			BarcodeReaderSettings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.Code32)
		End If
		If barcodeVinCheckBox.Checked Then
			BarcodeReaderSettings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.VIN)
		End If
		If barcodePznCheckBox.Checked Then
			BarcodeReaderSettings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.PZN)
		End If
		If barcodeCode39ExtendedCheckBox.Checked Then
			BarcodeReaderSettings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.Code39Extended)
		End If
		If barcodeOpcCheckBox.Checked Then
			BarcodeReaderSettings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.OPC)
		End If
		If barcodeItf14CheckBox.Checked Then
			BarcodeReaderSettings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.ITF14)
		End If
		If barcodeDeutschePostIdentcodeCheckBox.Checked Then
			BarcodeReaderSettings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.DeutschePostIdentcode)
		End If
		If barcodeDeutschePostLeitcodeCheckBox.Checked Then
			BarcodeReaderSettings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.DeutschePostLeitcode)
		End If
		If barcodeSscc18CheckBox.Checked Then
			BarcodeReaderSettings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.SSCC18)
		End If
		If barcodeJan13CheckBox.Checked Then
			BarcodeReaderSettings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.JAN13)
			If (scanBarcodeTypes And BarcodeType.Plus5) <> 0 Then
				BarcodeReaderSettings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.JAN13Plus5)
			End If
			If (scanBarcodeTypes And BarcodeType.Plus2) <> 0 Then
				BarcodeReaderSettings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.JAN13Plus2)
			End If
		End If
		If barcodeJan8CheckBox.Checked Then
			BarcodeReaderSettings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.JAN8)
			If (scanBarcodeTypes And BarcodeType.Plus5) <> 0 Then
				BarcodeReaderSettings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.JAN8Plus5)
			End If
			If (scanBarcodeTypes And BarcodeType.Plus2) <> 0 Then
				BarcodeReaderSettings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.JAN8Plus2)
			End If
		End If
		If barcodeIsbnCheckBox.Checked Then
			BarcodeReaderSettings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.ISBN)
			If (scanBarcodeTypes And BarcodeType.Plus5) <> 0 Then
				BarcodeReaderSettings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.ISBNPlus5)
			End If
			If (scanBarcodeTypes And BarcodeType.Plus2) <> 0 Then
				BarcodeReaderSettings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.ISBNPlus2)
			End If
		End If
		If barcodeIsmnCheckBox.Checked Then
			BarcodeReaderSettings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.ISMN)
			If (scanBarcodeTypes And BarcodeType.Plus5) <> 0 Then
				BarcodeReaderSettings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.ISMNPlus5)
			End If
			If (scanBarcodeTypes And BarcodeType.Plus2) <> 0 Then
				BarcodeReaderSettings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.ISMNPlus2)
			End If
		End If
		If barcodeIssnCheckBox.Checked Then
			BarcodeReaderSettings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.ISSN)
			If (scanBarcodeTypes And BarcodeType.Plus5) <> 0 Then
				BarcodeReaderSettings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.ISSNPlus5)
			End If
			If (scanBarcodeTypes And BarcodeType.Plus2) <> 0 Then
				BarcodeReaderSettings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.ISSNPlus2)
			End If
		End If
		If barcodeSwissPostParcelCheckBox.Checked Then
			BarcodeReaderSettings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.SwissPostParcel)
		End If
		If barcodePpnCheckBox.Checked Then
			BarcodeReaderSettings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.PPN)
		End If
		If barcodeEanVelocityCheckBox.Checked Then
			BarcodeReaderSettings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.EANVelocity)
		End If
		If barcodeNumlyNumberCheckBox.Checked Then
			BarcodeReaderSettings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.NumlyNumber)
		End If
		If barcodeFedExGround96CheckBox.Checked Then
			BarcodeReaderSettings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.FedExGround96)
		End If
		If barcodeVicsBolCheckBox.Checked Then
			BarcodeReaderSettings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.VicsBol)
		End If
		If barcodeVicsScacProCheckBox.Checked Then
			BarcodeReaderSettings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.VicsScacPro)
		End If
		If barcodeDhlAwbCheckBox.Checked Then
			BarcodeReaderSettings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.DhlAwb)
		End If
		If barcodeXFACompressedAztecCheckBox.Checked Then
			BarcodeReaderSettings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.XFACompressedAztec)
		End If
		If barcodeXFACompressedDataMatrixCheckBox.Checked Then
			BarcodeReaderSettings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.XFACompressedDataMatrix)
		End If
		If barcodeXFACompressedPDF417CheckBox.Checked Then
			BarcodeReaderSettings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.XFACompressedPDF417)
		End If
		If barcodeXFACompressedQRCheckBox.Checked Then
			BarcodeReaderSettings.ScanBarcodeSubsets.Add(BarcodeSymbologySubsets.XFACompressedQRCode)
		End If

		BarcodeReaderSettings.UnknownLinearMaxBars = CInt(Math.Truncate(unknownLinearMaxBarsNumericUpDown.Value))
		BarcodeReaderSettings.UnknownLinearMinBars = CInt(Math.Truncate(unknownLinearMinBarsNumericUpDown.Value))
		BarcodeReaderSettings.UnknownLinearMaxBarWide = CInt(Math.Truncate(unknownLinearMaxBarWideNumericUpDown.Value))
		BarcodeReaderSettings.UnknownLinearMinScanlines = CInt(Math.Truncate(unknownLinearMinScanlinesNumericUpDown.Value))


		OnSettingsChanged()
	End Sub

	Private Sub OnSettingsChanged()
		RaiseEvent SettingsChanged(Me, EventArgs.Empty)
	End Sub

	#End Region



	#Region "Events"

	Public Event SettingsChanged As EventHandler

	#End Region


End Class
