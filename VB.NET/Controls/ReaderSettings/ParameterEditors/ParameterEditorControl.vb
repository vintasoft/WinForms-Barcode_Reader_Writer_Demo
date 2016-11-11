Imports System.ComponentModel
Imports System.Windows.Forms

Imports Vintasoft.Barcode

''' <summary>
''' Represents a base class of a parameter editor.
''' </summary>
Public Partial Class ParameterEditorControl
	Inherits ReaderSettingsEditorControl

	#Region "Fields"

	Private _setValueEnabled As Boolean = True

	#End Region



	#Region "Constructor"

	Public Sub New()
		InitializeComponent()
	End Sub

	#End Region



	#Region "Properties"

	''' <summary>
	''' Gets or sets a title.
	''' </summary>
	Public Property Title() As String
		Get
			Return valueGroupBox.Text
		End Get
		Set
			valueGroupBox.Text = value
		End Set
	End Property

	''' <summary>
	''' Gets or sets a minimum value.
	''' </summary>
	Public Property Minimum() As Integer
		Get
			Return valueTrackBar.Minimum
		End Get
		Set
			valueTrackBar.Minimum = value
		End Set
	End Property

	''' <summary>
	''' Gets or sets a maximum value.
	''' </summary>
	Public Property Maximum() As Integer
		Get
			Return valueTrackBar.Maximum
		End Get
		Set
			valueTrackBar.Maximum = value
		End Set
	End Property

	''' <summary>
	''' Gets or sets a property value.
	''' </summary>
	Public Overridable Property Value() As Integer
		Get
			Return valueTrackBar.Value
		End Get
		Set
			valueTrackBar.Value = Math.Max(Minimum, Math.Min(Maximum, value))
		End Set
	End Property

	''' <summary>
	''' Gets or sets a value of TrackBar.TickFrequency property.
	''' </summary>
	Public Property TickFrequency() As Integer
		Get
			Return valueTrackBar.TickFrequency
		End Get
		Set
			valueTrackBar.TickFrequency = value
		End Set
	End Property

	#End Region



	#Region "Methods"

	Public Overridable Function GetValueAsString() As String
		Return Value.ToString()
	End Function

	Protected Overridable Sub OnValueChanged()
		Value = valueTrackBar.Value
		valueLabel.Text = GetValueAsString()
		RaiseEvent ValueChanged(Me, EventArgs.Empty)
	End Sub

	Protected Overrides Sub OnBarcodeReaderSettingsChanged(e As EventArgs)
		MyBase.OnBarcodeReaderSettingsChanged(e)
		OnValueChanged()
	End Sub

	Public Overrides Sub UpdateUI()
		_setValueEnabled = False
		valueTrackBar.Value = Value
		valueLabel.Text = GetValueAsString()
		_setValueEnabled = True
	End Sub

    Private Sub valueTrackBar_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles valueTrackBar.ValueChanged
        If _setValueEnabled Then
            OnValueChanged()
        End If
    End Sub

	#End Region



	#Region "Events"

	Public Event ValueChanged As EventHandler

	#End Region

End Class
