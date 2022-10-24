﻿using System;
using System.ComponentModel;
using System.Drawing;

using Vintasoft.Barcode;
using Vintasoft.Barcode.BarcodeStructure;
using Vintasoft.Barcode.Gdi;

namespace BarcodeDemo
{
    /// <summary>
    /// Provides a base class for renderers of matrix barcodes.
    /// </summary>
    public class MatrixBarcodeRendererBase : BarcodeGraphicsRenderer
    {

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MatrixBarcodeRendererBase"/> class.
        /// </summary>
        public MatrixBarcodeRendererBase()
        {
        }

        #endregion



        #region Properties

        /// <summary>
        /// Gets or sets a color that is used for drawing of all barcode layers.
        /// </summary>
        [Category("Colors")]
        [Description("A color that is used for drawing of all barcode layers.")]
        public Color ForegroundColor
        {
            get
            {
                if (DataLayerColor.ToArgb() == AlignmentPatternsColor.ToArgb() &&
                    AlignmentPatternsColor.ToArgb() == SearchPatternsColor.ToArgb() &&
                    SearchPatternsColor.ToArgb() == TimingPatternsColor.ToArgb() &&
                    TimingPatternsColor.ToArgb() == FormatInformationColor.ToArgb())
                {
                    return DataLayerColor;
                }
                return Color.Empty;
            }
            set
            {
                DataLayerColor = value;
                AlignmentPatternsColor = value;
                SearchPatternsColor = value;
                TimingPatternsColor = value;
                FormatInformationColor = value;
            }
        }

        Color _dataLayerColor = Color.DarkGreen;
        /// <summary>
        /// Gets or sets a color that is used for drawing the data layer.
        /// </summary>
        [Category("Colors")]
        [Description("A color that is used for drawing the data layer.")]
        public Color DataLayerColor
        {
            get
            {
                return _dataLayerColor;
            }
            set
            {
                _dataLayerColor = value;
            }
        }

        Color _formatInformationColor = Color.FromArgb(230, 120, 0);
        /// <summary>
        /// Gets or sets a color that is used for drawing the format information.
        /// </summary>
        [Category("Colors")]
        [Description("A color that is used for drawing the format information.")]
        public Color FormatInformationColor
        {
            get
            {
                return _formatInformationColor;
            }
            set
            {
                _formatInformationColor = value;
            }
        }

        Color _searchPatternsColor = Color.DarkRed;
        /// <summary>
        /// Gets or sets a color that is used for drawing the search patterns.
        /// </summary>
        [Category("Colors")]
        [Description("A color that is used for drawing the search patterns.")]
        public Color SearchPatternsColor
        {
            get
            {
                return _searchPatternsColor;
            }
            set
            {
                _searchPatternsColor = value;
            }
        }

        Color _timingPatternsColor = Color.Olive;
        /// <summary>
        /// Gets or sets a color that is used for drawing the timing patterns.
        /// </summary>
        [Category("Colors")]
        [Description("A color that is used for drawing the timing patterns.")]
        public Color TimingPatternsColor
        {
            get
            {
                return _timingPatternsColor;
            }
            set
            {
                _timingPatternsColor = value;
            }
        }

        Color _alignmentPatternsColor = Color.Teal;
        /// <summary>
        /// Gets or sets a color that is used for drawing the alignment patterns.
        /// </summary>
        [Category("Colors")]
        [Description("A color that is used for drawing the alignment patterns.")]
        public Color AlignmentPatternsColor
        {
            get
            {
                return _alignmentPatternsColor;
            }
            set
            {
                _alignmentPatternsColor = value;
            }
        }

        float _modulation = 0.7f;
        /// <summary>
        /// Gets or sets the modulation of the rendering barcode.
        /// </summary>
        /// <remarks>
        /// Modulation is difference between the brightness of a "white cell" and
        /// a "black cell" of barcode.<br />
        /// This parameter is used for calculating the color of "white cell"
        /// relatively the color of "black cell".<br />
        /// Barcode with high modulation has better chanсes for recognition.
        /// </remarks>
        /// <value>
        /// <b>0</b> - the "white cells" and "black cells" will be filled
        /// with color of "black cell" and generated barcode will be unrecognizable;<br />
        /// <b>0.7</b> - the color of "white cells" will be 70% lighter than
        /// the color of "black cells".
        /// <b>1</b> - the "white cells" will be filled with white color.
        /// </value>
        /// <seealso cref="GetLightenColor(Color)"/>
        [Category("Design")]
        [Description("Modulation of the rendering barcode.")]
        public float Modulation
        {
            get
            {
                return _modulation;
            }
            set
            {
                _modulation = value;
            }
        }

        #endregion



        #region Methods

        /// <summary>
        /// Returns a color that is lighter than specified color.
        /// </summary>
        /// <param name="color">The color.</param>
        /// <returns>A color that is lighter than specified color.</returns>
        protected Color GetLightenColor(Color color)
        {
            if (color == Color.Black)
                return Color.White;
            int dc = (int)Math.Round(255 * Modulation);
            return Color.FromArgb(
                color.A,
                Math.Min(255, color.R + dc),
                Math.Min(255, color.G + dc),
                Math.Min(255, color.B + dc));
        }

        /// <summary>
        /// Returns a matrix element at specified location.
        /// </summary>
        /// <param name="x">The X-coordiante on barcode matrix.</param>
        /// <param name="y">The Y-coordiante on barcode matrix.</param>
        /// <returns>A matrix element.</returns>
        protected BarcodeElement GetMatrixElement(int x, int y)
        {
            MatrixBarcodeStructure matrixBarcode = BarcodeElement as MatrixBarcodeStructure;
            if (matrixBarcode == null)
                return null;
            return matrixBarcode.GetMatrixElement(x, y);
        }

        /// <summary>
        /// Determines whether cell, at specified coordinate, is located in data layer.
        /// </summary>
        /// <param name="x">The X-coordiante on barcode matrix.</param>
        /// <param name="y">The Y-coordiante on barcode matrix.</param>
        /// <returns>
        /// <b>True</b> if cell is located in data layer; otherwise, <b>false</b>.
        /// </returns>
        protected bool IsDataLayer(int x, int y)
        {
            MatrixBarcodeStructure matrixBarcode = BarcodeElement as MatrixBarcodeStructure;
            if (matrixBarcode == null)
                return false;
            return matrixBarcode.IsDataLayer(x, y);
        }

        /// <summary>
        /// Determines whether cell, at specified coordinate, is located in format information layer.
        /// </summary>
        /// <param name="x">The X-coordiante on barcode matrix.</param>
        /// <param name="y">The Y-coordiante on barcode matrix.</param>
        /// <returns>
        /// <b>True</b> if cell is located in format information layer; otherwise, <b>false</b>.
        /// </returns>
        protected bool IsFormatInformation(int x, int y)
        {
            MatrixBarcodeStructure matrixBarcode = BarcodeElement as MatrixBarcodeStructure;
            if (matrixBarcode == null)
                return false;
            return matrixBarcode.IsFormatInformation(x, y);
        }

        /// <summary>
        /// Determines whether cell, at specified coordinate, is located in a timing pattern.
        /// </summary>
        /// <param name="x">The X-coordiante on barcode matrix.</param>
        /// <param name="y">The Y-coordiante on barcode matrix.</param>
        /// <returns>
        /// <b>True</b> if cell is located in a timing pattern; otherwise, <b>false</b>.
        /// </returns>
        protected bool IsTimingPattern(int x, int y)
        {
            MatrixBarcodeStructure matrixBarcode = BarcodeElement as MatrixBarcodeStructure;
            if (matrixBarcode == null)
                return false;
            return matrixBarcode.IsTimingPattern(x, y);
        }

        /// <summary>
        /// Determines whether cell, at specified coordinate, located in a alignment pattern.
        /// </summary>
        /// <param name="x">The X-coordiante on barcode matrix.</param>
        /// <param name="y">The Y-coordiante on barcode matrix.</param>
        /// <returns>
        /// <b>True</b> if cell is located in a alignment pattern; otherwise, <b>false</b>.
        /// </returns>
        protected bool IsAlignmentPattern(int x, int y)
        {
            MatrixBarcodeStructure matrixBarcode = BarcodeElement as MatrixBarcodeStructure;
            if (matrixBarcode == null)
                return false;
            return matrixBarcode.IsAlignmentPattern(x, y);
        }

        /// <summary>
        /// Determines whether cell, at specified coordinate, is located in a search pattern.
        /// </summary>
        /// <param name="x">The X-coordiante on barcode matrix.</param>
        /// <param name="y">The Y-coordiante on barcode matrix.</param>
        /// <returns>
        /// <b>True</b> if cell is located in a search pattern; otherwise, <b>false</b>.
        /// </returns>
        protected bool IsSearchPattern(int x, int y)
        {
            MatrixBarcodeStructure matrixBarcode = BarcodeElement as MatrixBarcodeStructure;
            if (matrixBarcode == null)
                return false;
            return matrixBarcode.IsSearchPattern(x, y);
        }

        #endregion

    }
}
