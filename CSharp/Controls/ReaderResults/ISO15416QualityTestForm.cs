using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Vintasoft.Barcode;
using Vintasoft.Barcode.BarcodeInfo;
using Vintasoft.Barcode.QualityTests;
using Vintasoft.Imaging;

namespace BarcodeDemo
{
    /// <summary>
    /// A form that allows to see the results of ISO15416 quality test.
    /// </summary>
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

        /// <summary>
        /// Initializes a new instance of the <see cref="ISO15416QualityTestForm"/> class.
        /// </summary>
        public ISO15416QualityTestForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ISO15416QualityTestForm"/> class.
        /// </summary>
        /// <param name="barcodeInfo">The barcode information.</param>
        /// <param name="barcodeImage">The barcode image.</param>
        public ISO15416QualityTestForm(
            BarcodeInfo1D barcodeInfo,
            Image barcodeImage)
            : this()
        {
            using (VintasoftBitmap bitmap = GdiConverter.Convert(barcodeImage, false))
            {
                ISO15416QualityTestSettings settings = new ISO15416QualityTestSettings(barcodeInfo);
                _test = new ISO15416QualityTest(bitmap, settings);
            }

            UpdateUI();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ISO15416QualityTestForm"/> class.
        /// </summary>
        /// <param name="test">The quality test.</param>
        public ISO15416QualityTestForm(ISO15416QualityTest test)
            : this()
        {
            _test = test;

            UpdateUI();
        }

        #endregion



        #region Methods

        #region Event handlers

        /// <summary>
        /// Closes this dialog.
        /// </summary>
        private void okButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Updates information about selected scan reflectance profile.
        /// </summary>
        private void infoTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTextDisplay();
        }

        /// <summary>
        /// Updates information about selected scan reflectance profile.
        /// </summary>
        private void analysisRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTextDisplay();
        }

        /// <summary>
        /// Updates information about selected scan reflectance profile.
        /// </summary>
        private void imageRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTextDisplay();
        }

        #endregion


        /// <summary>
        /// Updates the user interface.
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

            Color qualityGradeColor = GetGradeColor(_test.OverallSymbolGrade.AlphabeticGrade);
            Label qualityGradeLabel = null;
            switch (_test.OverallSymbolGrade.AlphabeticGrade)
            {
                case QualityTestAlphabeticGrade.A:
                    qualityGradeLabel = grade4Label;
                    sgHi.ForeColor = qualityGradeColor;
                    break;
                case QualityTestAlphabeticGrade.B:
                    qualityGradeLabel = grade3Label;
                    break;
                case QualityTestAlphabeticGrade.C:
                    qualityGradeLabel = grade2Label;
                    break;
                case QualityTestAlphabeticGrade.D:
                    qualityGradeLabel = grade1Label;
                    break;
                case QualityTestAlphabeticGrade.F:
                    qualityGradeLabel = grade0Label;
                    sgLow.ForeColor = qualityGradeColor;
                    break;
            }
            overallGradeGroupBox.Text = overallGradeGroupBox.Text + _test.OverallSymbolGrade.ToString();
            qualityGradeLabel.ForeColor = qualityGradeColor;
            qualityGradeLabel.Font = new Font(qualityGradeLabel.Font, FontStyle.Bold);
        }

        /// <summary>
        /// Returns a color of specified grade.
        /// </summary>
        private Color GetGradeColor(QualityTestAlphabeticGrade grade)
        {
            switch (grade)
            {
                case QualityTestAlphabeticGrade.A:
                case QualityTestAlphabeticGrade.B:
                    return Color.Green;
                case QualityTestAlphabeticGrade.C:
                    return Color.FromArgb(230, 163, 42);
                case QualityTestAlphabeticGrade.D:
                    return Color.FromArgb(180, 0, 0);
                case QualityTestAlphabeticGrade.F:
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
            // if summary information is displayed
            if (displayTypeComboBox.SelectedIndex == 0)
            {
                analysisRadioButton.Enabled = false;
                rawDataRadioButton.Enabled = false;
                fontSize = 9.75f;

                // symbology
                sb.AppendLine(string.Format("Symbology            : {0}", BarcodeSymbologies.GetSymbology(_test.BarcodeInfo.BarcodeType).Name));
                // overall symbol grade
                sb.AppendLine(string.Format("Overall symbol grade : {0}", _test.OverallSymbolGrade));
                sb.AppendLine();

                // check DifferentDecodedValues flag
                if (_test.DifferentDecodedValues)
                {
                    sb.Append("Attention! Scan reflectance profiles has different decoded barcode values!");
                    sb.AppendLine();
                }

                // draw a line that contains all profiles grade
                sb.AppendLine("Scan reflectance profiles grades:");
                if (_test.SymbolComponentQualityTests.Length == 1)
                {
                    ISO15416SymbolComponentQualityTest test = _test.SymbolComponentQualityTests[0];
                    for (int i = 0; i < test.ScanReflectanceProfiles.Length; i++)
                        sb.Append(test.ScanReflectanceProfiles[i].ScanGrade.AlphabeticGrade);
                    sb.AppendLine();
                }
                else
                {
                    for (int j = 0; j < _test.SymbolComponentQualityTests.Length; j++)
                    {
                        ISO15416SymbolComponentQualityTest test = _test.SymbolComponentQualityTests[j];
                        sb.Append(string.Format("Symbol component {0}: ", j + 1));
                        for (int i = 0; i < test.ScanReflectanceProfiles.Length; i++)
                            sb.Append(test.ScanReflectanceProfiles[i].ScanGrade.AlphabeticGrade);
                        sb.AppendLine();
                    }
                }
                sb.AppendLine();

                // append analysis of all scan reflectance profiles
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
                            sb.AppendLine(string.Format("Symbol component {0}, profile {1}:", j + 1, i + 1));
                            sb.AppendLine(GetProfileInfo(profile));
                        }
                    }
                }
                testResults.Font = new Font(testResults.Font.FontFamily, 9.75f);
            }
            // if information about single profile is displayed
            else
            {
                int index = displayTypeComboBox.SelectedIndex - 1;
                ISO15416ScanReflectanceProfile profile = _profiles[index];
                analysisRadioButton.Enabled = true;
                rawDataRadioButton.Enabled = true;
                if (analysisRadioButton.Checked)
                {
                    // append profile analysis
                    fontSize = 9.75f;
                    sb.AppendLine(string.Format("Profile {0} analysis:", index + 1));
                    sb.AppendLine(GetProfileInfo(profile));
                }
                else
                {
                    // append RAW data graph
                    fontSize = 3f;
                    sb.Append(GetProfileRawData(profile));
                }
            }
            testResults.Font = new Font(testResults.Font.FontFamily, fontSize);
            testResults.Text = sb.ToString();
        }

        /// <summary>
        /// Returns the text information about specified scan reflectance profile.
        /// </summary>
        private string GetProfileInfo(ISO15416ScanReflectanceProfile profile)
        {
            StringBuilder sb = new StringBuilder();
            AppendInfo(sb, "Parameter", "Value", "Grade");

            if (profile.Decode != null)
            {
                AppendParametrInfo(sb, "Decode", profile.Decode);
                if (profile.Decode.Value == 0)
                {
                    if (profile.QuietZoneLeft.Value >= 0 && profile.QuietZoneLeft.Value < 90)
                        sb.AppendLine("    Possible violation of left quiet zone!");
                    else if (profile.QuietZoneRight.Value >= 0 && profile.QuietZoneRight.Value < 90)
                        sb.AppendLine("    Possible violation of right quiet zone!");
                }
            }
            AppendParametrInfo(sb, "Quiet Zone Left", profile.QuietZoneLeft);
            AppendParametrInfo(sb, "Quiet Zone Right", profile.QuietZoneRight);
            AppendParametrInfo(sb, "Rmax (Max reflectance)", profile.MaxReflectance);
            AppendParametrInfo(sb, "Rmin (Min reflectance)", profile.MinReflectance);
            AppendParametrInfo(sb, "GT (Global threshold)", profile.GlobalThreshold);
            AppendParametrInfo(sb, "SC (Symbol contrast)", profile.SymbolContrast);
            AppendParametrInfo(sb, "ECmin (Min edge contrast)", profile.MinEdgeContrast);
            AppendParametrInfo(sb, "MOD (Modulation)", profile.Modulation);
            AppendParametrInfo(sb, "ERNMax", profile.MaxElementReflectanceNonUniformity);
            AppendParametrInfo(sb, "Defects", profile.Defects);
            AppendParametrInfo(sb, "Decodability", profile.Decodability);
            AppendParametrInfo(sb, "PCS (Print contrast signal)", profile.PrintContrastSignal);
            AppendParametrInfo(sb, "Average bar gain", profile.AverageBarGain);
            AppendParametrInfo(sb, "Black Narrow Width", profile.BlackNarrowBarWidth);
            AppendParametrInfo(sb, "White Narrow Width", profile.WhiteNarrowBarWidth);
            AppendParametrInfo(sb, "BWR (Black White Ratio)", profile.BlackWhiteRatio);
            AppendParametrInfo(sb, "Scan grade (profile grade)", profile.ScanGrade);
            return sb.ToString();
        }
     
        /// <summary>
        /// Appends information about parameter of 
        /// scan reflectance profile to the specified string builder.
        /// </summary>
        private void AppendParametrInfo(
            StringBuilder sb,
            string name,
            QualityTestAssessmentParameter value)
        {
            if (value != null)
                AppendInfo(sb, name, value.ValueText, value.GradeText);
        }

        /// <summary>
        /// Appends information about parameter.
        /// </summary>
        private static void AppendInfo(StringBuilder sb, string name, string valueText, string gradeText)
        {
            sb.AppendLine(string.Format("{0}{1}{2}", name.PadRight(30), valueText.PadRight(10), gradeText));
        }

        /// <summary>
        /// Returns a RAW data as text graph of specified reflectance profile.
        /// </summary>
        private string GetProfileRawData(ISO15416ScanReflectanceProfile profile)
        {
            StringBuilder sb = new StringBuilder();
            double[] reflectanceData = profile.ReflectanceData;

            // global threshold
            int globalThreshold = (int)Math.Round(100 - profile.GlobalThreshold.Value);

            sb.Append(' ');


            // draw a decode label (top-left corner)
            if (profile.Decode != null && profile.Decode.Value != 0)
                sb.Append("+");
            else
                sb.Append(" ");


            // draw the first line: binarized reflectance data using global thresold
            for (int x = 0; x < reflectanceData.Length; x++)
            {
                if (reflectanceData[x] > profile.GlobalThreshold.Value)
                    sb.Append(' ');
                else
                    sb.Append('@');
            }
            sb.AppendLine();
            sb.AppendLine();

            // Draw RAW 2-D graph:
            // Y-axis: inverted reflectance
            // X-axis: barcode line.

            // for each Y
            for (int y = 100; y >= 0; y--)
            {
                StringBuilder line = new StringBuilder();

                // draw element of Y-axis
                line.Append("[");

                // for each X for current Y
                for (int x = 0; x < reflectanceData.Length; x++)
                {
                    // draw element of X-axis:
                    if (Math.Round(100 - reflectanceData[x]) > y)
                    {
                        // draw filled cell
                        if (y == globalThreshold)
                            line.Append('|');
                        else
                            line.Append('#');
                    }
                    else if (y == globalThreshold)
                    {
                        // draw the global threshold marker
                        line.Append('-');
                    }
                    else
                    {
                        // draw an empty cell
                        line.Append(' ');
                    }
                }
                line.Append("]");
                sb.AppendLine(line.ToString());
            }

            // draw x-axis: left quiet zone + barcode zone + right quiet zone
            sb.Append(' ');
            for (int x = 0; x < reflectanceData.Length; x++)
            {
                // left quiet zone marker
                if (x < profile.QuietZoneAnalyzedSizeLeft)
                {
                    sb.Append(' ');
                }
                // right quiet zone marker
                else if (x > reflectanceData.Length - profile.QuietZoneAnalyzedSizeRight)
                {
                    sb.Append(' ');
                }
                // barcode
                else
                {
                    sb.Append('x');
                }
            }

            sb.AppendLine();
            return sb.ToString();
        }

        #endregion

    }
}