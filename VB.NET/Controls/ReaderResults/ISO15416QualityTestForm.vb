Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Vintasoft.Barcode.BarcodeInfo
Imports Vintasoft.Barcode.QualityTests
Imports System.Collections.Generic
Imports System.Globalization

Public Partial Class ISO15416QualityTestForm
	Inherits Form

	#Region "Fields"

	''' <summary>
	''' ISO-15416 quality test.
	''' </summary>
	Private _test As ISO15416QualityTest

	''' <summary>
	''' List of all scan profiles.
	''' </summary>
	Private _profiles As New List(Of ISO15416ScanReflectanceProfile)()

	#End Region



	#Region "Contstructors"

	Public Sub New()
		InitializeComponent()
	End Sub

	Public Sub New(info As BarcodeInfo1D, barcodeImage As Image, invertBarcodeImage As Boolean)
		Me.New()
		_test = New ISO15416QualityTest(info, barcodeImage, invertBarcodeImage)

		UpdateUI()
	End Sub

	Public Sub New(test As ISO15416QualityTest)
		Me.New()
		_test = test

		UpdateUI()
	End Sub

	#End Region



	#Region "Methods"

	#Region "Event handlers"

    Private Sub okButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles okButton.Click
        Close()
    End Sub

    Private Sub infoTypeComboBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles displayTypeComboBox.SelectedIndexChanged
        UpdateTextDisplay()
    End Sub

    Private Sub analysisRadioButton_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles analysisRadioButton.CheckedChanged
        UpdateTextDisplay()
    End Sub

    Private Sub imageRadioButton_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rawDataRadioButton.CheckedChanged
        UpdateTextDisplay()
    End Sub

	#End Region


	''' <summary>
	''' Updates user interface.
	''' </summary>
	Private Sub UpdateUI()
		displayTypeComboBox.Items.Add("Summary")
		displayTypeComboBox.SelectedIndex = 0
		If _test.SymbolComponentQualityTests.Length = 1 Then
			Dim test As ISO15416SymbolComponentQualityTest = _test.SymbolComponentQualityTests(0)
			For i As Integer = 0 To test.ScanReflectanceProfiles.Length - 1
				displayTypeComboBox.Items.Add(String.Format("Profile {0}", i + 1))
			Next
			_profiles.AddRange(test.ScanReflectanceProfiles)
		Else
			For j As Integer = 0 To _test.SymbolComponentQualityTests.Length - 1
				Dim test As ISO15416SymbolComponentQualityTest = _test.SymbolComponentQualityTests(j)
				For i As Integer = 0 To test.ScanReflectanceProfiles.Length - 1
					displayTypeComboBox.Items.Add(String.Format("Component {0}, profile {1}", j + 1, i + 1))
				Next
				_profiles.AddRange(test.ScanReflectanceProfiles)
			Next
		End If
		analysisRadioButton.Checked = True

		Dim qualityGradeColor As Color = GetGradeColor(_test.OverallSymbolGrade)
		Dim qualityGradeLabel As Label = Nothing
		Select Case _test.OverallSymbolGrade
			Case ISO15416QualityGrade.A
				qualityGradeLabel = grade4Label
				sgHi.ForeColor = qualityGradeColor
				Exit Select
			Case ISO15416QualityGrade.B
				qualityGradeLabel = grade3Label
				Exit Select
			Case ISO15416QualityGrade.C
				qualityGradeLabel = grade2Label
				Exit Select
			Case ISO15416QualityGrade.D
				qualityGradeLabel = grade1Label
				Exit Select
			Case ISO15416QualityGrade.F
				qualityGradeLabel = grade0Label
				sgLow.ForeColor = qualityGradeColor
				Exit Select
		End Select
		overallGradeGroupBox.Text += String.Format("{0:f2} ({1})", _test.OverallSymbolGradeValue, _test.OverallSymbolGrade)
		qualityGradeLabel.ForeColor = qualityGradeColor
		qualityGradeLabel.Font = New Font(qualityGradeLabel.Font, FontStyle.Bold)
	End Sub

	''' <summary>
	''' Gets a color of specified grade.
	''' </summary>
	Private Function GetGradeColor(grade As ISO15416QualityGrade) As Color
		Select Case grade
			Case ISO15416QualityGrade.A, ISO15416QualityGrade.B
				Return Color.Green
			Case ISO15416QualityGrade.C
				Return Color.FromArgb(230, 163, 42)
			Case ISO15416QualityGrade.D
				Return Color.FromArgb(180, 0, 0)
			Case ISO15416QualityGrade.F
				Return Color.FromArgb(255, 0, 0)
		End Select
		Return Color.FromArgb(255, 0, 0)
	End Function

	''' <summary>
	''' Updates information about selected scan reflectance profile.
	''' </summary>
	Private Sub UpdateTextDisplay()
		Dim sb As New StringBuilder()
		Dim fontSize As Single
		' If summary information is displayed.
		If displayTypeComboBox.SelectedIndex = 0 Then
			analysisRadioButton.Enabled = False
			rawDataRadioButton.Enabled = False
			fontSize = 9.75F

			' Overall symbol grade.
			sb.AppendLine(String.Format("Overall symbol grade: {0:f2} ({1})", _test.OverallSymbolGradeValue, _test.OverallSymbolGrade))
			sb.AppendLine()

			' Check DifferentDecodedValues flag.
			If _test.DifferentDecodedValues Then
				sb.Append("Attention! Scan reflectance profiles has different decoded barcode values!")
				sb.AppendLine()
			End If

			' Draw line that contains all profiles grade.
			sb.AppendLine("Scan reflectance profiles grades:")
			If _test.SymbolComponentQualityTests.Length = 1 Then
				Dim test As ISO15416SymbolComponentQualityTest = _test.SymbolComponentQualityTests(0)
				For i As Integer = 0 To test.ScanReflectanceProfiles.Length - 1
					sb.Append(test.ScanReflectanceProfiles(i).ScanGrade.ToString())
				Next
				sb.AppendLine()
			Else
				For j As Integer = 0 To _test.SymbolComponentQualityTests.Length - 1
					Dim test As ISO15416SymbolComponentQualityTest = _test.SymbolComponentQualityTests(j)
					sb.Append(String.Format("Symbol component {0}: ", j + 1))
					For i As Integer = 0 To test.ScanReflectanceProfiles.Length - 1
						sb.Append(test.ScanReflectanceProfiles(i).ScanGrade.ToString())
					Next
					sb.AppendLine()
				Next
			End If
			sb.AppendLine()

			' Append analysis of all scan reflectance profiles.
			sb.AppendLine("Scan reflectance profiles analysis:")
			sb.AppendLine()
			If _test.SymbolComponentQualityTests.Length = 1 Then
				Dim test As ISO15416SymbolComponentQualityTest = _test.SymbolComponentQualityTests(0)
				sb.AppendLine("Average scan reflectance profile values:")
				sb.AppendLine(GetProfileInfo(test.AverageScanReflectanceProfileValues))
				For i As Integer = 0 To test.ScanReflectanceProfiles.Length - 1
					Dim profile As ISO15416ScanReflectanceProfile = test.ScanReflectanceProfiles(i)
					sb.AppendLine(String.Format("Profile {0}:", i + 1))
					sb.AppendLine(GetProfileInfo(profile))
				Next
			Else
				For j As Integer = 0 To _test.SymbolComponentQualityTests.Length - 1
					Dim test As ISO15416SymbolComponentQualityTest = _test.SymbolComponentQualityTests(j)
					sb.AppendLine(String.Format("Average scan reflectance profile values (symbol component {0}):", j + 1))
					sb.AppendLine(GetProfileInfo(test.AverageScanReflectanceProfileValues))
					For i As Integer = 0 To test.ScanReflectanceProfiles.Length - 1
						Dim profile As ISO15416ScanReflectanceProfile = test.ScanReflectanceProfiles(i)
						sb.AppendLine(String.Format("Symbol component {0}, profile {1}:", j + 1, i + 1))
						sb.AppendLine(GetProfileInfo(profile))
					Next
				Next
			End If
			testResults.Font = New Font(testResults.Font.FontFamily, 9.75F)
		Else
			' If information about single profile is displayed.
			Dim index As Integer = displayTypeComboBox.SelectedIndex - 1
			Dim profile As ISO15416ScanReflectanceProfile = _profiles(index)
			analysisRadioButton.Enabled = True
			rawDataRadioButton.Enabled = True
			If analysisRadioButton.Checked Then
				' Append profile analysis.
				fontSize = 9.75F
				sb.AppendLine(String.Format("Profile {0} analysis:", index + 1))
				sb.AppendLine(GetProfileInfo(profile))
			Else
				' Append RAW data graph.
				fontSize = 3F
				sb.Append(GetProfileRawData(profile))
			End If
		End If
		testResults.Font = New Font(testResults.Font.FontFamily, fontSize)
		testResults.Text = sb.ToString()
	End Sub

	''' <summary>
	''' Gets the text information about specified scan reflectance profile.
	''' </summary>
	Private Function GetProfileInfo(profile As ISO15416ScanReflectanceProfile) As String
		Dim sb As New StringBuilder()
		AppendParametrInfoHeader(sb)

		If profile.DecodeGrade <> ISO15416QualityGrade.Unavailable Then
			If profile.Decode Then
				AppendParametrInfo(sb, "Decode", "YES", profile.DecodeGrade, String.Format(" ({0})", profile.DecodeValue))
			Else
				AppendParametrInfo(sb, "Decode", "NO", profile.DecodeGrade)
			End If
		End If
		AppendParametrInfo(sb, "Rmax (Max reflectance)", String.Format(CultureInfo.InvariantCulture, "{0:f1}%", profile.MaxReflectance), ISO15416QualityGrade.Unavailable)
		AppendParametrInfo(sb, "Rmin (Min reflectance)", String.Format(CultureInfo.InvariantCulture, "{0:f1}%", profile.MinReflectance), profile.MinReflectanceGrade)
		AppendParametrInfo(sb, "GT (Global threshold)", String.Format(CultureInfo.InvariantCulture, "{0:f1}%", profile.GlobalThreshold), ISO15416QualityGrade.Unavailable)
		AppendParametrInfo(sb, "SC (Symbol contrast)", String.Format(CultureInfo.InvariantCulture, "{0:f1}%", profile.SymbolContrast), profile.SymbolContrastGrade)
		AppendParametrInfo(sb, "ECmin (Min edge contrast)", String.Format(CultureInfo.InvariantCulture, "{0:f1}%", profile.MinEdgeContrast), profile.MinEdgeContrastGrade)
		AppendParametrInfo(sb, "MOD (Modulation)", String.Format(CultureInfo.InvariantCulture, "{0:f2}", profile.Modulation), profile.ModulationGrade)
		AppendParametrInfo(sb, "Defects", String.Format(CultureInfo.InvariantCulture, "{0:f2}", profile.Defects), profile.DefectsGrade)
		If profile.DecodabilityGrade <> ISO15416QualityGrade.Unavailable Then
			AppendParametrInfo(sb, "Decodability", String.Format(CultureInfo.InvariantCulture, "{0:f2}", profile.Decodability), profile.DecodabilityGrade)
		End If
		AppendParametrInfo(sb, "Left", String.Format(CultureInfo.InvariantCulture, "{0:f2}", profile.Defects), ISO15416QualityGrade.Unavailable)
		AppendParametrInfo(sb, "Scan grade (profile grade)", CInt(profile.ScanGrade).ToString(), profile.ScanGrade)
		Return sb.ToString()
	End Function

	''' <summary>
	''' Appends information about parameter of 
	''' scan reflectance profile to specified string builder.
	''' </summary>
	Private Sub AppendParametrInfo(sb As StringBuilder, name As String, value As String, grade As ISO15416QualityGrade)
		AppendParametrInfo(sb, name, value, grade, "")
	End Sub

	''' <summary>
	''' Appends information about parameter of 
	''' scan reflectance profile to specified string builder.
	''' </summary>
	Private Sub AppendParametrInfo(sb As StringBuilder, name As String, value As String, grade As ISO15416QualityGrade, comment As String)
		Dim gradeText As String
		If grade = ISO15416QualityGrade.Unavailable Then
			gradeText = "N/A"
		Else
			gradeText = grade.ToString()
		End If
		sb.AppendLine(String.Format("{0}{1}{2}{3}", name.PadRight(30), value.PadRight(10), gradeText, comment))
	End Sub

	''' <summary>
	''' Appends header of 
	''' scan reflectance profile to specified string builder.
	''' </summary>
	Private Sub AppendParametrInfoHeader(sb As StringBuilder)
		sb.AppendLine(String.Format("{0}{1}{2}", "Parameter".PadRight(30), "value".PadRight(10), "grade"))
	End Sub

	''' <summary>
	''' Returns a RAW data as text graph of specified reflectance profile.
	''' </summary>
	Private Function GetProfileRawData(profile As ISO15416ScanReflectanceProfile) As String
		Dim sb As New StringBuilder()
		Dim reflectanceData As Double() = profile.ReflectanceData

		' Global Threshold.
		Dim globalThreshold As Integer = CInt(Math.Truncate(Math.Round(100 - profile.GlobalThreshold)))

		' Draw decode label (top-left corner).
		If profile.Decode Then
			sb.Append("+")
		Else
			sb.Append(" ")
		End If

		' Draw first line: binarized reflectance data using global thresold.
		For x As Integer = 0 To reflectanceData.Length - 1
			If reflectanceData(x) > profile.GlobalThreshold Then
				sb.Append(" "C)
			Else
				sb.Append("@"C)
			End If
		Next
		sb.AppendLine()
		sb.AppendLine()

		' Draw RAW 2-D graph:
		' Y-axis: inverted reflectance
		' X-axis: barcode line.

		' Foreach Y:
		For y As Integer = 100 To 0 Step -1
			Dim line As New StringBuilder()

			' Draw element of Y-axis.
			line.Append("|")

			' For each X for current Y
			For x As Integer = 0 To reflectanceData.Length - 1
				' Draw element of X-axis:
				' If current inverted reflectance > Y then
				If Math.Round(100 - reflectanceData(x)) > y Then
					' Draw filled cell.
					If y = globalThreshold Then
						line.Append("|"C)
					Else
						line.Append("#"C)
					End If
				' If Y == GlobalThreshold then
				ElseIf y = globalThreshold Then
					' Draw Global Threshold marker.
					line.Append("-"C)
				Else
					' Draw empty cell.
					line.Append(" "C)
				End If
			Next
			sb.AppendLine(line.ToString())
		Next

		' Draw X-axis.
		For x As Integer = 0 To reflectanceData.Length
			sb.Append("_")
		Next

		sb.AppendLine()
		Return sb.ToString()
	End Function

	#End Region

End Class
