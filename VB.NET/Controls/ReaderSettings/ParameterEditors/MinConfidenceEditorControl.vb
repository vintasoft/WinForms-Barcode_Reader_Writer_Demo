''' <summary>
''' Represents an editor control of ReaderSettings.MinConfidence parameter.
''' </summary>
Public Class MinConfidenceEditorControl
	Inherits ParameterEditorControl

	#Region "Constructors"

	Public Sub New()
		Minimum = 0
		Maximum = 100
		Value = 95
		Title = "Min Confidence"
		TickFrequency = 2
	End Sub

	#End Region



	#Region "Properties"

	''' <summary>
	''' Gets or sets a property value.
	''' </summary>
	Public Overrides Property Value() As Integer
		Get
			Return BarcodeReaderSettings.MinConfidence
		End Get
		Set
			MyBase.Value = value
			BarcodeReaderSettings.MinConfidence = value
		End Set
	End Property

	#End Region



	#Region "Methods"

	Public Overrides Function GetValueAsString() As String
		Dim template As String = "{0}%"
		If Value = 0 Then
			template = "0% - show all barcodes"
		ElseIf Value = 100 Then
			template = "{0}% show recognized(no read errors) barcodes"
		ElseIf Value >= 95 Then
			template = "{0}% - show recognized barcodes"
		End If
		Return String.Format(template, Value)
	End Function

	#End Region

End Class
