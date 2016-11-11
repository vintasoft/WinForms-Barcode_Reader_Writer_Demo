using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Vintasoft.Barcode.BarcodeInfo;
using Vintasoft.Barcode.QualityTests;
using System.Collections.Generic;
using System.Globalization;

namespace BarcodeDemo
{
    public partial class ISO15416QualityTestForm : Form
    {

        #region Fields

        /// <summary>
        /// ISO-15416 quality test.
        /// </summary>
        ISO15416QualityTest _test;

        /// <summary>
        /// List of all scan profiles.
        /// </summary>
        List<ISO15416ScanReflectanceProfile> _profiles = new List<ISO15416ScanReflectanceProfile>();

        #endregion



        #region Contstructors

        public ISO15416QualityTestForm()
        {
            InitializeComponent();
        }

        public ISO15416QualityTestForm(BarcodeInfo1D info, Image barcodeImage, bool invertBarcodeImage)
            : this()
        {
            _test = new ISO15416QualityTest(info, barcodeImage, invertBarcodeImage);

            UpdateUI();
        }

        public ISO15416QualityTestForm(ISO15416QualityTest test)
            : this()
        {
            _test = test;

            UpdateUI();
        }        

        #endregion



        #region Methods

        #region Event handlers

        private void okButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void infoTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTextDisplay();
        }

        private void analysisRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTextDisplay();
        }

        private void imageRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTextDisplay();
        }

        #endregion


        /// <summary>
        /// Updates user interface.
        /// </summary>
        private void UpdateUI()
        {
            displayTypeComboBox.Items.Add("Summary");
            displayTypeComboBox.SelectedIndex = 0;
            if (_test.SymbolComponentQualityTests.Length == 1)
            {
                ISO15416SymbolComponentQualityTest test = _test.SymbolComponentQualityTests[0];
                for (int i = 0; i < test.ScanReflectanceProfiles.Length; i++)
                    displayTypeComboBox.Items.Add(string.Format("Profile {0}", i + 1));
                _profiles.AddRange(test.ScanReflectanceProfiles);
            }
            else
            {
                for (int j = 0; j < _test.SymbolComponentQualityTests.Length; j++)
                {
                    ISO15416SymbolComponentQualityTest test = _test.SymbolComponentQualityTests[j];
                    for (int i = 0; i < test.ScanReflectanceProfiles.Length; i++)
                        displayTypeComboBox.Items.Add(string.Format("Component {0}, profile {1}", j + 1, i + 1));
                    _profiles.AddRange(test.ScanReflectanceProfiles);
                }
            }
            analysisRadioButton.Checked = true;

            Color qualityGradeColor = GetGradeColor(_test.OverallSymbolGrade);
            Label qualityGradeLabel = null;
            switch (_test.OverallSymbolGrade)
            {
                case ISO15416QualityGrade.A:
                    qualityGradeLabel = grade4Label;
                    sgHi.ForeColor = qualityGradeColor;
                    break;
                case ISO15416QualityGrade.B:
                    qualityGradeLabel = grade3Label;
                    break;
                case ISO15416QualityGrade.C:
                    qualityGradeLabel = grade2Label;
                    break;
                case ISO15416QualityGrade.D:
                    qualityGradeLabel = grade1Label;
                    break;
                case ISO15416QualityGrade.F:
                    qualityGradeLabel = grade0Label;
                    sgLow.ForeColor = qualityGradeColor;
                    break;
            }
            overallGradeGroupBox.Text += string.Format("{0:f2} ({1})", _test.OverallSymbolGradeValue, _test.OverallSymbolGrade);
            qualityGradeLabel.ForeColor = qualityGradeColor;
            qualityGradeLabel.Font = new Font(qualityGradeLabel.Font, FontStyle.Bold);
        }

        /// <summary>
        /// Gets a color of specified grade.
        /// </summary>
        private Color GetGradeColor(ISO15416QualityGrade grade)
        {
            switch (grade)
            {
                case ISO15416QualityGrade.A:
                case ISO15416QualityGrade.B:
                    return Color.Green;
                case ISO15416QualityGrade.C:
                    return Color.FromArgb(230, 163, 42);
                case ISO15416QualityGrade.D:
                    return Color.FromArgb(180, 0, 0);
                case ISO15416QualityGrade.F:
                    return Color.FromArgb(255, 0, 0);
            }
            return Color.FromArgb(255, 0, 0);
        }

        /// <summary>
        /// Updates information about selected scan reflectance profile.
        /// </summary>
        private void UpdateTextDisplay()
        {
            StringBuilder sb = new StringBuilder();
            float fontSize;
            // If summary information is displayed.
            if (displayTypeComboBox.SelectedIndex == 0)
            {
                analysisRadioButton.Enabled = false;
                rawDataRadioButton.Enabled = false;
                fontSize = 9.75f;

                // Overall symbol grade.
                sb.AppendLine(string.Format("Overall symbol grade: {0:f2} ({1})", _test.OverallSymbolGradeValue, _test.OverallSymbolGrade));
                sb.AppendLine();

                // Check DifferentDecodedValues flag.
                if (_test.DifferentDecodedValues)
                {
                    sb.Append("Attention! Scan reflectance profiles has different decoded barcode values!");
                    sb.AppendLine();
                }

                // Draw line that contains all profiles grade.
                sb.AppendLine("Scan reflectance profiles grades:");
                if (_test.SymbolComponentQualityTests.Length == 1)
                {
                    ISO15416SymbolComponentQualityTest test = _test.SymbolComponentQualityTests[0];
                    for (int i = 0; i < test.ScanReflectanceProfiles.Length; i++)
                        sb.Append(test.ScanReflectanceProfiles[i].ScanGrade.ToString());
                    sb.AppendLine();
                }
                else
                {
                    for (int j = 0; j < _test.SymbolComponentQualityTests.Length; j++)
                    {
                        ISO15416SymbolComponentQualityTest test = _test.SymbolComponentQualityTests[j];
                        sb.Append(string.Format("Symbol component {0}: ", j + 1));
                        for (int i = 0; i < test.ScanReflectanceProfiles.Length; i++)
                            sb.Append(test.ScanReflectanceProfiles[i].ScanGrade.ToString());
                        sb.AppendLine();
                    }
                }
                sb.AppendLine();

                // Append analysis of all scan reflectance profiles.
                sb.AppendLine("Scan reflectance profiles analysis:");
                sb.AppendLine();
                if (_test.SymbolComponentQualityTests.Length == 1)
                {
                    ISO15416SymbolComponentQualityTest test = _test.SymbolComponentQualityTests[0];
                    sb.AppendLine("Average scan reflectance profile values:");
                    sb.AppendLine(GetProfileInfo(test.AverageScanReflectanceProfileValues));
                    for (int i = 0; i < test.ScanReflectanceProfiles.Length; i++)
                    {
                        ISO15416ScanReflectanceProfile profile = test.ScanReflectanceProfiles[i];
                        sb.AppendLine(string.Format("Profile {0}:", i + 1));
                        sb.AppendLine(GetProfileInfo(profile));
                    }
                }
                else
                {
                    for (int j = 0; j < _test.SymbolComponentQualityTests.Length; j++)
                    {
                        ISO15416SymbolComponentQualityTest test = _test.SymbolComponentQualityTests[j];
                        sb.AppendLine(string.Format("Average scan reflectance profile values (symbol component {0}):", j + 1));
                        sb.AppendLine(GetProfileInfo(test.AverageScanReflectanceProfileValues));
                        for (int i = 0; i < test.ScanReflectanceProfiles.Length; i++)
                        {
                            ISO15416ScanReflectanceProfile profile = test.ScanReflectanceProfiles[i];
                            sb.AppendLine(string.Format("Symbol component {0}, profile {1}:", j+1, i + 1));
                            sb.AppendLine(GetProfileInfo(profile));
                        }
                    }
                }
                testResults.Font = new Font(testResults.Font.FontFamily, 9.75f);
            }
            // If information about single profile is displayed.
            else
            {
                int index = displayTypeComboBox.SelectedIndex - 1;
                ISO15416ScanReflectanceProfile profile = _profiles[index];
                analysisRadioButton.Enabled = true;
                rawDataRadioButton.Enabled = true;
                if (analysisRadioButton.Checked)
                {
                    // Append profile analysis.
                    fontSize = 9.75f;
                    sb.AppendLine(string.Format("Profile {0} analysis:", index + 1));
                    sb.AppendLine(GetProfileInfo(profile));
                }
                else
                {
                    // Append RAW data graph.
                    fontSize = 3f;
                    sb.Append(GetProfileRawData(profile));
                }
            }
            testResults.Font = new Font(testResults.Font.FontFamily, fontSize);
            testResults.Text = sb.ToString();
        }

        /// <summary>
        /// Gets the text information about specified scan reflectance profile.
        /// </summary>
        private string GetProfileInfo(ISO15416ScanReflectanceProfile profile)
        {
            StringBuilder sb = new StringBuilder();
            AppendParametrInfoHeader(sb);

            if (profile.DecodeGrade != ISO15416QualityGrade.Unavailable)
            {
                if (profile.Decode)
                    AppendParametrInfo(sb, "Decode", "YES", profile.DecodeGrade, string.Format(" ({0})", profile.DecodeValue));
                else
                    AppendParametrInfo(sb, "Decode", "NO", profile.DecodeGrade);
            }
            AppendParametrInfo(sb, "Rmax (Max reflectance)", string.Format(CultureInfo.InvariantCulture, "{0:f1}%", profile.MaxReflectance), ISO15416QualityGrade.Unavailable);
            AppendParametrInfo(sb, "Rmin (Min reflectance)", string.Format(CultureInfo.InvariantCulture, "{0:f1}%", profile.MinReflectance), profile.MinReflectanceGrade);
            AppendParametrInfo(sb, "GT (Global threshold)", string.Format(CultureInfo.InvariantCulture, "{0:f1}%", profile.GlobalThreshold), ISO15416QualityGrade.Unavailable);
            AppendParametrInfo(sb, "SC (Symbol contrast)", string.Format(CultureInfo.InvariantCulture, "{0:f1}%", profile.SymbolContrast), profile.SymbolContrastGrade);
            AppendParametrInfo(sb, "ECmin (Min edge contrast)", string.Format(CultureInfo.InvariantCulture, "{0:f1}%", profile.MinEdgeContrast), profile.MinEdgeContrastGrade);
            AppendParametrInfo(sb, "MOD (Modulation)", string.Format(CultureInfo.InvariantCulture, "{0:f2}", profile.Modulation), profile.ModulationGrade);
            AppendParametrInfo(sb, "Defects", string.Format(CultureInfo.InvariantCulture, "{0:f2}", profile.Defects), profile.DefectsGrade);
            if (profile.DecodabilityGrade != ISO15416QualityGrade.Unavailable)
                AppendParametrInfo(sb, "Decodability", string.Format(CultureInfo.InvariantCulture, "{0:f2}", profile.Decodability), profile.DecodabilityGrade);
            AppendParametrInfo(sb, "Left", string.Format(CultureInfo.InvariantCulture, "{0:f2}", profile.Defects), ISO15416QualityGrade.Unavailable);
            AppendParametrInfo(sb, "Scan grade (profile grade)", ((int)profile.ScanGrade).ToString(), profile.ScanGrade);
            return sb.ToString();
        }

        /// <summary>
        /// Appends information about parameter of 
        /// scan reflectance profile to specified string builder.
        /// </summary>
        private void AppendParametrInfo(StringBuilder sb, string name, string value, ISO15416QualityGrade grade)
        {
            AppendParametrInfo(sb, name, value, grade, "");
        }

        /// <summary>
        /// Appends information about parameter of 
        /// scan reflectance profile to specified string builder.
        /// </summary>
        private void AppendParametrInfo(StringBuilder sb, string name, string value, ISO15416QualityGrade grade, string comment)
        {
            string gradeText;
            if (grade == ISO15416QualityGrade.Unavailable)
                gradeText = "N/A";
            else
                gradeText = grade.ToString();
            sb.AppendLine(string.Format("{0}{1}{2}{3}", name.PadRight(30), value.PadRight(10), gradeText, comment));
        }

        /// <summary>
        /// Appends header of 
        /// scan reflectance profile to specified string builder.
        /// </summary>
        private void AppendParametrInfoHeader(StringBuilder sb)
        {
            sb.AppendLine(string.Format("{0}{1}{2}", "Parameter".PadRight(30), "value".PadRight(10), "grade"));
        }

        /// <summary>
        /// Returns a RAW data as text graph of specified reflectance profile.
        /// </summary>
        private string GetProfileRawData(ISO15416ScanReflectanceProfile profile)
        {
            StringBuilder sb = new StringBuilder();
            double[] reflectanceData = profile.ReflectanceData;

            // Global Threshold.
            int globalThreshold = (int)Math.Round(100 - profile.GlobalThreshold);

            // Draw decode label (top-left corner).
            if (profile.Decode)
                sb.Append("+");
            else
                sb.Append(" ");

            // Draw first line: binarized reflectance data using global thresold.
            for (int x = 0; x < reflectanceData.Length; x++)
            {
                if (reflectanceData[x] > profile.GlobalThreshold)
                    sb.Append(' ');
                else
                    sb.Append('@');
            }
            sb.AppendLine();
            sb.AppendLine();

            // Draw RAW 2-D graph:
            // Y-axis: inverted reflectance
            // X-axis: barcode line.

            // Foreach Y:
            for (int y = 100; y >= 0; y--)
            {
                StringBuilder line = new StringBuilder();
                
                // Draw element of Y-axis.
                line.Append("|");  

                // For each X for current Y
                for (int x = 0; x < reflectanceData.Length; x++)
                {
                    // Draw element of X-axis:
                    // If current inverted reflectance > Y then
                    if (Math.Round(100 - reflectanceData[x]) > y)
                    {
                        // Draw filled cell.
                        if (y == globalThreshold)
                            line.Append('|');
                        else
                            line.Append('#');
                    }
                    // If Y == GlobalThreshold then
                    else if (y == globalThreshold)
                        // Draw Global Threshold marker.
                        line.Append('-');
                    else
                        // Draw empty cell.
                        line.Append(' ');
                }
                sb.AppendLine(line.ToString());
            }

            // Draw X-axis.
            for (int x = 0; x < reflectanceData.Length + 1; x++)
                sb.Append("_");

            sb.AppendLine();
            return sb.ToString();
        }

        #endregion

    }
}