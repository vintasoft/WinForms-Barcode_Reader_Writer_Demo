using System;

namespace BarcodeDemo
{
    /// <summary>
    /// Represents a slave parameter editor control.
    /// </summary>
    public class ParameterSlaveEditorControl: ParameterEditorControl
    {

        #region Properties

        ParameterEditorControl _masterParameterEditor;
        /// <summary>
        /// Gets or sets a master parameter editor.
        /// </summary>
        public ParameterEditorControl MasterParameterEditor
        {
            get
            {
                return _masterParameterEditor;
            }
            set
            {
                if (_masterParameterEditor != value)
                {
                    if (_masterParameterEditor != null)
                    {
                        _masterParameterEditor.ValueChanged -= new EventHandler(MasterParameterEditor_ValueChanged);
                    }
                    _masterParameterEditor = value;
                    if (_masterParameterEditor != null)
                    {
                        // Copy properties.
                        Enabled = _masterParameterEditor.Enabled;
                        _masterParameterEditor.ValueChanged += new EventHandler(MasterParameterEditor_ValueChanged);
                        Minimum = _masterParameterEditor.Minimum;
                        Maximum = _masterParameterEditor.Maximum;
                        Value = _masterParameterEditor.Value;
                        Title = _masterParameterEditor.Title;
                        TickFrequency = _masterParameterEditor.TickFrequency;

                    }
                    else
                    {
                        Enabled = false;
                    }
                }
            }
        }

        /// <summary>
        /// Gets or sets a property value.
        /// </summary>
        public override int Value
        {
            get
            {
                return base.Value;
            }
            set
            {
                base.Value = value;
                _masterParameterEditor.Value = value;
            }
        }

        #endregion



        #region Methods

        protected override void OnValueChanged()
        {
            base.OnValueChanged();
            MasterParameterEditor.Value = Value;
        }

        private void MasterParameterEditor_ValueChanged(object sender, EventArgs e)
        {
            Value = _masterParameterEditor.Value;
        }
  

        #endregion

    }
}
