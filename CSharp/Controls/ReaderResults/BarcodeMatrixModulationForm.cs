using System;
using System.Drawing;
using System.Windows.Forms;

using Vintasoft.Barcode.QualityTests;

namespace BarcodeDemo.Controls.ReaderResults
{
    /// <summary>
    /// A form that allows to see the modulation matrix of ISO15415 quality test.
    /// </summary>
    public partial class BarcodeMatrixModulationForm : Form
    {

        #region Fields

        /// <summary>
        /// The quality test.
        /// </summary>
        ISO15415QualityTest _qualityTest;

        #endregion



        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BarcodeMatrixModulationForm"/> class.
        /// </summary>
        public BarcodeMatrixModulationForm()
        {
            InitializeComponent();
        }

        #endregion



        #region Methods

        /// <summary>
        /// Sets the modualtion matrix.
        /// </summary>
        /// <param name="qualityTest">The quality test.</param>
        public void SetModualtionMatrix(ISO15415QualityTest qualityTest)
        {
            _qualityTest = qualityTest;

            Text = string.Format("{0} {1}x{2}: Modulation Matrix", qualityTest.BarcodeInfo.BarcodeType,
                qualityTest.BarcodeInfo.MatrixWidth, qualityTest.BarcodeInfo.MatrixHeight);

            UpdateModulationMatrixImage();
        }

        private void cellSizeNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            UpdateModulationMatrixImage();
        }

        private void alphaNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            UpdateModulationMatrixImage();
        }

        /// <summary>
        /// Updates the modulation matrix image.
        /// </summary>
        private void UpdateModulationMatrixImage()
        {
            if (_qualityTest != null)
            {
                Bitmap image = CreateModulationMatrixImage(_qualityTest, (int)cellSizeNumericUpDown.Value, (int)Math.Round(((int)alphaNumericUpDown.Value / 100f) * 255));
                Bitmap oldBitmap = (Bitmap)pictureBox1.Image;
                pictureBox1.Image = image;
                if (oldBitmap != null)
                    oldBitmap.Dispose();
            }
        }

        /// <summary>
        /// Returns the color grade of cell modulation.
        /// </summary>
        /// <param name="modulation">The cell modulation.</param>
        /// <returns>The color.</returns>
        private static Color GetColor(float modulation)
        {
            Color hiColor = Color.FromArgb(0, 192, 0);

            float threshold1 = 0.5f;
            Color threshold1Color = Color.FromArgb(128, 192, 0);

            float threshold2 = 0.3f;
            Color threshold2Color = Color.Orange;

            Color lowColor = Color.Red;

            if (modulation >= threshold1)
                return GetInterpolatedColor(threshold1, threshold1Color, 1, hiColor, modulation);

            if (modulation >= threshold2)
                return GetInterpolatedColor(threshold2, threshold2Color, threshold1, threshold1Color, modulation);

            return GetInterpolatedColor(0, lowColor, threshold2, threshold2Color, modulation);
        }

        /// <summary>
        /// Returns the interpolated color for specified value.
        /// </summary>
        /// <param name="min">The minimum value.</param>
        /// <param name="minColor">Color for minimum value.</param>
        /// <param name="max">The maximum value.</param>
        /// <param name="maxColor">Color for maximum value.</param>
        /// <param name="value">The value.</param>
        /// <returns>The interpolated color for <i>value</i>.</returns>
        private static Color GetInterpolatedColor(float min, Color minColor, float max, Color maxColor, float value)
        {
            float scale = (value - min) / (max - min);
            float r = minColor.R * (1 - scale) + maxColor.R * scale;
            float g = minColor.G * (1 - scale) + maxColor.G * scale;
            float b = minColor.B * (1 - scale) + maxColor.B * scale;
            return Color.FromArgb((int)Math.Round(r), (int)Math.Round(g), (int)Math.Round(b));
        }

        /// <summary>
        /// Creates the modulation matrix image.
        /// </summary>
        /// <param name="qualityTest">The quality test.</param>
        /// <param name="cellSize">The cell size.</param>
        /// <param name="modulationAlpha">The modulation alpha.</param>
        /// <returns>The bitmap.</returns>
        private static Bitmap CreateModulationMatrixImage(ISO15415QualityTest qualityTest, int cellSize, int modulationAlpha)
        {
            float fontSize = cellSize * 0.35f;
            Font textFont = null;
            StringFormat format = null;
            if (fontSize > 5)
            {
                textFont = new Font(SystemFonts.DefaultFont.FontFamily, fontSize);
                format = new StringFormat();
                format.Alignment = StringAlignment.Center;
                format.LineAlignment = StringAlignment.Center;
            }

            float[,] modulationMatrix = qualityTest.ModulationMatrix;
            int matrixHeight = modulationMatrix.GetLength(0);
            int matrixWidth = modulationMatrix.GetLength(1);

            // create bitmap
            Bitmap result = new Bitmap(matrixWidth * cellSize, matrixHeight * cellSize, System.Drawing.Imaging.PixelFormat.Format24bppRgb);

            // draw modulation matrix
            using (SolidBrush foreBrush = new SolidBrush(Color.White))
            {
                using (Graphics g = Graphics.FromImage(result))
                {
                    for (int y = 0; y < matrixHeight; y++)
                    {
                        for (int x = 0; x < matrixWidth; x++)
                        {
                            RectangleF rect = new RectangleF(x * cellSize, y * cellSize, cellSize, cellSize);
                            float modulation = modulationMatrix[y, x];

                            // background
                            Brush backBrush = modulation < 0 ? Brushes.White : Brushes.Black;
                            g.FillRectangle(backBrush, rect);

                            // modulation highlight
                            foreBrush.Color = Color.FromArgb(modulationAlpha, GetColor(Math.Abs(modulation)));
                            g.FillRectangle(foreBrush, rect);

                            if (textFont != null)
                            {
                                // modulation percent
                                string text = Math.Round(Math.Abs(modulation) * 100).ToString();
                                Brush textBrush = modulation >= 0 ? Brushes.White : Brushes.Black;
                                g.DrawString(text, textFont, textBrush, rect, format);
                            }
                        }
                    }
                }
            }

            if (textFont != null)
                textFont.Dispose();

            return result;
        }

        #endregion

    }
}
