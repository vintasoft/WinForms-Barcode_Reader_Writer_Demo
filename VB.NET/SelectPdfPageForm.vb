Imports System.Collections
Imports System.Drawing
Imports System.Windows.Forms
Imports Vintasoft.Barcode

Public Partial Class SelectPdfPageForm
	Inherits Form

	#Region "Fields"

	Private _labelText As String
	Private _selected As Boolean

	#End Region



	#Region "Constructors"

	Public Sub New()
		InitializeComponent()
		_labelText = label1.Text
	End Sub

	#End Region



	#Region "Methods"

    Private Sub FormPdfPageSelect_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
        Visible = False
        e.Cancel = True
    End Sub

    Private Sub selectButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles selectButton.Click
        _selected = True
        Close()
    End Sub


	Private Function GetImageFromPage(viewer As PdfImageViewer, pageIndex As Integer) As Image
		Dim names As String() = viewer.GetImageNames(pageIndex)
		Dim images As New ArrayList()
		For i As Integer = 0 To names.Length - 1
			Try
				images.Add(viewer.GetImage(pageIndex, names(i)))
			Catch e As Exception
				MessageBox.Show(String.Format("Image '{0}': {1}", names(i), e.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
			End Try
		Next
		If images.Count = 0 Then
			Return Nothing
		End If
		If images.Count = 1 Then
			Return DirectCast(images(0), Image)
		End If

		' merge images
		Dim padding As Integer = 5
		Dim heigth As Integer = 0
		Dim width As Integer = 0
		Dim n As Integer = images.Count
		For i As Integer = 0 To n - 1
			Dim current As Image = DirectCast(images(i), Image)
			If width < current.Width Then
				width = current.Width
			End If
			heigth += current.Height
		Next
		width += 3
		heigth += (n + 1) * padding
		Dim result As New Bitmap(width, heigth, System.Drawing.Imaging.PixelFormat.Format24bppRgb)
		Dim g As Graphics = Graphics.FromImage(result)
		g.FillRectangle(Brushes.White, New Rectangle(0, 0, width, heigth))
		Dim dy As Integer = 1
		For i As Integer = 0 To n - 1
			Dim current As Image = DirectCast(images(i), Image)
			g.DrawImageUnscaled(current, New Point(1, dy))
			dy += current.Height + padding
			current.Dispose()
		Next
		g.Dispose()

		Return result
	End Function

	Public Function SelectImage(pdfFileName As String) As Image
		Dim viewer As PdfImageViewer
		Try
			viewer = New PdfImageViewer(pdfFileName)
		Catch ex As Exception
			MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
			Return Nothing
		End Try

		Try
			pages.Items.Clear()
			For i As Integer = 0 To viewer.PageCount - 1
				Dim k As Integer = viewer.GetImageNames(i).Length
				If k > 0 Then
					pages.Items.Add(i + 1)
				End If
			Next
			If pages.Items.Count = 0 Then
				MessageBox.Show("Images in PDF file are not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
				Return Nothing
			End If
			pages.SelectedIndex = 0

			If pages.Items.Count = 1 Then
				Return GetImageFromPage(viewer, 0)
			End If

			label1.Text = String.Format(_labelText, pages.Items.Count)

			_selected = False
			ShowDialog()
			If _selected Then
				Dim result As Image = GetImageFromPage(viewer, CInt(pages.SelectedItem) - 1)
				Return result
			End If

			Return Nothing
		Finally
			viewer.Dispose()
		End Try
	End Function

	#End Region

End Class
