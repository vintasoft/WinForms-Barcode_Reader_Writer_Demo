Imports System.Windows.Forms

Public Partial Class PropertyGridForm
	Inherits Form

	#Region "Constructor"

	Public Sub New(obj As Object, formTitle As String)
		Me.New(obj, formTitle, False)
	End Sub

	Public Sub New(obj As Object, formTitle As String, canCancel As Boolean)
		InitializeComponent()
		Text = formTitle
		buttonCancel.Enabled = canCancel
		_propertyGrid.SelectedObject = obj
	End Sub

	#End Region


	#Region "Properties"

	Public ReadOnly Property PropertyGrid() As PropertyGrid
		Get
			Return _propertyGrid
		End Get
	End Property

	#End Region


	#Region "Methods"

    Private Sub buttonOk_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonOk.Click
        DialogResult = DialogResult.OK
        Close()
    End Sub

    Private Sub buttonCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonCancel.Click
        DialogResult = DialogResult.Cancel
        Close()
    End Sub

	#End Region

End Class
