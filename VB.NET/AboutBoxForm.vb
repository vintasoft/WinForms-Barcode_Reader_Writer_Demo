Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Reflection
Imports System.Windows.Forms
Imports Vintasoft.Barcode

Public Partial Class AboutBoxForm
	Inherits Form

	#Region "Constructors"

	Public Sub New()
		InitializeComponent()
	End Sub

	Public Sub New(productPrefix As String)
		Me.New()
		nameLabel.Text = String.Format(nameLabel.Text, AssemblyTitle, AssemblyShortVersion)
		imagingSDKVersionLabel.Text = String.Format(imagingSDKVersionLabel.Text, AssemblyVersion)
		productLinkLabel.Text = String.Format(productLinkLabel.Text, productPrefix)
		productFAQLinkLabel.Text = String.Format(productFAQLinkLabel.Text, productPrefix)
	End Sub

	#End Region



	#Region "Properties"

	<Browsable(False)> _
	Public ReadOnly Property AssemblyTitle() As String
		Get

			Dim attributes As Object() = Assembly.GetEntryAssembly().GetCustomAttributes(GetType(AssemblyTitleAttribute), False)
			If attributes.Length > 0 Then
				Dim titleAttribute As AssemblyTitleAttribute = DirectCast(attributes(0), AssemblyTitleAttribute)
				If titleAttribute.Title <> "" Then
					Return titleAttribute.Title
				End If
			End If
			Return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase)
		End Get
	End Property

	<Browsable(False)> _
	Public ReadOnly Property AssemblyVersion() As String
		Get
			Return Assembly.GetAssembly(GetType(IBarcodeInfo)).GetName().Version.ToString()
		End Get
	End Property

	<Browsable(False)> _
	Public ReadOnly Property AssemblyShortVersion() As String
		Get
			Dim ver As Version = Assembly.GetAssembly(GetType(IBarcodeInfo)).GetName().Version
			Return String.Format("{0}.{1}", ver.Major, ver.Minor)
		End Get
	End Property

	#End Region



	#Region "Methods"

	Protected Overrides Sub OnLoad(e As EventArgs)
		Text = "About..."
		MyBase.OnLoad(e)
	End Sub

    Private Sub okButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles okButton.Click
        Close()
    End Sub

    Private Sub linkLabel_LinkClicked(ByVal sender As Object, ByVal e As LinkLabelLinkClickedEventArgs) Handles registerLinkLabel.LinkClicked, productLinkLabel.LinkClicked, productFAQLinkLabel.LinkClicked, forumsLinkLabel.LinkClicked
        Process.Start(String.Format("http://{0}", DirectCast(sender, LinkLabel).Text))
    End Sub

    Private Sub vintasoftLogoPictureBox_Click(ByVal sender As Object, ByVal e As EventArgs) Handles vintasoftLogoPictureBox.Click
        Process.Start("http://www.vintasoft.com")
    End Sub

	#End Region

End Class
