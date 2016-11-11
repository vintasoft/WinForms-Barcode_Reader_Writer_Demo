Partial Class SelectImageFrameForm
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
        Me.label1 = New System.Windows.Forms.Label
        Me.selectButton = New System.Windows.Forms.Button
        Me.frameNumber = New System.Windows.Forms.NumericUpDown
        CType(Me.frameNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(12, 14)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(218, 13)
        Me.label1.TabIndex = 0
        Me.label1.Text = "This image contains {0} frames, select frame:"
        '
        'selectButton
        '
        Me.selectButton.Location = New System.Drawing.Point(144, 40)
        Me.selectButton.Name = "selectButton"
        Me.selectButton.Size = New System.Drawing.Size(75, 23)
        Me.selectButton.TabIndex = 1
        Me.selectButton.Text = "Select"
        Me.selectButton.UseVisualStyleBackColor = True
        '
        'frameNumber
        '
        Me.frameNumber.Location = New System.Drawing.Point(254, 12)
        Me.frameNumber.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.frameNumber.Name = "frameNumber"
        Me.frameNumber.Size = New System.Drawing.Size(82, 20)
        Me.frameNumber.TabIndex = 2
        Me.frameNumber.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'SelectImageFrameForm
        '
        Me.AcceptButton = Me.selectButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(348, 71)
        Me.Controls.Add(Me.frameNumber)
        Me.Controls.Add(Me.selectButton)
        Me.Controls.Add(Me.label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SelectImageFrameForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Frame select"
        CType(Me.frameNumber, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

	#End Region

	Private WithEvents label1 As System.Windows.Forms.Label
	Private WithEvents selectButton As System.Windows.Forms.Button
	Private WithEvents frameNumber As System.Windows.Forms.NumericUpDown
End Class
