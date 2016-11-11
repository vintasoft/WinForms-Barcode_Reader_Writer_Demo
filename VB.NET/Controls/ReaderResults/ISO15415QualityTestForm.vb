Imports System.Drawing
Imports System.Globalization
Imports System.Windows.Forms
Imports Vintasoft.Barcode.BarcodeInfo
Imports Vintasoft.Barcode.QualityTests

Public Partial Class ISO15415QualityTestForm
	Inherits Form

	#Region "Fields"

	Private _test As ISO15415QualityTest

	#End Region



	#Region "Constructors"

	Public Sub New(barcodeInfo As BarcodeInfo2D, barcodeImage As Image, invertImageColors As Boolean)
		InitializeComponent()
		Dim test As New ISO15415QualityTest(barcodeInfo, barcodeImage, invertImageColors)
		_test = test

		If test.StartPatternTestGrade <> ISO15415QualityGrade.Unavailable Then
			AddRow("Start Pattern", test.StartPatternTest.OverallSymbolGradeValue, "", test.StartPatternTestGrade)
		End If
		If test.CenterPatternTestGrade <> ISO15415QualityGrade.Unavailable Then
			AddRow("Center Pattern", test.CenterPatternTest.OverallSymbolGradeValue, "", test.CenterPatternTestGrade)
		End If
		If test.StopPatternTestGrade <> ISO15415QualityGrade.Unavailable Then
			AddRow("Stop Pattern", test.StopPatternTest.OverallSymbolGradeValue, "", test.StopPatternTestGrade)
		End If

		Dim decodeValue As String = "Passed"
		If test.DecodeGrade = ISO15415QualityGrade.F Then
			decodeValue = "Falied"
		End If
		AddRow("Decode", Single.MinValue, decodeValue, test.DecodeGrade)

		AddRow("Unused Error Correction", test.UnusedErrorCorrection, "%", test.UnusedErrorCorrectionGrade)

		If test.CodewordYieldGrade <> ISO15415QualityGrade.Unavailable Then
			AddRow("Codeword Yield", Math.Round(test.CodewordYield), "%", test.CodewordYieldGrade)
		End If

		If test.CodewordPrintQualityModulationGrade <> ISO15415QualityGrade.Unavailable Then
			AddRow("Codeword Print Quality Modulation", Single.MinValue, "", test.CodewordPrintQualityModulationGrade)
		End If

		If test.CodewordPrintQualityDefectsGrade <> ISO15415QualityGrade.Unavailable Then
			AddRow("Codeword Print Quality Defects", Single.MinValue, "", test.CodewordPrintQualityDefectsGrade)
		End If

		If test.CodewordPrintQualityDecodabilityGrade <> ISO15415QualityGrade.Unavailable Then
			AddRow("Codeword Print Quality Decodability", Single.MinValue, "", test.CodewordPrintQualityDecodabilityGrade)
		End If

		If test.CodewordPrintQualityGrade <> ISO15415QualityGrade.Unavailable Then
			AddRow("Codeword Print Quality", Single.MinValue, "", test.CodewordPrintQualityGrade)
		End If

		If test.MinReflectance <> Single.MinValue Then
			AddRow("Min Reflectance", test.MinReflectance, "%", ISO15415QualityGrade.Unavailable)
		End If
		If test.MaxReflectance <> Single.MinValue Then
			AddRow("Max Reflectance", test.MaxReflectance, "%", ISO15415QualityGrade.Unavailable)
		End If
		If test.GlobalThreshold <> Single.MinValue Then
			AddRow("Global Threshold", test.GlobalThreshold, "%", ISO15415QualityGrade.Unavailable)
		End If
		If test.SymbolContrast <> Single.MinValue Then
			AddRow("Symbol Contrast", test.SymbolContrast, "%", test.SymbolContrastGrade)
		End If
		If test.AxialNonuniformity <> Single.MinValue Then
			AddRow("Axial Nonuniformity", test.AxialNonuniformity, "", test.AxialNonuniformityGrade)
		End If
		If test.GridNonuniformity <> Single.MinValue Then
			AddRow("Grid Nonuniformity", test.GridNonuniformity, " (cell)", test.GridNonuniformityGrade)
		End If
		If test.ModulationGrade <> ISO15415QualityGrade.Unavailable Then
			AddRow("Modulation", Single.MinValue, "", test.ModulationGrade)
		End If
		If test.ReflectanceMarginGrade <> ISO15415QualityGrade.Unavailable Then
			AddRow("Reflectance Margin", Single.MinValue, "", test.ReflectanceMarginGrade)
		End If
		If test.FixedPatternDamageGrade <> ISO15415QualityGrade.Unavailable Then
			AddRow("Fixed Pattern Damage", Single.MinValue, "", test.FixedPatternDamageGrade)
		End If
		For Each name As String In test.AdditionalGrades.Keys
			AddRow(name, Single.MinValue, "", test.AdditionalGrades(name))
		Next
		If test.QuietZone >= 0 Then
			AddRow("Quiet Zone", test.QuietZone, "%", test.QuietZoneGrade)
		End If
		AddRow("Distortion Angle", test.DistortionAngle, "°", ISO15415QualityGrade.Unavailable)
		If test.ContrastUniformity <> Single.MinValue Then
			AddRow("Contrast Uniformity", test.ContrastUniformity, "", ISO15415QualityGrade.Unavailable)
		End If
		Dim scanGrade As ISO15415QualityGrade = test.ScanGrade
		Dim sgColor As Color = Color.Empty
		Dim sgLabel As Label = Nothing
		Select Case scanGrade
			Case ISO15415QualityGrade.A
				sgColor = Color.Green
				sgLabel = sg4
				sgHi.ForeColor = sgColor
				Exit Select
			Case ISO15415QualityGrade.B
				sgColor = Color.Green
				sgLabel = sg3
				Exit Select
			Case ISO15415QualityGrade.C
				sgColor = Color.FromArgb(230, 163, 42)
				sgLabel = sg2
				Exit Select
			Case ISO15415QualityGrade.D
				sgColor = Color.FromArgb(180, 0, 0)
				sgLabel = sg1
				Exit Select
			Case ISO15415QualityGrade.F
				sgColor = Color.FromArgb(255, 0, 0)
				sgLabel = sg0
				sgLow.ForeColor = sgColor
				Exit Select

		End Select
		gbScanGrade.Text += String.Format("{0} ({1})", CInt(scanGrade), scanGrade)
		If sgLabel IsNot Nothing Then
			sgLabel.ForeColor = sgColor
			sgLabel.Font = New Font(sgLabel.Font, FontStyle.Bold)
		End If
		startPatternButton.Enabled = test.StartPatternTest IsNot Nothing
		centerPatternButton.Enabled = test.CenterPatternTest IsNot Nothing
		stopPatternButton.Enabled = test.StopPatternTest IsNot Nothing
		barcodeSymbolButton.Enabled = test.SymbolIso15416QualityTest IsNot Nothing
	End Sub

	#End Region



	#Region "Methods"

	Private Sub AddRow(name As String, value As Double, units As String, grade As ISO15415QualityGrade)
		Dim index As Integer = dataGridView.Rows.Count
		dataGridView.Rows.Add()
		dataGridView.Rows(index).Cells(0).Value = name
		Dim gradeValue As String
		If grade = ISO15415QualityGrade.Unavailable Then
			gradeValue = "Unavailable"
		Else
			gradeValue = String.Format("{0} ({1})", CInt(grade), grade)
		End If
		If grade <> ISO15415QualityGrade.Unavailable OrElse value <> Single.MinValue Then
			If value <> Single.MinValue Then
				Dim val As String
				If units = "%" Then
					val = String.Format(CultureInfo.InvariantCulture, "{0:f1}%", value, units)
				ElseIf units <> "" Then
					val = String.Format(CultureInfo.InvariantCulture, "{0:f2}{1}", value, units)
				Else
					val = String.Format(CultureInfo.InvariantCulture, "{0:f2}", value)
				End If
				dataGridView.Rows(index).Cells(1).Value = val
			Else
				dataGridView.Rows(index).Cells(1).Value = units
			End If
		End If
		dataGridView.Rows(index).Cells(2).Value = gradeValue
	End Sub

    Private Sub startPatternButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles startPatternButton.Click
        Using form As New ISO15416QualityTestForm(_test.StartPatternTest)
            form.ShowDialog()
        End Using
    End Sub

    Private Sub centerPatternButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles centerPatternButton.Click
        Using form As New ISO15416QualityTestForm(_test.CenterPatternTest)
            form.ShowDialog()
        End Using
    End Sub

    Private Sub stopPatternButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles stopPatternButton.Click
        Using form As New ISO15416QualityTestForm(_test.StopPatternTest)
            form.ShowDialog()
        End Using
    End Sub


    Private Sub barcodeSymbolButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles barcodeSymbolButton.Click
        Using form As New ISO15416QualityTestForm(_test.SymbolIso15416QualityTest)
            form.ShowDialog()
        End Using
    End Sub

    Private Sub okButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles okButton.Click
        Close()
    End Sub

	#End Region

End Class
