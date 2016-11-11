using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace BarcodeDemo
{
    public partial class SelectImageFrameForm : Form
    {

        #region Fields

        string _labelText;

        #endregion



        #region Constructors

        public SelectImageFrameForm()
        {
            InitializeComponent();
            _labelText = label1.Text;
        }

        #endregion



        #region Methods

        public void SelectFrame(Image image)
        {
            FrameDimension dimension = new FrameDimension(image.FrameDimensionsList[0]);
            int frameCount = image.GetFrameCount(dimension);
            if (frameCount == 1)
                return;

            if (frameNumber.Value > frameCount)
                frameNumber.Value = 1;
            frameNumber.Maximum = frameCount;
            label1.Text = string.Format(_labelText, frameCount);
            ShowDialog();
            image.SelectActiveFrame(dimension, (int)frameNumber.Value - 1);
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormPageSelect_FormClosing(object sender, FormClosingEventArgs e)
        {
            Visible = false;
            e.Cancel = true;
        }

        #endregion

    }
}