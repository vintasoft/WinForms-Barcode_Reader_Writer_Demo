using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using Vintasoft.Barcode;
using Vintasoft.Imaging;

namespace BarcodeDemo
{
    /// <summary>
    /// A form that allows to select a page in PDF document.
    /// </summary>
    public partial class SelectPdfPageForm : Form
    {

        #region Fields

        /// <summary>
        /// The format string of information label.
        /// </summary>
        string _labelFromatString;

        /// <summary>
        /// Indicates that PDF page can be selected.
        /// </summary>
        bool _pageSelected;

        #endregion



        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="SelectPdfPageForm"/> class.
        /// </summary>
        public SelectPdfPageForm()
        {
            InitializeComponent();
            _labelFromatString = label1.Text;
        }

        #endregion



        #region Methods

        /// <summary>
        /// Handles the FormClosing event of this form.
        /// </summary>
        private void FormPdfPageSelect_FormClosing(object sender, FormClosingEventArgs e)
        {
            Visible = false;
            e.Cancel = true;
        }

        /// <summary>
        /// Closes this form.
        /// </summary>
        private void selectButton_Click(object sender, EventArgs e)
        {
            _pageSelected = true;
            Close();
        }


        /// <summary>
        /// Gets the image from PDF page with specified index.
        /// </summary>
        /// <param name="viewer">The PDF viewer.</param>
        /// <param name="pageIndex">Index of the page.</param>
        private Image GetImageFromPage(PdfImageViewer viewer, int pageIndex)
        {
            string[] names = viewer.GetImageNames(pageIndex);
            List<VintasoftBitmap> images = new List<VintasoftBitmap>();
            for (int i = 0; i < names.Length; i++)
            {
                try
                {
                    images.Add(viewer.GetImage(pageIndex, names[i]));
                }
                catch (Exception e)
                {
                    MessageBox.Show(string.Format("Image '{0}': {1}", names[i], e.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (images.Count == 0)
                return null;
            if (images.Count == 1)
                return GdiConverter.Convert(images[0], true);

            // merge images
            int padding = 5;
            int heigth = 0;
            int width = 0;
            int n = images.Count;
            for (int i = 0; i < n; i++)
            {
                VintasoftBitmap current = images[i];
                if (width < current.Width)
                    width = current.Width;
                heigth += current.Height;
            }
            width += 3;
            heigth += (n + 1) * padding;
            Bitmap result = new Bitmap(width, heigth, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            using (Graphics g = Graphics.FromImage(result))
            {
                g.FillRectangle(Brushes.White, new Rectangle(0, 0, width, heigth));
                int y = 1;
                for (int i = 0; i < n; i++)
                {
                    using (Bitmap current = GdiConverter.Convert(images[i], true))
                    {
                        g.DrawImageUnscaled(current, new Point(1, y));
                        y += current.Height + padding;
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Selects the image from PDF document.
        /// </summary>
        /// <param name="pdfFileName">Name of the PDF file.</param>
        public Image SelectImage(string pdfFileName)
        {
            PdfImageViewer viewer;
            try
            {
                viewer = new PdfImageViewer(pdfFileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            try
            {
                pages.Items.Clear();
                for (int i = 0; i < viewer.PageCount; i++)
                {
                    int k = viewer.GetImageNames(i).Length;
                    if (k > 0)
                        pages.Items.Add(i + 1);
                }
                if (pages.Items.Count == 0)
                {
                    MessageBox.Show("Images in PDF file are not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                pages.SelectedIndex = 0;

                if (pages.Items.Count == 1)
                {
                    return GetImageFromPage(viewer, 0);
                }

                label1.Text = string.Format(_labelFromatString, pages.Items.Count);

                _pageSelected = false;
                ShowDialog();
                if (_pageSelected)
                {
                    Image result = GetImageFromPage(viewer, (int)pages.SelectedItem - 1);
                    return result;
                }

                return null;
            }
            finally
            {
                viewer.Dispose();
            }
        }

        #endregion

    }
}