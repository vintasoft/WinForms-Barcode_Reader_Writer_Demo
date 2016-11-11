Partial Class GS1ValueEditorForm
	''' <summary>
	''' Required designer variable.
	''' </summary>
	Private components As System.ComponentModel.IContainer = Nothing

	''' <summary>
	''' Clean up any resources being used.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(disposing As Boolean)
		If disposing AndAlso (components IsNot Nothing) Then
			components.Dispose()
		End If
		MyBase.Dispose(disposing)
	End Sub

	#Region "Windows Form Designer generated code"

	''' <summary>
	''' Required method for Designer support - do not modify
	''' the contents of this method with the code editor.
	''' </summary>
	Private Sub InitializeComponent()
        Me.ApplicationIdentifierLabel = New System.Windows.Forms.Label
        Me.aiNumberComboBox = New System.Windows.Forms.ComboBox
        Me.dataContentLabel = New System.Windows.Forms.Label
        Me.aiValueTextBox = New System.Windows.Forms.TextBox
        Me.dataValueLabel = New System.Windows.Forms.Label
        Me.aiDataContentLabel = New System.Windows.Forms.Label
        Me.addButton = New System.Windows.Forms.Button
        Me.deleteButton = New System.Windows.Forms.Button
        Me.aiListDataGridView = New System.Windows.Forms.DataGridView
        Me.aiNumberColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.aiTitleColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.aiValueColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.okButton = New System.Windows.Forms.Button
        Me.buttonCancel = New System.Windows.Forms.Button
        Me.dataFormatLabel = New System.Windows.Forms.Label
        Me.aiDataFormatLabel = New System.Windows.Forms.Label
        Me.formatStructureLabel = New System.Windows.Forms.Label
        Me.formatStructureValueLabel = New System.Windows.Forms.Label
        Me.barcodePrintableValueLabel = New System.Windows.Forms.Label
        Me.gs1BarcodePrintableValueTextBox = New System.Windows.Forms.TextBox
        Me.setDataValueButton = New System.Windows.Forms.Button
        Me.setPrintableValueButton = New System.Windows.Forms.Button
        CType(Me.aiListDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ApplicationIdentifierLabel
        '
        Me.ApplicationIdentifierLabel.AutoSize = True
        Me.ApplicationIdentifierLabel.Location = New System.Drawing.Point(9, 40)
        Me.ApplicationIdentifierLabel.Name = "ApplicationIdentifierLabel"
        Me.ApplicationIdentifierLabel.Size = New System.Drawing.Size(102, 13)
        Me.ApplicationIdentifierLabel.TabIndex = 0
        Me.ApplicationIdentifierLabel.Text = "Application Identifier"
        '
        'aiNumberComboBox
        '
        Me.aiNumberComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.aiNumberComboBox.FormattingEnabled = True
        Me.aiNumberComboBox.Location = New System.Drawing.Point(134, 37)
        Me.aiNumberComboBox.Name = "aiNumberComboBox"
        Me.aiNumberComboBox.Size = New System.Drawing.Size(424, 21)
        Me.aiNumberComboBox.TabIndex = 1
        '
        'dataContentLabel
        '
        Me.dataContentLabel.AutoSize = True
        Me.dataContentLabel.Location = New System.Drawing.Point(9, 61)
        Me.dataContentLabel.Name = "dataContentLabel"
        Me.dataContentLabel.Size = New System.Drawing.Size(70, 13)
        Me.dataContentLabel.TabIndex = 2
        Me.dataContentLabel.Text = "Data Content"
        '
        'aiValueTextBox
        '
        Me.aiValueTextBox.Location = New System.Drawing.Point(134, 101)
        Me.aiValueTextBox.Name = "aiValueTextBox"
        Me.aiValueTextBox.Size = New System.Drawing.Size(316, 20)
        Me.aiValueTextBox.TabIndex = 3
        '
        'dataValueLabel
        '
        Me.dataValueLabel.AutoSize = True
        Me.dataValueLabel.Location = New System.Drawing.Point(9, 101)
        Me.dataValueLabel.Name = "dataValueLabel"
        Me.dataValueLabel.Size = New System.Drawing.Size(60, 13)
        Me.dataValueLabel.TabIndex = 4
        Me.dataValueLabel.Text = "Data Value"
        '
        'aiDataContentLabel
        '
        Me.aiDataContentLabel.Location = New System.Drawing.Point(131, 61)
        Me.aiDataContentLabel.Name = "aiDataContentLabel"
        Me.aiDataContentLabel.Size = New System.Drawing.Size(427, 37)
        Me.aiDataContentLabel.TabIndex = 5
        Me.aiDataContentLabel.Text = "[Data Content]"
        '
        'addButton
        '
        Me.addButton.Location = New System.Drawing.Point(456, 140)
        Me.addButton.Name = "addButton"
        Me.addButton.Size = New System.Drawing.Size(102, 23)
        Me.addButton.TabIndex = 6
        Me.addButton.Text = "Add"
        Me.addButton.UseVisualStyleBackColor = True
        '
        'deleteButton
        '
        Me.deleteButton.Location = New System.Drawing.Point(456, 170)
        Me.deleteButton.Name = "deleteButton"
        Me.deleteButton.Size = New System.Drawing.Size(102, 23)
        Me.deleteButton.TabIndex = 7
        Me.deleteButton.Text = "Delete"
        Me.deleteButton.UseVisualStyleBackColor = True
        '
        'aiListDataGridView
        '
        Me.aiListDataGridView.AllowUserToAddRows = False
        Me.aiListDataGridView.AllowUserToDeleteRows = False
        Me.aiListDataGridView.AllowUserToResizeColumns = False
        Me.aiListDataGridView.AllowUserToResizeRows = False
        Me.aiListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.aiListDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.aiNumberColumn, Me.aiTitleColumn, Me.aiValueColumn})
        Me.aiListDataGridView.Location = New System.Drawing.Point(12, 199)
        Me.aiListDataGridView.MultiSelect = False
        Me.aiListDataGridView.Name = "aiListDataGridView"
        Me.aiListDataGridView.ReadOnly = True
        Me.aiListDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.aiListDataGridView.Size = New System.Drawing.Size(546, 130)
        Me.aiListDataGridView.TabIndex = 8
        '
        'aiNumberColumn
        '
        Me.aiNumberColumn.HeaderText = "AI"
        Me.aiNumberColumn.Name = "aiNumberColumn"
        Me.aiNumberColumn.ReadOnly = True
        Me.aiNumberColumn.Width = 70
        '
        'aiTitleColumn
        '
        Me.aiTitleColumn.HeaderText = "Data Title"
        Me.aiTitleColumn.Name = "aiTitleColumn"
        Me.aiTitleColumn.ReadOnly = True
        Me.aiTitleColumn.Width = 200
        '
        'aiValueColumn
        '
        Me.aiValueColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.aiValueColumn.HeaderText = "Value"
        Me.aiValueColumn.Name = "aiValueColumn"
        Me.aiValueColumn.ReadOnly = True
        '
        'okButton
        '
        Me.okButton.Location = New System.Drawing.Point(402, 335)
        Me.okButton.Name = "okButton"
        Me.okButton.Size = New System.Drawing.Size(75, 23)
        Me.okButton.TabIndex = 9
        Me.okButton.Text = "OK"
        Me.okButton.UseVisualStyleBackColor = True
        '
        'buttonCancel
        '
        Me.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.buttonCancel.Location = New System.Drawing.Point(483, 335)
        Me.buttonCancel.Name = "buttonCancel"
        Me.buttonCancel.Size = New System.Drawing.Size(75, 23)
        Me.buttonCancel.TabIndex = 10
        Me.buttonCancel.Text = "Cancel"
        Me.buttonCancel.UseVisualStyleBackColor = True
        '
        'dataFormatLabel
        '
        Me.dataFormatLabel.AutoSize = True
        Me.dataFormatLabel.Location = New System.Drawing.Point(9, 126)
        Me.dataFormatLabel.Name = "dataFormatLabel"
        Me.dataFormatLabel.Size = New System.Drawing.Size(65, 13)
        Me.dataFormatLabel.TabIndex = 11
        Me.dataFormatLabel.Text = "Data Format"
        '
        'aiDataFormatLabel
        '
        Me.aiDataFormatLabel.AutoSize = True
        Me.aiDataFormatLabel.Location = New System.Drawing.Point(131, 126)
        Me.aiDataFormatLabel.Name = "aiDataFormatLabel"
        Me.aiDataFormatLabel.Size = New System.Drawing.Size(71, 13)
        Me.aiDataFormatLabel.TabIndex = 12
        Me.aiDataFormatLabel.Text = "[Data Format]"
        '
        'formatStructureLabel
        '
        Me.formatStructureLabel.AutoSize = True
        Me.formatStructureLabel.Location = New System.Drawing.Point(9, 143)
        Me.formatStructureLabel.Name = "formatStructureLabel"
        Me.formatStructureLabel.Size = New System.Drawing.Size(85, 13)
        Me.formatStructureLabel.TabIndex = 13
        Me.formatStructureLabel.Text = "Format Structure"
        '
        'formatStructureValueLabel
        '
        Me.formatStructureValueLabel.Location = New System.Drawing.Point(131, 143)
        Me.formatStructureValueLabel.Name = "formatStructureValueLabel"
        Me.formatStructureValueLabel.Size = New System.Drawing.Size(303, 61)
        Me.formatStructureValueLabel.TabIndex = 14
        Me.formatStructureValueLabel.Text = "'Nk' - k numeric digits, fixed length" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "'NkC' - k numeric digits + check digit, fi" & _
            "xed length" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "'N..k' - up to k numeric digits" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "'X..k' - up to k characters ISO646"
        '
        'barcodePrintableValueLabel
        '
        Me.barcodePrintableValueLabel.AutoSize = True
        Me.barcodePrintableValueLabel.Location = New System.Drawing.Point(9, 9)
        Me.barcodePrintableValueLabel.Name = "barcodePrintableValueLabel"
        Me.barcodePrintableValueLabel.Size = New System.Drawing.Size(119, 13)
        Me.barcodePrintableValueLabel.TabIndex = 15
        Me.barcodePrintableValueLabel.Text = "Barcode printable value"
        '
        'gs1BarcodePrintableValueTextBox
        '
        Me.gs1BarcodePrintableValueTextBox.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.gs1BarcodePrintableValueTextBox.Location = New System.Drawing.Point(134, 6)
        Me.gs1BarcodePrintableValueTextBox.Name = "gs1BarcodePrintableValueTextBox"
        Me.gs1BarcodePrintableValueTextBox.ReadOnly = True
        Me.gs1BarcodePrintableValueTextBox.Size = New System.Drawing.Size(316, 20)
        Me.gs1BarcodePrintableValueTextBox.TabIndex = 16
        '
        'setDataValueButton
        '
        Me.setDataValueButton.Location = New System.Drawing.Point(456, 99)
        Me.setDataValueButton.Name = "setDataValueButton"
        Me.setDataValueButton.Size = New System.Drawing.Size(102, 23)
        Me.setDataValueButton.TabIndex = 17
        Me.setDataValueButton.Text = "Set"
        Me.setDataValueButton.UseVisualStyleBackColor = True
        '
        'setPrintableValueButton
        '
        Me.setPrintableValueButton.Location = New System.Drawing.Point(456, 4)
        Me.setPrintableValueButton.Name = "setPrintableValueButton"
        Me.setPrintableValueButton.Size = New System.Drawing.Size(102, 23)
        Me.setPrintableValueButton.TabIndex = 18
        Me.setPrintableValueButton.Text = "Set"
        Me.setPrintableValueButton.UseVisualStyleBackColor = True
        '
        'GS1ValueEditorForm
        '
        Me.AcceptButton = Me.okButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.buttonCancel
        Me.ClientSize = New System.Drawing.Size(570, 366)
        Me.Controls.Add(Me.setPrintableValueButton)
        Me.Controls.Add(Me.setDataValueButton)
        Me.Controls.Add(Me.gs1BarcodePrintableValueTextBox)
        Me.Controls.Add(Me.barcodePrintableValueLabel)
        Me.Controls.Add(Me.formatStructureLabel)
        Me.Controls.Add(Me.aiDataFormatLabel)
        Me.Controls.Add(Me.dataFormatLabel)
        Me.Controls.Add(Me.buttonCancel)
        Me.Controls.Add(Me.okButton)
        Me.Controls.Add(Me.aiListDataGridView)
        Me.Controls.Add(Me.deleteButton)
        Me.Controls.Add(Me.addButton)
        Me.Controls.Add(Me.aiDataContentLabel)
        Me.Controls.Add(Me.dataValueLabel)
        Me.Controls.Add(Me.aiValueTextBox)
        Me.Controls.Add(Me.dataContentLabel)
        Me.Controls.Add(Me.aiNumberComboBox)
        Me.Controls.Add(Me.ApplicationIdentifierLabel)
        Me.Controls.Add(Me.formatStructureValueLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "GS1ValueEditorForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FormGS1ValueEditor"
        CType(Me.aiListDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

	#End Region

	Private WithEvents ApplicationIdentifierLabel As System.Windows.Forms.Label
	Private WithEvents aiNumberComboBox As System.Windows.Forms.ComboBox
	Private WithEvents dataContentLabel As System.Windows.Forms.Label
	Private WithEvents aiValueTextBox As System.Windows.Forms.TextBox
	Private WithEvents dataValueLabel As System.Windows.Forms.Label
	Private WithEvents aiDataContentLabel As System.Windows.Forms.Label
	Private WithEvents addButton As System.Windows.Forms.Button
	Private WithEvents deleteButton As System.Windows.Forms.Button
    Private WithEvents aiListDataGridView As System.Windows.Forms.DataGridView
	Private WithEvents okButton As System.Windows.Forms.Button
	Private WithEvents buttonCancel As System.Windows.Forms.Button
	Private WithEvents dataFormatLabel As System.Windows.Forms.Label
	Private WithEvents aiDataFormatLabel As System.Windows.Forms.Label
	Private WithEvents formatStructureLabel As System.Windows.Forms.Label
	Private WithEvents formatStructureValueLabel As System.Windows.Forms.Label
	Private WithEvents aiNumberColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Private WithEvents aiTitleColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Private WithEvents aiValueColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Private WithEvents barcodePrintableValueLabel As System.Windows.Forms.Label
	Private WithEvents gs1BarcodePrintableValueTextBox As System.Windows.Forms.TextBox
	Private WithEvents setDataValueButton As System.Windows.Forms.Button
	Private WithEvents setPrintableValueButton As System.Windows.Forms.Button
End Class
