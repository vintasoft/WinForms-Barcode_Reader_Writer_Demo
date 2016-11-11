''' <summary>
''' Represents an editor control of ReaderSettings.ExpectedBarcodes parameter.
''' </summary>
Public Class ExpectedBarcodesEditorControl
	Inherits ParameterEditorControl

	#Region "Constructors"

	Public Sub New()
		Minimum = 1
		Maximum = 72
		Value = 1
		Title = "Expected barcodes"
		TickFrequency = 2
	End Sub

	#End Region



	#Region "Properties"

	''' <summary>
	''' Gets or sets a property value.
	''' </summary>
	Public Overrides Property Value() As Integer
		Get
			Return BarcodeReaderSettings.ExpectedBarcodes
		End Get
		Set
			MyBase.Value = value
			BarcodeReaderSettings.ExpectedBarcodes = value
		End Set
	End Property

	#End Region

End Class
