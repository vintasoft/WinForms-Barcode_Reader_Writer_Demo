using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace BarcodeDemo
{
    /// <summary>
    /// A form that allows to select the frame in a multipage image file.
    /// </summary>
    public partial class SelectImageFrameForm : Form
    {

        #region Fields

        /// <summary>
        /// The format string of information label.
        /// </summary>
        string _labelFormatString;

        #endregion



        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="SelectImageFrameForm"/> class.
        /// </summary>
        public SelectImageFrameForm()
        {
            InitializeComponent();
            _labelFormatString = label1.Text;
        }

        #endregion



        #region Methods

        /// <summary>
        /// Selects the frame of specified image.
        /// </summary>
        /// <param name="image">The image.</param>
        public void SelectFrame(Image image)
        {
            FrameDimension dimension = new FrameDimension(image.FrameDimensionsList[0]);
            int frameCount = image.GetFrameCount(dimension);
            if (frameCount == 1)
                return;

            if (frameNumber.Value > frameCount)
                frameNumber.Value = 1;
            frameNumber.Maximum = frameCount;
            label1.Text = string.Format(_labelFormatString, frameCount);
            ShowDialog();
            image.SelectActiveFrame(dimension, (int)frameNumber.Value - 1);
        }

        /// <summary>
        /// Closes this form.
        /// </summary>
        private void selectButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Handles the FormClosing event of this form.
        /// </summary>
        private void FormPageSelect_FormClosing(object sender, FormClosingEventArgs e)
        {
            Visible = false;
            e.Cancel = true;
        }

        #endregion

    }
}