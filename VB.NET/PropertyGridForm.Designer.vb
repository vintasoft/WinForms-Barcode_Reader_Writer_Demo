Partial Class PropertyGridForm
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
        Me._propertyGrid = New System.Windows.Forms.PropertyGrid
        Me.panel1 = New System.Windows.Forms.Panel
        Me.buttonCancel = New System.Windows.Forms.Button
        Me.buttonOk = New System.Windows.Forms.Button
        Me.panel2 = New System.Windows.Forms.Panel
        Me.panel1.SuspendLayout()
        Me.panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        '_propertyGrid
        '
        Me._propertyGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me._propertyGrid.Location = New System.Drawing.Point(0, 0)
        Me._propertyGrid.Name = "_propertyGrid"
        Me._propertyGrid.Size = New System.Drawing.Size(441, 270)
        Me._propertyGrid.TabIndex = 0
        Me._propertyGrid.ToolbarVisible = False
        '
        'panel1
        '
        Me.panel1.Controls.Add(Me.buttonCancel)
        Me.panel1.Controls.Add(Me.buttonOk)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel1.Location = New System.Drawing.Point(0, 270)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(441, 49)
        Me.panel1.TabIndex = 1
        '
        'buttonCancel
        '
        Me.buttonCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.buttonCancel.Location = New System.Drawing.Point(354, 14)
        Me.buttonCancel.Name = "buttonCancel"
        Me.buttonCancel.Size = New System.Drawing.Size(75, 23)
        Me.buttonCancel.TabIndex = 1
        Me.buttonCancel.Text = "Cancel"
        Me.buttonCancel.UseVisualStyleBackColor = True
        '
        'buttonOk
        '
        Me.buttonOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonOk.Location = New System.Drawing.Point(273, 14)
        Me.buttonOk.Name = "buttonOk"
        Me.buttonOk.Size = New System.Drawing.Size(75, 23)
        Me.buttonOk.TabIndex = 0
        Me.buttonOk.Text = "OK"
        Me.buttonOk.UseVisualStyleBackColor = True
        '
        'panel2
        '
        Me.panel2.Controls.Add(Me._propertyGrid)
        Me.panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel2.Location = New System.Drawing.Point(0, 0)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(441, 270)
        Me.panel2.TabIndex = 2
        '
        'PropertyGridForm
        '
        Me.AcceptButton = Me.buttonOk
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.buttonCancel
        Me.ClientSize = New System.Drawing.Size(441, 319)
        Me.Controls.Add(Me.panel2)
        Me.Controls.Add(Me.panel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PropertyGridForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "PropertyGridForm"
        Me.panel1.ResumeLayout(False)
        Me.panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

	#End Region

	Friend WithEvents _propertyGrid As System.Windows.Forms.PropertyGrid
	Private WithEvents panel1 As System.Windows.Forms.Panel
	Private WithEvents buttonOk As System.Windows.Forms.Button
	Private WithEvents panel2 As System.Windows.Forms.Panel
	Private WithEvents buttonCancel As System.Windows.Forms.Button
End Class
