using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Vintasoft.Barcode;
using Vintasoft.Barcode.BarcodeInfo;

namespace BarcodeDemo
{
    /// <summary>
    /// A control that allows to change the advanced settings of barcode reader.
    /// </summary>
    public partial class AdvancedReaderSettingsControl : ReaderSettingsEditorControl
    {

        #region Fields

        bool _enableSetSettings = true;

        #endregion



        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="AdvancedReaderSettingsControl"/> class.
        /// </summary>
        public AdvancedReaderSettingsControl()
        {
            _enableSetSettings = false;

            InitializeComponent();

            barcodeReaderAustralianCustomInfoComboBox.Items.AddRange(EnumGetValues(typeof(AustralianPostCustomerInfoFormat)));

            barcodeReaderMSIChecksumComboBox.Items.Add(MSIChecksumType.Mod10);
            barcodeReaderMSIChecksumComboBox.Items.Add(MSIChecksumType.Mod11);
            barcodeReaderMSIChecksumComboBox.Items.Add(MSIChecksumType.Mod10Mod10);
            barcodeReaderMSIChecksumComboBox.Items.Add(MSIChecksumType.Mod11Mod10);
            barcodeReaderMSIChecksumComboBox.Items.Add(MSIChecksumType.None);

            toolTip1.SetToolTip(qrMaxAxialNonuniformityNumericUpDown, "QR maximum axial non-uniformity (x0.01)");

            _enableSetSettings = true;
        }

        #endregion



        #region Properties

        /// <summary>
        /// Gets or sets a value indicating whether barcode reader must interpret ECI characters.
        /// </summary>
        /// <value>
        /// <b>True</b> if barcode reader must interpret ECI characters; otherwise, <b>false</b>.
        /// </value>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
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

        private void barcodeReaderAustralianCustomInfoComboBox_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            SetSettings();
        }

        private void barcodeReaderMSIChecksumComboBox_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            SetSettings();
        }

        private void DataMatrixLPatternMaxErasuresNumericUpDown_ValueChanged(
            object sender,
            EventArgs e)
        {
            SetSettings();
        }

        private void qrMaxANNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            SetSettings();
        }

        /// <summary>
        /// Updates the User Interface.
        /// </summary>
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
            barcodeCharacteristicNormalBarcodesCheckBox.Checked = (BarcodeReaderSettings.BarcodeCharacteristics & BarcodeCharacteristics.NormalSizeBarcodes) != 0;
            qrMaxAxialNonuniformityNumericUpDown.Value = (int)(BarcodeReaderSettings.QrMaxAxialNonuniformity * 100);
            recognitionTimeoutNumericUpDown.Value = BarcodeReaderSettings.RecognitionTimeout;
            code39WithoutStartStopCheckBox.Checked = BarcodeReaderSettings.SearchCode39WithoutStartStop;
            barcodeReaderAustralianCustomInfoComboBox.SelectedItem = BarcodeReaderSettings.AustralianPostCustomerInfoFormat;
            barcodeReaderMSIChecksumComboBox.SelectedItem = BarcodeReaderSettings.MSIChecksum;
            maxCellSizeNumericUpDown.Value = BarcodeReaderSettings.MatrixBarcodeMaxCellSize;
            searchQRModel1CheckBox.Checked = BarcodeReaderSettings.SearchQRModel1Barcodes;
            if (BarcodeReaderSettings.ImageScaleFactor <= 1 / 4f)
                downscale4RadioButton.Checked = true;
            else if (BarcodeReaderSettings.ImageScaleFactor <= 1 / 3f)
                downscale3RadioButton.Checked = true;
            else if (BarcodeReaderSettings.ImageScaleFactor <= 1 / 2f)
                downscale2RadioButton.Checked = true;
            else if (BarcodeReaderSettings.ImageScaleFactor <= 1.5f)
                noScaleRadioButton.Checked = true;
            else if (BarcodeReaderSettings.ImageScaleFactor <= 2f)
                upscale2RadioButton.Checked = true;
            else if (BarcodeReaderSettings.ImageScaleFactor <= 3f)
                upscale3RadioButton.Checked = true;
            invertColorsCheckBox.Checked = BarcodeReaderSettings.InvertImageColors;
            erodeCheckBox.Checked = BarcodeReaderSettings.Erode;
            removePeasCheckBox.Checked = BarcodeReaderSettings.RemovePeas;
            adaptiveBinarizationStepNumericUpDown.Value = BarcodeReaderSettings.AdaptiveBinarizationStep;

            _enableSetSettings = true;
        }

        /// <summary>
        /// Returns the enum values for specified type.
        /// </summary>
        private object[] EnumGetValues(Type type)
        {
            Array ar = Enum.GetValues(type);
            object[] result = new object[ar.Length];
            ar.CopyTo(result, 0);
            return result;
        }

        /// <summary>
        /// Sets the settings.
        /// </summary>
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
            BarcodeReaderSettings.BarcodeCharacteristics = BarcodeCharacteristics.Undefinded;
            if (barcodeCharacteristicSmallBarcodesCheckBox.Checked)
                BarcodeReaderSettings.BarcodeCharacteristics |= BarcodeCharacteristics.SmallBarcodes;
            if (barcodeCharacteristicNormalBarcodesCheckBox.Checked)
                BarcodeReaderSettings.BarcodeCharacteristics |= BarcodeCharacteristics.NormalSizeBarcodes;

            BarcodeReaderSettings.AustralianPostCustomerInfoFormat = (AustralianPostCustomerInfoFormat)barcodeReaderAustralianCustomInfoComboBox.SelectedItem;
            BarcodeReaderSettings.MSIChecksum = (MSIChecksumType)barcodeReaderMSIChecksumComboBox.SelectedItem;
            try
            {
                BarcodeReaderSettings.RecognitionTimeout = (int)recognitionTimeoutNumericUpDown.Value;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            BarcodeReaderSettings.SearchCode39WithoutStartStop = code39WithoutStartStopCheckBox.Checked;
            BarcodeReaderSettings.MatrixBarcodeMaxCellSize = (int)maxCellSizeNumericUpDown.Value;
            BarcodeReaderSettings.QrMaxAxialNonuniformity = (float)qrMaxAxialNonuniformityNumericUpDown.Value / 100f;
            BarcodeReaderSettings.SearchQRModel1Barcodes = searchQRModel1CheckBox.Checked;
            if (downscale4RadioButton.Checked)
                BarcodeReaderSettings.ImageScaleFactor = 1 / 4f;
            else if (downscale3RadioButton.Checked)
                BarcodeReaderSettings.ImageScaleFactor = 1 / 3f;
            else if (downscale2RadioButton.Checked)
                BarcodeReaderSettings.ImageScaleFactor = 1 / 2f;
            else if (noScaleRadioButton.Checked)
                BarcodeReaderSettings.ImageScaleFactor = 1f;
            else if (upscale2RadioButton.Checked)
                BarcodeReaderSettings.ImageScaleFactor = 2f;
            else if (upscale3RadioButton.Checked)
                BarcodeReaderSettings.ImageScaleFactor = 3f;
            BarcodeReaderSettings.InvertImageColors = invertColorsCheckBox.Checked;
            BarcodeReaderSettings.Erode = erodeCheckBox.Checked;
            BarcodeReaderSettings.RemovePeas = removePeasCheckBox.Checked;
            BarcodeReaderSettings.AdaptiveBinarizationStep = (int)adaptiveBinarizationStepNumericUpDown.Value;

            _enableSetSettings = true;
        }

        /// <summary>
        /// Sets BarcodeReaderSettings.RecognitionTimeout value.
        /// </summary>
        private void recognitionTimeoutNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                BarcodeReaderSettings.RecognitionTimeout = (int)recognitionTimeoutNumericUpDown.Value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Sets BarcodeReaderSettings.MatrixBarcodeMaxCellSize value.
        /// </summary>
        private void maxCellSizeNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            BarcodeReaderSettings.MatrixBarcodeMaxCellSize = (int)maxCellSizeNumericUpDown.Value;
        }

        /// <summary>
        /// Raises the <see cref="E:ImageProcessingSettingsChanged" /> event.
        /// </summary>
        private void OnImageProcessingSettingsChanged(EventArgs e)
        {
            if (ImageProcessingSettingsChanged != null)
                ImageProcessingSettingsChanged(this, e);
        }

        /// <summary>
        /// Set the reader settings.
        /// </summary>
        private void imageProcessing_SettingsChanged(object sender, EventArgs e)
        {
            SetSettings();
            OnImageProcessingSettingsChanged(EventArgs.Empty);
        }

        #endregion



        #region Events

        /// <summary>
        /// The image processing settings are changed.
        /// </summary>
        public event EventHandler ImageProcessingSettingsChanged;

        #endregion

    }
}
