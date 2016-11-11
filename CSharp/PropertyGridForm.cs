using System;
using System.Windows.Forms;

namespace BarcodeDemo
{
    public partial class PropertyGridForm : Form
    {

        #region Constructor

        public PropertyGridForm(object obj, string formTitle)
            : this(obj, formTitle, false)
        {
        }

        public PropertyGridForm(object obj, string formTitle, bool canCancel)
        {
            InitializeComponent();
            Text = formTitle;
            buttonCancel.Enabled = canCancel;
            _propertyGrid.SelectedObject = obj;
        }

        #endregion


        #region Properties

        public PropertyGrid PropertyGrid
        {
            get
            {
                return _propertyGrid;
            }
        }

        #endregion


        #region Methods

        private void buttonOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        #endregion

    }
}
