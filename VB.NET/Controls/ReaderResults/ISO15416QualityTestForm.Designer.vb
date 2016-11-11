Partial Class ISO15416QualityTestForm
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
        Me.okButton = New System.Windows.Forms.Button
        Me.overallGradeGroupBox = New System.Windows.Forms.GroupBox
        Me.sgHi = New System.Windows.Forms.Label
        Me.sgLow = New System.Windows.Forms.Label
        Me.grade4Label = New System.Windows.Forms.Label
        Me.grade3Label = New System.Windows.Forms.Label
        Me.grade2Label = New System.Windows.Forms.Label
        Me.grade1Label = New System.Windows.Forms.Label
        Me.grade0Label = New System.Windows.Forms.Label
        Me.displayTypeComboBox = New System.Windows.Forms.ComboBox
        Me.groupBox1 = New System.Windows.Forms.GroupBox
        Me.rawDataRadioButton = New System.Windows.Forms.RadioButton
        Me.analysisRadioButton = New System.Windows.Forms.RadioButton
        Me.testResults = New System.Windows.Forms.RichTextBox
        Me.overallGradeGroupBox.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'okButton
        '
        Me.okButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.okButton.Location = New System.Drawing.Point(354, 526)
        Me.okButton.Name = "okButton"
        Me.okButton.Size = New System.Drawing.Size(75, 27)
        Me.okButton.TabIndex = 0
        Me.okButton.Text = "OK"
        Me.okButton.UseVisualStyleBackColor = True
        '
        'overallGradeGroupBox
        '
        Me.overallGradeGroupBox.Controls.Add(Me.sgHi)
        Me.overallGradeGroupBox.Controls.Add(Me.sgLow)
        Me.overallGradeGroupBox.Controls.Add(Me.grade4Label)
        Me.overallGradeGroupBox.Controls.Add(Me.grade3Label)
        Me.overallGradeGroupBox.Controls.Add(Me.grade2Label)
        Me.overallGradeGroupBox.Controls.Add(Me.grade1Label)
        Me.overallGradeGroupBox.Controls.Add(Me.grade0Label)
        Me.overallGradeGroupBox.Location = New System.Drawing.Point(10, 3)
        Me.overallGradeGroupBox.Name = "overallGradeGroupBox"
        Me.overallGradeGroupBox.Size = New System.Drawing.Size(249, 61)
        Me.overallGradeGroupBox.TabIndex = 4
        Me.overallGradeGroupBox.TabStop = False
        Me.overallGradeGroupBox.Text = "Overall Symbol Grade - "
        '
        'sgHi
        '
        Me.sgHi.AutoSize = True
        Me.sgHi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.sgHi.Location = New System.Drawing.Point(218, 27)
        Me.sgHi.Name = "sgHi"
        Me.sgHi.Size = New System.Drawing.Size(24, 13)
        Me.sgHi.TabIndex = 16
        Me.sgHi.Text = "- HI"
        '
        'sgLow
        '
        Me.sgLow.AutoSize = True
        Me.sgLow.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.sgLow.ForeColor = System.Drawing.Color.Black
        Me.sgLow.Location = New System.Drawing.Point(8, 27)
        Me.sgLow.Name = "sgLow"
        Me.sgLow.Size = New System.Drawing.Size(41, 13)
        Me.sgLow.TabIndex = 15
        Me.sgLow.Text = "LOW - "
        '
        'grade4Label
        '
        Me.grade4Label.AutoSize = True
        Me.grade4Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.grade4Label.ForeColor = System.Drawing.Color.Silver
        Me.grade4Label.Location = New System.Drawing.Point(183, 27)
        Me.grade4Label.Name = "grade4Label"
        Me.grade4Label.Size = New System.Drawing.Size(29, 13)
        Me.grade4Label.TabIndex = 14
        Me.grade4Label.Text = "4 (A)"
        '
        'grade3Label
        '
        Me.grade3Label.AutoSize = True
        Me.grade3Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.grade3Label.ForeColor = System.Drawing.Color.Silver
        Me.grade3Label.Location = New System.Drawing.Point(148, 27)
        Me.grade3Label.Name = "grade3Label"
        Me.grade3Label.Size = New System.Drawing.Size(29, 13)
        Me.grade3Label.TabIndex = 13
        Me.grade3Label.Text = "3 (B)"
        '
        'grade2Label
        '
        Me.grade2Label.AutoSize = True
        Me.grade2Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.grade2Label.ForeColor = System.Drawing.Color.Silver
        Me.grade2Label.Location = New System.Drawing.Point(113, 27)
        Me.grade2Label.Name = "grade2Label"
        Me.grade2Label.Size = New System.Drawing.Size(29, 13)
        Me.grade2Label.TabIndex = 12
        Me.grade2Label.Text = "2 (C)"
        '
        'grade1Label
        '
        Me.grade1Label.AutoSize = True
        Me.grade1Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.grade1Label.ForeColor = System.Drawing.Color.Silver
        Me.grade1Label.Location = New System.Drawing.Point(77, 27)
        Me.grade1Label.Name = "grade1Label"
        Me.grade1Label.Size = New System.Drawing.Size(30, 13)
        Me.grade1Label.TabIndex = 11
        Me.grade1Label.Text = "1 (D)"
        '
        'grade0Label
        '
        Me.grade0Label.AutoSize = True
        Me.grade0Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.grade0Label.ForeColor = System.Drawing.Color.Silver
        Me.grade0Label.Location = New System.Drawing.Point(46, 27)
        Me.grade0Label.Name = "grade0Label"
        Me.grade0Label.Size = New System.Drawing.Size(28, 13)
        Me.grade0Label.TabIndex = 10
        Me.grade0Label.Text = "0 (F)"
        '
        'displayTypeComboBox
        '
        Me.displayTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.displayTypeComboBox.FormattingEnabled = True
        Me.displayTypeComboBox.Location = New System.Drawing.Point(7, 15)
        Me.displayTypeComboBox.Name = "displayTypeComboBox"
        Me.displayTypeComboBox.Size = New System.Drawing.Size(143, 21)
        Me.displayTypeComboBox.TabIndex = 5
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.rawDataRadioButton)
        Me.groupBox1.Controls.Add(Me.analysisRadioButton)
        Me.groupBox1.Controls.Add(Me.displayTypeComboBox)
        Me.groupBox1.Location = New System.Drawing.Point(265, 3)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(159, 61)
        Me.groupBox1.TabIndex = 7
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Display Type"
        '
        'rawDataRadioButton
        '
        Me.rawDataRadioButton.AutoSize = True
        Me.rawDataRadioButton.Location = New System.Drawing.Point(81, 38)
        Me.rawDataRadioButton.Name = "rawDataRadioButton"
        Me.rawDataRadioButton.Size = New System.Drawing.Size(75, 17)
        Me.rawDataRadioButton.TabIndex = 7
        Me.rawDataRadioButton.TabStop = True
        Me.rawDataRadioButton.Text = "RAW data"
        Me.rawDataRadioButton.UseVisualStyleBackColor = True
        '
        'analysisRadioButton
        '
        Me.analysisRadioButton.AutoSize = True
        Me.analysisRadioButton.Location = New System.Drawing.Point(7, 38)
        Me.analysisRadioButton.Name = "analysisRadioButton"
        Me.analysisRadioButton.Size = New System.Drawing.Size(63, 17)
        Me.analysisRadioButton.TabIndex = 6
        Me.analysisRadioButton.TabStop = True
        Me.analysisRadioButton.Text = "Analysis"
        Me.analysisRadioButton.UseVisualStyleBackColor = True
        '
        'testResults
        '
        Me.testResults.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.testResults.Font = New System.Drawing.Font("Courier New", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.testResults.Location = New System.Drawing.Point(10, 70)
        Me.testResults.Name = "testResults"
        Me.testResults.ReadOnly = True
        Me.testResults.Size = New System.Drawing.Size(764, 450)
        Me.testResults.TabIndex = 8
        Me.testResults.Text = ""
        Me.testResults.WordWrap = False
        '
        'ISO15416QualityTestForm
        '
        Me.AcceptButton = Me.okButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.testResults)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.overallGradeGroupBox)
        Me.Controls.Add(Me.okButton)
        Me.MinimizeBox = False
        Me.Name = "ISO15416QualityTestForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ISO/IEC 15465 Print Quality Test"
        Me.overallGradeGroupBox.ResumeLayout(False)
        Me.overallGradeGroupBox.PerformLayout()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

	#End Region

	Private WithEvents okButton As System.Windows.Forms.Button
    Private WithEvents overallGradeGroupBox As System.Windows.Forms.GroupBox
	Private WithEvents sgHi As System.Windows.Forms.Label
	Private WithEvents sgLow As System.Windows.Forms.Label
	Private WithEvents grade4Label As System.Windows.Forms.Label
	Private WithEvents grade3Label As System.Windows.Forms.Label
	Private WithEvents grade2Label As System.Windows.Forms.Label
	Private WithEvents grade1Label As System.Windows.Forms.Label
	Private WithEvents grade0Label As System.Windows.Forms.Label
	Private WithEvents displayTypeComboBox As System.Windows.Forms.ComboBox
    Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
	Private WithEvents rawDataRadioButton As System.Windows.Forms.RadioButton
	Private WithEvents analysisRadioButton As System.Windows.Forms.RadioButton
	Private WithEvents testResults As System.Windows.Forms.RichTextBox
End Class
