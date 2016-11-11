Imports System.ComponentModel
Imports System.Windows.Forms

Imports Vintasoft.Barcode

''' <summary>
''' Represents a base class of barcode reader settings editor.
''' </summary>
Public Class ReaderSettingsEditorControl
	Inherits UserControl

	#Region "Properties"

	Private _barcodeReaderSettings As New ReaderSettings()
	''' <summary>
	''' Gets or sets a barcode reader settings.
	''' </summary>
	<Browsable(False)> _
	<EditorBrowsable(EditorBrowsableState.Never)> _
	Public ReadOnly Property BarcodeReaderSettings() As ReaderSettings
		Get
			Return _barcodeReaderSettings
		End Get
	End Property

	#End Region



	#Region "Methods"

	Public Sub SetBarcodeReaderSettings(settings As ReaderSettings)
		_barcodeReaderSettings = settings
		OnBarcodeReaderSettingsChanged(EventArgs.Empty)
	End Sub

	Public Overridable Sub UpdateUI()
	End Sub

	Protected Overridable Sub OnBarcodeReaderSettingsChanged(e As EventArgs)
		UpdateUI()
	End Sub

	#End Region

End Class
