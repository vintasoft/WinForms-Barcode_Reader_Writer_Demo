using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Vintasoft.Barcode.GS1;

namespace BarcodeDemo
{
    /// <summary>
    /// A form that allows to edit the GS1 barcode value.
    /// </summary>
    public partial class GS1ValueEditorForm : Form
    {

        #region Fields

        /// <summary>
        /// Indicates that dialog is opened in read-only mode.
        /// </summary>
        bool _readOnly = false;

        /// <summary>
        /// Collection of identifier values.
        /// </summary>
        List<GS1ApplicationIdentifierValue> _identifierValuesList = new List<GS1ApplicationIdentifierValue>();

        #endregion



        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="GS1ValueEditorForm"/> class.
        /// </summary>
        /// <param name="gs1ApplicationIdentifierValues">The GS1 application
        /// identifier values.</param>
        /// <param name="readOnly">Indicates that dialog must be opened in read-only mode.</param>
        public GS1ValueEditorForm(
            GS1ApplicationIdentifierValue[] gs1ApplicationIdentifierValues,
            bool readOnly)
        {
            InitializeComponent();
            addButton.Visible = !readOnly;
            deleteButton.Visible = !readOnly;
            aiNumberComboBox.Enabled = !readOnly;
            gs1BarcodePrintableValueTextBox.ReadOnly = readOnly;
            setPrintableValueButton.Enabled = !readOnly;
            if (!readOnly)
                gs1BarcodePrintableValueTextBox.BackColor = SystemColors.Window;
            GS1ApplicationIdentifier[] applicationIdentifiers = GS1ApplicationIdentifiers.ApplicationIdentifiers;
            for (int i = 0; i < applicationIdentifiers.Length; i++)
                aiNumberComboBox.Items.Add(string.Format("{0}: {1}", applicationIdentifiers[i].ApplicationIdentifier, applicationIdentifiers[i].DataTitle));
            _GS1ApplicationIdentifierValues = gs1ApplicationIdentifierValues;
            _identifierValuesList.AddRange(gs1ApplicationIdentifierValues);
            _readOnly = readOnly;
            aiValueTextBox.ReadOnly = readOnly;
            if (readOnly)
            {
                Text = "GS1 Value Decoder";
            }
            else
            {
                Text = "GS1 Value Editor";
            }
            setDataValueButton.Enabled = !readOnly;
            ShowPrintableValue();
            ShowAIList();
        }

        #endregion



        #region Properties

        GS1ApplicationIdentifierValue[] _GS1ApplicationIdentifierValues;
        /// <summary>
        /// Gets the GS1 application identifier values.
        /// </summary>
        public GS1ApplicationIdentifierValue[] GS1ApplicationIdentifierValues
        {
            get
            {
                return _GS1ApplicationIdentifierValues;
            }
        }

        #endregion



        #region Methods

        /// <summary>
        /// Updates information about data format.
        /// </summary>
        private void aiNumberComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            GS1ApplicationIdentifier ai = GS1ApplicationIdentifiers.ApplicationIdentifiers[aiNumberComboBox.SelectedIndex];
            aiDataContentLabel.Text = ai.DataContent;
            string format = ai.Format;
            if (ai.IsContainsDecimalPoint)
                format += " (with decimal point)";
            aiDataFormatLabel.Text = format;
            aiValueTextBox.Text = "";
        }

        /// <summary>
        /// Sets the current AI number.
        /// </summary>
        private void aiListDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (aiListDataGridView.Rows[e.RowIndex].Cells[0].Value != null)
            {
                aiNumberComboBox.SelectedIndex = GS1ApplicationIdentifiers.IndexOfApplicationIdentifier((string)aiListDataGridView.Rows[e.RowIndex].Cells[0].Value);
                aiValueTextBox.Text = (string)aiListDataGridView.Rows[e.RowIndex].Cells[2].Value;
            }
        }

        /// <summary>
        /// Add new AI data.
        /// </summary>
        private void addButton_Click(object sender, EventArgs e)
        {
            AddNewAI(GS1ApplicationIdentifiers.ApplicationIdentifiers[aiNumberComboBox.SelectedIndex].ApplicationIdentifier, aiValueTextBox.Text);
        }

        /// <summary>
        /// Sets value of current AI.
        /// </summary>
        private void setButton_Click(object sender, EventArgs e)
        {
            if (aiListDataGridView.Rows.Count > 0 && aiListDataGridView.SelectedRows.Count > 0)
            {
                int index = aiListDataGridView.SelectedRows[0].Index;
                GS1ApplicationIdentifierValue ai = null;
                try
                {
                    string number = GS1ApplicationIdentifiers.ApplicationIdentifiers[aiNumberComboBox.SelectedIndex].ApplicationIdentifier;
                    ai = new GS1ApplicationIdentifierValue(GS1ApplicationIdentifiers.FindApplicationIdentifier(number), aiValueTextBox.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                _identifierValuesList[index] = ai;
                aiListDataGridView.Rows[index].Cells[0].Value = ai.ApplicationIdentifier.ApplicationIdentifier;
                aiListDataGridView.Rows[index].Cells[1].Value = ai.ApplicationIdentifier.DataTitle;
                aiListDataGridView.Rows[index].Cells[2].Value = ai.Value;
                ShowPrintableValue();
            }
        }

        /// <summary>
        /// Deletes the selected AI.
        /// </summary>
        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (aiListDataGridView.Rows.Count > 0 && aiListDataGridView.SelectedRows.Count > 0)
            {
                int index = aiListDataGridView.SelectedRows[0].Index;
                _identifierValuesList.RemoveAt(index);
                aiListDataGridView.Rows.RemoveAt(index);
                ShowPrintableValue();
            }
        }

        /// <summary>
        /// Closes this dialog with "OK" dialog result.
        /// </summary>
        private void okButton_Click(object sender, EventArgs e)
        {
            if (SetPrintableValue())
            {
                _GS1ApplicationIdentifierValues = _identifierValuesList.ToArray();
                DialogResult = DialogResult.OK;
            }
        }

        /// <summary>
        /// Closes this dialog with "Cancel" dialog result.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// Shows the list of AI.
        /// </summary>
        private void ShowAIList()
        {
            if (_GS1ApplicationIdentifierValues.Length == 0)
            {
                aiNumberComboBox.SelectedIndex = 0;
            }
            else
            {
                for (int i = 0; i < _identifierValuesList.Count; i++)
                    AddAIToTable(_identifierValuesList[i]);
            }
        }

        /// <summary>
        /// Adds the AI to the visual table.
        /// </summary>
        /// <param name="value">The value.</param>
        private void AddAIToTable(GS1ApplicationIdentifierValue value)
        {
            int index = aiListDataGridView.Rows.Count;
            aiListDataGridView.Rows.Add();
            aiListDataGridView.Rows[index].Cells[0].Value = value.ApplicationIdentifier.ApplicationIdentifier;
            aiListDataGridView.Rows[index].Cells[1].Value = value.ApplicationIdentifier.DataTitle;
            aiListDataGridView.Rows[index].Cells[2].Value = value.Value;
        }

        /// <summary>
        /// Adds the new AI with value to AI list.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <param name="value">The value.</param>
        private void AddNewAI(string number, string value)
        {
            GS1ApplicationIdentifierValue ai = null;
            try
            {
                ai = new GS1ApplicationIdentifierValue(GS1ApplicationIdentifiers.FindApplicationIdentifier(number), value);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _identifierValuesList.Add(ai);
            ShowPrintableValue();
            AddAIToTable(ai);
        }

        /// <summary>
        /// Shows the printable value.
        /// </summary>
        private void ShowPrintableValue()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < _identifierValuesList.Count; i++)
                sb.Append(_identifierValuesList[i].ToString());
            gs1BarcodePrintableValueTextBox.Text = sb.ToString();
        }

        /// <summary>
        /// Sets the printable value.
        /// </summary>
        private bool SetPrintableValue()
        {
            try
            {
                GS1ApplicationIdentifierValue[] values = GS1Codec.ParsePrintableValue(gs1BarcodePrintableValueTextBox.Text);
                _identifierValuesList.Clear();
                _identifierValuesList.AddRange(values);
                aiListDataGridView.Rows.Clear();
                ShowAIList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        /// <summary>
        /// Sets the printable value.
        /// </summary>
        private void setPrintableValueButton_Click(object sender, EventArgs e)
        {
            SetPrintableValue();
        }

        #endregion

    }
}
