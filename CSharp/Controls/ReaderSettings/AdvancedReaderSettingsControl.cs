using System;
using System.ComponentModel;
using System.Drawing;

using Vintasoft.Barcode;
using Vintasoft.Barcode.BarcodeInfo;

namespace BarcodeDemo
{
    /// <summary>
    /// Represents an editor control of advanced reader settings.
    /// </summary>
    public partial class AdvancedReaderSettingsControl : ReaderSettingsEditorControl
    {

        #region Fields

        bool _enableSetSettings = true;

        #endregion



        #region Constructors

        public AdvancedReaderSettingsControl()
        {
            InitializeComponent();

            barcodeReaderAustralianCustomInfoComboBox.Items.AddRange(EnumGetValues(typeof(AustralianPostCustomerInfoFormat)));

            barcodeReaderMSIChecksumComboBox.Items.Add(MSIChecksumType.Mod10);
            barcodeReaderMSIChecksumComboBox.Items.Add(MSIChecksumType.Mod11);
            barcodeReaderMSIChecksumComboBox.Items.Add(MSIChecksumType.Mod10Mod10);
            barcodeReaderMSIChecksumComboBox.Items.Add(MSIChecksumType.Mod11Mod10);
            barcodeReaderMSIChecksumComboBox.Items.Add(MSIChecksumType.None);

            toolTip1.SetToolTip(qrMaxAxialNonuniformityNumericUpDown, "QR maximum axial non-uniformity (x0.01)");
        }


        #endregion



        #region Properties

        BarcodeTypesReaderSettingsControl _barcodeTypesReaderSettings = null;
        [DefaultValue(null)]
        public BarcodeTypesReaderSettingsControl BarcodeTypesReaderSettings
        {
            get
            {
                return _barcodeTypesReaderSettings;
            }
            set
            {
                _barcodeTypesReaderSettings = value;
                UpdateUI();
            }
        }

        public bool InterpretEciCharacters
        {
            get
            {
                return interpretEciCharactersCheckBox.Checked;
            }
            set
            {
                interpretEciCharactersCheckBox.Checked = value;
            }
        }

        #endregion



        #region Methods

        private void settingCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            SetSettings();
        }

        private void barcodeReaderAustralianCustomInfoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetSettings();
        }

        private void barcodeReaderMSIChecksumComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetSettings();
        }

        private void DataMatrixLPatternMaxErasuresNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            SetSettings();
        }


        private void qrMaxANNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            SetSettings();
        }

        public override void UpdateUI()
        {
            _enableSetSettings = false;

            optionalChecksumCheckBox.Checked = BarcodeReaderSettings.OptionalCheckSum;
            if (BarcodeReaderSettings.OptionalCheckSum)
                optionalChecksumCheckBox.ForeColor = Color.Red;
            else
                optionalChecksumCheckBox.ForeColor = Color.Black;
            searchDistortedDataMatrixBarcodesCheckBox.Checked = BarcodeReaderSettings.SearchDistortedDataMatrixBarcodes;
            searchDistortedQRBarcodesCheckBox.Checked = BarcodeReaderSettings.SearchDistortedQRBarcodes;
            telepenEnableNumericModeCheckBox.Checked = BarcodeReaderSettings.EnableTelepenNumericMode;
            collectQualityTestInformationCheckBox.Checked = BarcodeReaderSettings.CollectTestInformation;
            useCode128ExtendedDecodeTableCheckBox.Checked = BarcodeReaderSettings.Code128UseFnc4ShiftToExtendedAsciiTable;
            DataMatrixLPatternMaxErasuresNumericUpDown.Value = BarcodeReaderSettings.DataMatrixLPatternMaxErasures;
            barcodeCharacteristicSmallBarcodesCheckBox.Checked = (BarcodeReaderSettings.BarcodeCharacteristics & BarcodeCharacteristics.SmallBarcodes) != 0;
            qrMaxAxialNonuniformityNumericUpDown.Value = (int)(BarcodeReaderSettings.QRMaxAxialNonuniformity * 100);

            barcodeReaderAustralianCustomInfoComboBox.SelectedItem = BarcodeReaderSettings.AustralianPostCustomerInfoFormat;
            barcodeReaderMSIChecksumComboBox.SelectedItem = BarcodeReaderSettings.MSIChecksum;

            if (_barcodeTypesReaderSettings != null)
            {
                _barcodeTypesReaderSettings.HighlightOptionalChecksumBarcodes = optionalChecksumCheckBox.Checked;
            }

            _enableSetSettings = true;
        }

        private object[] EnumGetValues(Type type)
        {
            Array ar = Enum.GetValues(type);
            object[] result = new object[ar.Length];
            ar.CopyTo(result, 0);
            return result;
        }

        private void SetSettings()
        {
            if (!_enableSetSettings)
                return;

            _enableSetSettings = false;

            BarcodeReaderSettings.OptionalCheckSum = optionalChecksumCheckBox.Checked;
            if (BarcodeReaderSettings.OptionalCheckSum)
                optionalChecksumCheckBox.ForeColor = Color.Red;
            else
                optionalChecksumCheckBox.ForeColor = Color.Black;

            BarcodeReaderSettings.SearchDistortedDataMatrixBarcodes = searchDistortedDataMatrixBarcodesCheckBox.Checked;
            BarcodeReaderSettings.DataMatrixLPatternMaxErasures = (int)DataMatrixLPatternMaxErasuresNumericUpDown.Value;
            BarcodeReaderSettings.SearchDistortedQRBarcodes = searchDistortedQRBarcodesCheckBox.Checked;
            BarcodeReaderSettings.EnableTelepenNumericMode = telepenEnableNumericModeCheckBox.Checked;
            BarcodeReaderSettings.CollectTestInformation = collectQualityTestInformationCheckBox.Checked;
            BarcodeReaderSettings.Code128UseFnc4ShiftToExtendedAsciiTable = useCode128ExtendedDecodeTableCheckBox.Checked;
            if (barcodeCharacteristicSmallBarcodesCheckBox.Checked)
                BarcodeReaderSettings.BarcodeCharacteristics = BarcodeCharacteristics.SmallBarcodes;
            else
                BarcodeReaderSettings.BarcodeCharacteristics = BarcodeCharacteristics.Undefinded;

            BarcodeReaderSettings.AustralianPostCustomerInfoFormat = (AustralianPostCustomerInfoFormat)barcodeReaderAustralianCustomInfoComboBox.SelectedItem;
            BarcodeReaderSettings.MSIChecksum = (MSIChecksumType)barcodeReaderMSIChecksumComboBox.SelectedItem;

            BarcodeReaderSettings.QRMaxAxialNonuniformity = (float)qrMaxAxialNonuniformityNumericUpDown.Value / 100f;

            if (_barcodeTypesReaderSettings != null)
            {
                _barcodeTypesReaderSettings.HighlightOptionalChecksumBarcodes = optionalChecksumCheckBox.Checked;
            }

            _enableSetSettings = true;
        }

        #endregion

    }
}
