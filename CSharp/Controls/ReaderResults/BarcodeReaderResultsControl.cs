using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

using Vintasoft.Barcode;
using Vintasoft.Barcode.BarcodeInfo;
using Vintasoft.Barcode.GS1;
using Vintasoft.Barcode.SymbologySubsets;
using Vintasoft.Barcode.SymbologySubsets.AAMVA;
using Vintasoft.Barcode.SymbologySubsets.Hibc;
using Vintasoft.Barcode.SymbologySubsets.Isbt128;

namespace BarcodeDemo
{
    /// <summary>
    /// A control that shows the barcode reader results.
    /// </summary>
    public partial class BarcodeReaderResultsControl : UserControl
    {

        #region Fields

        /// <summary>
        /// Indicates that the barcode value must NOT be shown.
        /// </summary>
        bool _disableShowingValue = false;

        #endregion



        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="BarcodeReaderResultsControl"/> class.
        /// </summary>
        public BarcodeReaderResultsControl()
        {
            InitializeComponent();

            readerTextEncodingComboBox.Items.Add("Default");
            EncodingInfo[] encodings = Encoding.GetEncodings();
            for (int i = 0; i < encodings.Length; i++)
                readerTextEncodingComboBox.Items.Add(string.Format("{0}: {1} [{2}]", encodings[i].CodePage, encodings[i].DisplayName, encodings[i].Name));
            readerTextEncodingComboBox.SelectedIndex = 0;
        }

        #endregion



        #region Properties

        IBarcodeInfo[] _recognizedBarcodes;
        /// <summary>
        /// Gets or sets the recognized barcodes.
        /// </summary>
        public IBarcodeInfo[] RecognizedBarcodes
        {
            get
            {
                return _recognizedBarcodes;
            }
            set
            {
                _recognizedBarcodes = value;

                ResetUI();
            }
        }

        int _barcodeInfoIndex = 0;
        /// <summary>
        /// Gets or sets the index of current barcode.
        /// </summary>
        public int BarcodeInfoIndex
        {
            get
            {
                return _barcodeInfoIndex;
            }
            set
            {
                _barcodeInfoIndex = value;

                ResetUI();
            }
        }

        Image _barcodeImage;
        /// <summary>
        /// Gets or sets the image with barcodes.
        /// </summary>
        public Image BarcodeImage
        {
            get
            {
                return _barcodeImage;
            }
            set
            {
                _barcodeImage = value;
            }
        }

        bool _invertBarcodeImage = false;
        /// <summary>
        /// Gets or sets a value indicating whether barcode image is inverted.
        /// </summary>
        public bool InvertBarcodeImage
        {
            get
            {
                return _invertBarcodeImage;
            }
            set
            {
                _invertBarcodeImage = value;
            }
        }

        bool _interpretEciCharacters = false;
        /// <summary>
        /// Gets or sets a value indicating whether the barcode reader must interpret ECI characters.
        /// </summary>
        /// <value>
        /// <b>True</b> if barcode reader must interpret ECI characters; otherwise, <b>false</b>.
        /// </value>
        public bool InterpretEciCharacters
        {
            get
            {
                return _interpretEciCharacters;
            }
            set
            {
                _interpretEciCharacters = value;
            }
        }

        #endregion



        #region Methods

        /// <summary>
        /// Resets an user interface.
        /// </summary>
        private void ResetUI()
        {
            if (_recognizedBarcodes == null || _recognizedBarcodes.Length <= _barcodeInfoIndex)
                _barcodeInfoIndex = 0;
            if (_recognizedBarcodes == null || _recognizedBarcodes.Length == 0)
            {
                selectedBarcodeNumericUpDown.Minimum = 0;
                selectedBarcodeNumericUpDown.Maximum = 0;
                selectedBarcodeNumericUpDown.Value = 0;
                ShowBarcodeInformation(null);
                totalBarcodesLabel.Text = "0";
            }
            else
            {
                _disableShowingValue = true;
                selectedBarcodeNumericUpDown.Minimum = 1;
                selectedBarcodeNumericUpDown.Maximum = _recognizedBarcodes.Length;
                selectedBarcodeNumericUpDown.Value = _barcodeInfoIndex + 1;
                _disableShowingValue = false;
                MoveToBarcode(_barcodeInfoIndex);
                totalBarcodesLabel.Text = _recognizedBarcodes.Length.ToString();
            }
        }

        /// <summary>
        /// Removes a special characters from specified string.
        /// </summary>
        private string RemoveSpecialCharacters(string text)
        {
            StringBuilder sb = new StringBuilder();
            if (text != null)
            {
                for (int i = 0; i < text.Length; i++)
                {
                    if (text[i] >= ' ' || text[i] == '\n' || text[i] == '\r' || text[i] == '\t')
                        sb.Append(text[i]);
                    else
                        sb.Append('?');
                }
            }
            return sb.ToString();
        }

        /// <summary>
        /// Displays the specified barcode info.
        /// </summary>
        private void ShowBarcodeInformation(IBarcodeInfo info)
        {
            if (info == null)
            {
                barcodeTypeLabel.Text = "";
                confidenceLabel.Text = "";
                readingQualityLabel.Text = "";
                directionLabel.Text = "";
                boundRectnalgeLabel.Text = "";
                rotationAngleLabel.Text = "";
                thresholdLabel.Text = "";
                barcodeValueAsGS1RadioButton.Enabled = showGS1DecoderButton.Enabled = false;
                structureAppendLabel.Visible = false;
            }
            else
            {
                if (info is BarcodeSubsetInfo)
                    barcodeTypeLabel.Text = ((BarcodeSubsetInfo)info).BarcodeSubset.ToString();
                else
                    barcodeTypeLabel.Text = info.BarcodeType.ToString();

                if (info is StructuredAppendBarcodeInfo)
                    barcodeTypeLabel.Text += " (Reconstructed)";

                if (info.Confidence == ReaderSettings.ConfidenceNotAvailable)
                {
                    confidenceLabel.Text = "N/A";
                    confidenceLabel.ForeColor = Color.Black;
                }
                else
                {
                    confidenceLabel.Text = info.Confidence.ToString() + "%";
                    if (info.Confidence < 95)
                        confidenceLabel.ForeColor = Color.Red;
                    else
                        confidenceLabel.ForeColor = Color.Green;
                }
                readingQualityLabel.Text = info.ReadingQuality.ToString("F3");
                if (info.ReadingQuality <= 0.5)
                    readingQualityLabel.ForeColor = Color.Red;
                else if (info.ReadingQuality <= 0.7)
                    readingQualityLabel.ForeColor = Color.DarkRed;
                else
                    readingQualityLabel.ForeColor = Color.Green;
                directionLabel.Text = info.Direction.ToString();
                if (info.Region == null)
                {
                    boundRectnalgeLabel.Text = "N/A";
                    rotationAngleLabel.Text = "N/A";
                }
                else
                {
                    boundRectnalgeLabel.Text = info.Region.Rectangle.ToString();
                    rotationAngleLabel.Text = info.Region.Angle.ToString("F3") + "°";
                }
                thresholdLabel.Text = info.Threshold.ToString();
                info.ShowNonDataFlagsInValue = true;
                bool isGSValue = info is GS1BarcodeInfo;
                barcodeValueAsGS1RadioButton.Enabled = showGS1DecoderButton.Enabled = isGSValue;
                if (!isGSValue && barcodeValueAsGS1RadioButton.Checked)
                {
                    barcodeValueAsGS1RadioButton.Checked = false;
                    barcodeValueAsTextRadioButton.Checked = true;
                }

                ISO15415QualityTestButton.Enabled =
                    info.BarcodeType == BarcodeType.DataMatrix ||
                    info.BarcodeType == BarcodeType.HanXinCode ||
                    info.BarcodeType == BarcodeType.QR ||
                    info.BarcodeType == BarcodeType.MicroQR ||
                    info.BarcodeType == BarcodeType.PDF417 ||
                    info.BarcodeType == BarcodeType.PDF417Compact ||
                    info.BarcodeType == BarcodeType.MicroPDF417 ||
                    info.BarcodeType == BarcodeType.Aztec;

                ISO15416QualityTestButton.Enabled =
                    info.BarcodeType == BarcodeType.EAN13 ||
                    info.BarcodeType == BarcodeType.EAN8 ||
                    info.BarcodeType == BarcodeType.UPCA ||
                    info.BarcodeType == BarcodeType.UPCE ||
                    info.BarcodeType == BarcodeType.Interleaved2of5 ||
                    info.BarcodeType == BarcodeType.Standard2of5 ||
                    info.BarcodeType == BarcodeType.IATA2of5 ||
                    info.BarcodeType == BarcodeType.Matrix2of5 ||
                    info.BarcodeType == BarcodeType.Code11 ||
                    info.BarcodeType == BarcodeType.Code39 ||
                    info.BarcodeType == BarcodeType.Telepen ||
                    info.BarcodeType == BarcodeType.MSI ||
                    info.BarcodeType == BarcodeType.Pharmacode ||
                    info.BarcodeType == BarcodeType.Code93 ||
                    info.BarcodeType == BarcodeType.Codabar ||
                    info.BarcodeType == BarcodeType.Code128 ||
                    info.BarcodeType == BarcodeType.RSS14 ||
                    info.BarcodeType == BarcodeType.RSS14Stacked ||
                    info.BarcodeType == BarcodeType.RSSExpanded ||
                    info.BarcodeType == BarcodeType.RSSLimited ||
                    info.BarcodeType == BarcodeType.RSSExpandedStacked;

                if (info is StructuredAppendBarcodeInfo)
                {
                    ISO15415QualityTestButton.Enabled = false;
                    ISO15416QualityTestButton.Enabled = false;
                    structureAppendLabel.Text = string.Format("Used Structured Append:\n{0} symbol(s)", info.SymbolComponents.Length);
                    structureAppendLabel.Visible = true;
                }
                else if (info.ValueItems != null &&
                    info.ValueItems.Length > 0 &&
                    info.ValueItems[0] is StructuredAppendCharacter)
                {
                    StructuredAppendCharacter saItem = (StructuredAppendCharacter)info.ValueItems[0];
                    structureAppendLabel.Text = string.Format("Used Structured Append:\nsymbol {0} of {1}", saItem.SymbolPosition, saItem.SymbolCount);
                    structureAppendLabel.Visible = true;
                }
                else
                {
                    structureAppendLabel.Visible = false;
                }
            }
            ShowBarcodeValue(info);

            if (info is BarcodeSubsetInfo && !(((BarcodeSubsetInfo)info).BarcodeSubset is CompositeBarcodeSymbologySubset))
                info = ((BarcodeSubsetInfo)info).BaseBarcodeInfo;
            ShowBarcodeExtendedInformation(info);
            ShowBarcodeValueItems(info);
            ShowBarcodeImage(info);
        }

        /// <summary>
        /// Displays a barcode image of specified barcode info.
        /// </summary>
        private void ShowBarcodeImage(IBarcodeInfo info)
        {
            Image lastImage = barcodePictureBox.Image;
            if (info == null || info.Region == null)
            {
                barcodePictureBox.Image = null;
            }
            else
            {
                Rectangle rect = info.Region.Rectangle;
                int p = 1;
                rect.X = Math.Max(0, rect.X - p);
                rect.Y = Math.Max(0, rect.Y - p);
                rect.Width = Math.Min(rect.Width + p * 2, _barcodeImage.Width - rect.X);
                rect.Height = Math.Min(rect.Height + p * 2, _barcodeImage.Height - rect.Y);
                Bitmap barcodeImage = new Bitmap(rect.Width, rect.Height, PixelFormat.Format24bppRgb);
                using (Graphics g = Graphics.FromImage(barcodeImage))
                    g.DrawImage(_barcodeImage, new Rectangle(0, 0, rect.Width, rect.Height), rect, GraphicsUnit.Pixel);
                barcodePictureBox.Image = barcodeImage;
            }
            if (lastImage != null)
                lastImage.Dispose();
        }

        /// <summary>
        /// Displays a barcode value of current barcode info.
        /// </summary>
        private void ShowBarcodeValue()
        {
            readerTextEncodingPanel.Visible = barcodeValueAsTextRadioButton.Checked;
            if (_recognizedBarcodes == null)
                return;
            ShowBarcodeValue(_recognizedBarcodes[_barcodeInfoIndex]);
        }

        /// <summary>
        /// Displays a barcode value of specified barcode info.
        /// </summary>
        private void ShowBarcodeValue(IBarcodeInfo info)
        {
            if (info == null)
            {
                barcodeValueTextBox.Text = "";
                return;
            }

            info.ShowNonDataFlagsInValue = showNonDataFlagsCheckBox.Checked;

            string infoValue;
            if (InterpretEciCharacters && info.ValueItems != null)
                infoValue = EciCharacterDecoder.Decode(info.ValueItems);
            else
                infoValue = info.Value;

            if (barcodeValueAsTextRadioButton.Checked)
            {
                barcodeValueTextBox.WordWrap = true;
                if (info is UnknownLinearBarcodeInfo)
                {
                    StringBuilder value = new StringBuilder();
                    value.AppendLine("Normalized bars:");
                    value.AppendLine(info.Value);
                    value.AppendLine("Normalized[unnormalized]:");
                    double[] barcodeLine = ((UnknownLinearBarcodeInfo)info).BarcodeLine;
                    int[] normalizedBarcodeLine = ((UnknownLinearBarcodeInfo)info).NormalizedBarcodeLine;
                    for (int i = 0; i < barcodeLine.Length; i++)
                        value.Append(string.Format("{0}[{1}] ", normalizedBarcodeLine[i], barcodeLine[i].ToString("F1", CultureInfo.InvariantCulture)));
                    barcodeValueTextBox.Text = value.ToString();
                }
                else if (info is MailmarkCmdmBarcodeInfo)
                {
                    StringBuilder sb = new StringBuilder();

                    sb.Append(string.Format("{0} decoded value: ", ((BarcodeSubsetInfo)info).BarcodeSubset));
                    sb.Append(Environment.NewLine);
                    sb.Append(Environment.NewLine);

                    MailmarkCmdmValueItem mailmarkCmdmValue = ((MailmarkCmdmBarcodeInfo)info).DecodedValue;

                    sb.Append(string.Format("UPU Country ID:            '{0}'", mailmarkCmdmValue.UpuCountryId));
                    sb.Append(Environment.NewLine);
                    sb.Append(string.Format("Information Type ID:       '{0}'", mailmarkCmdmValue.InformationTypeId));
                    sb.Append(Environment.NewLine);
                    sb.Append(string.Format("Version ID:                '{0}'", mailmarkCmdmValue.VersionId));
                    sb.Append(Environment.NewLine);
                    sb.Append(string.Format("Class:                     '{0}'", mailmarkCmdmValue.Class));
                    sb.Append(Environment.NewLine);
                    sb.Append(string.Format("Supply Chain ID:           '{0}'", mailmarkCmdmValue.SupplyChainId));
                    sb.Append(Environment.NewLine);
                    sb.Append(string.Format("Item ID:                   '{0}'", mailmarkCmdmValue.ItemId));
                    sb.Append(Environment.NewLine);
                    sb.Append(string.Format("DPS:                       '{0}'", mailmarkCmdmValue.Dps));
                    sb.Append(Environment.NewLine);
                    sb.Append(string.Format("RTS Flag:                  '{0}'", mailmarkCmdmValue.RtsFlag));
                    sb.Append(Environment.NewLine);
                    sb.Append(string.Format("Return To Sender Post Code:'{0}'", mailmarkCmdmValue.ReturnToSenderPostCode));
                    sb.Append(Environment.NewLine);
                    sb.Append(string.Format("Reserved:                  '{0}'", mailmarkCmdmValue.Reserved));
                    sb.Append(Environment.NewLine);
                    sb.Append(string.Format("Customer Content:          '{0}'", mailmarkCmdmValue.CustomerContent));

                    barcodeValueTextBox.Text = sb.ToString();
                }
                else if (info is GS1BarcodeInfo)
                {
                    StringBuilder sb = new StringBuilder();
                    string subsetName = ((GS1BarcodeInfo)info).BarcodeSubset.Name;

                    sb.Append(string.Format("{0} transmited data: ", subsetName));
                    sb.Append(Environment.NewLine);
                    sb.Append(((GS1BarcodeInfo)info).TransmittedData);
                    sb.Append(Environment.NewLine);

                    sb.Append(Environment.NewLine);

                    sb.Append(string.Format("{0} printable value: ", subsetName));
                    sb.Append(Environment.NewLine);
                    sb.Append(((GS1BarcodeInfo)info).PrintableValue);
                    sb.Append(Environment.NewLine);

                    sb.Append(Environment.NewLine);

                    CompositeBarcodeSymbologySubset compositeSubset = ((BarcodeSubsetInfo)info).BarcodeSubset as CompositeBarcodeSymbologySubset;
                    if (compositeSubset!=null)
                    {
                        foreach (IBarcodeInfo componentInfo in info.SymbolComponents)
                        {
                            sb.Append(string.Format("{0} component value: ", componentInfo.BarcodeType));
                            sb.Append(Environment.NewLine);
                            sb.Append(componentInfo.Value);
                            sb.Append(Environment.NewLine);
                        }
                    }
                    else
                    {
                        sb.Append(string.Format("{0} value: ", ((BarcodeSubsetInfo)info).BaseBarcodeInfo.BarcodeType));
                        sb.Append(Environment.NewLine);
                        sb.Append(((BarcodeSubsetInfo)info).BaseBarcodeInfo.Value);
                        sb.Append(Environment.NewLine);
                    }

                    sb.Append(Environment.NewLine);
                    sb.Append("GS1 decoded value:");
                    sb.Append(Environment.NewLine);
                    foreach (GS1ApplicationIdentifierValue aiv in ((GS1BarcodeInfo)info).ApplicationIdentifierValues)
                    {
                        sb.Append(string.Format("{0}: {1}", aiv.ApplicationIdentifier.DataTitle.PadRight(20), aiv.Value));
                        sb.Append(Environment.NewLine);
                    }

                    barcodeValueTextBox.Text = sb.ToString();
                }
                else if (info is PpnBarcodeInfo)
                {
                    StringBuilder sb = new StringBuilder();

                    PpnBarcodeValue ppnValue = ((PpnBarcodeInfo)info).PpnValue;
                    if (ppnValue.PharmacyProductNumber != null)
                    {
                        sb.AppendFormat("PPN:                 {0}", ppnValue.PharmacyProductNumber);
                        sb.AppendLine();
                    }
                    if (ppnValue.BatchNumber != null)
                    {
                        sb.AppendFormat("Batch:               {0}", ppnValue.BatchNumber);
                        sb.AppendLine();
                    }
                    if (ppnValue.ExpiryDate != null)
                    {
                        sb.AppendFormat("Expiry Date:         {0} (YYMMDD)", ppnValue.ExpiryDate);
                        sb.AppendLine();
                    }
                    if (ppnValue.SerialNumber != null)
                    {
                        sb.AppendFormat("Serial Number:       {0}", ppnValue.SerialNumber);
                        sb.AppendLine();
                    }
                    if (ppnValue.DateOfManufacture != null)
                    {
                        sb.AppendFormat("Date of Manufacture: {0} (YYYMMDD)", ppnValue.DateOfManufacture);
                        sb.AppendLine();
                    }
                    if (ppnValue.GTIN != null)
                    {
                        sb.AppendFormat("GTIN:                {0}", ppnValue.GTIN);
                        sb.AppendLine();
                    }
                    sb.AppendFormat("Is German PPN:       {0}", ppnValue.IsGermanMarketPpn);
                    sb.AppendLine();

                    sb.Append(Environment.NewLine);

                    sb.Append(string.Format("{0} value: ", ((BarcodeSubsetInfo)info).BaseBarcodeInfo.BarcodeType));
                    sb.Append(Environment.NewLine);
                    sb.Append(((BarcodeSubsetInfo)info).BaseBarcodeInfo.Value);
                    barcodeValueTextBox.Text = sb.ToString();
                }
                else if (info is AamvaBarcodeInfo)
                {
                    StringBuilder sb = new StringBuilder();

                    AamvaBarcodeInfo aamvaBarcode = (AamvaBarcodeInfo)info;
                    sb.AppendLine(string.Format("Issuer identification number: {0}", aamvaBarcode.IssuerIdentificationNumber));
                    sb.AppendLine(string.Format("File type: {0}", aamvaBarcode.AamvaValue.Header.FileType));
                    sb.AppendLine(string.Format("AAMVA Version number: {0} ({1})", aamvaBarcode.VersionLevel, (int)aamvaBarcode.VersionLevel));
                    sb.AppendLine(string.Format("Jurisdiction Version number: {0}", aamvaBarcode.JurisdictionVersionNumber));
                    sb.AppendLine();
                    foreach (AamvaSubfile subfile in aamvaBarcode.Subfiles)
                    {
                        sb.AppendLine(string.Format("[{0}] subfile:", subfile.SubfileType));
                        foreach (AamvaDataElement dataElement in subfile.DataElements)
                        {
                            if (dataElement.Identifier.VersionLevel != AamvaVersionLevel.Undefined)
                            {
                                sb.Append(string.Format("  [{0}](v{1}) {2}:", dataElement.Identifier.ID, (int)dataElement.Identifier.VersionLevel, dataElement.Identifier.Description));
                            }
                            else
                            {
                                sb.Append(string.Format("  [{0}]:", dataElement.Identifier.ID));
                            }
                            sb.AppendLine(string.Format(" {0}", dataElement.Value));
                        }
                    }
                    barcodeValueTextBox.Text = sb.ToString();
                }
                else if (info is IsbtBarcodeInfo)
                {
                    StringBuilder sb = new StringBuilder();

                    IsbtDataValue[] value = ((IsbtBarcodeInfo)info).IsbtValue.DataValues;
                    foreach (IsbtDataValue dataValue in value)
                    {
                        sb.AppendLine(string.Format("{0} ({1}): {2}", dataValue.DataStructure.Name, dataValue.DataStructure.Number, dataValue.DataContent));
                    }
                    sb.AppendLine();
                    sb.AppendLine(string.Format("{0} base type value:", ((BarcodeSubsetInfo)info).BaseBarcodeInfo.BarcodeType));
                    sb.AppendLine(((BarcodeSubsetInfo)info).BaseBarcodeInfo.Value);

                    barcodeValueTextBox.Text = sb.ToString();
                }
                else if (info is HibcLicBarcodeInfo)
                {
                    StringBuilder sb = new StringBuilder();

                    HibcLicValueItem value = ((HibcLicBarcodeInfo)info).HibcLicValue;

                    if (value.PrimaryDataStructure != null && value.SecondaryDataStructure != null)
                        sb.AppendLine("Data structure:   Primary + Secondary");
                    else if (value.PrimaryDataStructure != null)
                        sb.AppendLine("Data structure:   Primary");
                    else
                        sb.AppendLine("Data structure:   Secondary");

                    if (value.PrimaryDataStructure != null)
                    {
                        sb.AppendLine(string.Format("LIC:              {0}", value.PrimaryDataStructure.Lic));
                        sb.AppendLine(string.Format("Product ID:       {0}", value.PrimaryDataStructure.Pcn));
                        sb.AppendLine(string.Format("Unit of Measure:  {0}", value.PrimaryDataStructure.UnitOfMeasureID));
                    }

                    if (value.SecondaryDataStructure != null)
                    {
                        if (value.SecondaryDataStructure.ExpiryDateString != null)
                        {
                            sb.AppendLine(string.Format("Expiry date:      {0} ({1}={2})",
                                value.SecondaryDataStructure.ExpiryDate.ToShortDateString(),
                                value.SecondaryDataStructure.ExpiryDateStringFormat,
                                value.SecondaryDataStructure.ExpiryDateString));
                        }
                        if (value.SecondaryDataStructure.LotNumber != null)
                            sb.AppendLine(string.Format("Lot number:       {0}", value.SecondaryDataStructure.LotNumber));
                        if (value.SecondaryDataStructure.SerialNumber != null)
                            sb.AppendLine(string.Format("Serial number:    {0}", value.SecondaryDataStructure.SerialNumber));
                        if (value.PrimaryDataStructure == null)
                            sb.AppendLine(string.Format("Link character:   {0}", value.LinkCharacter));
                    }

                    if (value.AdditionalData != null)
                    {
                        foreach (HibcLicAdditionalDataStructure additionalData in value.AdditionalData)
                        {
                            if (additionalData is HibcLicSerialNumberAdditionalDataStructure)
                                sb.AppendLine(string.Format("Serial number:    {0}", ((HibcLicSerialNumberAdditionalDataStructure)additionalData).SerialNumber));
                            if (additionalData is HibcLicManufactureDateAdditionalDataStructure)
                                sb.AppendLine(string.Format("Manufacture date: {0}", ((HibcLicManufactureDateAdditionalDataStructure)additionalData).ManufactureDate.ToShortDateString()));
                            if (additionalData is HibcLicExpiryDateAdditionalDataStructure)
                                sb.AppendLine(string.Format("Expiry date:      {0}", ((HibcLicExpiryDateAdditionalDataStructure)additionalData).ExpiryDate.ToShortDateString()));
                            if (additionalData is HibcLicQuantityAdditionalDataStructure)
                                sb.AppendLine(string.Format("Quantity:         {0}", ((HibcLicQuantityAdditionalDataStructure)additionalData).Quantity));
                        }
                    }

                    sb.AppendLine(string.Format("Check character:  {0}", value.CheckCharacter));

                    sb.AppendLine();
                    sb.AppendLine(string.Format("{0} base type value:", ((BarcodeSubsetInfo)info).BaseBarcodeInfo.BarcodeType));
                    sb.AppendLine(((BarcodeSubsetInfo)info).BaseBarcodeInfo.Value);

                    barcodeValueTextBox.Text = sb.ToString();
                }
                else if (info is SwissQRCodeBarcodeInfo)
                {
                    StringBuilder sb = new StringBuilder();

                    SwissQRCodeValueItem value = ((SwissQRCodeBarcodeInfo)info).DecodedValue;

                    sb.AppendLine(string.Format("Version:                                           {0}", value.Version));
                    sb.AppendLine(string.Format("CodingType:                                        {0}", value.CodingType));
                    
                    if (!string.IsNullOrEmpty(value.IBAN))
                        sb.AppendLine(string.Format("IBAN:                                              {0}", value.IBAN));

                    if (!string.IsNullOrEmpty(value.CreditorAddressType))
                        sb.AppendLine(string.Format("Creditor address type:                             {0}", value.CreditorAddressType));
                    if (!string.IsNullOrEmpty(value.CreditorName))
                        sb.AppendLine(string.Format("Creditor name:                                     {0}", value.CreditorName));
                    if (!string.IsNullOrEmpty(value.CreditorStreetOrAddressLine1))
                        sb.AppendLine(string.Format("Creditor street or address line 1:                 {0}", value.CreditorStreetOrAddressLine1));
                    if (!string.IsNullOrEmpty(value.CreditorBuildingNumberOrAddressLine2))
                        sb.AppendLine(string.Format("Creditor building number or address line 2:        {0}", value.CreditorBuildingNumberOrAddressLine2));
                    if (!string.IsNullOrEmpty(value.CreditorTown))
                        sb.AppendLine(string.Format("Creditor town:                                     {0}", value.CreditorTown));
                    if (!string.IsNullOrEmpty(value.CreditorCountry))
                        sb.AppendLine(string.Format("Creditor country:                                   {0}", value.CreditorCountry));


                    if (!string.IsNullOrEmpty(value.Amount))
                        sb.AppendLine(string.Format("Amount:                                            {0}", value.Amount));
                    if (!string.IsNullOrEmpty(value.AmountCurrency))
                        sb.AppendLine(string.Format("Amount currency:                                   {0}", value.AmountCurrency));

                    if (!string.IsNullOrEmpty(value.UltimateDebtorAddressType))
                        sb.AppendLine(string.Format("Ultimate debtor address type:                      {0}", value.UltimateDebtorAddressType));
                    if (!string.IsNullOrEmpty(value.UltimateDebtorName))
                        sb.AppendLine(string.Format("Ultimate debtor name:                              {0}", value.UltimateDebtorName));
                    if (!string.IsNullOrEmpty(value.UltimateDebtorStreetOrAddressLine1))
                        sb.AppendLine(string.Format("Ultimate debtor street or address line 1:          {0}", value.UltimateDebtorStreetOrAddressLine1));
                    if (!string.IsNullOrEmpty(value.UltimateDebtorBuildingNumberOrAddressLine2))
                        sb.AppendLine(string.Format("Ultimate debtor building number or address line 2: {0}", value.UltimateDebtorBuildingNumberOrAddressLine2));
                    if (!string.IsNullOrEmpty(value.UltimateDebtorTown))
                        sb.AppendLine(string.Format("Ultimate debtor town:                              {0}", value.UltimateDebtorTown));
                    if (!string.IsNullOrEmpty(value.UltimateDebtorCountry))
                        sb.AppendLine(string.Format("Ultimate debtor country:                            {0}", value.UltimateDebtorCountry));

                    if (!string.IsNullOrEmpty(value.PaymentReferenceType))
                        sb.AppendLine(string.Format("Payment reference type:                            {0}", value.PaymentReferenceType));
                    if (!string.IsNullOrEmpty(value.PaymentReference))
                        sb.AppendLine(string.Format("Payment reference:                                 {0}", value.PaymentReference));

                    if (!string.IsNullOrEmpty(value.UnstructuredMessage))
                        sb.AppendLine(string.Format("Unstructured message:                              {0}", value.UnstructuredMessage));

                    if (!string.IsNullOrEmpty(value.BillInformation))
                        sb.AppendLine(string.Format("Bill information:                                  {0}", value.BillInformation));

                    if (!string.IsNullOrEmpty(value.AlternativeSchemeParameters1))
                        sb.AppendLine(string.Format("Alternative scheme parameters 1:                   {0}", value.AlternativeSchemeParameters1));
                    if (!string.IsNullOrEmpty(value.AlternativeSchemeParameters1))
                        sb.AppendLine(string.Format("Alternative scheme parameters 2:                   {0}", value.AlternativeSchemeParameters2));

                    barcodeValueTextBox.Text = sb.ToString();
                }
                else if (info is BarcodeSubsetInfo)
                {
                    StringBuilder sb = new StringBuilder();

                    sb.Append(string.Format("{0} decoded value: ", ((BarcodeSubsetInfo)info).BarcodeSubset.Name));
                    sb.Append(Environment.NewLine);
                    sb.Append(info.Value);
                    sb.Append(Environment.NewLine);

                    sb.Append(Environment.NewLine);

                    sb.Append(string.Format("{0} base type value: ", ((BarcodeSubsetInfo)info).BaseBarcodeInfo.BarcodeType));
                    sb.Append(Environment.NewLine);
                    sb.Append(((BarcodeSubsetInfo)info).BaseBarcodeInfo.Value);

                    barcodeValueTextBox.Text = sb.ToString();
                }
                else if (info.BarcodeType == BarcodeType.Mailmark4StateC || info.BarcodeType == BarcodeType.Mailmark4StateL)
                {
                    Mailmark4StateValueItem item = (Mailmark4StateValueItem)info.ValueItems[0];

                    StringBuilder sb = new StringBuilder();

                    sb.Append(string.Format("Barcode value:   '{0}'", info.Value));
                    sb.Append(Environment.NewLine);
                    sb.Append(Environment.NewLine);
                    sb.Append("Decoded value:");
                    sb.Append(Environment.NewLine);
                    sb.Append(string.Format("Format:          '{0}'", item.Format));
                    sb.Append(Environment.NewLine);
                    sb.Append(string.Format("Version ID:      '{0}'", item.VersionId));
                    sb.Append(Environment.NewLine);
                    sb.Append(string.Format("Class:           '{0}'", item.Class));
                    sb.Append(Environment.NewLine);
                    sb.Append(string.Format("Supply Chain ID: '{0}'", item.SupplyChainId));
                    sb.Append(Environment.NewLine);
                    sb.Append(string.Format("Item ID:         '{0}'", item.ItemId));
                    sb.Append(Environment.NewLine);
                    sb.Append(string.Format("DPS:             '{0}'", item.Dps));
                    sb.Append(Environment.NewLine);

                    barcodeValueTextBox.Text = sb.ToString();
                }
                else
                {
                    string value = SetEncoding(infoValue);
                    barcodeValueTextBox.Text = RemoveSpecialCharacters(value);
                }
            }
            else if (barcodeValueAsBinaryRadioButton.Checked)
            {
                barcodeValueTextBox.WordWrap = false;
                barcodeValueTextBox.Text = StringToBinary(infoValue, 16);
            }
            else if (barcodeValueAsHexRadioButton.Checked)
            {
                barcodeValueTextBox.WordWrap = false;
                barcodeValueTextBox.Text = StringToHex(infoValue, 16);
            }
            else if (barcodeValueAsGS1RadioButton.Checked)
            {
                barcodeValueTextBox.Text = DecodeGS1BarcodeValue(((GS1BarcodeInfo)info).TransmittedData);
            }

            info.ShowNonDataFlagsInValue = true;
        }

        /// <summary>
        /// Sets current encoding of specified string.
        /// </summary>
        private string SetEncoding(string value)
        {
            if (readerTextEncodingComboBox.SelectedIndex == 0)
                return value;

            EncodingInfo[] encodings = Encoding.GetEncodings();
            Encoding newEncoding = encodings[readerTextEncodingComboBox.SelectedIndex - 1].GetEncoding();

            return SetEncoding(value, newEncoding);
        }


        /// <summary>
        /// Sets encoding of specified string.
        /// </summary>
        private string SetEncoding(string value, Encoding newEncoding)
        {
            bool singleByteEncoding = true;
            for (int i = 0; i < value.Length; i++)
                if ((int)value[i] > 255)
                {
                    singleByteEncoding = false;
                    break;
                }

            byte[] bytes;
            if (singleByteEncoding)
            {
                bytes = new byte[value.Length];
                for (int i = 0; i < value.Length; i++)
                    bytes[i] = (byte)value[i];
            }
            else
            {
                bytes = Encoding.Default.GetBytes(value);
            }

            return newEncoding.GetString(bytes);
        }

        /// <summary>
        /// Returns the barcode value as the GS1 value.
        /// </summary>
        private string GetGS1BarcodeValue(string value)
        {
            try
            {
                GS1ApplicationIdentifierValue[] ai = GS1Codec.Decode(value);
                if (ai == null)
                    return null;
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < ai.Length; i++)
                    sb.Append(ai[i].ToString());
                return sb.ToString();
            }
            catch
            {
                return "GS1 Decoding Error.";
            }
        }

        /// <summary>
        /// Decodes the GS1 barcode value.
        /// </summary>
        private string DecodeGS1BarcodeValue(string value)
        {
            try
            {
                GS1ApplicationIdentifierValue[] ai = GS1Codec.Decode(value);
                StringBuilder sb = new StringBuilder();
                sb.Append("Symbology Format : " + GS1Codec.GetSymbologyFormat(value));
                sb.Append(Environment.NewLine);
                sb.Append("Value            : " + GetGS1BarcodeValue(value));
                return sb.ToString();
            }
            catch
            {
                return "GS1 Decoding Error.";
            }
        }

        /// <summary>
        /// Converts a string to a binary format.
        /// </summary>
        private string StringToBinary(string data, int line)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                if (i % line == 0)
                {
                    if (i != 0)
                    {
                        for (int j = i - line; j < i; j++)
                        {
                            char val = data[j];

                            if (val >= (char)32 && val <= (char)127)
                                sb.Append(val);
                            else
                                sb.Append('?');
                        }
                        sb.AppendLine();
                    }
                    sb.Append(string.Format("0x{0} ", i.ToString("X4")));
                }
                if ((i % line != 0) && (i % (line / 2) == 0))
                    sb.Append("| ");
                int d = 2;
                if ((int)data[i] > 255)
                    d = 4;
                sb.Append(((int)data[i]).ToString("X" + d.ToString()) + " ");
            }
            return sb.ToString();
        }

        /// <summary>
        /// Adds an extended barcode information.
        /// </summary>
        private void AddBarcodeExtendedInformation(string name, object value)
        {
            DataGridViewRow row = new DataGridViewRow();
            row.Cells.Add(new DataGridViewTextBoxCell());
            row.Cells.Add(new DataGridViewTextBoxCell());
            row.Cells[0].Value = name;
            row.Cells[1].Value = value;
            extendedInfoDataGridView.Rows.Add(row);
        }

        /// <summary>
        /// Adds an information about barcode value item.
        /// </summary>
        private void AddBarcodeValueItemInformation(
            int number,
            string itemType,
            string value,
            string hexValue)
        {
            DataGridViewRow row = new DataGridViewRow();
            row.Cells.Add(new DataGridViewTextBoxCell());
            row.Cells.Add(new DataGridViewTextBoxCell());
            row.Cells.Add(new DataGridViewTextBoxCell());
            row.Cells.Add(new DataGridViewTextBoxCell());
            row.Cells[0].Value = number;
            row.Cells[1].Value = itemType;
            row.Cells[2].Value = value;
            row.Cells[3].Value = hexValue;
            valueItemsDataGridView.Rows.Add(row);
        }

        /// <summary>
        /// Displays an extended information of specified barcode info.
        /// </summary>
        private void ShowBarcodeExtendedInformation(IBarcodeInfo info)
        {
            extendedInfoDataGridView.Rows.Clear();
            if (info == null)
                return;
            if (info is BarcodeInfo2D)
            {
                BarcodeInfo2D info2D = (BarcodeInfo2D)info;
                AddBarcodeExtendedInformation("Matrix size", string.Format("{0} x {1}", info2D.MatrixWidth, info2D.MatrixHeight));
                AddBarcodeExtendedInformation("Cell size", string.Format(CultureInfo.InvariantCulture, "{0:f2} x {1:f2}", info2D.CellWidth, info2D.CellHeight));
                AddBarcodeExtendedInformation("Data codewords", info2D.TotalCodewordCount - info2D.ErrorCorrectionCodewordCount);
                AddBarcodeExtendedInformation("Error correction codewords", info2D.ErrorCorrectionCodewordCount);
                AddBarcodeExtendedInformation("Total codewords", info2D.TotalCodewordCount);
                AddBarcodeExtendedInformation("Corrected errors", info2D.CorrectedErrors);
                AddBarcodeExtendedInformation("Barcode image mirrored", info2D.IsMirrored);
            }
            if (info is BarcodeInfo1D)
            {
                BarcodeInfo1D info1D = (BarcodeInfo1D)info;
                AddBarcodeExtendedInformation("Narrow bar count", info1D.NarrowBarCount);
                AddBarcodeExtendedInformation("Narrow bar size", info1D.NarrowBarSize);
            }
            if (info is StructuredAppendBarcodeInfo)
            {
                AddBarcodeExtendedInformation("Symbol component count", info.SymbolComponents.Length);
            }
            else
            {
                switch (info.BarcodeType)
                {
                    case BarcodeType.PDF417:
                    case BarcodeType.PDF417Compact:
                        PDF417Info pdf417Info = (PDF417Info)info;
                        AddBarcodeExtendedInformation("Error correction level", pdf417Info.ErrorCorrectionLevel);
                        AddBarcodeExtendedInformation("Row codewords count", pdf417Info.RowCodewordsCount);
                        AddBarcodeExtendedInformation("Rows count", pdf417Info.RowsCount);
                        AddBarcodeExtendedInformation("GS1 component type", pdf417Info.GS1ComponentType);
                        break;
                    case BarcodeType.MicroPDF417:
                        MicroPDF417Info microPdf417Info = (MicroPDF417Info)info;
                        AddBarcodeExtendedInformation("Symbol type", microPdf417Info.SymbolType);
                        AddBarcodeExtendedInformation("GS1 component type", microPdf417Info.GS1ComponentType);
                        break;
                    case BarcodeType.DataMatrix:
                        DataMatrixInfo dataMatrixInfo = (DataMatrixInfo)info;
                        AddBarcodeExtendedInformation("Symbol ECC type", dataMatrixInfo.Symbol.SymbolECCType);
                        AddBarcodeExtendedInformation("Symbol type", dataMatrixInfo.Symbol.SymbolType);
                        break;
                    case BarcodeType.MicroQR:
                    case BarcodeType.QR:
                        QRInfo qrInfo = (QRInfo)info;
                        AddBarcodeExtendedInformation("Error correction level", qrInfo.ErrorCorrectionLevel);
                        AddBarcodeExtendedInformation("Data mask pattern", qrInfo.DataMaskPattern);
                        if (!qrInfo.Symbol.IsMicroQR)
                            AddBarcodeExtendedInformation("Model", qrInfo.Symbol.Model);
                        AddBarcodeExtendedInformation("Symbol version", qrInfo.Symbol.Version);
                        break;
                    case BarcodeType.Aztec:
                        AztecInfo aztecInfo = (AztecInfo)info;
                        AddBarcodeExtendedInformation("Error correction data (%)", aztecInfo.Symbol.ErrorCorrectionData.ToString("F3"));
                        AddBarcodeExtendedInformation("Symbol type", aztecInfo.Symbol.SymbolType);
                        AddBarcodeExtendedInformation("Data layers", aztecInfo.Symbol.DataLayers);
                        AddBarcodeExtendedInformation("Bulleye center", aztecInfo.BulleyeCenter);
                        break;
                    case BarcodeType.HanXinCode:
                        HanXinCodeInfo hanXinInfo = (HanXinCodeInfo)info;
                        AddBarcodeExtendedInformation("Symbol version", hanXinInfo.Symbol.Version);
                        AddBarcodeExtendedInformation("Error correction level", hanXinInfo.Symbol.ErrorCorrectionLevel);
                        break;
                    case BarcodeType.MaxiCode:
                        MaxiCodeInfo maxiCodeInfo = (MaxiCodeInfo)info;
                        AddBarcodeExtendedInformation("Encoding mode", maxiCodeInfo.EncodingMode);
                        break;
                    case BarcodeType.RSS14:
                    case BarcodeType.RSS14Stacked:
                    case BarcodeType.RSSExpanded:
                    case BarcodeType.RSSExpandedStacked:
                    case BarcodeType.RSSLimited:
                        RSSInfo rssInfo = (RSSInfo)info;
                        AddBarcodeExtendedInformation("Segments count", rssInfo.SegmentsCount);
                        AddBarcodeExtendedInformation("Rows count", rssInfo.RowsCount);
                        AddBarcodeExtendedInformation("Segments in row", rssInfo.SegmentsInRow);
                        AddBarcodeExtendedInformation("Linkage flag", rssInfo.LinkageFlag);
                        break;
                    case BarcodeType.IntelligentMail:
                        IntelligentMailInfo intelligentMailInfo = (IntelligentMailInfo)info;
                        AddBarcodeExtendedInformation("Barcode ID", intelligentMailInfo.BarcodeID);
                        AddBarcodeExtendedInformation("Service Type ID", intelligentMailInfo.ServiceTypeID);
                        AddBarcodeExtendedInformation("Mailer ID", intelligentMailInfo.MailerID);
                        AddBarcodeExtendedInformation("Serial Number", intelligentMailInfo.SerialNumber);
                        if (intelligentMailInfo.RoutingZIPCode != "")
                            AddBarcodeExtendedInformation("Routing ZIP Code", intelligentMailInfo.RoutingZIPCode);
                        break;
                    case BarcodeType.Pharmacode:
                        PharmacodeInfo pharmacodeInfo = (PharmacodeInfo)info;
                        AddBarcodeExtendedInformation("Reverse read value", pharmacodeInfo.ReverseReadValue);
                        break;
                    case BarcodeType.UPCE:
                        UPCEANInfo upcEANInfo = (UPCEANInfo)info;
                        AddBarcodeExtendedInformation("UPCE value", upcEANInfo.UPCEValue);
                        break;
                    case BarcodeType.Codabar:
                        CodabarInfo codabarInfo = (CodabarInfo)info;
                        AddBarcodeExtendedInformation("Start symbol", codabarInfo.StartSymbol);
                        AddBarcodeExtendedInformation("Stop symbol", codabarInfo.StopSymbol);
                        break;
                    case BarcodeType.DotCode:
                        DotCodeInfo dotcodeInfo = (DotCodeInfo)info;
                        AddBarcodeExtendedInformation("Mask", dotcodeInfo.Mask);
                        break;
                }
            }
        }

        /// <summary>
        /// Diplays a barcode value items.
        /// </summary>
        private void ShowBarcodeValueItems(IBarcodeInfo info)
        {
            valueItemsDataGridView.Rows.Clear();
            if (info == null || info.ValueItems == null)
                return;
            ValueItemBase[] items = info.ValueItems;
            if (InterpretEciCharacters)
            {
                items = EciCharacterDecoder.DecodeEciItems(items);
            }
            for (int i = 0; i < items.Length; i++)
            {
                string hexValue = "";
                if (items[i] is BinaryValueItem)
                {
                    hexValue = BytesToHex(((BinaryValueItem)items[i]).Value);
                }
                else if (items[i] is HanXinCodeGB18030TextValueItem)
                {
                    hexValue = BytesToHex(((HanXinCodeGB18030TextValueItem)items[i]).BinaryValue);
                }
                else if (items[i].DataType == ValueItemDataType.NumericData || items[i].DataType == ValueItemDataType.TextData)
                {
                    hexValue = StringToHex(items[i].ToString(), 0);
                }
                AddBarcodeValueItemInformation(i, GetValueItemType(items[i]), GetValueItemValue(items[i]), hexValue);
            }
        }

        /// <summary>
        /// Returns a value of specified barcode value item.
        /// </summary>
        private string GetValueItemValue(ValueItemBase item)
        {
            if (item is AztecStructuredAppendCharacter)
            {
                AztecStructuredAppendCharacter aztecStructureAppend = (AztecStructuredAppendCharacter)item;
                return string.Format("{0} (Symbol {1} of {2}; MessageID=\"{3}\")", item, aztecStructureAppend.SymbolPosition, aztecStructureAppend.SymbolCount, aztecStructureAppend.MessageID);
            }
            if (item is DataMatrixStructuredAppendCharacter)
            {
                DataMatrixStructuredAppendCharacter dmStructureAppend = (DataMatrixStructuredAppendCharacter)item;
                return string.Format("{0} (Symbol {1} of {2}; FileID={3})", item, dmStructureAppend.SymbolPosition, dmStructureAppend.SymbolCount, dmStructureAppend.FileID);
            }
            if (item is QRStructuredAppendCharacter)
            {
                QRStructuredAppendCharacter qrStructureAppend = (QRStructuredAppendCharacter)item;
                return string.Format("{0} (Symbol {1} of {2}; Parity data={3})", item, qrStructureAppend.SymbolPosition, qrStructureAppend.SymbolCount, qrStructureAppend.ParityData);
            }
            if (item is PDF417StructuredAppendCharacter)
            {
                PDF417StructuredAppendCharacter pdfStructureAppend = (PDF417StructuredAppendCharacter)item;
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("{0} (Symbol {1} of {2}; FileID={3}", item, pdfStructureAppend.SymbolPosition, pdfStructureAppend.SymbolCount, pdfStructureAppend.FileID);
                if (pdfStructureAppend.Addressee != null)
                    sb.AppendFormat("; Addresse={0}", pdfStructureAppend.Addressee);
                if (pdfStructureAppend.Checksum >= 0)
                    sb.AppendFormat("; Checksum={0}", pdfStructureAppend.Checksum);
                if (pdfStructureAppend.FileName != null)
                    sb.AppendFormat("; FileName={0}", pdfStructureAppend.FileName);
                if (pdfStructureAppend.FileSize >= 0)
                    sb.AppendFormat("; FileSize={0}", pdfStructureAppend.FileSize);
                if (pdfStructureAppend.Sender != null)
                    sb.AppendFormat("; Sender={0}", pdfStructureAppend.Sender);
                if (pdfStructureAppend.TimeStamp >= 0)
                    sb.AppendFormat("; TimeStamp={0}", pdfStructureAppend.TimeStamp);
                sb.Append(")");
                return sb.ToString();
            }
            return RemoveSpecialCharacters(item.ToString());
        }

        /// <summary>
        /// Returns a type of specified value item.
        /// </summary>
        private string GetValueItemType(ValueItemBase item)
        {
            if (item is EciCharacterValueItem)
                return "ECI character";
            if (item is MacroCharacter)
                return "Macro character";
            if (item is StructuredAppendCharacter)
                return "Structured Append character";
            if (item is DataMatrixTextValueItem)
                return ((DataMatrixTextValueItem)item).Mode.ToString();
            if (item is IQRValueItem)
                return ((IQRValueItem)item).Mode.ToString();
            if (item is Code128ValueItem)
                return ((Code128ValueItem)item).Mode.ToString();
            if (item is HanXinCodeGB18030TextValueItem)
                return ((HanXinCodeGB18030TextValueItem)item).Mode.ToString();
            return item.DataType.ToString();
        }

        /// <summary>
        /// Convers a string to a HEX representation.
        /// </summary>
        private string StringToHex(string value, int row)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < value.Length; i++)
            {
                int ch = (int)value[i];
                int d = 2;
                if ((int)ch > 255)
                    d = 4;
                if (row > 0 && i % row == 0 && i != 0)
                    result.Append(Environment.NewLine);
                result.Append(ch.ToString("X" + d.ToString()));
                result.Append(' ');
            }
            return result.ToString();
        }

        /// <summary>
        /// Convers a byte array to a HEX representation.
        /// </summary>
        private string BytesToHex(byte[] value)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < value.Length; i++)
            {
                result.Append(value[i].ToString("X2"));
                result.Append(' ');
            }
            return result.ToString();
        }

        /// <summary>
        /// Changes the current barcode info index to the specified index.
        /// </summary>
        /// <param name="index"></param>
        private void MoveToBarcode(int index)
        {
            if (_disableShowingValue ||
                _recognizedBarcodes == null ||
                index < 0 ||
                index >= _recognizedBarcodes.Length)
                return;
            _barcodeInfoIndex = index;
            ShowBarcodeInformation(_recognizedBarcodes[_barcodeInfoIndex]);
        }

        /// <summary>
        /// Updates the displaying barcode value.
        /// </summary>
        private void barcodeValueAs_CheckedChanged(object sender, EventArgs e)
        {
            ShowBarcodeValue();
        }

        /// <summary>
        /// Updates the displaying barcode value.
        /// </summary>
        private void readerTextEncodingComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowBarcodeValue();
        }

        /// <summary>
        /// Sets new current barcode info.
        /// </summary>
        private void selectedBarcodeNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            MoveToBarcode((int)selectedBarcodeNumericUpDown.Value - 1);
        }

        /// <summary>
        /// Shows the GS1 barcode value.
        /// </summary>
        private void showGS1DecoderButton_Click(object sender, EventArgs e)
        {
            try
            {
                GS1BarcodeInfo info = (GS1BarcodeInfo)_recognizedBarcodes[_barcodeInfoIndex];
                GS1ValueEditorForm gs1Viewer = new GS1ValueEditorForm(info.ApplicationIdentifierValues, true);
                gs1Viewer.ShowDialog();
                gs1Viewer.Dispose();
            }
            catch
            {
                MessageBox.Show("GS1 decoding error.");
            }
        }

        /// <summary>
        /// Shows the ISO15415 quality test dialog.
        /// </summary>
        private void ISO15415QualityTestButton_Click(object sender, EventArgs e)
        {
            if (_barcodeInfoIndex >= 0)
            {
                try
                {
                    IBarcodeInfo info = _recognizedBarcodes[_barcodeInfoIndex];
                    if (info is BarcodeSubsetInfo)
                        info = ((BarcodeSubsetInfo)info).BaseBarcodeInfo;
                    ISO15415QualityTestForm formQualityTest = new ISO15415QualityTestForm((BarcodeInfo2D)info, _barcodeImage, _invertBarcodeImage);
                    formQualityTest.ShowDialog();
                    formQualityTest.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Format("{0}: {1}", ex.GetType().Name, ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        /// <summary>
        /// Shows the ISO15416 quality test dialog.
        /// </summary>
        private void ISO15416QualityTestButton_Click(object sender, EventArgs e)
        {
            if (_barcodeInfoIndex >= 0)
            {
                try
                {
                    IBarcodeInfo info = _recognizedBarcodes[_barcodeInfoIndex];
                    if (info is BarcodeSubsetInfo)
                        info = ((BarcodeSubsetInfo)info).BaseBarcodeInfo;
                    ISO15416QualityTestForm formQualityTest = new ISO15416QualityTestForm((BarcodeInfo1D)info, _barcodeImage, _invertBarcodeImage);
                    formQualityTest.ShowDialog();
                    formQualityTest.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        #endregion

    }
}
