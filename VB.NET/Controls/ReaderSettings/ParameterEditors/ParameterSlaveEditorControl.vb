
''' <summary>
''' Represents a slave parameter editor control.
''' </summary>
Public Class ParameterSlaveEditorControl
	Inherits ParameterEditorControl

	#Region "Properties"

	Private _masterParameterEditor As ParameterEditorControl
	''' <summary>
	''' Gets or sets a master parameter editor.
	''' </summary>
	Public Property MasterParameterEditor() As ParameterEditorControl
		Get
			Return _masterParameterEditor
		End Get
		Set
			If _masterParameterEditor IsNot value Then
				If _masterParameterEditor IsNot Nothing Then
					RemoveHandler _masterParameterEditor.ValueChanged, New EventHandler(AddressOf MasterParameterEditor_ValueChanged)
				End If
				_masterParameterEditor = value
				If _masterParameterEditor IsNot Nothing Then
					' Copy properties.
					Enabled = _masterParameterEditor.Enabled
					AddHandler _masterParameterEditor.ValueChanged, New EventHandler(AddressOf MasterParameterEditor_ValueChanged)
					Minimum = _masterParameterEditor.Minimum
					Maximum = _masterParameterEditor.Maximum
                    Me.Value = _masterParameterEditor.Value
					Title = _masterParameterEditor.Title

					TickFrequency = _masterParameterEditor.TickFrequency
				Else
					Enabled = False
				End If
			End If
		End Set
	End Property

	''' <summary>
	''' Gets or sets a property value.
	''' </summary>
	Public Overrides Property Value() As Integer
		Get
			Return MyBase.Value
		End Get
		Set
			MyBase.Value = value
            If Not _masterParameterEditor Is Nothing Then
                _masterParameterEditor.Value = Value
            End If
        End Set
	End Property

	#End Region



	#Region "Methods"

	Protected Overrides Sub OnValueChanged()
        MyBase.OnValueChanged()
        If Not MasterParameterEditor Is Nothing Then
            MasterParameterEditor.Value = Value
        End If
    End Sub

	Private Sub MasterParameterEditor_ValueChanged(sender As Object, e As EventArgs)
		Value = _masterParameterEditor.Value
	End Sub


	#End Region

End Class
