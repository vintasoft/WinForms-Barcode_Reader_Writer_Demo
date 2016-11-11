Partial Class SelectPdfPageForm
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
        Me.selectButton = New System.Windows.Forms.Button
        Me.label1 = New System.Windows.Forms.Label
        Me.pages = New System.Windows.Forms.ComboBox
        Me.SuspendLayout()
        '
        'selectButton
        '
        Me.selectButton.Location = New System.Drawing.Point(167, 37)
        Me.selectButton.Name = "selectButton"
        Me.selectButton.Size = New System.Drawing.Size(75, 28)
        Me.selectButton.TabIndex = 4
        Me.selectButton.Text = "Select"
        Me.selectButton.UseVisualStyleBackColor = True
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(7, 10)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(281, 13)
        Me.label1.TabIndex = 3
        Me.label1.Text = "This PDF file contains {0} pages with images, select page:"
        '
        'pages
        '
        Me.pages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.pages.FormattingEnabled = True
        Me.pages.Location = New System.Drawing.Point(294, 7)
        Me.pages.Name = "pages"
        Me.pages.Size = New System.Drawing.Size(86, 21)
        Me.pages.TabIndex = 5
        '
        'SelectPdfPageForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(399, 73)
        Me.Controls.Add(Me.pages)
        Me.Controls.Add(Me.selectButton)
        Me.Controls.Add(Me.label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SelectPdfPageForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Select a PDF page number"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

	#End Region

	Private WithEvents selectButton As System.Windows.Forms.Button
	Private WithEvents label1 As System.Windows.Forms.Label
	Private WithEvents pages As System.Windows.Forms.ComboBox
End Class
