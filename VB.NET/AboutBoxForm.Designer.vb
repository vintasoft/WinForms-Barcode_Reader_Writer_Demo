Public Partial Class AboutBoxForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AboutBoxForm))
        Me.vintasoftLogoPictureBox = New System.Windows.Forms.PictureBox
        Me.label4 = New System.Windows.Forms.Label
        Me.productFAQLinkLabel = New System.Windows.Forms.LinkLabel
        Me.label3 = New System.Windows.Forms.Label
        Me.productLinkLabel = New System.Windows.Forms.LinkLabel
        Me.label1 = New System.Windows.Forms.Label
        Me.registerLinkLabel = New System.Windows.Forms.LinkLabel
        Me.okButton = New System.Windows.Forms.Button
        Me.panel1 = New System.Windows.Forms.Panel
        Me.imagingSDKVersionLabel = New System.Windows.Forms.Label
        Me.label6 = New System.Windows.Forms.Label
        Me.label2 = New System.Windows.Forms.Label
        Me.forumsLinkLabel = New System.Windows.Forms.LinkLabel
        Me.nameLabel = New System.Windows.Forms.Label
        Me.decriptionRichTextBox = New System.Windows.Forms.RichTextBox
        CType(Me.vintasoftLogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'vintasoftLogoPictureBox
        '
        Me.vintasoftLogoPictureBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.vintasoftLogoPictureBox.BackColor = System.Drawing.Color.Silver
        Me.vintasoftLogoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.vintasoftLogoPictureBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.vintasoftLogoPictureBox.Image = CType(resources.GetObject("vintasoftLogoPictureBox.Image"), System.Drawing.Image)
        Me.vintasoftLogoPictureBox.Location = New System.Drawing.Point(4, 4)
        Me.vintasoftLogoPictureBox.Name = "vintasoftLogoPictureBox"
        Me.vintasoftLogoPictureBox.Size = New System.Drawing.Size(114, 100)
        Me.vintasoftLogoPictureBox.TabIndex = 12
        Me.vintasoftLogoPictureBox.TabStop = False
        '
        'label4
        '
        Me.label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(124, 45)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(31, 13)
        Me.label4.TabIndex = 29
        Me.label4.Text = "FAQ:"
        '
        'productFAQLinkLabel
        '
        Me.productFAQLinkLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.productFAQLinkLabel.AutoSize = True
        Me.productFAQLinkLabel.Location = New System.Drawing.Point(175, 45)
        Me.productFAQLinkLabel.Name = "productFAQLinkLabel"
        Me.productFAQLinkLabel.Size = New System.Drawing.Size(156, 13)
        Me.productFAQLinkLabel.TabIndex = 28
        Me.productFAQLinkLabel.TabStop = True
        Me.productFAQLinkLabel.Text = "www.vintasoft.com/{0}-faq.html"
        '
        'label3
        '
        Me.label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(124, 24)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(33, 13)
        Me.label3.TabIndex = 27
        Me.label3.Text = "Web:"
        '
        'productLinkLabel
        '
        Me.productLinkLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.productLinkLabel.AutoSize = True
        Me.productLinkLabel.Location = New System.Drawing.Point(175, 24)
        Me.productLinkLabel.Name = "productLinkLabel"
        Me.productLinkLabel.Size = New System.Drawing.Size(166, 13)
        Me.productLinkLabel.TabIndex = 26
        Me.productLinkLabel.TabStop = True
        Me.productLinkLabel.Text = "www.vintasoft.com/{0}-index.html"
        '
        'label1
        '
        Me.label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(124, 67)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(49, 13)
        Me.label1.TabIndex = 31
        Me.label1.Text = "Register:"
        '
        'registerLinkLabel
        '
        Me.registerLinkLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.registerLinkLabel.AutoSize = True
        Me.registerLinkLabel.Location = New System.Drawing.Point(175, 67)
        Me.registerLinkLabel.Name = "registerLinkLabel"
        Me.registerLinkLabel.Size = New System.Drawing.Size(158, 13)
        Me.registerLinkLabel.TabIndex = 30
        Me.registerLinkLabel.TabStop = True
        Me.registerLinkLabel.Text = "www.vintasoft.com/register.html"
        '
        'okButton
        '
        Me.okButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.okButton.Location = New System.Drawing.Point(209, 437)
        Me.okButton.Name = "okButton"
        Me.okButton.Size = New System.Drawing.Size(96, 26)
        Me.okButton.TabIndex = 32
        Me.okButton.Text = "OK"
        Me.okButton.UseVisualStyleBackColor = True
        '
        'panel1
        '
        Me.panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel1.Controls.Add(Me.imagingSDKVersionLabel)
        Me.panel1.Controls.Add(Me.label6)
        Me.panel1.Controls.Add(Me.label2)
        Me.panel1.Controls.Add(Me.forumsLinkLabel)
        Me.panel1.Controls.Add(Me.vintasoftLogoPictureBox)
        Me.panel1.Controls.Add(Me.productLinkLabel)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Controls.Add(Me.label3)
        Me.panel1.Controls.Add(Me.registerLinkLabel)
        Me.panel1.Controls.Add(Me.productFAQLinkLabel)
        Me.panel1.Controls.Add(Me.label4)
        Me.panel1.Location = New System.Drawing.Point(5, 316)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(494, 110)
        Me.panel1.TabIndex = 33
        '
        'imagingSDKVersionLabel
        '
        Me.imagingSDKVersionLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.imagingSDKVersionLabel.AutoSize = True
        Me.imagingSDKVersionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.imagingSDKVersionLabel.Location = New System.Drawing.Point(175, 4)
        Me.imagingSDKVersionLabel.Name = "imagingSDKVersionLabel"
        Me.imagingSDKVersionLabel.Size = New System.Drawing.Size(144, 13)
        Me.imagingSDKVersionLabel.TabIndex = 35
        Me.imagingSDKVersionLabel.Text = "VintaSoft Barcode .NET v{0}"
        '
        'label6
        '
        Me.label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(124, 4)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(32, 13)
        Me.label6.TabIndex = 34
        Me.label6.Text = "SDK:"
        '
        'label2
        '
        Me.label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(124, 89)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(44, 13)
        Me.label2.TabIndex = 33
        Me.label2.Text = "Forums:"
        '
        'forumsLinkLabel
        '
        Me.forumsLinkLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.forumsLinkLabel.AutoSize = True
        Me.forumsLinkLabel.Location = New System.Drawing.Point(175, 89)
        Me.forumsLinkLabel.Name = "forumsLinkLabel"
        Me.forumsLinkLabel.Size = New System.Drawing.Size(138, 13)
        Me.forumsLinkLabel.TabIndex = 32
        Me.forumsLinkLabel.TabStop = True
        Me.forumsLinkLabel.Text = "www.vintasoft.com/forums/"
        '
        'nameLabel
        '
        Me.nameLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nameLabel.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.nameLabel.Location = New System.Drawing.Point(5, 7)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(494, 26)
        Me.nameLabel.TabIndex = 34
        Me.nameLabel.Text = "{0} v{1}"
        Me.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'decriptionRichTextBox
        '
        Me.decriptionRichTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.decriptionRichTextBox.Location = New System.Drawing.Point(5, 45)
        Me.decriptionRichTextBox.Name = "decriptionRichTextBox"
        Me.decriptionRichTextBox.ReadOnly = True
        Me.decriptionRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.decriptionRichTextBox.Size = New System.Drawing.Size(494, 258)
        Me.decriptionRichTextBox.TabIndex = 35
        Me.decriptionRichTextBox.Tag = ""
        Me.decriptionRichTextBox.Text = resources.GetString("decriptionRichTextBox.Text")
        '
        'AboutBoxForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(504, 472)
        Me.Controls.Add(Me.decriptionRichTextBox)
        Me.Controls.Add(Me.nameLabel)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.okButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AboutBoxForm"
        Me.Padding = New System.Windows.Forms.Padding(9)
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "About..."
        CType(Me.vintasoftLogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

	#End Region

    Private WithEvents vintasoftLogoPictureBox As System.Windows.Forms.PictureBox
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents productFAQLinkLabel As System.Windows.Forms.LinkLabel
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents productLinkLabel As System.Windows.Forms.LinkLabel
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents registerLinkLabel As System.Windows.Forms.LinkLabel
    Private WithEvents okButton As System.Windows.Forms.Button
    Private WithEvents panel1 As System.Windows.Forms.Panel
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents forumsLinkLabel As System.Windows.Forms.LinkLabel
    Private WithEvents nameLabel As System.Windows.Forms.Label
    Private WithEvents label6 As System.Windows.Forms.Label
    Private WithEvents imagingSDKVersionLabel As System.Windows.Forms.Label
    Protected WithEvents decriptionRichTextBox As System.Windows.Forms.RichTextBox

End Class
