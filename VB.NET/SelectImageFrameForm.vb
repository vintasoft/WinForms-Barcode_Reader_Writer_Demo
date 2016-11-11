Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Windows.Forms

Public Partial Class SelectImageFrameForm
	Inherits Form

	#Region "Fields"

	Private _labelText As String

	#End Region



	#Region "Constructors"

	Public Sub New()
		InitializeComponent()
		_labelText = label1.Text
	End Sub

	#End Region



	#Region "Methods"

	Public Sub SelectFrame(image As Image)
		Dim dimension As New FrameDimension(image.FrameDimensionsList(0))
		Dim frameCount As Integer = image.GetFrameCount(dimension)
		If frameCount = 1 Then
			Return
		End If

		If frameNumber.Value > frameCount Then
			frameNumber.Value = 1
		End If
		frameNumber.Maximum = frameCount
		label1.Text = String.Format(_labelText, frameCount)
		ShowDialog()
		image.SelectActiveFrame(dimension, CInt(Math.Truncate(frameNumber.Value)) - 1)
	End Sub

    Private Sub selectButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles selectButton.Click
        Close()
    End Sub

    Private Sub FormPageSelect_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
        Visible = False
        e.Cancel = True
    End Sub

	#End Region

End Class
