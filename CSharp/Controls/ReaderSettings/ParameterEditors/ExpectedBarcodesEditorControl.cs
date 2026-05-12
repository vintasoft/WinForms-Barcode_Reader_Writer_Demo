using System.ComponentModel;

namespace BarcodeDemo
{
    /// <summary>
    /// A control that allows to change the ReaderSettings.ExpectedBarcodes parameter.
    /// </summary>
    public class ExpectedBarcodesEditorControl : ParameterEditorControl
    {
        
        #region Constructors
        
        /// <summary>
        /// Initializes a new instance of the <see cref="ExpectedBarcodesEditorControl"/> class.
        /// </summary>
        public ExpectedBarcodesEditorControl()
        {
            Minimum = 0;
            Maximum = 100;
            Value = 1;
            Title = "Expected barcodes";
            TickFrequency = 2;
        }

        #endregion



        #region Properties

        /// <summary>
        /// Gets or sets a property value.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public override int Value
        {
            get
            {
                return BarcodeReaderSettings.ExpectedBarcodes;
            }
            set
            {
                base.Value = value;
                BarcodeReaderSettings.ExpectedBarcodes = value;
            }
        }

        #endregion


        #region Methods

        public override string GetValueAsString()
        {
            if (Value == 0)
                return "AUTO";
            return base.GetValueAsString();
        }

        #endregion

    }
}
