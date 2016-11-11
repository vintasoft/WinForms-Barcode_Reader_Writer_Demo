Imports System.Collections.Generic
Imports System.IO

Friend Class FindFiles

    Public Shared GRAPHIC_FILES As String() = New String() {"*.bmp", "*.jpg", "*.jpeg", "*.jpe", "*.jfif", "*.tif", _
     "*.tiff", "*.png", "*.gif", "*.wmf", "*.emf", "*.pdf"}



	Public Shared Function Find(path As String, masks As String()) As String()
		Dim result As New List(Of String)()
		For Each mask As String In masks
			Dim filenames As String() = Directory.GetFiles(path, mask)
			For Each filename As String In filenames
				Dim lowerFilename As String = filename.ToLower()
				If Not result.Contains(lowerFilename) Then
					result.Add(lowerFilename)
				End If
			Next
		Next
		result.Sort()
		Return result.ToArray()
	End Function

End Class
