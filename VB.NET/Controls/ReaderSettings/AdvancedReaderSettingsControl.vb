Imports System.ComponentModel
Imports System.Windows.Forms

Imports Vintasoft.Barcode
Imports Vintasoft.Barcode.BarcodeInfo
Imports System.Drawing

''' <summary>
''' Represents an editor control of advanced reader settings.
''' </summary>
Public Partial Class AdvancedReaderSettingsControl
	Inherits ReaderSettingsEditorControl

	#Region "Fields"

	Private _enableSetSettings As Boolean = True

	#End Region



	#Region "Constructors"

	Public Sub New()
		InitializeComponent()

		barcodeReaderAustralianCustomInfoComboBox.Items.AddRange(EnumGetValues(GetType(AustralianPostCustomerInfoFormat)))

		barcodeReaderMSIChecksumComboBox.Items.Add(MSIChecksumType.Mod10)
		barcodeReaderMSIChecksumComboBox.Items.Add(MSIChecksumType.Mod11)
		barcodeReaderMSIChecksumComboBox.Items.Add(MSIChecksumType.Mod10Mod10)
		barcodeReaderMSIChecksumComboBox.Items.Add(MSIChecksumType.Mod11Mod10)
		barcodeReaderMSIChecksumComboBox.Items.Add(MSIChecksumType.None)
	End Sub


	#End Region



	#Region "Properties"

	Private _barcodeTypesReaderSettings As BarcodeTypesReaderSettingsControl = Nothing
	Public Property BarcodeTypesReaderSettings() As BarcodeTypesReaderSettingsControl
        Get
            Return _barcodeTypesReaderSettings
        End Get
        Set(ByVal value As BarcodeTypesReaderSettingsControl)
            _barcodeTypesReaderSettings = Value
            UpdateUI()
        End Set
    End Property

	Public Property InterpretEciCharacters() As Boolean
		Get
			Return interpretEciCharactersCheckBox.Checked
		End Get
		Set
			interpretEciCharactersCheckBox.Checked = value
		End Set
	End Property

	#End Region



	#Region "Methods"

    Private Sub settingCheckBox_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles useCode128ExtendedDecodeTableCheckBox.CheckedChanged, telepenEnableNumericModeCheckBox.CheckedChanged, searchDistortedQRBarcodesCheckBox.CheckedChanged, searchDistortedDataMatrixBarcodesCheckBox.CheckedChanged, optionalChecksumCheckBox.CheckedChanged, collectQualityTestInformationCheckBox.CheckedChanged, barcodeCharacteristicSmallBarcodesCheckBox.CheckedChanged
        SetSettings()
    End Sub

    Private Sub barcodeReaderAustralianCustomInfoComboBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles barcodeReaderAustralianCustomInfoComboBox.SelectedIndexChanged
        SetSettings()
    End Sub

    Private Sub barcodeReaderMSIChecksumComboBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles barcodeReaderMSIChecksumComboBox.SelectedIndexChanged
        SetSettings()
    End Sub

    Private Sub DataMatrixLPatternMaxErasuresNumericUpDown_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles DataMatrixLPatternMaxErasuresNumericUpDown.ValueChanged
        SetSettings()
    End Sub

	Public Overrides Sub UpdateUI()
		_enableSetSettings = False

		optionalChecksumCheckBox.Checked = BarcodeReaderSettings.OptionalCheckSum
		If BarcodeReaderSettings.OptionalCheckSum Then
			optionalChecksumCheckBox.ForeColor = Color.Red
		Else
			optionalChecksumCheckBox.ForeColor = Color.Black
		End If
		searchDistortedDataMatrixBarcodesCheckBox.Checked = BarcodeReaderSettings.SearchDistortedDataMatrixBarcodes
		searchDistortedQRBarcodesCheckBox.Checked = BarcodeReaderSettings.SearchDistortedQRBarcodes
		telepenEnableNumericModeCheckBox.Checked = BarcodeReaderSettings.EnableTelepenNumericMode
		collectQualityTestInformationCheckBox.Checked = BarcodeReaderSettings.CollectTestInformation
		useCode128ExtendedDecodeTableCheckBox.Checked = BarcodeReaderSettings.Code128UseFnc4ShiftToExtendedAsciiTable
		DataMatrixLPatternMaxErasuresNumericUpDown.Value = BarcodeReaderSettings.DataMatrixLPatternMaxErasures
		barcodeCharacteristicSmallBarcodesCheckBox.Checked = (BarcodeReaderSettings.BarcodeCharacteristics And BarcodeCharacteristics.SmallBarcodes) <> 0

		barcodeReaderAustralianCustomInfoComboBox.SelectedItem = BarcodeReaderSettings.AustralianPostCustomerInfoFormat
		barcodeReaderMSIChecksumComboBox.SelectedItem = BarcodeReaderSettings.MSIChecksum

		If _barcodeTypesReaderSettings IsNot Nothing Then
			_barcodeTypesReaderSettings.HighlightOptionalChecksumBarcodes = optionalChecksumCheckBox.Checked
		End If

		_enableSetSettings = True
	End Sub

	Private Function EnumGetValues(type As Type) As Object()
		Dim ar As Array = [Enum].GetValues(type)
		Dim result As Object() = New Object(ar.Length - 1) {}
		ar.CopyTo(result, 0)
		Return result
	End Function

	Private Sub SetSettings()
		If Not _enableSetSettings Then
			Return
		End If

		_enableSetSettings = False

		BarcodeReaderSettings.OptionalCheckSum = optionalChecksumCheckBox.Checked
		If BarcodeReaderSettings.OptionalCheckSum Then
			optionalChecksumCheckBox.ForeColor = Color.Red
		Else
			optionalChecksumCheckBox.ForeColor = Color.Black
		End If

		BarcodeReaderSettings.SearchDistortedDataMatrixBarcodes = searchDistortedDataMatrixBarcodesCheckBox.Checked
		BarcodeReaderSettings.DataMatrixLPatternMaxErasures = CInt(Math.Truncate(DataMatrixLPatternMaxErasuresNumericUpDown.Value))
		BarcodeReaderSettings.SearchDistortedQRBarcodes = searchDistortedQRBarcodesCheckBox.Checked
		BarcodeReaderSettings.EnableTelepenNumericMode = telepenEnableNumericModeCheckBox.Checked
		BarcodeReaderSettings.CollectTestInformation = collectQualityTestInformationCheckBox.Checked
		BarcodeReaderSettings.Code128UseFnc4ShiftToExtendedAsciiTable = useCode128ExtendedDecodeTableCheckBox.Checked
		If barcodeCharacteristicSmallBarcodesCheckBox.Checked Then
			BarcodeReaderSettings.BarcodeCharacteristics = BarcodeCharacteristics.SmallBarcodes
		Else
			BarcodeReaderSettings.BarcodeCharacteristics = BarcodeCharacteristics.Undefinded
		End If

		BarcodeReaderSettings.AustralianPostCustomerInfoFormat = DirectCast(barcodeReaderAustralianCustomInfoComboBox.SelectedItem, AustralianPostCustomerInfoFormat)
		BarcodeReaderSettings.MSIChecksum = DirectCast(barcodeReaderMSIChecksumComboBox.SelectedItem, MSIChecksumType)

		If _barcodeTypesReaderSettings IsNot Nothing Then
			_barcodeTypesReaderSettings.HighlightOptionalChecksumBarcodes = optionalChecksumCheckBox.Checked
		End If

		_enableSetSettings = True
	End Sub

	#End Region

End Class
