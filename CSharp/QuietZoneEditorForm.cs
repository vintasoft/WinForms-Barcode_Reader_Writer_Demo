using System;
using System.Windows.Forms;

using Vintasoft.Barcode;

namespace BarcodeDemo
{
    /// <summary>
    /// A form that allows to change the barcode quiet zones.
    /// </summary>
    public partial class QuietZoneEditorForm : Form
    {

        #region Fields

        /// <summary>
        /// Indicates that all quiet zones can be set using one value.
        /// </summary>
        bool _setAll = false;

        #endregion



        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="QuietZoneEditorForm"/> class.
        /// </summary>
        public QuietZoneEditorForm()
        {
            InitializeComponent();
            Settings = null;
        }

        #endregion



        #region Properties

        WriterSettings _settings = null;
        public WriterSettings Settings
        {
            get
            {
                return _settings;
            }
            set
            {
                _settings = value;
                if (value == null)
                {
                    groupBox1.Enabled = false;
                    topNumericUpDown.Value = 0;
                    bottomNumericUpDown.Value = 0;
                    leftNumericUpDown.Value = 0;
                    rightNumericUpDown.Value = 0;
                }
                else
                {
                    groupBox1.Enabled = true;
                    topNumericUpDown.Value = value.QuietZoneTop;
                    bottomNumericUpDown.Value = value.QuietZoneBottom;
                    leftNumericUpDown.Value = value.QuietZoneLeft;
                    rightNumericUpDown.Value = value.QuietZoneRight;
                }
            }
        }

        #endregion



        #region Methods

        /// <summary>
        /// Sets value of "all" numericUpDown.
        /// </summary>
        private void sideNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (_setAll)
                return;
            if (topNumericUpDown.Value == bottomNumericUpDown.Value &&
                bottomNumericUpDown.Value == leftNumericUpDown.Value &&
                leftNumericUpDown.Value == rightNumericUpDown.Value)
            {
                allNumericUpDown.Value = leftNumericUpDown.Value;
            }
            else
            {
                allNumericUpDown.Value = -1;
            }
        }

        /// <summary>
        /// Handles the ValueChanged event of the allNumericUpDown control.
        /// </summary>
        private void allNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (allNumericUpDown.Value >= 0)
            {
                _setAll = true;
                topNumericUpDown.Value = allNumericUpDown.Value;
                bottomNumericUpDown.Value = allNumericUpDown.Value;
                leftNumericUpDown.Value = allNumericUpDown.Value;
                rightNumericUpDown.Value = allNumericUpDown.Value;
                _setAll = false;
            }
        }

        /// <summary>
        /// Closes this dialog with "Cancel" dialog result.
        /// </summary>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// Closes this dialog with "OK" dialog result.
        /// </summary>
        private void buttonOK_Click(object sender, EventArgs e)
        {
            Settings.QuietZoneTop = (int)topNumericUpDown.Value;
            Settings.QuietZoneBottom = (int)bottomNumericUpDown.Value;
            Settings.QuietZoneLeft = (int)leftNumericUpDown.Value;
            Settings.QuietZoneRight = (int)rightNumericUpDown.Value;

            DialogResult = DialogResult.OK;
        }

        #endregion

    }
}
