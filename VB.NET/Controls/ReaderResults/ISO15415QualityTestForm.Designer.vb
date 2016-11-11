Partial Class ISO15415QualityTestForm
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
        Me.panel1 = New System.Windows.Forms.Panel
        Me.groupBox1 = New System.Windows.Forms.GroupBox
        Me.centerPatternButton = New System.Windows.Forms.Button
        Me.barcodeSymbolButton = New System.Windows.Forms.Button
        Me.stopPatternButton = New System.Windows.Forms.Button
        Me.startPatternButton = New System.Windows.Forms.Button
        Me.gbScanGrade = New System.Windows.Forms.GroupBox
        Me.sgHi = New System.Windows.Forms.Label
        Me.sgLow = New System.Windows.Forms.Label
        Me.sg4 = New System.Windows.Forms.Label
        Me.sg3 = New System.Windows.Forms.Label
        Me.sg2 = New System.Windows.Forms.Label
        Me.sg1 = New System.Windows.Forms.Label
        Me.sg0 = New System.Windows.Forms.Label
        Me.okButton = New System.Windows.Forms.Button
        Me.panel2 = New System.Windows.Forms.Panel
        Me.dataGridView = New System.Windows.Forms.DataGridView
        Me.cName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cValue = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cGrade = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.panel1.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        Me.gbScanGrade.SuspendLayout()
        Me.panel2.SuspendLayout()
        CType(Me.dataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel1
        '
        Me.panel1.Controls.Add(Me.groupBox1)
        Me.panel1.Controls.Add(Me.gbScanGrade)
        Me.panel1.Controls.Add(Me.okButton)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel1.Location = New System.Drawing.Point(0, 514)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(508, 108)
        Me.panel1.TabIndex = 0
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.centerPatternButton)
        Me.groupBox1.Controls.Add(Me.barcodeSymbolButton)
        Me.groupBox1.Controls.Add(Me.stopPatternButton)
        Me.groupBox1.Controls.Add(Me.startPatternButton)
        Me.groupBox1.Location = New System.Drawing.Point(4, 6)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(500, 51)
        Me.groupBox1.TabIndex = 4
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "ISO15416 Quality Tests (multi-row symbologies: PDF417, MicroPDF417)"
        '
        'centerPatternButton
        '
        Me.centerPatternButton.Location = New System.Drawing.Point(116, 19)
        Me.centerPatternButton.Name = "centerPatternButton"
        Me.centerPatternButton.Size = New System.Drawing.Size(99, 23)
        Me.centerPatternButton.TabIndex = 8
        Me.centerPatternButton.Text = "Center Pattern..."
        Me.centerPatternButton.UseVisualStyleBackColor = True
        '
        'barcodeSymbolButton
        '
        Me.barcodeSymbolButton.Location = New System.Drawing.Point(326, 19)
        Me.barcodeSymbolButton.Name = "barcodeSymbolButton"
        Me.barcodeSymbolButton.Size = New System.Drawing.Size(168, 23)
        Me.barcodeSymbolButton.TabIndex = 7
        Me.barcodeSymbolButton.Text = "Barcode Symbol (informative)..."
        Me.barcodeSymbolButton.UseVisualStyleBackColor = True
        '
        'stopPatternButton
        '
        Me.stopPatternButton.Location = New System.Drawing.Point(221, 19)
        Me.stopPatternButton.Name = "stopPatternButton"
        Me.stopPatternButton.Size = New System.Drawing.Size(99, 23)
        Me.stopPatternButton.TabIndex = 6
        Me.stopPatternButton.Text = "Stop Pattern..."
        Me.stopPatternButton.UseVisualStyleBackColor = True
        '
        'startPatternButton
        '
        Me.startPatternButton.Location = New System.Drawing.Point(11, 19)
        Me.startPatternButton.Name = "startPatternButton"
        Me.startPatternButton.Size = New System.Drawing.Size(96, 23)
        Me.startPatternButton.TabIndex = 5
        Me.startPatternButton.Text = "Start Pattern..."
        Me.startPatternButton.UseVisualStyleBackColor = True
        '
        'gbScanGrade
        '
        Me.gbScanGrade.Controls.Add(Me.sgHi)
        Me.gbScanGrade.Controls.Add(Me.sgLow)
        Me.gbScanGrade.Controls.Add(Me.sg4)
        Me.gbScanGrade.Controls.Add(Me.sg3)
        Me.gbScanGrade.Controls.Add(Me.sg2)
        Me.gbScanGrade.Controls.Add(Me.sg1)
        Me.gbScanGrade.Controls.Add(Me.sg0)
        Me.gbScanGrade.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.gbScanGrade.Location = New System.Drawing.Point(132, 63)
        Me.gbScanGrade.Name = "gbScanGrade"
        Me.gbScanGrade.Size = New System.Drawing.Size(249, 39)
        Me.gbScanGrade.TabIndex = 3
        Me.gbScanGrade.TabStop = False
        Me.gbScanGrade.Text = "Scan Grade (minimum of all grades) - "
        '
        'sgHi
        '
        Me.sgHi.AutoSize = True
        Me.sgHi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.sgHi.Location = New System.Drawing.Point(218, 17)
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
        Me.sgLow.Location = New System.Drawing.Point(8, 17)
        Me.sgLow.Name = "sgLow"
        Me.sgLow.Size = New System.Drawing.Size(41, 13)
        Me.sgLow.TabIndex = 15
        Me.sgLow.Text = "LOW - "
        '
        'sg4
        '
        Me.sg4.AutoSize = True
        Me.sg4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.sg4.ForeColor = System.Drawing.Color.Silver
        Me.sg4.Location = New System.Drawing.Point(183, 17)
        Me.sg4.Name = "sg4"
        Me.sg4.Size = New System.Drawing.Size(29, 13)
        Me.sg4.TabIndex = 14
        Me.sg4.Text = "4 (A)"
        '
        'sg3
        '
        Me.sg3.AutoSize = True
        Me.sg3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.sg3.ForeColor = System.Drawing.Color.Silver
        Me.sg3.Location = New System.Drawing.Point(148, 17)
        Me.sg3.Name = "sg3"
        Me.sg3.Size = New System.Drawing.Size(29, 13)
        Me.sg3.TabIndex = 13
        Me.sg3.Text = "3 (B)"
        '
        'sg2
        '
        Me.sg2.AutoSize = True
        Me.sg2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.sg2.ForeColor = System.Drawing.Color.Silver
        Me.sg2.Location = New System.Drawing.Point(113, 17)
        Me.sg2.Name = "sg2"
        Me.sg2.Size = New System.Drawing.Size(29, 13)
        Me.sg2.TabIndex = 12
        Me.sg2.Text = "2 (C)"
        '
        'sg1
        '
        Me.sg1.AutoSize = True
        Me.sg1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.sg1.ForeColor = System.Drawing.Color.Silver
        Me.sg1.Location = New System.Drawing.Point(77, 17)
        Me.sg1.Name = "sg1"
        Me.sg1.Size = New System.Drawing.Size(30, 13)
        Me.sg1.TabIndex = 11
        Me.sg1.Text = "1 (D)"
        '
        'sg0
        '
        Me.sg0.AutoSize = True
        Me.sg0.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.sg0.ForeColor = System.Drawing.Color.Silver
        Me.sg0.Location = New System.Drawing.Point(46, 17)
        Me.sg0.Name = "sg0"
        Me.sg0.Size = New System.Drawing.Size(28, 13)
        Me.sg0.TabIndex = 10
        Me.sg0.Text = "0 (F)"
        '
        'okButton
        '
        Me.okButton.Location = New System.Drawing.Point(429, 73)
        Me.okButton.Name = "okButton"
        Me.okButton.Size = New System.Drawing.Size(75, 27)
        Me.okButton.TabIndex = 0
        Me.okButton.Text = "OK"
        Me.okButton.UseVisualStyleBackColor = True
        '
        'panel2
        '
        Me.panel2.Controls.Add(Me.dataGridView)
        Me.panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel2.Location = New System.Drawing.Point(0, 0)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(508, 514)
        Me.panel2.TabIndex = 1
        '
        'dataGridView
        '
        Me.dataGridView.AllowUserToAddRows = False
        Me.dataGridView.AllowUserToDeleteRows = False
        Me.dataGridView.AllowUserToResizeColumns = False
        Me.dataGridView.AllowUserToResizeRows = False
        Me.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cName, Me.cValue, Me.cGrade})
        Me.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dataGridView.Location = New System.Drawing.Point(0, 0)
        Me.dataGridView.MultiSelect = False
        Me.dataGridView.Name = "dataGridView"
        Me.dataGridView.ReadOnly = True
        Me.dataGridView.RowHeadersVisible = False
        Me.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataGridView.ShowEditingIcon = False
        Me.dataGridView.Size = New System.Drawing.Size(508, 514)
        Me.dataGridView.TabIndex = 1
        '
        'cName
        '
        Me.cName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.cName.FillWeight = 130.0!
        Me.cName.HeaderText = "Name"
        Me.cName.Name = "cName"
        Me.cName.ReadOnly = True
        '
        'cValue
        '
        Me.cValue.HeaderText = "Value"
        Me.cValue.Name = "cValue"
        Me.cValue.ReadOnly = True
        '
        'cGrade
        '
        Me.cGrade.HeaderText = "Grade"
        Me.cGrade.Name = "cGrade"
        Me.cGrade.ReadOnly = True
        Me.cGrade.Width = 110
        '
        'ISO15415QualityTestForm
        '
        Me.AcceptButton = Me.okButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(508, 622)
        Me.Controls.Add(Me.panel2)
        Me.Controls.Add(Me.panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ISO15415QualityTestForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ISO/IEC 15415 Print Quality Test"
        Me.panel1.ResumeLayout(False)
        Me.groupBox1.ResumeLayout(False)
        Me.gbScanGrade.ResumeLayout(False)
        Me.gbScanGrade.PerformLayout()
        Me.panel2.ResumeLayout(False)
        CType(Me.dataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

	#End Region

    Private WithEvents panel1 As System.Windows.Forms.Panel
    Private WithEvents okButton As System.Windows.Forms.Button
    Private WithEvents panel2 As System.Windows.Forms.Panel
    Private WithEvents dataGridView As System.Windows.Forms.DataGridView
    Private WithEvents cName As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents cValue As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents cGrade As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents gbScanGrade As System.Windows.Forms.GroupBox
    Private WithEvents sgHi As System.Windows.Forms.Label
    Private WithEvents sgLow As System.Windows.Forms.Label
    Private WithEvents sg4 As System.Windows.Forms.Label
    Private WithEvents sg3 As System.Windows.Forms.Label
    Private WithEvents sg2 As System.Windows.Forms.Label
    Private WithEvents sg1 As System.Windows.Forms.Label
    Private WithEvents sg0 As System.Windows.Forms.Label
    Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents stopPatternButton As System.Windows.Forms.Button
    Private WithEvents startPatternButton As System.Windows.Forms.Button
    Private WithEvents barcodeSymbolButton As System.Windows.Forms.Button
    Private WithEvents centerPatternButton As System.Windows.Forms.Button

End Class
