Partial Class ParameterEditorControl
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
        Me.valueGroupBox = New System.Windows.Forms.GroupBox
        Me.valueLabel = New System.Windows.Forms.Label
        Me.valueTrackBar = New System.Windows.Forms.TrackBar
        Me.valueGroupBox.SuspendLayout()
        CType(Me.valueTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'valueGroupBox
        '
        Me.valueGroupBox.Controls.Add(Me.valueLabel)
        Me.valueGroupBox.Controls.Add(Me.valueTrackBar)
        Me.valueGroupBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.valueGroupBox.Location = New System.Drawing.Point(0, 0)
        Me.valueGroupBox.Name = "valueGroupBox"
        Me.valueGroupBox.Size = New System.Drawing.Size(190, 81)
        Me.valueGroupBox.TabIndex = 24
        Me.valueGroupBox.TabStop = False
        '
        'valueLabel
        '
        Me.valueLabel.Dock = System.Windows.Forms.DockStyle.Top
        Me.valueLabel.Location = New System.Drawing.Point(3, 16)
        Me.valueLabel.Name = "valueLabel"
        Me.valueLabel.Size = New System.Drawing.Size(184, 16)
        Me.valueLabel.TabIndex = 1
        Me.valueLabel.Text = "5"
        Me.valueLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'valueTrackBar
        '
        Me.valueTrackBar.AutoSize = False
        Me.valueTrackBar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.valueTrackBar.Location = New System.Drawing.Point(3, 40)
        Me.valueTrackBar.Maximum = 20
        Me.valueTrackBar.Minimum = 1
        Me.valueTrackBar.Name = "valueTrackBar"
        Me.valueTrackBar.Size = New System.Drawing.Size(184, 38)
        Me.valueTrackBar.TabIndex = 0
        Me.valueTrackBar.Value = 5
        '
        'ParameterEditorControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.valueGroupBox)
        Me.Name = "ParameterEditorControl"
        Me.Size = New System.Drawing.Size(190, 81)
        Me.valueGroupBox.ResumeLayout(False)
        CType(Me.valueTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

	#End Region

	Friend WithEvents valueGroupBox As System.Windows.Forms.GroupBox
	Friend WithEvents valueLabel As System.Windows.Forms.Label
	Friend WithEvents valueTrackBar As System.Windows.Forms.TrackBar
End Class
