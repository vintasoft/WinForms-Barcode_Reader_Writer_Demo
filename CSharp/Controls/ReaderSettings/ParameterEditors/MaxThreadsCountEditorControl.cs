using System;

namespace BarcodeDemo
{
    /// <summary>
    /// Represents an editor control of ReaderSettings.MaximalThreadsCount parameter.
    /// </summary>
    public class MaxThreadsCountEditorControl: ParameterEditorControl
    {

        #region Constructors

        public MaxThreadsCountEditorControl()
        {
            Minimum = 1;
            Maximum = Math.Max(Environment.ProcessorCount * 2, BarcodeReaderSettings.MaximalThreadsCount);
            Value = BarcodeReaderSettings.MaximalThreadsCount;
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
                return Math.Min(Maximum, Math.Max(Minimum, BarcodeReaderSettings.MaximalThreadsCount));
            }
            set
            {
                base.Value = value;
                BarcodeReaderSettings.MaximalThreadsCount = base.Value;
            }
        }

        #endregion

    }
}
