using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Forms;

using Vintasoft.Barcode;

namespace BarcodeDemo
{
    /// <summary>
    /// A form that allows to set size of barcode image.
    /// </summary>
    public partial class GetSizeForm : Form
    {

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSizeForm"/> class.
        /// </summary>
        public GetSizeForm()
        {
            InitializeComponent();
            unitsValueEditor.Items.Add(UnitOfMeasure.Pixels);
            unitsValueEditor.Items.Add(UnitOfMeasure.Inches);
            unitsValueEditor.Items.Add(UnitOfMeasure.Centimeters);
            unitsValueEditor.Items.Add(UnitOfMeasure.Millimeters);
            unitsValueEditor.SelectedItem = UnitOfMeasure.Pixels;
        }

        #endregion



        #region Properties

        /// <summary>
        /// Gets or sets an image width, in units.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public float WidthValue
        {
            get
            {
                return (float)widthValueEditor.Value;
            }
            set
            {
                widthValueEditor.Value = (decimal)value;
            }
        }

        /// <summary>
        /// Gets or sets an image height, in units.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public float HeightValue
        {
            get
            {
                return (float)heightValueEditor.Value;
            }
            set
            {
                heightValueEditor.Value = (decimal)value;
            }
        }

        /// <summary>
        /// Gets or sets the unit of measure of width and height.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public UnitOfMeasure UnitsValue
        {
            get
            {
                return (UnitOfMeasure)unitsValueEditor.SelectedItem;
            }
            set
            {
                unitsValueEditor.SelectedItem = value;
            }
        }

        /// <summary>
        /// Gets or sets an image resolution.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public float ResolutionValue
        {
            get
            {
                return (float)resolutionValueEditor.Value;
            }
            set
            {
                resolutionValueEditor.Value = (int)Math.Round(value);
            }
        }

        #endregion



        #region Methods

        /// <summary>
        /// Closes this dialog with "OK" dialog result.
        /// </summary>
        private void buttonOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        /// <summary>
        /// Closes this dialog with "Cancel" dialog result.
        /// </summary>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        #endregion

    }
}