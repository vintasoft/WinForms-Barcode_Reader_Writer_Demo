Partial Class GetSizeForm
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
        Me.buttonOK = New System.Windows.Forms.Button
        Me.buttonCancel = New System.Windows.Forms.Button
        Me.labelSize = New System.Windows.Forms.Label
        Me.variableValue = New System.Windows.Forms.TextBox
        Me.dpiValue = New System.Windows.Forms.NumericUpDown
        Me.label1 = New System.Windows.Forms.Label
        Me.cbUnits = New System.Windows.Forms.ComboBox
        Me.label2 = New System.Windows.Forms.Label
        CType(Me.dpiValue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'buttonOK
        '
        Me.buttonOK.Location = New System.Drawing.Point(15, 108)
        Me.buttonOK.Name = "buttonOK"
        Me.buttonOK.Size = New System.Drawing.Size(75, 23)
        Me.buttonOK.TabIndex = 0
        Me.buttonOK.Text = "OK"
        Me.buttonOK.UseVisualStyleBackColor = True
        '
        'buttonCancel
        '
        Me.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.buttonCancel.Location = New System.Drawing.Point(115, 108)
        Me.buttonCancel.Name = "buttonCancel"
        Me.buttonCancel.Size = New System.Drawing.Size(75, 23)
        Me.buttonCancel.TabIndex = 1
        Me.buttonCancel.Text = "Cancel"
        Me.buttonCancel.UseVisualStyleBackColor = True
        '
        'labelSize
        '
        Me.labelSize.AutoSize = True
        Me.labelSize.Location = New System.Drawing.Point(12, 9)
        Me.labelSize.Name = "labelSize"
        Me.labelSize.Size = New System.Drawing.Size(24, 13)
        Me.labelSize.TabIndex = 2
        Me.labelSize.Text = "{0}:"
        '
        'variableValue
        '
        Me.variableValue.Location = New System.Drawing.Point(15, 25)
        Me.variableValue.Name = "variableValue"
        Me.variableValue.Size = New System.Drawing.Size(75, 20)
        Me.variableValue.TabIndex = 3
        Me.variableValue.Text = "0"
        '
        'dpiValue
        '
        Me.dpiValue.Location = New System.Drawing.Point(15, 73)
        Me.dpiValue.Maximum = New Decimal(New Integer() {6000, 0, 0, 0})
        Me.dpiValue.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.dpiValue.Name = "dpiValue"
        Me.dpiValue.Size = New System.Drawing.Size(75, 20)
        Me.dpiValue.TabIndex = 4
        Me.dpiValue.Value = New Decimal(New Integer() {96, 0, 0, 0})
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(12, 57)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(60, 13)
        Me.label1.TabIndex = 5
        Me.label1.Text = "Resolution:"
        '
        'cbUnits
        '
        Me.cbUnits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbUnits.FormattingEnabled = True
        Me.cbUnits.Location = New System.Drawing.Point(99, 25)
        Me.cbUnits.Name = "cbUnits"
        Me.cbUnits.Size = New System.Drawing.Size(91, 21)
        Me.cbUnits.TabIndex = 6
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(96, 80)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(25, 13)
        Me.label2.TabIndex = 7
        Me.label2.Text = "DPI"
        '
        'GetSizeForm
        '
        Me.AcceptButton = Me.buttonOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.buttonCancel
        Me.ClientSize = New System.Drawing.Size(208, 143)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.cbUnits)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.dpiValue)
        Me.Controls.Add(Me.variableValue)
        Me.Controls.Add(Me.labelSize)
        Me.Controls.Add(Me.buttonCancel)
        Me.Controls.Add(Me.buttonOK)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "GetSizeForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Set {0}"
        CType(Me.dpiValue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

	#End Region

	Private WithEvents buttonOK As System.Windows.Forms.Button
	Private WithEvents buttonCancel As System.Windows.Forms.Button
	Private WithEvents labelSize As System.Windows.Forms.Label
	Private WithEvents variableValue As System.Windows.Forms.TextBox
	Private WithEvents dpiValue As System.Windows.Forms.NumericUpDown
	Private WithEvents label1 As System.Windows.Forms.Label
	Private WithEvents cbUnits As System.Windows.Forms.ComboBox
	Private WithEvents label2 As System.Windows.Forms.Label
End Class
