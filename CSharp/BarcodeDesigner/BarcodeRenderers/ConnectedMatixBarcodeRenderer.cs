﻿using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;

using Vintasoft.Barcode;
using Vintasoft.Barcode.BarcodeStructure;

namespace BarcodeDemo
{
    /// <summary>
    /// A matrix barcode renderer that connects the barcode cells using the custom logic.
    /// </summary>
    public class ConnectedMatixBarcodeRenderer : DotMatixBarcodeRenderer
    {

        #region Fields

        /// <summary>
        /// Matrix that stores connection condition for cells.
        /// </summary>
        bool[,] _canConnectCellMatrix;

        /// <summary>
        /// The barcode X location.
        /// </summary>
        int _barcodeX;

        /// <summary>
        /// The barcode Y location.
        /// </summary>
        int _barcodeY;

        #endregion



        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectedMatixBarcodeRenderer"/> class.
        /// </summary>
        public ConnectedMatixBarcodeRenderer()
        {
        }

        #endregion



        #region Properties

        bool _drawMultiplyConnectedDots = true;
        /// <summary>
        /// Gets or sets a value indicating whether renderer must draw multiply connected cells.
        /// </summary>
        /// <value>
        /// <b>True</b> if renderer must draw multiply connected cells; otherwise, <b>false</b>.
        /// </value>
        [Category("Design")]
        [Description("Indicates that renderer must draw multiply connected cells.")]
        public bool DrawMultiplyConnectedCells
        {
            get
            {
                return _drawMultiplyConnectedDots;
            }
            set
            {
                _drawMultiplyConnectedDots = value;
            }
        }


        bool _connectOrthogonalCells = true;
        /// <summary>
        /// Gets or sets a value indicating whether renderer must connect the orthogonal cells.
        /// </summary>
        /// <value>
        /// <b>True</b> if renderer must connect the orthogonal cells; otherwise, <b>false</b>.
        /// </value>
        [Category("Design")]
        [Description("Indicates that renderer must connect the orthogonal cells.")]
        public bool ConnectOrthogonalCells
        {
            get
            {
                return _connectOrthogonalCells;
            }
            set
            {
                _connectOrthogonalCells = value;
            }
        }


        bool _connectDiagonalCells = false;
        /// <summary>
        /// Gets or sets a value indicating whether renderer must connect the diagonal cells.
        /// </summary>
        /// <value>
        /// <b>True</b> if renderer must connect the diagonal cells; otherwise, <b>false</b>.
        /// </value>
        [Category("Design")]
        [Description("Indicates that renderer must connect the diagonal cells.")]
        public bool ConnectDiagonalCells
        {
            get
            {
                return _connectDiagonalCells;
            }
            set
            {
                _connectDiagonalCells = value;
            }
        }

        float _connectionLineWidthFactor = 0.3f;
        /// <summary>
        /// Gets or sets the factor of connection line width.
        /// </summary>
        [Category("Design")]
        [Description("Factor of connection line width.")]
        public float ConnectionLineWidthFactor
        {
            get
            {
                return _connectionLineWidthFactor;
            }
            set
            {
                _connectionLineWidthFactor = value;
            }
        }

        #endregion



        #region Methods

        #region PUBLIC

        /// <summary>
        /// Renders the barcode.
        /// </summary>
        /// <seealso cref="BarcodeElement" />
        public override void Render()
        {
            // create cached matrix that stores connection condition for cells
            Rectangle barcodeBBox = GdiConverter.Convert(BarcodeElement.GetBoundingBox());
            _barcodeX = barcodeBBox.X;
            _barcodeY = barcodeBBox.Y;
            _canConnectCellMatrix = new bool[barcodeBBox.Height, barcodeBBox.Width];
            for (int y = 0; y < barcodeBBox.Height; y++)
            {
                for (int x = 0; x < barcodeBBox.Width; x++)
                {
                    int bx = x + _barcodeX;
                    int by = y + _barcodeY;
                    // connection condition for cells
                    _canConnectCellMatrix[y, x] =
                        IsDataLayer(bx, by) ||
                        IsFormatInformation(bx, by) ||
                        IsTimingPattern(bx, by) ||
                        (!DrawAlignmentPatternAsSinglePattern && IsAlignmentPattern(bx, by));
                }
            }

            base.Render();
        }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return "Connected Matrix";
        }

        #endregion


        #region PROTECTED

        /// <summary>
        /// Renders the barcode element.
        /// </summary>
        /// <param name="barcodeElement">The barcode element to render.</param>
        /// <param name="x">The X-coordinate, where barcode element must be rendered.</param>
        /// <param name="y">The Y-coordinate, where barcode element must be rendered.</param>
        protected override void RenderBarcodeElement(BarcodeElement barcodeElement, int x, int y)
        {
            if (Modulation == 1)
                if (barcodeElement == BarcodeElements.WhiteCell)
                    return;

            int connectionCount = 0;

            // if element is "black cell" or "white cell"
            bool isMatrixCell = false;
            if (barcodeElement == BarcodeElements.BlackCell)
                isMatrixCell = true;
            else if (barcodeElement == BarcodeElements.WhiteCell)
                isMatrixCell = true;
            if (isMatrixCell)
            {
                // if can connect this cell
                if (CanConnectCell(x, y))
                {
                    // select cell color
                    Color color;
                    if (IsDataLayer(x, y))
                        color = DataLayerColor;
                    else if (IsAlignmentPattern(x, y))
                        color = AlignmentPatternsColor;
                    else if (IsFormatInformation(x, y))
                        color = FormatInformationColor;
                    else if (IsTimingPattern(x, y))
                        color = TimingPatternsColor;
                    else
                        throw new NotImplementedException();
                    
                    // if is white cell, get lighten color
                    if (barcodeElement == BarcodeElements.WhiteCell)
                        color = GetLightenColor(color);
                    
                    // if color not equals a background color
                    if (color.ToArgb() != BackgroundColor.ToArgb())
                    {
                        // create drawing pen
                        using (Pen pen = new Pen(color, DotDiameter * ConnectionLineWidthFactor))
                        {
                            pen.EndCap = LineCap.Round;
                            pen.StartCap = LineCap.Round;
                            float cx = x + 0.5f;
                            float cy = y + 0.5f;
                            pen.LineJoin = LineJoin.Round;
                            MatrixBarcodeStructure barcode = (MatrixBarcodeStructure)BarcodeElement;

                            // check connections of a cell at all sides
                            bool leftBottom = NeedConnectCells(x, y, x - 1, y + 1);
                            bool rightBottom = NeedConnectCells(x, y, x + 1, y + 1);
                            bool leftTop = NeedConnectCells(x, y, x - 1, y - 1);
                            bool rightTop = NeedConnectCells(x, y, x + 1, y - 1);
                            bool top = NeedConnectCells(x, y, x, y - 1);
                            bool left = NeedConnectCells(x, y, x - 1, y);
                            bool right = NeedConnectCells(x, y, x + 1, y);
                            bool bottom = NeedConnectCells(x, y, x, y + 1);
                            // if need connect the diagonal cells
                            if (ConnectDiagonalCells && (leftBottom || rightBottom || leftTop || rightTop))
                            {
                                if (leftBottom)
                                    connectionCount++;
                                if (rightBottom)
                                    connectionCount++;
                                if (leftTop)
                                    connectionCount++;
                                if (rightTop)
                                    connectionCount++;
                                if (leftBottom)
                                    Graphics.DrawLine(pen, cx, cy, cx - 1, cy + 1);
                                if (rightBottom)
                                    Graphics.DrawLine(pen, cx, cy, cx + 1, cy + 1);
                            }
                            // if need connect the orthogonal cells
                            if (ConnectOrthogonalCells)
                            {
                                if (left || right || bottom || top)
                                {
                                    if (left)
                                        connectionCount++;
                                    if (right)
                                        connectionCount++;
                                    if (bottom)
                                        connectionCount++;
                                    if (top)
                                        connectionCount++;
                                    if (left)
                                        Graphics.DrawLine(pen, cx, cy, cx - 1, cy);
                                    if (right)
                                        Graphics.DrawLine(pen, cx, cy, cx + 1, cy);
                                    if (bottom)
                                        Graphics.DrawLine(pen, cx, cy, cx, cy + 1);
                                }
                            }
                        }
                    }
                }
            }
            if (connectionCount < 2 || DrawMultiplyConnectedCells)
                base.RenderBarcodeElement(barcodeElement, x, y);
        }

        #endregion


        #region PRIVATE

        /// <summary>
        /// Determines whether renderer can connect cell at specified location.
        /// </summary>
        /// <param name="x">The X-coordinate of cell.</param>
        /// <param name="y">The Y-coordinate of cell.</param>
        private bool CanConnectCell(int x, int y)
        {
            x -= _barcodeX;
            if (x < 0 || x >= _canConnectCellMatrix.GetLength(1))
                return false;
            y -= _barcodeY;
            if (y < 0 || y >= _canConnectCellMatrix.GetLength(0))
                return false;
            return _canConnectCellMatrix[y, x];
        }

        /// <summary>
        /// Determines whether renderer must connect cells at specified locations.
        /// </summary>
        /// <param name="x1">The X-coordinate of cell 1.</param>
        /// <param name="y1">The Y-coordinate of cell 1.</param>
        /// <param name="x2">The X-coordinate of cell 2.</param>
        /// <param name="y2">The Y-coordinate of cell 2.</param>
        private bool NeedConnectCells(int x1, int y1, int x2, int y2)
        {
            if (CanConnectCell(x1, y1) &&
                CanConnectCell(x2, y2) &&
                GetMatrixElement(x1, y1) == GetMatrixElement(x2, y2))
            {
                if (IsAlignmentPattern(x1, y1) || IsAlignmentPattern(x2, y2))
                    return IsAlignmentPattern(x1, y1) && IsAlignmentPattern(x2, y2);
                if (TimingPatternsColor.ToArgb() != DataLayerColor.ToArgb())
                {
                    if (IsTimingPattern(x1, y1) || IsTimingPattern(x2, y2))
                        return IsTimingPattern(x1, y1) && IsTimingPattern(x2, y2);
                }
                if (FormatInformationColor.ToArgb() != DataLayerColor.ToArgb())
                {
                    if (IsFormatInformation(x1, y1) || IsFormatInformation(x2, y2))
                        return IsFormatInformation(x1, y1) && IsFormatInformation(x2, y2);
                }
                return true;
            }
            return false;
        }

        #endregion

        #endregion

    }
}
