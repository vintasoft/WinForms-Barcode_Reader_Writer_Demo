using System;

namespace BarcodeDemo
{
    /// <summary>
    /// A control that allows to change the ReaderSettings.MaximumThreadCount parameter.
    /// </summary>
    public class MaxThreadCountEditorControl: ParameterEditorControl
    {

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MaxThreadCountEditorControl"/> class.
        /// </summary>
        public MaxThreadCountEditorControl()
        {
            Minimum = 1;
            Maximum = Math.Max(Environment.ProcessorCount * 2, BarcodeReaderSettings.MaximumThreadCount);
            Value = BarcodeReaderSettings.MaximumThreadCount;
            Title = "Max threads count";
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
                return Math.Min(Maximum, Math.Max(Minimum, BarcodeReaderSettings.MaximumThreadCount));
            }
            set
            {
                base.Value = value;
                BarcodeReaderSettings.MaximumThreadCount = base.Value;
            }
        }

        #endregion

    }
}
