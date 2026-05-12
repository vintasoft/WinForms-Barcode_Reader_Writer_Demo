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
        public ISO15415QualityTestForm(
            BarcodeInfo2D barcodeInfo,
            Image barcodeImage)
        {
            InitializeComponent();

            ISO15415QualityTest test = new ISO15415QualityTest();
            using (VintasoftBitmap bitmap = GdiConverter.Convert(barcodeImage, false))
                test.CalculateGrades(barcodeInfo, bitmap);
            _test = test;
            
            AddRow("Symbology", BarcodeSymbologies.GetSymbology(_test.BarcodeInfo.BarcodeType).Name, "");
            AddValueRow("Aperture", test.ApertureFactor * 100, "%");
            AddValueRow("Quiet Zone Size", test.QuietZoneSize, "X");
            AddParameterRow("Overall Symbol Grade", test.OverallSymbolGrade);
            AddParameterRow("Start Pattern", test.StartPatternTestGrade);
            AddParameterRow("Center Pattern", test.CenterPatternTestGrade);
            AddParameterRow("Stop Pattern", test.StopPatternTestGrade);
            AddParameterRow("Decode", test.Decode);
            AddParameterRow("Unused Error Correction", test.UnusedErrorCorrection);
            AddParameterRow("Codeword Yield", test.CodewordYield);
            AddParameterRow("Codeword Print Quality Modulation", test.CodewordPrintQualityModulationGrade);
            AddParameterRow("Codeword Print Quality Defects", test.CodewordPrintQualityDefectsGrade);
            AddParameterRow("Codeword Print Quality Decodability", test.CodewordPrintQualityDecodabilityGrade);
            AddParameterRow("Codeword Print Quality", test.CodewordPrintQualityGrade);
            AddParameterRow("Min Reflectance", test.MinReflectance);
            AddParameterRow("Max Reflectance", test.MaxReflectance);
            AddParameterRow("Global Threshold", test.GlobalThreshold);
            AddParameterRow("Symbol Contrast", test.SymbolContrast);
            AddParameterRow("Print Growth", test.PrintGrowth);
            AddParameterRow("Axial Nonuniformity", test.AxialNonuniformity);
            AddParameterRow("Grid Nonuniformity", test.GridNonuniformity);
            AddParameterRow("Modulation", test.Modulation);
            AddParameterRow("Fixed Pattern Damage", test.FixedPatternDamage);
            foreach (string name in test.AdditionalGrades.Keys)
                AddParameterRow(name, test.AdditionalGrades[name]);
            AddParameterRow("Quiet Zone", test.QuietZone);
            AddParameterRow("Distortion Angle", test.DistortionAngle);
            AddParameterRow("Contrast Uniformity", test.ContrastUniformity);

            QualityTestAlphabeticGrade overallSymbolGradeAlphabetic = test.OverallSymbolGrade.AlphabeticGrade;
            Color sgColor = Color.Empty;
            Label sgLabel = null;
            switch (overallSymbolGradeAlphabetic)
            {
                case QualityTestAlphabeticGrade.A:
                    sgColor = Color.Green;
                    sgLabel = sg4;
                    sgHi.ForeColor = sgColor;
                    break;
                case QualityTestAlphabeticGrade.B:
                    sgColor = Color.Green;
                    sgLabel = sg3;
                    break;
                case QualityTestAlphabeticGrade.C:
                    sgColor = Color.FromArgb(230, 163, 42);
                    sgLabel = sg2;
                    break;
                case QualityTestAlphabeticGrade.D:
                    sgColor = Color.FromArgb(180, 0, 0);
                    sgLabel = sg1;
                    break;
                case QualityTestAlphabeticGrade.F:
                    sgColor = Color.FromArgb(255, 0, 0);
                    sgLabel = sg0;
                    sgLow.ForeColor = sgColor;
                    break;
            }
            string symbolGradeText = test.OverallSymbolGrade.ToString();
            gbScanGrade.Text += ": " + symbolGradeText;
            if (sgLabel != null)
            {
                sgLabel.Text = symbolGradeText;
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
        private void AddRow(string name, string param1, string param2)
        {
            int index = dataGridView.Rows.Count;
            dataGridView.Rows.Add();
            dataGridView.Rows[index].Cells[0].Value = name;
            dataGridView.Rows[index].Cells[1].Value = param1;
            dataGridView.Rows[index].Cells[2].Value = param2;
        }

        /// <summary>
        /// Adds the row to the parameters table.
        /// </summary>
        private void AddParameterRow(string name, QualityTestAssessmentParameter parameter)
        {
            if (parameter == null)
                return;
            AddRow(name, parameter.ValueText, parameter.GradeText);
        }

    
        /// <summary>
        /// Adds the row to the parameters table.
        /// </summary>
        private void AddValueRow(string name, double value, string units)
        {
            string valueText = "";
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
                valueText = val;
            }
            else
            {
                valueText = "NA";
            }
            AddRow(name, valueText, "");
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
            form.SetModulationMatrix(_test);
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
