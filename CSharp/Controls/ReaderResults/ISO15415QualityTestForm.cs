using BarcodeDemo.Controls.ReaderResults;
using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using Vintasoft.Barcode;
using Vintasoft.Barcode.BarcodeInfo;
using Vintasoft.Barcode.QualityTests;
using Vintasoft.Imaging;

namespace BarcodeDemo
{
    /// <summary>
    /// A form that allows to see the results of ISO15415 quality test.
    /// </summary>
    public partial class ISO15415QualityTestForm : Form
    {

        #region Fields

        ISO15415QualityTest _test;

        #endregion



        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ISO15415QualityTestForm"/> class.
        /// </summary>
        /// <param name="barcodeInfo">The barcode information.</param>
        /// <param name="barcodeImage">The barcode image.</param>
        /// <param name="invertImageColors">Determines when image colors is inverted.</param>
        public ISO15415QualityTestForm(
            BarcodeInfo2D barcodeInfo,
            Image barcodeImage,
            bool invertImageColors)
        {
            InitializeComponent();

            ISO15415QualityTest test = new ISO15415QualityTest();
            using (VintasoftBitmap bitmap = GdiConverter.Convert(barcodeImage, false))
                test.CalculateGrades(barcodeInfo, bitmap, invertImageColors);
            _test = test;

            if (test.StartPatternTestGrade != ISO15415QualityGrade.Unavailable)
                AddRow("Start Pattern", test.StartPatternTest.OverallSymbolGradeValue, "", test.StartPatternTestGrade);
            if (test.CenterPatternTestGrade != ISO15415QualityGrade.Unavailable)
                AddRow("Center Pattern", test.CenterPatternTest.OverallSymbolGradeValue, "", test.CenterPatternTestGrade);
            if (test.StopPatternTestGrade != ISO15415QualityGrade.Unavailable)
                AddRow("Stop Pattern", test.StopPatternTest.OverallSymbolGradeValue, "", test.StopPatternTestGrade);

            string decodeValue = "Passed";
            if (test.DecodeGrade == ISO15415QualityGrade.F)
                decodeValue = "Failed";
            AddRow("Decode", float.MinValue, decodeValue, test.DecodeGrade);

            AddRow("Unused Error Correction", test.UnusedErrorCorrection, "%", test.UnusedErrorCorrectionGrade);

            if (test.CodewordYieldGrade != ISO15415QualityGrade.Unavailable)
                AddRow("Codeword Yield", Math.Round(test.CodewordYield), "%", test.CodewordYieldGrade);

            if (test.CodewordPrintQualityModulationGrade != ISO15415QualityGrade.Unavailable)
                AddRow("Codeword Print Quality Modulation", float.MinValue, "", test.CodewordPrintQualityModulationGrade);

            if (test.CodewordPrintQualityDefectsGrade != ISO15415QualityGrade.Unavailable)
                AddRow("Codeword Print Quality Defects", float.MinValue, "", test.CodewordPrintQualityDefectsGrade);

            if (test.CodewordPrintQualityDecodabilityGrade != ISO15415QualityGrade.Unavailable)
                AddRow("Codeword Print Quality Decodability", float.MinValue, "", test.CodewordPrintQualityDecodabilityGrade);

            if (test.CodewordPrintQualityGrade != ISO15415QualityGrade.Unavailable)
                AddRow("Codeword Print Quality", float.MinValue, "", test.CodewordPrintQualityGrade);

            if (test.MinReflectance != float.MinValue)
                AddRow("Min Reflectance", test.MinReflectance, "%", ISO15415QualityGrade.Unavailable);
            if (test.MaxReflectance != float.MinValue)
                AddRow("Max Reflectance", test.MaxReflectance, "%", ISO15415QualityGrade.Unavailable);
            if (test.GlobalThreshold != float.MinValue)
                AddRow("Global Threshold", test.GlobalThreshold, "%", ISO15415QualityGrade.Unavailable);
            if (test.SymbolContrast != float.MinValue)
                AddRow("Symbol Contrast", test.SymbolContrast, "%", test.SymbolContrastGrade);
            if (test.AxialNonuniformity != float.MinValue)
                AddRow("Axial Nonuniformity", test.AxialNonuniformity, "", test.AxialNonuniformityGrade);
            if (test.GridNonuniformity != float.MinValue)
                AddRow("Grid Nonuniformity", test.GridNonuniformity, " (cell)", test.GridNonuniformityGrade);
            if (test.ModulationGrade != ISO15415QualityGrade.Unavailable)
                AddRow("Modulation", float.MinValue, "", test.ModulationGrade);
            if (test.ReflectanceMarginGrade != ISO15415QualityGrade.Unavailable)
                AddRow("Reflectance Margin", float.MinValue, "", test.ReflectanceMarginGrade);
            if (test.FixedPatternDamageGrade != ISO15415QualityGrade.Unavailable)
                AddRow("Fixed Pattern Damage", float.MinValue, "", test.FixedPatternDamageGrade);
            foreach (string name in test.AdditionalGrades.Keys)
                AddRow(name, float.MinValue, "", test.AdditionalGrades[name]);
            AddRow("Quiet Zone Size", test.QuietZoneSize, "X", ISO15415QualityGrade.Unavailable);
            if (test.QuietZone >= 0)
                AddRow("Quiet Zone", test.QuietZone, "%", test.QuietZoneGrade);
            AddRow("Distortion Angle", test.DistortionAngle, "°", ISO15415QualityGrade.Unavailable);
            if (test.ContrastUniformity != float.MinValue)
                AddRow("Contrast Uniformity", test.ContrastUniformity, "", ISO15415QualityGrade.Unavailable);
            AddRow("Aperture", test.ApertureFactor * 100, "%", ISO15415QualityGrade.Unavailable);
            ISO15415QualityGrade scanGrade = test.ScanGrade;
            Color sgColor = Color.Empty;
            Label sgLabel = null;
            switch (scanGrade)
            {
                case ISO15415QualityGrade.A:
                    sgColor = Color.Green;
                    sgLabel = sg4;
                    sgHi.ForeColor = sgColor;
                    break;
                case ISO15415QualityGrade.B:
                    sgColor = Color.Green;
                    sgLabel = sg3;
                    break;
                case ISO15415QualityGrade.C:
                    sgColor = Color.FromArgb(230, 163, 42);
                    sgLabel = sg2;
                    break;
                case ISO15415QualityGrade.D:
                    sgColor = Color.FromArgb(180, 0, 0);
                    sgLabel = sg1;
                    break;
                case ISO15415QualityGrade.F:
                    sgColor = Color.FromArgb(255, 0, 0);
                    sgLabel = sg0;
                    sgLow.ForeColor = sgColor;
                    break;

            }
            gbScanGrade.Text += string.Format("{0} ({1})", (int)scanGrade, scanGrade);
            if (sgLabel != null)
            {
                sgLabel.ForeColor = sgColor;
                sgLabel.Font = new Font(sgLabel.Font, FontStyle.Bold);
            }
            startPatternButton.Enabled = test.StartPatternTest != null;
            centerPatternButton.Enabled = test.CenterPatternTest != null;
            stopPatternButton.Enabled = test.StopPatternTest != null;
            barcodeSymbolButton.Enabled = test.SymbolIso15416QualityTest != null;
            matrixModulationButton.Enabled = test.ModulationMatrix != null;
        }

        #endregion



        #region Methods

        /// <summary>
        /// Adds the row to the parameters table.
        /// </summary>
        private void AddRow(string name, double value, string units, ISO15415QualityGrade grade)
        {
            int index = dataGridView.Rows.Count;
            dataGridView.Rows.Add();
            dataGridView.Rows[index].Cells[0].Value = name;
            string gradeValue;
            if (grade == ISO15415QualityGrade.Unavailable)
                gradeValue = "";
            else
                gradeValue = string.Format("{0} ({1})", (int)grade, grade);
            if (grade != ISO15415QualityGrade.Unavailable || value != float.MinValue)
            {
                if (value != float.MinValue)
                {
                    string val;
                    if (units == "%")
                        val = string.Format(CultureInfo.InvariantCulture, "{0:f1}%", value, units);
                    else if (units == "X")
                        val = string.Format(CultureInfo.InvariantCulture, "{0}{1}", value, units);
                    else if (units != "")
                        val = string.Format(CultureInfo.InvariantCulture, "{0:f2}{1}", value, units);
                    else
                        val = string.Format(CultureInfo.InvariantCulture, "{0:f2}", value);
                    dataGridView.Rows[index].Cells[1].Value = val;
                }
                else
                    dataGridView.Rows[index].Cells[1].Value = units;
            }
            dataGridView.Rows[index].Cells[2].Value = gradeValue;
        }

        /// <summary>
        /// Shows the quality test of start pattern.
        /// </summary>
        private void startPatternButton_Click(object sender, EventArgs e)
        {
            using (ISO15416QualityTestForm form = new ISO15416QualityTestForm(_test.StartPatternTest))
                form.ShowDialog();
        }

        /// <summary>
        /// Shows the quality test of center pattern.
        /// </summary>
        private void centerPatternButton_Click(object sender, EventArgs e)
        {
            using (ISO15416QualityTestForm form = new ISO15416QualityTestForm(_test.CenterPatternTest))
                form.ShowDialog();
        }

        /// <summary>
        /// Shows the quality test of stop pattern.
        /// </summary>
        private void stopPatternButton_Click(object sender, EventArgs e)
        {
            using (ISO15416QualityTestForm form = new ISO15416QualityTestForm(_test.StopPatternTest))
                form.ShowDialog();
        }

        /// <summary>
        /// Shows the quality test of barcode symbol.
        /// </summary>
        private void barcodeSymbolButton_Click(object sender, EventArgs e)
        {
            using (ISO15416QualityTestForm form = new ISO15416QualityTestForm(_test.SymbolIso15416QualityTest))
                form.ShowDialog();
        }

        /// <summary>
        /// Shows modulation matrix.
        /// </summary>
        private void matrixModulationButton_Click(object sender, EventArgs e)
        {
            BarcodeMatrixModulationForm form = new BarcodeMatrixModulationForm();
            form.SetModualtionMatrix(_test);
            form.ShowDialog();
        }

        /// <summary>
        /// Closes this dialog.
        /// </summary>
        private void okButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion
     
    }
}
