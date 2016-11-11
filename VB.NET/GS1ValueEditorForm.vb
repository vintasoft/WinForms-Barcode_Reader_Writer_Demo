Imports System.Collections.Generic
Imports System.Text
Imports System.Windows.Forms
Imports Vintasoft.Barcode.GS1
Imports System.Drawing

Public Partial Class GS1ValueEditorForm
	Inherits Form

	#Region "Fields"

	Private _readOnly As Boolean = False
	Private _existsAISelected As Boolean = False
	Private _identifierValuesList As New List(Of GS1ApplicationIdentifierValue)()

	#End Region



	#Region "Constructors"


	Public Sub New(gs1ApplicationIdentifierValues As GS1ApplicationIdentifierValue(), [readOnly] As Boolean)
		InitializeComponent()
		addButton.Visible = Not [readOnly]
		deleteButton.Visible = Not [readOnly]
		aiNumberComboBox.Enabled = Not [readOnly]
		gs1BarcodePrintableValueTextBox.[ReadOnly] = [readOnly]
		setPrintableValueButton.Enabled = Not [readOnly]
		If Not [readOnly] Then
			gs1BarcodePrintableValueTextBox.BackColor = SystemColors.Window
		End If
		Dim applicationIdentifiers As GS1ApplicationIdentifier() = GS1ApplicationIdentifiers.ApplicationIdentifiers
		For i As Integer = 0 To applicationIdentifiers.Length - 1
			aiNumberComboBox.Items.Add(String.Format("{0}: {1}", applicationIdentifiers(i).ApplicationIdentifier, applicationIdentifiers(i).DataTitle))
		Next
		_GS1ApplicationIdentifierValues = gs1ApplicationIdentifierValues
		_identifierValuesList.AddRange(gs1ApplicationIdentifierValues)
		_readOnly = [readOnly]
		aiValueTextBox.[ReadOnly] = [readOnly]
		If [readOnly] Then
			Text = "GS1 Value Decoder"
		Else
			Text = "GS1 Value Editor"
		End If
		setDataValueButton.Enabled = Not [readOnly]
		ShowPrintableValue()
		ShowAI()
	End Sub

	#End Region



	#Region "Properties"

	Private _GS1ApplicationIdentifierValues As GS1ApplicationIdentifierValue()
	Public ReadOnly Property GS1ApplicationIdentifierValues() As GS1ApplicationIdentifierValue()
		Get
			Return _GS1ApplicationIdentifierValues
		End Get
	End Property


	#End Region



	#Region "Methods"

    Private Sub aiNumberComboBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles aiNumberComboBox.SelectedIndexChanged
        If Not _existsAISelected Then
            Dim ai As GS1ApplicationIdentifier = GS1ApplicationIdentifiers.ApplicationIdentifiers(aiNumberComboBox.SelectedIndex)
            aiDataContentLabel.Text = ai.DataContent
            Dim format As String = ai.Format
            If ai.IsContainsDecimalPoint Then
                format += " (with decimal point)"
            End If
            aiDataFormatLabel.Text = format
            aiValueTextBox.Text = ""
        End If
    End Sub

    Private Sub aiListDataGridView_RowEnter(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles aiListDataGridView.RowEnter
        If aiListDataGridView.Rows(e.RowIndex).Cells(0).Value IsNot Nothing Then
            aiNumberComboBox.SelectedIndex = GS1ApplicationIdentifiers.IndexOfApplicationIdentifier(DirectCast(aiListDataGridView.Rows(e.RowIndex).Cells(0).Value, String))
            aiValueTextBox.Text = DirectCast(aiListDataGridView.Rows(e.RowIndex).Cells(2).Value, String)
        End If
    End Sub

    Private Sub addButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles addButton.Click
        AddAI(GS1ApplicationIdentifiers.ApplicationIdentifiers(aiNumberComboBox.SelectedIndex).ApplicationIdentifier, aiValueTextBox.Text)
    End Sub

    Private Sub setButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles setDataValueButton.Click
        If aiListDataGridView.Rows.Count > 0 AndAlso aiListDataGridView.SelectedRows.Count > 0 Then
            Dim index As Integer = aiListDataGridView.SelectedRows(0).Index
            Dim ai As GS1ApplicationIdentifierValue = Nothing
            Try
                Dim number As String = GS1ApplicationIdentifiers.ApplicationIdentifiers(aiNumberComboBox.SelectedIndex).ApplicationIdentifier
                ai = New GS1ApplicationIdentifierValue(GS1ApplicationIdentifiers.FindApplicationIdentifier(number), aiValueTextBox.Text)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                Return
            End Try
            _identifierValuesList(index) = ai
            aiListDataGridView.Rows(index).Cells(0).Value = ai.ApplicationIdentifier.ApplicationIdentifier
            aiListDataGridView.Rows(index).Cells(1).Value = ai.ApplicationIdentifier.DataTitle
            aiListDataGridView.Rows(index).Cells(2).Value = ai.Value
        End If
    End Sub

    Private Sub deleteButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles deleteButton.Click
        If aiListDataGridView.Rows.Count > 0 AndAlso aiListDataGridView.SelectedRows.Count > 0 Then
            Dim index As Integer = aiListDataGridView.SelectedRows(0).Index
            _identifierValuesList.RemoveAt(index)
            aiListDataGridView.Rows.RemoveAt(index)
            ShowPrintableValue()
        End If
    End Sub

    Private Sub okButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles okButton.Click
        If SetPrintableValue() Then
            _GS1ApplicationIdentifierValues = _identifierValuesList.ToArray()
            DialogResult = DialogResult.OK
        End If
    End Sub

    Private Sub buttonCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonCancel.Click
        DialogResult = DialogResult.Cancel
    End Sub


	Private Sub ShowAI()
		If _GS1ApplicationIdentifierValues.Length = 0 Then
			aiNumberComboBox.SelectedIndex = 0
		Else
			For i As Integer = 0 To _identifierValuesList.Count - 1
				AddAIToTable(_identifierValuesList(i))
			Next
		End If
	End Sub

	Private Sub AddAIToTable(value As GS1ApplicationIdentifierValue)
		Dim index As Integer = aiListDataGridView.Rows.Count
		aiListDataGridView.Rows.Add()
		aiListDataGridView.Rows(index).Cells(0).Value = value.ApplicationIdentifier.ApplicationIdentifier
		aiListDataGridView.Rows(index).Cells(1).Value = value.ApplicationIdentifier.DataTitle
		aiListDataGridView.Rows(index).Cells(2).Value = value.Value
	End Sub

	Private Sub AddAI(number As String, value As String)
		Dim ai As GS1ApplicationIdentifierValue = Nothing
		Try
			ai = New GS1ApplicationIdentifierValue(GS1ApplicationIdentifiers.FindApplicationIdentifier(number), value)
		Catch e As Exception
			MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
			Return
		End Try
		_identifierValuesList.Add(ai)
		ShowPrintableValue()
		AddAIToTable(ai)
	End Sub

	Private Sub ShowPrintableValue()
		Dim sb As New StringBuilder()
		For i As Integer = 0 To _identifierValuesList.Count - 1
			sb.Append(_identifierValuesList(i).ToString())
		Next
		gs1BarcodePrintableValueTextBox.Text = sb.ToString()
	End Sub

	Private Function SetPrintableValue() As Boolean
		Try
			Dim values As GS1ApplicationIdentifierValue() = GS1Codec.ParsePrintableValue(gs1BarcodePrintableValueTextBox.Text)
			_identifierValuesList.Clear()
			_identifierValuesList.AddRange(values)
			aiListDataGridView.Rows.Clear()
			ShowAI()
		Catch ex As Exception
			MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
			Return False
		End Try
		Return True
	End Function

    Private Sub setPrintableValueButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles setPrintableValueButton.Click
        SetPrintableValue()
    End Sub

	#End Region

End Class
