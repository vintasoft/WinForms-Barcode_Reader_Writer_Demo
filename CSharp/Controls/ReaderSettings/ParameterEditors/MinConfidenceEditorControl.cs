namespace BarcodeDemo
{
    /// <summary>
    /// Represents an editor control of ReaderSettings.MinConfidence parameter.
    /// </summary>
    public class MinConfidenceEditorControl: ParameterEditorControl
    {

        #region Constructors

        public MinConfidenceEditorControl()
        {
            Minimum = 0;
            Maximum = 100;
            Value = 95;
            Title = "Min Confidence";
            TickFrequency = 2;
        }

        #endregion



        #region Properties

        /// <summary>
        /// Gets or sets a property value.
        /// </summary>
        public override int Value
        {
            get
            {
                return BarcodeReaderSettings.MinConfidence;
            }
            set
            {
                base.Value = value;
                BarcodeReaderSettings.MinConfidence = value;
            }
        }

        #endregion



        #region Methods

        public override string GetValueAsString()
        {
            string template = "{0}%";
            if (Value == 0)
                template = "0% - show all barcodes";
            else
                if (Value == 100)
                    template = "{0}% show recognized(no read errors) barcodes";
                else
                    if (Value >= 95)
                        template = "{0}% - show recognized barcodes";
            return string.Format(template, Value);
        }

        #endregion

    }
}
