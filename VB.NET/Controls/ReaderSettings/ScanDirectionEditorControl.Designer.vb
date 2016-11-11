Partial Class ScanDirectionEditorControl
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

	#Region "Component Designer generated code"

	''' <summary> 
	''' Required method for Designer support - do not modify 
	''' the contents of this method with the code editor.
	''' </summary>
	Private Sub InitializeComponent()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.directionRB_LTCheckBox = New System.Windows.Forms.CheckBox
        Me.directionLB_RTCheckBox = New System.Windows.Forms.CheckBox
        Me.directionRT_LBCheckBox = New System.Windows.Forms.CheckBox
        Me.directionLT_RBCheckBox = New System.Windows.Forms.CheckBox
        Me.label1 = New System.Windows.Forms.Label
        Me.directionAngle45CheckBox = New System.Windows.Forms.CheckBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.label5 = New System.Windows.Forms.Label
        Me.label7 = New System.Windows.Forms.Label
        Me.directionTBCheckBox = New System.Windows.Forms.CheckBox
        Me.directionRLCheckBox = New System.Windows.Forms.CheckBox
        Me.directionBTCheckBox = New System.Windows.Forms.CheckBox
        Me.directionLRCheckBox = New System.Windows.Forms.CheckBox
        Me.label6 = New System.Windows.Forms.Label
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.directionRB_LTCheckBox)
        Me.GroupBox2.Controls.Add(Me.directionLB_RTCheckBox)
        Me.GroupBox2.Controls.Add(Me.directionRT_LBCheckBox)
        Me.GroupBox2.Controls.Add(Me.directionLT_RBCheckBox)
        Me.GroupBox2.Controls.Add(Me.label1)
        Me.GroupBox2.Controls.Add(Me.directionAngle45CheckBox)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.label5)
        Me.GroupBox2.Controls.Add(Me.label7)
        Me.GroupBox2.Controls.Add(Me.directionTBCheckBox)
        Me.GroupBox2.Controls.Add(Me.directionRLCheckBox)
        Me.GroupBox2.Controls.Add(Me.directionBTCheckBox)
        Me.GroupBox2.Controls.Add(Me.directionLRCheckBox)
        Me.GroupBox2.Controls.Add(Me.label6)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(255, 100)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Scan Direction"
        '
        'directionRB_LTCheckBox
        '
        Me.directionRB_LTCheckBox.Enabled = False
        Me.directionRB_LTCheckBox.Location = New System.Drawing.Point(138, 61)
        Me.directionRB_LTCheckBox.Name = "directionRB_LTCheckBox"
        Me.directionRB_LTCheckBox.Size = New System.Drawing.Size(16, 16)
        Me.directionRB_LTCheckBox.TabIndex = 14
        '
        'directionLB_RTCheckBox
        '
        Me.directionLB_RTCheckBox.Enabled = False
        Me.directionLB_RTCheckBox.Location = New System.Drawing.Point(106, 61)
        Me.directionLB_RTCheckBox.Name = "directionLB_RTCheckBox"
        Me.directionLB_RTCheckBox.Size = New System.Drawing.Size(16, 16)
        Me.directionLB_RTCheckBox.TabIndex = 13
        '
        'directionRT_LBCheckBox
        '
        Me.directionRT_LBCheckBox.Enabled = False
        Me.directionRT_LBCheckBox.Location = New System.Drawing.Point(138, 29)
        Me.directionRT_LBCheckBox.Name = "directionRT_LBCheckBox"
        Me.directionRT_LBCheckBox.Size = New System.Drawing.Size(16, 16)
        Me.directionRT_LBCheckBox.TabIndex = 12
        '
        'directionLT_RBCheckBox
        '
        Me.directionLT_RBCheckBox.Enabled = False
        Me.directionLT_RBCheckBox.Location = New System.Drawing.Point(106, 29)
        Me.directionLT_RBCheckBox.Name = "directionLT_RBCheckBox"
        Me.directionLT_RBCheckBox.Size = New System.Drawing.Size(16, 16)
        Me.directionLT_RBCheckBox.TabIndex = 11
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(19, 17)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(58, 16)
        Me.label1.TabIndex = 10
        Me.label1.Text = "45°/135°"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'directionAngle45CheckBox
        '
        Me.directionAngle45CheckBox.Location = New System.Drawing.Point(6, 19)
        Me.directionAngle45CheckBox.Name = "directionAngle45CheckBox"
        Me.directionAngle45CheckBox.Size = New System.Drawing.Size(16, 16)
        Me.directionAngle45CheckBox.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(36, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Left to right"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'label5
        '
        Me.label5.Location = New System.Drawing.Point(160, 45)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(85, 16)
        Me.label5.TabIndex = 7
        Me.label5.Text = "Right to left"
        Me.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'label7
        '
        Me.label7.Location = New System.Drawing.Point(96, 7)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(80, 16)
        Me.label7.TabIndex = 5
        Me.label7.Text = "Top to bottom"
        Me.label7.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'directionTBCheckBox
        '
        Me.directionTBCheckBox.Checked = True
        Me.directionTBCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.directionTBCheckBox.Location = New System.Drawing.Point(122, 24)
        Me.directionTBCheckBox.Name = "directionTBCheckBox"
        Me.directionTBCheckBox.Size = New System.Drawing.Size(16, 16)
        Me.directionTBCheckBox.TabIndex = 4
        '
        'directionRLCheckBox
        '
        Me.directionRLCheckBox.Checked = True
        Me.directionRLCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.directionRLCheckBox.Location = New System.Drawing.Point(144, 45)
        Me.directionRLCheckBox.Name = "directionRLCheckBox"
        Me.directionRLCheckBox.Size = New System.Drawing.Size(16, 16)
        Me.directionRLCheckBox.TabIndex = 3
        '
        'directionBTCheckBox
        '
        Me.directionBTCheckBox.Checked = True
        Me.directionBTCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.directionBTCheckBox.Location = New System.Drawing.Point(122, 67)
        Me.directionBTCheckBox.Name = "directionBTCheckBox"
        Me.directionBTCheckBox.Size = New System.Drawing.Size(16, 14)
        Me.directionBTCheckBox.TabIndex = 2
        '
        'directionLRCheckBox
        '
        Me.directionLRCheckBox.Checked = True
        Me.directionLRCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.directionLRCheckBox.Location = New System.Drawing.Point(100, 45)
        Me.directionLRCheckBox.Name = "directionLRCheckBox"
        Me.directionLRCheckBox.Size = New System.Drawing.Size(16, 16)
        Me.directionLRCheckBox.TabIndex = 0
        '
        'label6
        '
        Me.label6.Location = New System.Drawing.Point(94, 79)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(72, 13)
        Me.label6.TabIndex = 6
        Me.label6.Text = "Bottom to top"
        Me.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ScanDirectionEditorControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "ScanDirectionEditorControl"
        Me.Size = New System.Drawing.Size(255, 100)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

	#End Region

	Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
	Friend WithEvents directionRB_LTCheckBox As System.Windows.Forms.CheckBox
	Friend WithEvents directionLB_RTCheckBox As System.Windows.Forms.CheckBox
	Friend WithEvents directionRT_LBCheckBox As System.Windows.Forms.CheckBox
	Friend WithEvents directionLT_RBCheckBox As System.Windows.Forms.CheckBox
	Friend WithEvents label1 As System.Windows.Forms.Label
	Friend WithEvents directionAngle45CheckBox As System.Windows.Forms.CheckBox
	Friend WithEvents Label4 As System.Windows.Forms.Label
	Friend WithEvents label5 As System.Windows.Forms.Label
	Friend WithEvents label7 As System.Windows.Forms.Label
	Friend WithEvents directionTBCheckBox As System.Windows.Forms.CheckBox
	Friend WithEvents directionRLCheckBox As System.Windows.Forms.CheckBox
	Friend WithEvents directionBTCheckBox As System.Windows.Forms.CheckBox
	Friend WithEvents directionLRCheckBox As System.Windows.Forms.CheckBox
	Friend WithEvents label6 As System.Windows.Forms.Label
End Class
