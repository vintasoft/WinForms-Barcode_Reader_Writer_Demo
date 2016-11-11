
''' <summary>
''' Represents an editor control of ReaderSettings.MaximalThreadsCount parameter.
''' </summary>
Public Class MaxThreadsCountEditorControl
	Inherits ParameterEditorControl

	#Region "Constructors"

	Public Sub New()
		Minimum = 1
		Maximum = Math.Max(Environment.ProcessorCount * 2, BarcodeReaderSettings.MaximalThreadsCount)
		Value = BarcodeReaderSettings.MaximalThreadsCount
		Title = "Max threads count"
	End Sub

	#End Region



	#Region "Properties"

	''' <summary>
	''' Gets or sets a property value.
	''' </summary>
	Public Overrides Property Value() As Integer
		Get
			Return Math.Min(Maximum, Math.Max(Minimum, BarcodeReaderSettings.MaximalThreadsCount))
		End Get
		Set
			MyBase.Value = value
			BarcodeReaderSettings.MaximalThreadsCount = MyBase.Value
		End Set
	End Property

	#End Region

End Class
