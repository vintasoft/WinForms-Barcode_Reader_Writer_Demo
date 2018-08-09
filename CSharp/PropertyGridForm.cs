using System;
using System.Windows.Forms;

namespace BarcodeDemo
{
    /// <summary>
    /// A form that allows to show a grid with object properties.
    /// </summary>
    public partial class PropertyGridForm : Form
    {

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyGridForm"/> class.
        /// </summary>
        /// <param name="obj">The object, which must be shown in property grid.</param>
        /// <param name="formTitle">The form title.</param>
        public PropertyGridForm(object obj, string formTitle)
            : this(obj, formTitle, false)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyGridForm"/> class.
        /// </summary>
        /// <param name="obj">The object, which must be shown in property grid.</param>
        /// <param name="formTitle">The form title.</param>
        /// <param name="canCancel">Indicates that form must have "Cancel" button.</param>
        public PropertyGridForm(object obj, string formTitle, bool canCancel)
        {
            InitializeComponent();
            Text = formTitle;
            buttonCancel.Enabled = canCancel;
            _propertyGrid.SelectedObject = obj;
        }

        #endregion



        #region Properties

        /// <summary>
        /// Gets the property grid.
        /// </summary>
        public PropertyGrid PropertyGrid
        {
            get
            {
                return _propertyGrid;
            }
        }

        #endregion



        #region Methods

        /// <summary>
        /// Closes this dialog with "OK" result.
        /// </summary>
        private void buttonOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        /// <summary>
        /// Closes this dialog with "Cancel" result.
        /// </summary>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        #endregion

    }
}
