﻿using System;
using System.Drawing;
using System.Windows.Forms;
using Vintasoft.Barcode.BarcodeStructure;

using Vintasoft.Barcode;
using Vintasoft.Barcode.Gdi;

namespace BarcodeDemo.Controls
{
    /// <summary>
    /// A control that allows to display barcode generated by the barcode renderer.
    /// </summary>
    public class BarcodeStructureViewer : UserControl
    {

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BarcodeStructureViewer"/> class.
        /// </summary>
        public BarcodeStructureViewer()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            SetStyle(ControlStyles.ResizeRedraw, true);
            SetStyle(ControlStyles.ContainerControl, false);
        }

        #endregion



        #region Properties

        float _renderingScale = 5;
        /// <summary>
        /// Gets or sets the rendering scale.
        /// </summary>
        public float RenderingScale
        {
            get
            {
                return _renderingScale;
            }
            set
            {
                _renderingScale = value;
                Invalidate();
            }
        }


        BarcodeGraphicsRenderer _barcodeStructureRender;
        /// <summary>
        /// Gets or sets the barcode renderer.
        /// </summary>
        public BarcodeGraphicsRenderer BarcodeRenderer
        {
            get
            {
                return _barcodeStructureRender;
            }
            set
            {
                _barcodeStructureRender = value;
                Invalidate();
            }
        }

        #endregion



        #region Methods

        /// <summary>
        /// Raises the <see cref="System.Windows.Forms.Control.Paint"/> event.
        /// </summary>
        /// <param name="e">A <see cref="System.Windows.Forms.PaintEventArgs"/> that
        /// contains the event data.</param>
        protected override void OnPaint(PaintEventArgs e)
        {
            if (_barcodeStructureRender != null)
            {
                BarcodeElement barcodeElement = BarcodeRenderer.BarcodeElement;
                if (barcodeElement != null)
                {
                    Rectangle bbox = GdiConverter.Convert(barcodeElement.GetBoundingBox());
                    float dx = Math.Abs(bbox.X) * RenderingScale + (Width - barcodeElement.Width * RenderingScale) / 2;
                    float dy = Math.Abs(bbox.Y) * RenderingScale + (Height - barcodeElement.Height * RenderingScale) / 2;
                    e.Graphics.TranslateTransform(dx, dy);
                    e.Graphics.ScaleTransform(RenderingScale, RenderingScale);
                    _barcodeStructureRender.Graphics = e.Graphics;
                    _barcodeStructureRender.Render();
                }
            }
        }

        #endregion

    }
}