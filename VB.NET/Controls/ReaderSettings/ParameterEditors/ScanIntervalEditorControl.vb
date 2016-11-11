''' <summary>
''' Represents an editor control of ReaderSettings.ScanInterval parameter.
''' </summary>
Public Class ScanIntervalEditorControl
	Inherits ParameterEditorControl

	#Region "Constructors"

	Public Sub New()
		Minimum = 1
		Maximum = 25
		Value = 5
		Title = "Scan interval"
	End Sub

	#End Region



	#Region "Properties"

	''' <summary>
	''' Gets or sets a property value.
	''' </summary>
	Public Overrides Property Value() As Integer
		Get
			Return BarcodeReaderSettings.ScanInterval
		End Get
		Set
			MyBase.Value = value
			BarcodeReaderSettings.ScanInterval = value
		End Set
	End Property

	#End Region

End Class
