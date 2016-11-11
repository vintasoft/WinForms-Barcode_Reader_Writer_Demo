Imports System.ComponentModel
Imports System.Windows.Forms

Imports Vintasoft.Barcode

''' <summary>
''' Represents an editor of ReaderSettings.ScanDirection property.
''' </summary>
Public Partial Class ScanDirectionEditorControl
	Inherits ReaderSettingsEditorControl

	#Region "Fields"

	Private _enableSetSettings As Boolean = True

	#End Region



	#Region "Constructors"

	Public Sub New()
		InitializeComponent()
	End Sub

	#End Region



	#Region "Methods"

	Private Sub UpdateDirection45()
		Dim direction45 As Boolean = directionAngle45CheckBox.Checked
		directionLB_RTCheckBox.Visible = direction45
		directionLT_RBCheckBox.Visible = direction45
		directionRB_LTCheckBox.Visible = direction45
		directionRT_LBCheckBox.Visible = direction45
		If directionAngle45CheckBox.Checked Then
			directionLT_RBCheckBox.Checked = directionLRCheckBox.Checked OrElse directionTBCheckBox.Checked
			directionRT_LBCheckBox.Checked = directionTBCheckBox.Checked OrElse directionRLCheckBox.Checked
			directionLB_RTCheckBox.Checked = directionLRCheckBox.Checked OrElse directionBTCheckBox.Checked
			directionRB_LTCheckBox.Checked = directionBTCheckBox.Checked OrElse directionRLCheckBox.Checked
		End If
	End Sub

	Public Overrides Sub UpdateUI()
		_enableSetSettings = False

		Dim scanDirection__1 As ScanDirection = BarcodeReaderSettings.ScanDirection
		directionLRCheckBox.Checked = (scanDirection__1 And ScanDirection.LeftToRight) <> 0
		directionRLCheckBox.Checked = (scanDirection__1 And ScanDirection.RightToLeft) <> 0
		directionTBCheckBox.Checked = (scanDirection__1 And ScanDirection.TopToBottom) <> 0
		directionBTCheckBox.Checked = (scanDirection__1 And ScanDirection.BottomToTop) <> 0

		directionAngle45CheckBox.Checked = (scanDirection__1 And ScanDirection.Angle45and135) <> 0
		UpdateDirection45()

		_enableSetSettings = True
	End Sub

    Private Sub direction_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles directionTBCheckBox.CheckedChanged, directionRLCheckBox.CheckedChanged, directionLRCheckBox.CheckedChanged, directionBTCheckBox.CheckedChanged, directionAngle45CheckBox.CheckedChanged
        SetDirection()
    End Sub

	Private Sub SetDirection()
		If Not _enableSetSettings Then
			Return
		End If

		_enableSetSettings = False

		UpdateDirection45()

		Dim scanDirection__1 As ScanDirection = ScanDirection.None
		If directionLRCheckBox.Checked Then
			scanDirection__1 = scanDirection__1 Or ScanDirection.LeftToRight
		End If
		If directionRLCheckBox.Checked Then
			scanDirection__1 = scanDirection__1 Or ScanDirection.RightToLeft
		End If
		If directionTBCheckBox.Checked Then
			scanDirection__1 = scanDirection__1 Or ScanDirection.TopToBottom
		End If
		If directionBTCheckBox.Checked Then
			scanDirection__1 = scanDirection__1 Or ScanDirection.BottomToTop
		End If
		If directionAngle45CheckBox.Checked Then
			scanDirection__1 = scanDirection__1 Or ScanDirection.Angle45and135
		End If

		BarcodeReaderSettings.ScanDirection = scanDirection__1

		_enableSetSettings = True
	End Sub

	#End Region

End Class
