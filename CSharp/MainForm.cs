using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Collections.Generic;

using Vintasoft.Barcode;
using Vintasoft.Barcode.BarcodeInfo;
using Vintasoft.Barcode.BarcodeStructure;
using Vintasoft.Barcode.SymbologySubsets;
using Vintasoft.Barcode.Gdi;
using Vintasoft.Primitives;
using System.ComponentModel;

namespace BarcodeDemo
{
    /// <summary>
    /// A main form of application.
    /// </summary>
    public partial class MainForm : Form
    {

        #region Fields

        /// <summary>
        /// Title of the application's main form.
        /// </summary>
        string _formTitle;

        /// <summary>
        /// Indicates whether the main form of application is loaded.
        /// </summary>
        bool _isMainFormLoaded = false;


        /// <summary>
        /// Names of files, which are located in current working directory.
        /// </summary>
        string[] _filesList = null;
        /// <summary>
        /// Name of file, which is loaded for barcode recognition.
        /// </summary>
        string _currentFileName = null;
        /// <summary>
        /// Indicates whether the events of filesListTrackBar control are disabled.
        /// </summary>
        bool _disableFilesListEventHandler = false;


        /// <summary>
        /// Form for selection page of multipage image.
        /// </summary>
        SelectImageFrameForm _selectPageFromMultipageImageForm = new SelectImageFrameForm();
        /// <summary>
        /// Form for selection page of PDF document.
        /// </summary>
        SelectPdfPageForm _selectPdfPageForm = new SelectPdfPageForm();

        /// <summary>
        /// Name of the file from which the barcode reader source image is loaded.
        /// </summary>
        string _fileName = null;
        /// <summary>
        /// The source image stream.
        /// </summary>
        Stream _barcodeReaderSourceStream = null;
        /// <summary>
        /// The source image, loaded from file or received from barcode writer,
        /// in which the barcode reader searches the barcodes.
        /// </summary>
        Image _barcodeReaderSourceImage = null;
        /// <summary>
        /// Image (may contain recognition results) in which the barcode reader searches the barcodes.
        /// </summary>
        Image _barcodeReaderImage = null;


        /// <summary>
        /// Barcode reader.
        /// </summary>
        BarcodeReader _barcodeReader = new BarcodeReader();

        /// <summary>
        /// Indicates, whether the barcode recognition must be stopped.
        /// </summary>
        bool _stopReadBarcodes = false;

        /// <summary>
        /// Results of barcode recognition.
        /// </summary>
        IBarcodeInfo[] _barcodeRecognitionResults;

        /// <summary>
        /// Indicates, whether the image contains barcode recognition results.
        /// </summary>
        bool _isBarcodeReaderImageMarked = false;

        /// <summary>
        /// Location of the last mouse position in the picture box of barcode reader.
        /// </summary>
        Point _lastMousePosition;

        /// <summary>
        /// Threshold trackbar, that the user has changed the last.
        /// </summary>
        TrackBar _lastThresholdTrackBar = null;

        /// <summary>
        /// Indicates whether the events of threshold trackbar are disabled.
        /// </summary>
        bool _disableThreshold1ChangeEvent = false;


        /// <summary>
        /// Barcode writer.
        /// </summary>
        BarcodeWriter _barcodeWriter = new BarcodeWriter();

        /// <summary>
        /// Indicates when barcode writing.
        /// </summary>
        bool _barcodeWriting = false;

        /// <summary>
        /// Barcode image width.
        /// </summary>

        float _barcodeImageWidth = 0;
        /// <summary>
        /// Barcode image height.
        /// </summary>
        float _barcodeImageHeigth = 0;

        /// <summary>
        /// Barcode image resolution.
        /// </summary>
        float _barcodeImageResolution = 96;

        /// <summary>
        /// Unit of measure of barcode image size.
        /// </summary>
        UnitOfMeasure _barcodeImageSizeUnits = UnitOfMeasure.Pixels;

        /// <summary>
        /// Barcode renderer (for "design" barcodes).
        /// </summary>
        BarcodeGraphicsRenderer _barcodeRenderer;

        #endregion



        #region Constructors

        /// <summary>
        /// Initializes the <see cref="MainForm"/> class.
        /// </summary>
        static MainForm()
        {
            // register the evaluation license for VintaSoft Barcode .NET SDK
            Vintasoft.Barcode.BarcodeGlobalSettings.Register("REG_USER", "REG_EMAIL", "EXPIRATION_DATE", "REG_CODE");

#if NETCOREAPP
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
#endif

            // initialize Vintasoft.Barcode.Gdi assembly
            Vintasoft.Barcode.GdiAssembly.Init();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            // this code is necessary for evaluation version only
            using (Image image = new Bitmap(32, 32))
                _barcodeReader.ReadBarcodes(image);


            _formTitle = string.Format("VintaSoft 1D/2D Barcode Reader/Writer Demo v{0} ", BarcodeGlobalSettings.ProductVersion);
            // update the application title
            Text = _formTitle;

            _barcodeReader.Progress += new EventHandler<BarcodeReaderProgressEventArgs>(BarcodeReader_RecognizeProgress);

            _barcodeReader.Settings.CollectTestInformation = true;

            readerBarcodeTypes.SettingsChanged += new EventHandler(ReaderBarcodeTypes_SettingsChanged);


            _barcodeWriter.Settings.Barcode = BarcodeType.Code128;
            _barcodeWriter.Settings.Value = "012345";
            _barcodeWriter.Settings.PixelFormat = BarcodeImagePixelFormat.Bgr24;
            _barcodeWriter.Settings.PharmacodeMaxValue = long.MaxValue;
            barcodeWriterSettingsControl1.BarcodeWriterSettings = _barcodeWriter.Settings;
            _barcodeWriter.Settings.Changed += new EventHandler(WriterSettings_Changed);

            advancedReaderSettings.ImageProcessingSettingsChanged += new EventHandler(AdvancedReaderSettings_ImageProcessingSettingsChanged);
        }

        #endregion



        #region Properties

        /// <summary>
        /// Current working directory.
        /// </summary>
        string _currentDirectory = Environment.CurrentDirectory;
        /// <summary>
        /// Gets or set the current working directory.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        internal string CurrentDirectory
        {
            get
            {
                return _currentDirectory;
            }
            set
            {
                _currentDirectory = value;

                // updates the file list
                UpdateFileList();
            }
        }

        #endregion



        #region Methods

        #region 'File' menu

        /// <summary>
        /// Selects and opens an image file.
        /// </summary>
        private void openImageButton_Click(object sender, EventArgs e)
        {
            SelectAndOpenBarcodeReaderImage();
        }

        /// <summary>
        /// Closes the image file.
        /// </summary>
        private void closeImageButton_Click(object sender, EventArgs e)
        {
            CloseBarcodeReaderImage();
        }

        /// <summary>
        /// Exits the application.
        /// </summary>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion


        #region 'Writer' menu

        private void barcodeDesignToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BarcodeStructureBase barcodeStructure = null;
            try
            {
                barcodeStructure = _barcodeWriter.GetBarcodeStructure();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (BarcodeDesignerForm form = new BarcodeDesignerForm())
            {
                form.Barcode = barcodeStructure;
                if (_barcodeRenderer != null)
                    form.BarcodeRenderer = _barcodeRenderer;
                if (form.ShowDialog() == DialogResult.OK)
                {
                    _barcodeRenderer = form.BarcodeRenderer;
                    WriteBarcode();
                }
            }
        }

        private void resetBarcodeDesignToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _barcodeRenderer = null;
            WriteBarcode();
        }

        #endregion


        #region 'Help' menu

        /// <summary>
        /// Shows 'About' dialog.
        /// </summary>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (AboutBoxForm aboutDialog = new AboutBoxForm("vsbarcode-dotnet"))
                aboutDialog.ShowDialog();
        }

        #endregion


        #region Common

        /// <summary>
        /// Handles the ImageProcessingSettingsChanged event of the AdvancedReaderSettings control.
        /// </summary>
        private void AdvancedReaderSettings_ImageProcessingSettingsChanged(object sender, EventArgs e)
        {
            if (showImageProcessingCheckBox.Checked)
                UpdateImageInBarcodeReaderPictureBox();
        }

        /// <summary>
        /// Main form is loaded.
        /// </summary>
        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                // get the path to directory with barcode image samples
                string exampleImagesDir = GetExampleImagesDirectory();
                // if directory exists
                if (exampleImagesDir != null)
                    // make the directory as initial directory for the open file dialog
                    openFileDialog1.InitialDirectory = exampleImagesDir;
            }
            catch (Exception)
            {
            }

            // set the current working directory
            CurrentDirectory = openFileDialog1.InitialDirectory;

            // indicate that form is loaded
            _isMainFormLoaded = true;

            // show group box with restrictions of demo version if demo version is used
            demoVersionRestrictionsGroupBox.Visible = BarcodeGlobalSettings.IsDemoVersion;
        }

        /// <summary>
        /// Returns path to "Images" directory with example barcode images.
        /// </summary>
        /// <returns>Path to "Images" directory with example barcode images.</returns>
        private string GetExampleImagesDirectory()
        {
            string binDir = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().ManifestModule.FullyQualifiedName);
            string exampleImagesDir = Path.Combine(binDir, Path.Combine("..", Path.Combine("..", Path.Combine("..", "Images"))));
            if (Directory.Exists(exampleImagesDir))
                return Path.GetFullPath(exampleImagesDir);

            exampleImagesDir = Path.Combine(binDir, Path.Combine("..", Path.Combine("..", Path.Combine("..", Path.Combine("..", "Images")))));
            if (Directory.Exists(exampleImagesDir))
                return Path.GetFullPath(exampleImagesDir);

            exampleImagesDir = Path.Combine(binDir, Path.Combine("..", Path.Combine("..", Path.Combine("..", Path.Combine("..", Path.Combine("..", "Images"))))));
            if (Directory.Exists(exampleImagesDir))
                return Path.GetFullPath(exampleImagesDir);

            exampleImagesDir = Path.Combine(binDir, Path.Combine("..", Path.Combine("..", Path.Combine("..", Path.Combine("..", Path.Combine("..", Path.Combine("..", "Images")))))));
            if (Directory.Exists(exampleImagesDir))
                return Path.GetFullPath(exampleImagesDir);

            return null;
        }

        /// <summary>
        /// Main form is shown.
        /// </summary>
        private void MainForm_Shown(object sender, EventArgs e)
        {
            // update the application title
            this.Text = "Loading settings...";
            Application.DoEvents();

            _barcodeReader.Settings = DeserializeBarcodeReaderSettings("ReaderSettings.xml");
            _barcodeReader.Settings.Erode = false;
            _barcodeReader.Settings.RecognitionTimeout = 0;

            InitBarcodeReaderSettingsControls(_barcodeReader.Settings);
            InitBarcodeReaderSettingsUI(_barcodeReader.Settings);
            UpdateVisibilityOfDemoVersionRestrictionGroupBox();
            CloseBarcodeReaderImage();

            // process command line of the application
            string[] appArgs = Environment.GetCommandLineArgs();
            if (appArgs.Length > 0)
            {
                if (appArgs.Length == 2)
                {
                    try
                    {
                        OpenBarcodeReaderImageFromFile(appArgs[1]);

                        // set the current working directory as directory where the opened file is located
                        CurrentDirectory = Path.GetDirectoryName(Path.GetFullPath(appArgs[1]));
                    }
                    catch
                    {
                        CloseBarcodeReaderImage();
                    }
                }
            }
        }


        /// <summary>
        /// Key is down in main form.
        /// </summary>
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && tabControl.SelectedTab == readerTabPage)
            {
                ReadBarcodes();
                e.Handled = true;
                return;
            }
            if (readBarcodesButton.Text != "Stop")
            {
                if (e.Control && e.KeyCode == Keys.O && tabControl.SelectedTab == readerTabPage)
                {
                    SelectAndOpenBarcodeReaderImage();
                    return;
                }
                if (e.KeyCode == Keys.PageUp)
                {
                    e.Handled = true;
                    if (filesListTrackBar.Value < filesListTrackBar.Maximum)
                        filesListTrackBar.Value++;
                }
                if (e.KeyCode == Keys.PageDown)
                {
                    e.Handled = true;
                    if (filesListTrackBar.Value > filesListTrackBar.Minimum)
                        filesListTrackBar.Value--;
                }
            }
        }

        /// <summary>
        /// Tab page is changed.
        /// </summary>
        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            readerTools.Visible = (tabControl.SelectedTab != writerTabPage) && (tabControl.SelectedTab != tpResults);
            writerTabPage.Refresh();
        }

        /// <summary>
        /// Main form is closed.
        /// </summary>
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // update the application title
            this.Text = "Save settings...";
            Application.DoEvents();

            InitBarcodeReaderSettings();
            SerializeBarcodeReaderSettings(_barcodeReader.Settings, "ReaderSettings.xml");
        }


        /// <summary>
        /// Determines whether the image is large.
        /// </summary>
        private bool IsLargeImage(Image image)
        {
            if (image == null)
                return false;
            if (IsPaletteImage(image))
                return (image.Width * image.Height) > (3 * 60 * 1024 * 1024);
            return (image.Width * image.Height) > (60 * 1024 * 1024);
        }

        /// <summary>
        /// Determines whether the image is a palette image.
        /// </summary>
        private bool IsPaletteImage(Image image)
        {
            return
                image.PixelFormat == PixelFormat.Format1bppIndexed ||
                image.PixelFormat == PixelFormat.Format4bppIndexed ||
                image.PixelFormat == PixelFormat.Format8bppIndexed ||
                image.PixelFormat == PixelFormat.Indexed;
        }

        #endregion


        #region Barcode reader

        #region Update the barcode reader UI

        /// <summary>
        /// Updates the UI of barcode reader.
        /// </summary>
        private void UpdateBarcodeReaderUI()
        {
            bool isBarcodeReaderImageLoaded = _barcodeReaderImage != null;
            bool isAutomaticRecognitionEnabled = automaticRecognitionCheckBox.Checked;
            bool isThresholdingEnabled = isBarcodeReaderImageLoaded && IsThresholdingEnabled();

            closeToolStripMenuItem.Enabled = isBarcodeReaderImageLoaded;
            readBarcodesButton.Enabled = isBarcodeReaderImageLoaded;

            automaticRecognitionCheckBox.Enabled = isBarcodeReaderImageLoaded;

            thresholdMethodGroupBox.Enabled = isBarcodeReaderImageLoaded && !isAutomaticRecognitionEnabled;
            thresholdGroupBox.Enabled = isBarcodeReaderImageLoaded && !isAutomaticRecognitionEnabled;
            highThresholdGroupBox.Enabled = isBarcodeReaderImageLoaded && !isAutomaticRecognitionEnabled;

            zoomImageCheckBox.Enabled = isBarcodeReaderImageLoaded;
            showImageProcessingCheckBox.Enabled = isBarcodeReaderImageLoaded;

            if (isAutomaticRecognitionEnabled)
                showImageProcessingCheckBox.Checked = false;

            if (isAutomaticRecognitionEnabled)
            {
                thresholdMethodGroupBox.Visible = false;
                thresholdIterationGroupBox.Visible = false;
                thresholdGroupBox.Visible = false;
                highThresholdGroupBox.Visible = false;

                showProgressCheckBox.Visible = true;

                showImageProcessingCheckBox.Enabled = false;
            }
            else
            {
                showImageProcessingCheckBox.Enabled = true;
                thresholdMethodGroupBox.Visible = true;
                thresholdGroupBox.Visible = true;

                if (thresholdMethodAutoRadioButton.Checked)
                {
                    thresholdIterationGroupBox.Visible = false;
                    thresholdGroupBox.Enabled = false;
                    highThresholdGroupBox.Visible = false;

                    showProgressCheckBox.Visible = false;
                }
                else if (thresholdMethodManualRadioButton.Checked)
                {
                    thresholdIterationGroupBox.Visible = false;
                    thresholdGroupBox.Enabled = isThresholdingEnabled;
                    UpdateThresholdMinValue();
                    highThresholdGroupBox.Visible = false;

                    showProgressCheckBox.Visible = false;
                }
                else if (thresholdMethodIterationRadioButton.Checked)
                {
                    thresholdIterationGroupBox.Visible = true;
                    thresholdGroupBox.Enabled = isThresholdingEnabled;
                    UpdateThresholdMinValue();
                    highThresholdGroupBox.Visible = true;
                    highThresholdGroupBox.Enabled = isThresholdingEnabled;
                    UpdateThresholdMaxValue();

                    showProgressCheckBox.Visible = true;
                }
            }

            expectedBarcodesSlaveEditor.Visible = isBarcodeReaderImageLoaded && isAutomaticRecognitionEnabled;
            scanIntervalSlaveEditor.Visible = isBarcodeReaderImageLoaded && isAutomaticRecognitionEnabled;
        }

        #endregion


        #region Image files in current working directory

        /// <summary>
        /// Updates the list of files, which are located in current directory.
        /// </summary>
        private void UpdateFileList()
        {
            // if current working directory is not specified or does not exist
            if (CurrentDirectory == "" || !Directory.Exists(CurrentDirectory))
            {
                fileListGroupBox.Visible = false;
                return;
            }

            fileListGroupBox.Visible = true;

            // get the list of files, which are located in current working directory
            _filesList = FindFiles.Find(CurrentDirectory, FindFiles.GRAPHIC_FILES);

            // disable events of filesListTrackBar
            _disableFilesListEventHandler = true;
            filesListTrackBar.Maximum = _filesList.Length;
            if (_currentFileName != null)
            {
                int i = Array.IndexOf(_filesList, _currentFileName);
                if (i >= 0)
                    filesListTrackBar.Value = i + 1;
            }
            else
            {
                filesListTrackBar.Value = Math.Min(1, _filesList.Length);
            }
            // enable events of filesListTrackBar
            _disableFilesListEventHandler = false;

            UpdateFileListGroupBoxText();
        }

        /// <summary>
        /// Updates the text of fileListGroupBox.
        /// </summary>
        private void UpdateFileListGroupBoxText()
        {
            if (_currentFileName == null)
                fileListGroupBox.Text = string.Format("{0} files", filesListTrackBar.Maximum);
            else
                fileListGroupBox.Text = string.Format("File {0} of {1}", filesListTrackBar.Value, filesListTrackBar.Maximum);
        }

        /// <summary>
        /// Value of filesListTrackBar control is changed.
        /// </summary>
        private void filesListTrackBar_ValueChanged(object sender, EventArgs e)
        {
            // if events of filesListTrackBar control are not disabled
            if (!_disableFilesListEventHandler)
            {
                if (filesListTrackBar.Maximum > 0)
                {
                    // open the image file, which is selected using the trackbar
                    OpenBarcodeReaderImageFromFile(_filesList[filesListTrackBar.Value - 1]);
                }
            }

            UpdateFileListGroupBoxText();
        }

        #endregion


        #region Load/close the barcode reader image (image where barcodes must be searched)

        /// <summary>
        /// Selects an image file and opens it.
        /// </summary>
        private void SelectAndOpenBarcodeReaderImage()
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                OpenBarcodeReaderImageFromFile(openFileDialog1.FileName);

                // set the current working directory as directory where the opened file is located
                CurrentDirectory = Path.GetDirectoryName(openFileDialog1.FileName);
            }
        }

        /// <summary>
        /// Opens an image file and loads an image from file.
        /// </summary>
        private void OpenBarcodeReaderImageFromFile(string fileName)
        {
            if (_barcodeReaderImage != null)
                CloseBarcodeReaderImage();

            _fileName = fileName;
            try
            {
                // check that file is not used by another process
                using (Stream tempStream = File.OpenRead(_fileName))
                {
                }

                // if file has ".pdf" extension
                if (Path.GetExtension(_fileName).ToUpper() == ".PDF")
                {
                    if (BarcodeGlobalSettings.IsDemoVersion)
                        MessageBox.Show("Evaluation version allows to extract images only from the first page of PDF document.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    // load image from PDF document
                    _barcodeReaderImage = _selectPdfPageForm.SelectImage(_fileName);
                }
                else
                {
                    // load image from image file
                    _barcodeReaderSourceStream = File.OpenRead(_fileName);
                    _barcodeReaderImage = Image.FromStream(_barcodeReaderSourceStream);
                }
                // if image is not loaded
                if (_barcodeReaderImage == null)
                    return;

                // enable image processing for not big images
                showImageProcessingCheckBox.Visible = !IsLargeImage(_barcodeReaderImage);
                // specify that image is loaded from file
                _barcodeReaderSourceImage = _barcodeReaderImage;
            }
            catch (IOException e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (Exception)
            {
                MessageBox.Show(string.Format("Image '{0}' has unsupported format.", System.IO.Path.GetFileName(_fileName)), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // save the filename of opened file
            _currentFileName = fileName.ToLower();

            // update the application title
            this.Text = string.Format("{0} - {1}", _formTitle, System.IO.Path.GetFileName(_fileName));

            // 
            OpenBarcodeReaderImage(_barcodeReaderImage);
        }

        /// <summary>
        /// Opens the barcode reader images.
        /// </summary>
        private void OpenBarcodeReaderImage(Image image)
        {
            _barcodeReaderImage = image;
            _selectPageFromMultipageImageForm.SelectFrame(_barcodeReaderImage);

            tabControl.SelectedTab = readerTabPage;
            readerTabPage.Text = "Reader [source]";

            barcodeReaderPictureBox.Image = _barcodeReaderImage;

            if (!IsThresholdingEnabled())
            {
                outputTextRichTextBox.Text = "Threshold option is disabled because image is black-white.";
            }
            else
            {
                outputTextRichTextBox.Text = "";
            }

            ClearBarcodeRecognitionResults();
            barcodeReaderResultsControl1.BarcodeImage = image;

            UpdateBarcodeReaderUI();
        }

        /// <summary>
        /// Closes the barcode reader image.
        /// </summary>
        private void CloseBarcodeReaderImage()
        {
            ClearBarcodeRecognitionResults();
            barcodeReaderResultsControl1.BarcodeImage = null;

            barcodeReaderPictureBox.Image = null;

            if (_barcodeReaderImage != null && _barcodeReaderSourceImage != writerPictureBox.Image)
            {
                if (_barcodeReaderSourceImage != _barcodeReaderImage)
                {
                    _barcodeReaderSourceImage.Dispose();
                    _barcodeReaderSourceImage = null;
                    _barcodeReaderSourceStream.Dispose();
                    _barcodeReaderSourceStream = null;
                }
                _barcodeReaderImage.Dispose();
                _barcodeReaderImage = null;
            }

            _barcodeReaderImage = null;
            GC.Collect();

            outputTextRichTextBox.Clear();
            currentBarcodeInfo.Text = "(0,0)";

            this.Text = _formTitle;
            readerTabPage.Text = "Reader [no image]";

            UpdateBarcodeReaderUI();
        }

        #endregion


        #region PictureBox of barcode reader

        /// <summary>
        /// Updates an image in picture box of barcode reader.
        /// </summary>
        private void UpdateImageInBarcodeReaderPictureBox()
        {
            if (_barcodeReaderImage == null)
                return;

            Bitmap tempBitmap;
            Bitmap bitmap = (Bitmap)_barcodeReaderImage;
            if (showImageProcessingCheckBox.Checked && !IsLargeImage(_barcodeReaderImage))
            {
                tempBitmap = bitmap;

                if (thresholdMethodIterationRadioButton.Checked && _lastThresholdTrackBar != null)
                {
                    _barcodeReader.Settings.Threshold = _lastThresholdTrackBar.Value;
                }
                else if (thresholdMethodManualRadioButton.Checked)
                {
                    _barcodeReader.Settings.Threshold = thresholdMinTrackBar.Value;
                }

                bitmap = (Bitmap)_barcodeReader.ProcessImage(bitmap);

                if (tempBitmap != _barcodeReaderImage)
                    tempBitmap.Dispose();

                if (thresholdMethodAutoRadioButton.Checked)
                {
                    _disableThreshold1ChangeEvent = true;
                    thresholdMinTrackBar.Value = _barcodeReader.Settings.Threshold;
                    _disableThreshold1ChangeEvent = false;
                }
            }

            if (bitmap != barcodeReaderPictureBox.Image)
            {
                tempBitmap = (Bitmap)barcodeReaderPictureBox.Image;
                barcodeReaderPictureBox.Image = bitmap;
                if (tempBitmap != _barcodeReaderImage)
                    tempBitmap.Dispose();
            }
            UpdateImageText();
        }

        /// <summary>
        /// Zooming of the barcode reader image is enabled/disabled.
        /// </summary>
        private void zoomReaderImage_CheckedChanged(object sender, EventArgs e)
        {
            if (zoomImageCheckBox.Checked)
            {
                Image bitmap = barcodeReaderPictureBox.Image;
                barcodeReaderPictureBox.Image = null;
                UpdateBarcodeReaderPictureBoxSize();
                barcodeReaderPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                barcodeReaderPictureBox.Image = bitmap;
                currentBarcodeInfo.Text = "";
            }
            else
            {
                barcodeReaderPictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            }
        }

        /// <summary>
        /// Updates size of PictureBox.
        /// </summary>
        private void UpdateBarcodeReaderPictureBoxSize()
        {
            barcodeReaderPictureBox.Size = new Size(splitContainer1.Panel1.ClientSize.Width - 3, splitContainer1.Panel1.ClientSize.Height - panel9.Height - 3);
        }

        /// <summary>
        /// Form is resized.
        /// </summary>
        private void MainForm_Resize(object sender, EventArgs e)
        {
            // if image must be zoomed in PictureBox
            if (zoomImageCheckBox.Checked)
            {
                // update size of PictureBox
                UpdateBarcodeReaderPictureBoxSize();
            }
        }

        /// <summary>
        /// Mouse is clicked on PictureBox.
        /// </summary>
        private void barcodeReaderPictureBox_Click(object sender, EventArgs e)
        {
            // try to find barcode in cursor position
            int index = FindInfoIndex(_lastMousePosition);
            // if barcode was found
            if (index >= 0)
            {
                barcodeReaderResultsControl1.BarcodeInfoIndex = index;
                tabControl.SelectedTab = tpResults;
            }
        }

        /// <summary>
        /// Mouse is moved over the PictureBox.
        /// </summary>
        private void barcodeReaderPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (_barcodeReaderImage == null)
                return;

            // convert cursor position to image space
            _lastMousePosition = ConvertPointToImageSpace(e.Location);
            // add cursor position to status strip
            string s = string.Format("({0},{1})   ", _lastMousePosition.X, _lastMousePosition.Y);
            // try to find barcode in cursor position
            int index = FindInfoIndex(_lastMousePosition);

            // if barcode was found
            if (index >= 0)
            {
                // add barcode data to status strip
                string barcodeType = _barcodeRecognitionResults[index].BarcodeType.ToString();
                if (_barcodeRecognitionResults[index] is BarcodeSubsetInfo)
                    barcodeType = ((BarcodeSubsetInfo)_barcodeRecognitionResults[index]).BarcodeSubset.Name;
                s += string.Format("[{0}:{1}] {2}", index + 1, barcodeType, _barcodeRecognitionResults[index].Value);
            }
            if (currentBarcodeInfo.Text != s)
                currentBarcodeInfo.Text = s;
        }

        /// <summary>
        /// Converts point from image viewer space to the image space.
        /// </summary>
        /// <param name="pointInViewerSpace">Point in image viewer space.</param>
        /// <returns>Point in image space.</returns>
        private Point ConvertPointToImageSpace(Point pointInViewerSpace)
        {
            Size viewerSize = barcodeReaderPictureBox.Size;
            Size imageSize = barcodeReaderPictureBox.Image.Size;

            if (viewerSize == imageSize)
                return pointInViewerSpace;

            int mouseX;
            int mouseY;
            // get side scaling
            float scaleX = (float)viewerSize.Width / imageSize.Width;
            float scaleY = (float)viewerSize.Height / imageSize.Height;
            // if image height is scaled proportionally to the viewer height
            if (scaleY < scaleX)
            {
                // convert Y to image space
                mouseY = imageSize.Height * pointInViewerSpace.Y / viewerSize.Height;
                // find left image border in viewer space
                int imageX = (int)((viewerSize.Width - imageSize.Width * scaleY) / 2f);
                // convert cursor position X to image space
                mouseX = (int)((pointInViewerSpace.X - imageX) / scaleY);
            }
            // if image width is scaled proportionally to the viewer width
            else if (scaleY > scaleX)
            {
                // convert X to image space
                mouseX = imageSize.Width * pointInViewerSpace.X / viewerSize.Width;
                // find top image border in viewer space
                int imageY = (int)((viewerSize.Height - imageSize.Height * scaleX) / 2f);
                // convert cursor position Y to image space
                mouseY = (int)((pointInViewerSpace.Y - imageY) / scaleX);
            }
            else
            {
                // convert X to image space
                mouseX = imageSize.Width * pointInViewerSpace.X / viewerSize.Width;
                // convert Y to image space
                mouseY = imageSize.Height * pointInViewerSpace.Y / viewerSize.Height;
            }

            return new Point(mouseX, mouseY);
        }

        /// <summary>
        /// Finds barcode located in specified position.
        /// </summary>
        /// <param name="mousePosition">Mouse position.</param>
        /// <returns>The index of barcode located in specified position.</returns>
        private int FindInfoIndex(Point mousePosition)
        {
            // if there is no recognized barcodes
            if (_barcodeRecognitionResults == null || _barcodeRecognitionResults.Length == 0)
                return -1;

            // for each recognized barcode
            for (int i = 0; i < _barcodeRecognitionResults.Length; i++)
            {
                // if recognized barcode has region
                if (_barcodeRecognitionResults[i].Region != null)
                {
                    // if point is located in region
                    if (_barcodeRecognitionResults[i].Region.IsPointInRegion(GdiConverter.Convert(mousePosition)))
                        return i;
                }
            }

            return -1;
        }

        /// <summary>
        /// Updates information about the barcode reader image.
        /// </summary>
        private void UpdateImageText()
        {
            string readerTabPageText;
            if (showImageProcessingCheckBox.Checked)
            {
                readerTabPageText = String.Format("Reader [threshold {0}]", _barcodeReader.Settings.Threshold);
            }
            else
            {
                readerTabPageText = "Reader [source]";
            }
            if (readerTabPage.Text != readerTabPageText)
                readerTabPage.Text = readerTabPageText;
        }

        #endregion


        #region Process the barcode reader image

        /// <summary>
        /// Enables/disables preview of the image processing for image with barcodes.
        /// </summary>
        private void showImageProcessing_CheckedChanged(object sender, EventArgs e)
        {
            UpdateImageInBarcodeReaderPictureBox();
        }

        /// <summary>
        /// Enables/disables eroding of image with barcodes.
        /// </summary>
        private void readerErode_CheckedChanged(object sender, EventArgs e)
        {
            if (!_isMainFormLoaded)
                return;


            UpdateBarcodeReaderUI();

            if (showImageProcessingCheckBox.Checked)
                UpdateImageInBarcodeReaderPictureBox();
        }

        #endregion


        #region Barcode reader settings

        /// <summary>
        /// Initializes the barcode reader settings UI from the barcode reader settings.
        /// </summary>
        private void InitBarcodeReaderSettingsUI(ReaderSettings settings)
        {
            thresholdIterationsTrackBar.Maximum = 75;
            if (settings.ThresholdIterations > 1)
                thresholdIterationsTrackBar.Value = settings.ThresholdIterations;
            else
                thresholdIterationsTrackBar.Value = 8;
            thresholdMinTrackBar.Value = settings.Threshold;
            thresholdMaxTrackBar.Value = settings.ThresholdMax;

            switch (settings.ThresholdMode)
            {
                case ThresholdMode.Automatic:
                    thresholdMethodAutoRadioButton.Checked = true;
                    break;

                case ThresholdMode.Iterations:
                    thresholdMethodIterationRadioButton.Checked = true;
                    break;

                case ThresholdMode.Manual:
                    thresholdMethodManualRadioButton.Checked = true;
                    break;
            }

            automaticRecognitionCheckBox.Checked = settings.AutomaticRecognition;

            readerBarcodeTypes.UpdateUI();
            advancedReaderSettings.UpdateUI();

            UpdateBarcodeReaderUI();
        }

        /// <summary>
        /// Initializes the barcode reader settings controls.
        /// </summary>
        private void InitBarcodeReaderSettingsControls(ReaderSettings settings)
        {
            readerBarcodeTypes.SetBarcodeReaderSettings(settings);
            advancedReaderSettings.SetBarcodeReaderSettings(settings);
            minConfidenceEditor.SetBarcodeReaderSettings(settings);
            maxThreadCountEditor.SetBarcodeReaderSettings(settings);
            scanDirectionEditor.SetBarcodeReaderSettings(settings);
            expectedBarcodesEditor.SetBarcodeReaderSettings(settings);
            scanIntervalEditor.SetBarcodeReaderSettings(settings);
        }

        /// <summary>
        /// Initializes the barcode reader settings from UI.
        /// </summary>
        private void InitBarcodeReaderSettings()
        {
            _barcodeReader.Settings.AutomaticRecognition = automaticRecognitionCheckBox.Checked;

            _barcodeReader.Settings.Threshold = thresholdMinTrackBar.Value;
            if (thresholdMethodIterationRadioButton.Checked)
            {
                // threshold interations method ON
                _barcodeReader.Settings.ThresholdMode = ThresholdMode.Iterations;
                _barcodeReader.Settings.ThresholdIterations = thresholdIterationsTrackBar.Value;
                _barcodeReader.Settings.ThresholdMin = thresholdMinTrackBar.Value;
                _barcodeReader.Settings.ThresholdMax = thresholdMaxTrackBar.Value;
            }
            else
            {
                if (thresholdMethodAutoRadioButton.Checked)
                    _barcodeReader.Settings.ThresholdMode = ThresholdMode.Automatic;
                else
                    _barcodeReader.Settings.ThresholdMode = ThresholdMode.Manual;
            }
        }

        /// <summary>
        /// Returns the default reader settings.
        /// </summary>
        private ReaderSettings GetDefaultReaderSettings()
        {
            ReaderSettings settings = new ReaderSettings();
            settings.AutomaticRecognition = true;
            settings.ScanBarcodeTypes = BarcodeType.QR | BarcodeType.Code39 | BarcodeType.Code128 | BarcodeType.EAN13 | BarcodeType.UPCA;
            settings.ScanDirection = ScanDirection.LeftToRight | ScanDirection.RightToLeft | ScanDirection.BottomToTop | ScanDirection.TopToBottom;
            settings.ThresholdIterations = 8;
            settings.ThresholdMode = ThresholdMode.Automatic;
            settings.MinConfidence = 95;
            settings.SearchQRModel1Barcodes = true;
            int processorCount = Environment.ProcessorCount;
            settings.MaximumThreadCount = processorCount + processorCount / 2;
            settings.CollectTestInformation = true;
            settings.PharmacodeMaxValue = long.MaxValue;
            return settings;
        }

        /// <summary>
        /// Enables/disables the automatic barcode recognition.
        /// </summary>
        private void automaticRecognitionCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _barcodeReader.Settings.AutomaticRecognition = automaticRecognitionCheckBox.Checked;

            UpdateBarcodeReaderUI();
        }


        #region Threshold settings

        /// <summary>
        /// Automatic threshold method is selected.
        /// </summary>
        private void thresholdMethodAutoRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (!_isMainFormLoaded)
                return;

            _barcodeReader.Settings.ThresholdMode = ThresholdMode.Automatic;

            UpdateBarcodeReaderUI();
        }

        /// <summary>
        /// Manual threshold method is selected.
        /// </summary>
        private void thresholdMethodManualRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (!_isMainFormLoaded)
                return;

            _barcodeReader.Settings.ThresholdMode = ThresholdMode.Manual;

            UpdateBarcodeReaderUI();
        }

        /// <summary>
        /// Iteration threshold method is selected.
        /// </summary>
        private void thresholdMethodIterationRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (!_isMainFormLoaded)
                return;

            _barcodeReader.Settings.ThresholdMode = ThresholdMode.Iterations;

            thresholdMinTrackBar.Value = 250;
            thresholdMaxTrackBar.Value = 500;

            UpdateBarcodeReaderUI();
        }


        /// <summary>
        /// Iteration count in the iteration threshold method is changed.
        /// </summary>
        private void thresholdIterationsTrackBar_ValueChanged(object sender, EventArgs e)
        {
            thresholdIterationGroupBox.Text = string.Format("Iteration count - {0}", thresholdIterationsTrackBar.Value);
        }

        /// <summary>
        /// Value of (low) threshold is changed.
        /// </summary>
        private void thresholdMinTrackBar_ValueChanged(object sender, EventArgs e)
        {
            UpdateThresholdMinValue();
        }

        /// <summary>
        /// Value of high threshold is changed.
        /// </summary>
        private void thresholdMaxTrackBar_ValueChanged(object sender, EventArgs e)
        {
            UpdateThresholdMaxValue();
        }

        /// <summary>
        /// Determines that thresholding is enabled.
        /// </summary>
        private bool IsThresholdingEnabled()
        {
            bool isColorImage = _barcodeReaderImage.PixelFormat != System.Drawing.Imaging.PixelFormat.Format1bppIndexed;
            return
                isColorImage ||
                automaticRecognitionCheckBox.Checked ||
                _barcodeReader.Settings.Erode ||
                _barcodeReader.Settings.ImageScaleFactor != 1f;
        }

        /// <summary>
        /// Updates the (low) threshold value.
        /// </summary>
        private void UpdateThresholdMinValue()
        {
            string thresholdFormatString;
            if (thresholdMethodIterationRadioButton.Checked)
                thresholdFormatString = "Low threshold - {0}";
            else
                thresholdFormatString = "Threshold - {0}";
            thresholdGroupBox.Text = string.Format(thresholdFormatString, thresholdMinTrackBar.Value);

            if (thresholdMethodManualRadioButton.Checked)
            {
                _barcodeReader.Settings.Threshold = thresholdMinTrackBar.Value;
            }
            else
            {
                _barcodeReader.Settings.ThresholdMin = thresholdMinTrackBar.Value;
            }

            _lastThresholdTrackBar = thresholdMinTrackBar;

            if (showImageProcessingCheckBox.Checked && !_disableThreshold1ChangeEvent)
                UpdateImageInBarcodeReaderPictureBox();
        }

        /// <summary>
        /// Updates the high threshold value.
        /// </summary>
        private void UpdateThresholdMaxValue()
        {
            highThresholdGroupBox.Text = string.Format("High threshold - {0}", thresholdMaxTrackBar.Value);

            _barcodeReader.Settings.ThresholdMax = thresholdMaxTrackBar.Value;

            _lastThresholdTrackBar = thresholdMaxTrackBar;

            if (showImageProcessingCheckBox.Checked)
                UpdateImageInBarcodeReaderPictureBox();
        }

        #endregion


        /// <summary>
        /// Barcode types for barcode recognition are changed.
        /// </summary>
        private void ReaderBarcodeTypes_SettingsChanged(object sender, EventArgs e)
        {
            UpdateVisibilityOfDemoVersionRestrictionGroupBox();
        }

        /// <summary>
        /// Updates visibility of demo version restriction group box.
        /// </summary>
        private void UpdateVisibilityOfDemoVersionRestrictionGroupBox()
        {
            BarcodeType barcodeTypes = _barcodeReader.Settings.ScanBarcodeTypes;
            foreach (BarcodeSymbologySubset subset in _barcodeReader.Settings.ScanBarcodeSubsets)
                barcodeTypes |= subset.BarcodeType;
            bool visible =
                (barcodeTypes & BarcodeType.QR) != 0 ||
                (barcodeTypes & BarcodeType.RSS14) != 0 ||
                (barcodeTypes & BarcodeType.RSS14Stacked) != 0 ||
                (barcodeTypes & BarcodeType.RSSExpanded) != 0 ||
                (barcodeTypes & BarcodeType.RSSExpandedStacked) != 0 ||
                (barcodeTypes & BarcodeType.RSSLimited) != 0 ||
                (barcodeTypes & BarcodeType.IntelligentMail) != 0;
            demoVersionRestrictionsGroupBox.Visible = visible;
        }


        /// <summary>
        /// Resets the barcode reader settings.
        /// </summary>
        private void ResetSettingsButton_Click(object sender, EventArgs e)
        {
            _barcodeReader.Settings = GetDefaultReaderSettings();

            InitBarcodeReaderSettingsControls(_barcodeReader.Settings);
            InitBarcodeReaderSettingsUI(_barcodeReader.Settings);
            UpdateVisibilityOfDemoVersionRestrictionGroupBox();
        }


        /// <summary>
        /// Serializes the barcode reader settings.
        /// </summary>
        private void SerializeBarcodeReaderSettings(ReaderSettings settings, string filename)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(ReaderSettings));
                using (FileStream stream = new FileStream(filename, FileMode.Create, FileAccess.Write))
                    serializer.Serialize(stream, settings);
            }
            catch
            {
            }
        }

        /// <summary>
        /// Deserializes the barcode reader settings from file.
        /// </summary>
        private ReaderSettings DeserializeBarcodeReaderSettings(string filename)
        {
            if (File.Exists(filename))
            {
                try
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(ReaderSettings));
                    using (FileStream stream = new FileStream(filename, FileMode.Open, FileAccess.Read))
                        return (ReaderSettings)serializer.Deserialize(stream);
                }
                catch
                {
                    return GetDefaultReaderSettings();
                }
            }
            else
            {
                return GetDefaultReaderSettings();
            }
        }

        #endregion


        #region Read barcodes

        /// <summary>
        /// Recognizes the barcodes in image.
        /// </summary>
        private void readBarcodesButton_Click(object sender, EventArgs e)
        {
            ReadBarcodes();
        }

        /// <summary>
        /// Enables/disables the displaying of barcode recognition progress.
        /// </summary>
        private void showProgressCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showProgressCheckBox.Checked)
                _barcodeReader.Progress += new EventHandler<BarcodeReaderProgressEventArgs>(BarcodeReader_RecognizeProgress);
            else
                _barcodeReader.Progress -= new EventHandler<BarcodeReaderProgressEventArgs>(BarcodeReader_RecognizeProgress);
        }


        /// <summary>
        /// Progress of barcode recognition is changed.
        /// </summary>
        private void BarcodeReader_RecognizeProgress(object sender, BarcodeReaderProgressEventArgs e)
        {
            progressGroupBox.Text = string.Format("{0}%; {1} barcodes found", e.Progress, e.FoundBarcodes.Count);
            progressBar.Value = e.Progress;
            if (e.Progress == 100)
            {
                progressGroupBox.Visible = false;
                fileListGroupBox.Visible = true;
                fileListGroupBox.Refresh();
                readBarcodesButton.Text = "Read barcodes";
                readBarcodesButton.Refresh();
            }
            else
            {
                readBarcodesButton.Text = "Stop";
                fileListGroupBox.Visible = false;
                progressGroupBox.Visible = true;

                if (e.Progress > 0)
                    Application.DoEvents();

                if (_stopReadBarcodes)
                    e.Cancel = true;
            }
        }

        /// <summary>
        /// Reads barcodes from image.
        /// </summary>
        private void ReadBarcodes()
        {
            if (readBarcodesButton.Text == "Stop")
            {
                _stopReadBarcodes = true;
                return;
            }

            if (_barcodeReaderImage == null)
                return;

            // change tab
            if (tabControl.SelectedTab != readerTabPage)
            {
                tabControl.SelectedTab = readerTabPage;
            }

            Bitmap tempBitmap = (Bitmap)barcodeReaderPictureBox.Image;
            if (barcodeReaderPictureBox.Image != _barcodeReaderImage)
                barcodeReaderPictureBox.Image = _barcodeReaderImage;
            if (tempBitmap != _barcodeReaderImage)
            {
                tempBitmap.Dispose();
                tempBitmap = null;
            }

            InitBarcodeReaderSettings();

            outputTextRichTextBox.Text = "Recognition...";
            outputTextRichTextBox.Refresh();

            if (_isBarcodeReaderImageMarked)
            {
                _barcodeReaderImage.Dispose();
                OpenBarcodeReaderImageFromFile(_fileName);
                _isBarcodeReaderImageMarked = false;
            }

            _stopReadBarcodes = false;

            try
            {
                barcodeReaderPictureBox.Enabled = false;

                _barcodeRecognitionResults = _barcodeReader.ReadBarcodes(_barcodeReaderImage);

                StructuredAppendBarcodeInfo[] reconstructedBarcodes = StructuredAppendBarcodeInfo.ReconstructFrom(_barcodeRecognitionResults);
                if (reconstructedBarcodes.Length > 0)
                {
                    List<IBarcodeInfo> infos = new List<IBarcodeInfo>(_barcodeRecognitionResults);
                    infos.AddRange(reconstructedBarcodes);
                    _barcodeRecognitionResults = infos.ToArray();
                }

                barcodeReaderResultsControl1.InterpretEciCharacters = advancedReaderSettings.InterpretEciCharacters;
                barcodeReaderResultsControl1.RecognizedBarcodes = _barcodeRecognitionResults;
                barcodeReaderResultsControl1.InvertBarcodeImage = _barcodeReader.Settings.InvertImageColors;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                outputTextRichTextBox.Text = "";
                return;
            }
            finally
            {
                barcodeReaderPictureBox.Enabled = true;
            }

            if (readBarcodesButton.Text == "Stop")
                readBarcodesButton.Text = "Read barcodes";

            _disableThreshold1ChangeEvent = true;
            if (thresholdMethodAutoRadioButton.Checked)
                thresholdMinTrackBar.Value = _barcodeReader.Settings.Threshold;
            _disableThreshold1ChangeEvent = false;

            // extended info
            int c = 0;
            for (int i = 0; i < _barcodeRecognitionResults.Length; i++)
            {
                if (_barcodeRecognitionResults[i].Confidence > 95)
                    c++;
            }
            double barcodeRecognitionTimeInMilliseconds = _barcodeReader.RecognizeTime.TotalMilliseconds;
            string totalInfo = null;
            if (_barcodeRecognitionResults.Length > 0)
            {
                string barcodeRecognitionTimeInMillisecondsAsString;
                if (barcodeRecognitionTimeInMilliseconds <= double.Epsilon)
                    barcodeRecognitionTimeInMillisecondsAsString = "<1";
                else
                    barcodeRecognitionTimeInMillisecondsAsString = barcodeRecognitionTimeInMilliseconds.ToString();
                totalInfo = string.Format("{0} barcode(s) found, {1} with confidence >95%, recognition time {2} ms.", _barcodeRecognitionResults.Length, c, barcodeRecognitionTimeInMillisecondsAsString);
            }
            else
            {
                totalInfo = string.Format(
                    "No barcodes found({0} ms).\r\n" +
                    "\r\n" +
                    "You should try to change barcode recognition settings, for example decrease scan interval, use advanced threshold mode, add new scan direction, etc if you are sure that image contains a barcode.\r\n" +
                    "\r\n", barcodeRecognitionTimeInMilliseconds);
                if (!automaticRecognitionCheckBox.Checked)
                {
                    totalInfo += "Please try to use \"Automatic recognition\" mode if you have barcodes with low quality.\r\n\r\n";
                }
                totalInfo += "\r\nPlease send image with barcode to support@vintasoft.com if you cannot recognize barcode - we will do the best to help you.";
            }

            // short info
            StringBuilder sb = new StringBuilder();
            sb.Append(totalInfo);
            sb.Append("\r\n");
            sb.Append("\r\n");
            for (int i = 0; i < _barcodeRecognitionResults.Length; i++)
            {
                sb.AppendLine(GetBarcodeInfo(i, _barcodeRecognitionResults[i]));
            }

            outputTextRichTextBox.Text = sb.ToString();
            outputTextRichTextBox.Refresh();

            // bitmap, which must be displayed in picture box
            Bitmap bitmap;
            // if image is big
            if (IsLargeImage(_barcodeReaderImage))
            {
                // picture box will display source image 
                bitmap = (Bitmap)_barcodeReaderImage;
                _isBarcodeReaderImageMarked = _barcodeRecognitionResults.Length > 0;
            }
            else
            {
                // if picture box must contain processed image
                if (showImageProcessingCheckBox.Checked)
                {
                    // create the processed image from the source image
                    bitmap = (Bitmap)_barcodeReader.ProcessImage(_barcodeReaderImage);
                }
                else
                {
                    // get clone of source image
                    bitmap = new Bitmap(_barcodeReaderImage);
                }
            }
            UpdateImageText();
            GC.Collect();

            // draws an information about found barcodes on the reader image
            DrawBarcodeInfoOnImageWithBarcodes(bitmap, _barcodeRecognitionResults);

            // shows the reader image in picture box
            barcodeReaderPictureBox.Image = bitmap;
        }

        /// <summary>
        /// Draws information about found barcodes on image with barcodes.
        /// </summary>
        /// <param name="imageWithBarcodes">Image with barcodes.</param>
        /// <param name="barcodeInfos">Information about found barcodes.</param>
        private void DrawBarcodeInfoOnImageWithBarcodes(Bitmap imageWithBarcodes, IBarcodeInfo[] barcodeInfos)
        {
            try
            {
                using (Graphics g = Graphics.FromImage(imageWithBarcodes))
                {
                    Brush brush = Brushes.Blue;
                    for (int i = 0; i < barcodeInfos.Length; i++)
                    {
                        IBarcodeInfo inf = barcodeInfos[i];
                        if (inf.Region == null)
                            continue;
                        Pen pen = new Pen(Color.Blue);
                        if (inf.Confidence > 95 || inf.Confidence == ReaderSettings.ConfidenceNotAvailable)
                        {
                            if (inf.BarcodeType == BarcodeType.UnknownLinear)
                                pen.Color = Color.Red;
                            else
                                pen.Color = Color.Green;
                            pen.Width = 2;
                        }
                        else
                        {
                            if (inf.Confidence <= 50)
                            {
                                pen.Color = Color.Red;
                            }
                        }
                        if (inf.SymbolComponents != null)
                        {
                            Pen symbolComponentPen = new Pen(Color.FromArgb(192, Color.Blue), 2);
                            foreach (IBarcodeInfo symbolComponentInfo in inf.SymbolComponents)
                            {
                                g.DrawPolygon(symbolComponentPen, GdiConverter.Convert(symbolComponentInfo.Region.GetPoints()));
                            }
                        }
                        pen.Color = Color.FromArgb(192, pen.Color);
                        g.FillPolygon(new SolidBrush(Color.FromArgb(48, pen.Color)), GdiConverter.Convert(inf.Region.GetPoints()));
                        g.DrawPolygon(pen, GdiConverter.Convert(inf.Region.GetPoints()));

                        SolidBrush br = new SolidBrush(Color.Lime);
                        if (inf.ReadingQuality < 0.75)
                        {
                            if (inf.ReadingQuality >= 0.5)
                                br.Color = Color.Yellow;
                            else
                                br.Color = Color.Red;
                        }

                        string barcodeTypeValue;
                        if (inf is BarcodeSubsetInfo)
                            barcodeTypeValue = ((BarcodeSubsetInfo)inf).BarcodeSubset.Name;
                        else
                            barcodeTypeValue = inf.BarcodeType.ToString();

                        br.Color = Color.FromArgb(192, br.Color);
                        g.FillRectangle(br, inf.Region.LeftTop.X, inf.Region.LeftTop.Y, pen.Width + 2, pen.Width + 2);
                        inf.ShowNonDataFlagsInValue = true;
                        using (GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath())
                        {
                            g.DrawString(string.Format("[{0}] {1}: {2}", i + 1, barcodeTypeValue, inf.Value), new Font("Courier New", 8), brush, inf.Region.LeftTop.X, inf.Region.LeftTop.Y - 20);
                        }

                        VintasoftPointF[] referenceRecognitionPoints = null;
                        if (inf is AztecInfo)
                        {
                            referenceRecognitionPoints = new VintasoftPointF[] {
                                ((AztecInfo)inf).BulleyeCenter
                            };
                        }
                        else if (inf is QRInfo)
                        {
                            referenceRecognitionPoints = new VintasoftPointF[] {
                               ((QRInfo)inf).LeftTopFinderPatternCenter,
                               ((QRInfo)inf).LeftBottomFinderPatternCenter,
                               ((QRInfo)inf).RightTopFinderPatternCenter
                            };
                        }
                        else if (inf is HanXinCodeInfo)
                        {
                            referenceRecognitionPoints = new VintasoftPointF[] {
                               ((HanXinCodeInfo)inf).LeftTopFinderPatternCenter,
                               ((HanXinCodeInfo)inf).LeftBottomFinderPatternCenter,
                               ((HanXinCodeInfo)inf).RightTopFinderPatternCenter,
                               ((HanXinCodeInfo)inf).RightBottomFinderPatternCenter
                            };
                        }
                        if (referenceRecognitionPoints != null)
                        {
                            SmoothingMode smoothingMode = g.SmoothingMode;
                            g.SmoothingMode = SmoothingMode.AntiAlias;
                            using (Brush pointBrush = new SolidBrush(Color.FromArgb(192, Color.Lime)))
                            {
                                using (Brush centerPointBrush = new SolidBrush(Color.FromArgb(192, Color.Red)))
                                {
                                    float delta = (float)Math.Max(((BarcodeInfo2D)inf).CellWidth, ((BarcodeInfo2D)inf).CellHeight) / 2;
                                    for (int j = 0; j < referenceRecognitionPoints.Length; j++)
                                    {
                                        PointF point = GdiConverter.Convert(referenceRecognitionPoints[j]);
                                        if (!point.IsEmpty)
                                        {
                                            g.FillEllipse(pointBrush, new RectangleF(point.X - delta, point.Y - delta, delta * 2, delta * 2));
                                            g.FillEllipse(centerPointBrush, new RectangleF(point.X - 0.5f, point.Y - 0.5f, 1, 1));
                                        }
                                    }
                                }
                            }
                            g.SmoothingMode = smoothingMode;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion


        #region Barcode reader results

        /// <summary>
        /// Returns the barcode value as a string.
        /// </summary>
        /// <param name="barcodeInfoIndex">Index of barcode info in barcode recognition result.</param>
        /// <param name="barcodeInfo">Barcode info.</param>
        /// <returns>Barcode value as a string.</returns>
        private string GetBarcodeInfo(int barcodeInfoIndex, IBarcodeInfo barcodeInfo)
        {
            barcodeInfo.ShowNonDataFlagsInValue = true;

            string value;
            if (barcodeInfo.BarcodeInfoClass == BarcodeInfoClass.Barcode2D && advancedReaderSettings.InterpretEciCharacters)
                value = EciCharacterDecoder.Decode(barcodeInfo.ValueItems);
            else
                value = barcodeInfo.Value;

            if (barcodeInfo is UPCEANInfo)
            {
                if ((barcodeInfo.BarcodeType & BarcodeType.UPCE) != 0)
                    value += string.Format(" (UPC-E: {0})", (barcodeInfo as UPCEANInfo).UPCEValue);

                if ((barcodeInfo.BarcodeType & BarcodeType.UPCA) != 0)
                    value += string.Format(" (UPC-A: {0})", (barcodeInfo as UPCEANInfo).UPCAValue);
            }

            string confidence;
            if (barcodeInfo.Confidence == ReaderSettings.ConfidenceNotAvailable)
                confidence = "N/A";
            else
                confidence = Math.Round(barcodeInfo.Confidence).ToString() + "%";

            if (barcodeInfo is BarcodeSubsetInfo)
            {
                if (barcodeInfo is AamvaBarcodeInfo)
                {
                    AamvaBarcodeValue aamvaValue = ((AamvaBarcodeInfo)barcodeInfo).AamvaValue;
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine();
                    sb.AppendLine(string.Format("Issuer identification number: {0}", aamvaValue.Header.IssuerIdentificationNumber));
                    sb.AppendLine(string.Format("File type: {0}", aamvaValue.Header.FileType));
                    sb.AppendLine(string.Format("AAMVA Version number: {0} ({1})", aamvaValue.Header.VersionLevel, (int)aamvaValue.Header.VersionLevel));
                    sb.AppendLine(string.Format("Jurisdiction Version number: {0}", aamvaValue.Header.JurisdictionVersionNumber));
                    sb.AppendLine();
                    foreach (AamvaSubfile subfile in aamvaValue.Subfiles)
                    {
                        sb.AppendLine(string.Format("[{0}] subfile:", subfile.SubfileType));
                        foreach (AamvaDataElement dataElement in subfile.DataElements)
                        {
                            if (dataElement.Identifier.VersionLevel != AamvaVersionLevel.Undefined)
                                sb.Append(string.Format("  [{0}] {1}:", dataElement.Identifier.ID, dataElement.Identifier.Description));
                            else
                                sb.Append(string.Format("  [{0}]:", dataElement.Identifier.ID));
                            sb.AppendLine(string.Format(" {0}", dataElement.Value));
                        }
                    }
                    value = sb.ToString();
                }
                else
                {
                    value = string.Format("{0}{1}Base value: {2}",
                        RemoveSpecialCharacters(value), Environment.NewLine,
                        RemoveSpecialCharacters(((BarcodeSubsetInfo)barcodeInfo).BaseBarcodeInfo.Value));
                }
            }
            else
            {
                value = RemoveSpecialCharacters(value);
            }

            string barcodeTypeValue;
            if (barcodeInfo is StructuredAppendBarcodeInfo)
            {
                barcodeTypeValue = string.Format("{0} (Reconstructed)", barcodeInfo.BarcodeType);
            }
            else if (barcodeInfo is BarcodeSubsetInfo)
            {
                BarcodeSubsetInfo subsetInfo = (BarcodeSubsetInfo)barcodeInfo;
                barcodeTypeValue = string.Format("{0} ({1})", subsetInfo.BarcodeSubset.Name, subsetInfo.BarcodeSubset.BarcodeType);
            }
            else
            {
                barcodeTypeValue = barcodeInfo.BarcodeType.ToString();
            }

            StringBuilder result = new StringBuilder();
            result.AppendLine(string.Format("[{0}:{1}]", barcodeInfoIndex + 1, barcodeTypeValue));
            result.AppendLine(string.Format("Value: {0}", value));
            result.AppendLine(string.Format("Confidence: {0}", confidence));
            result.AppendLine(string.Format("Reading quality: {0}", barcodeInfo.ReadingQuality));
            result.AppendLine(string.Format("Threshold: {0}", barcodeInfo.Threshold));
            result.AppendLine(string.Format("Region: {0}", barcodeInfo.Region));
            return result.ToString();
        }

        /// <summary>
        /// Removes the special characters from the text.
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
        /// Clears the barcode reader results.
        /// </summary>
        private void ClearBarcodeRecognitionResults()
        {
            _barcodeRecognitionResults = null;

            barcodeReaderResultsControl1.RecognizedBarcodes = null;
            barcodeReaderResultsControl1.BarcodeInfoIndex = 0;
        }

        #endregion

        #endregion


        #region Barcode writer

        /// <summary>
        /// Creates an image with barcode.
        /// </summary>
        private void createWriterImageButton_Click(object sender, EventArgs e)
        {
            if (barcodeWriterSettingsControl1.EncodeValue())
                WriteBarcode();
        }

        /// <summary>
        /// Saves image with barcode.
        /// </summary>
        private void saveImageButton_Click(object sender, EventArgs e)
        {
            if (saveImageFileDialog.ShowDialog() == DialogResult.OK)
            {
                writerPictureBox.Image.Save(saveImageFileDialog.FileName);

                ProcessStartInfo processInfo = new ProcessStartInfo(saveImageFileDialog.FileName);
                processInfo.UseShellExecute = true;
                Process.Start(processInfo);
            }
        }

        /// <summary>
        /// Saves image with barcode as SVG file.
        /// </summary>
        private void saveSVGImageAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (barcodeWriterSettingsControl1.EncodeValue())
            {
                WriteBarcode();
                if (saveSvgFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (BarcodeGlobalSettings.IsDemoVersion)
                    {
                        MessageBox.Show("The evaluation version adds noise to the barcode image.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    _barcodeWriter.Settings.UseLegacyVectorGenerator = false;
                    string svgFile = _barcodeWriter.GetBarcodeAsSvgFile();

                    File.WriteAllText(saveSvgFileDialog.FileName, svgFile);

                    ProcessStartInfo processInfo = new ProcessStartInfo(saveSvgFileDialog.FileName);
                    processInfo.UseShellExecute = true;
                    Process.Start(processInfo);
                }
            }
        }

        /// <summary>
        /// Reads barcodes from image with barcode, which was created by the barcode writer.
        /// </summary>
        private void readBarcodesInWriterButton_Click(object sender, EventArgs e)
        {
            if (writerPictureBox.Image == null)
                return;

            if (_barcodeReaderSourceImage != writerPictureBox.Image)
                CloseBarcodeReaderImage();

            _fileName = "from Barcode Writer";
            _barcodeReaderSourceImage = writerPictureBox.Image;
            OpenBarcodeReaderImage(writerPictureBox.Image);
            _barcodeReader.Settings.ScanBarcodeTypes |= _barcodeWriter.Settings.Barcode;
            _barcodeReader.Settings.EnableTelepenNumericMode = _barcodeWriter.Settings.EnableTelepenNumericMode;
            _barcodeReader.Settings.OptionalCheckSum = _barcodeWriter.Settings.OptionalCheckSum;
            _barcodeReader.Settings.AustralianPostCustomerInfoFormat = _barcodeWriter.Settings.AustralianPostCustomerInfoFormat;
            _barcodeReader.Settings.MSIChecksum = _barcodeWriter.Settings.MSIChecksum;
            _barcodeReader.Settings.PharmacodeMaxValue = _barcodeWriter.Settings.PharmacodeMaxValue;
            if (_barcodeWriter.Settings.Barcode == BarcodeType.DotCode)
            {
                if (_barcodeReader.Settings.ScanInterval > _barcodeWriter.Settings.MinWidth)
                {
                    _barcodeReader.Settings.ScanInterval = _barcodeWriter.Settings.MinWidth;
                    scanIntervalEditor.UpdateUI();
                }
            }
            if (barcodeWriterSettingsControl1.SelectedBarcodeSubset != null)
            {
                if (!_barcodeReader.Settings.ScanBarcodeSubsets.Contains(barcodeWriterSettingsControl1.SelectedBarcodeSubset))
                    _barcodeReader.Settings.ScanBarcodeSubsets.Add(barcodeWriterSettingsControl1.SelectedBarcodeSubset);
            }
            advancedReaderSettings.InterpretEciCharacters = barcodeWriterSettingsControl1.EncodeEciCharacter;
            readerBarcodeTypes.UpdateUI();
            advancedReaderSettings.UpdateUI();


            ReadBarcodes();
        }

        /// <summary>
        /// Sets the  barcode image size.
        /// </summary>
        private void setWriterImageSizeButton_Click(object sender, EventArgs e)
        {
            using (GetSizeForm form = new GetSizeForm())
            {
                if (_barcodeImageWidth == 0 && _barcodeImageHeigth == 0 && _barcodeImageSizeUnits == UnitOfMeasure.Pixels && writerPictureBox.Image != null)
                {
                    form.WidthValue = writerPictureBox.Image.Width;
                    form.HeightValue = writerPictureBox.Image.Height;
                }
                else
                {
                    form.WidthValue = _barcodeImageWidth;
                    form.HeightValue = _barcodeImageHeigth;
                }
                form.UnitsValue = _barcodeImageSizeUnits;
                form.ResolutionValue = _barcodeImageResolution;

                if (form.ShowDialog() == DialogResult.OK)
                {
                    if (BarcodeGlobalSettings.IsDemoVersion)
                    {
                        MessageBox.Show("The evaluation version adds noise to the barcode image.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    _barcodeImageWidth = form.WidthValue;
                    _barcodeImageHeigth = form.HeightValue;
                    _barcodeImageSizeUnits = form.UnitsValue;
                    _barcodeImageResolution = form.ResolutionValue;
                    WriteBarcode();
                }
            }
        }

        /// <summary>
        /// Reset the barcode image size to the auto size.
        /// </summary>
        private void resetBarcodeImageSizeButton_Click(object sender, EventArgs e)
        {
            _barcodeImageWidth = 0;
            _barcodeImageHeigth = 0;
            _barcodeImageResolution = 96;
            _barcodeImageSizeUnits = UnitOfMeasure.Pixels;
            WriteBarcode();
        }

        /// <summary>
        /// Clears the image with barcode.
        /// </summary>
        private void clearWriterImageButton_Click(object sender, EventArgs e)
        {
            ClearWriterImage();
        }

        /// <summary>
        /// Barcode writer settings are changed.
        /// </summary>
        private void WriterSettings_Changed(object sender, EventArgs e)
        {
            if (!_barcodeWriting)
                WriteBarcode();
        }

        /// <summary>
        /// Creates image with barcode.
        /// </summary>
        private void WriteBarcode()
        {
            if (barcodeWriterSettingsControl1.SelectedBarcodeSubset == null)
                barcodeWriterBarcodeInformation.Text = BarcodesInformation.GetInformation(_barcodeWriter.Settings.Barcode);
            else
                barcodeWriterBarcodeInformation.Text = BarcodesInformation.GetInformation(barcodeWriterSettingsControl1.SelectedBarcodeSubset);

            if (!_isMainFormLoaded)
                return;
            _barcodeWriting = true;
            try
            {
                if (barcodeWriterSettingsControl1.SelectedBarcodeSubset != null)
                {
                    if (!barcodeWriterSettingsControl1.EncodeValue())
                        return;
                }
                barcodeWriterErrorText.Visible = false;
                bool barcodeRendered = false;
                if (_barcodeRenderer != null)
                {
                    try
                    {
                        // generate "design" barcode use barcode render
                        if (_barcodeImageWidth > 0 && _barcodeImageHeigth > 0)
                            _barcodeWriter.Settings.Resolution = _barcodeImageResolution;
                        writerPictureBox.Image = _barcodeRenderer.GetBarcodeAsBitmap(
                            _barcodeWriter, _barcodeImageWidth, _barcodeImageHeigth, _barcodeImageSizeUnits);
                        barcodeRendered = true;
                    }
                    catch (NotSupportedException)
                    {
                    }
                }
                if (!barcodeRendered)
                {
                    if (_barcodeImageWidth > 0 && _barcodeImageHeigth > 0)
                    {
                        // generate barcode image with specified size
                        _barcodeWriter.Settings.Resolution = _barcodeImageResolution;
                        _barcodeWriter.Settings.UseLegacyVectorGenerator = false;
                        writerPictureBox.Image = _barcodeWriter.GetBarcodeAsBitmap(
                            _barcodeImageWidth, _barcodeImageHeigth, _barcodeImageSizeUnits);
                    }
                    else
                    {
                        // generate barcode image with auto size
                        writerPictureBox.Image = _barcodeWriter.GetBarcodeAsBitmap();
                    }
                }
                barcodeWriterSettingsControl1.UpdateBarcodeWriterSettings();
                barcodeWriterSettingsControl1.BarcodeImage = writerPictureBox.Image;
            }
            catch (WriterSettingsException err)
            {
                ClearWriterImage();
                barcodeWriterErrorText.Visible = true;
                barcodeWriterErrorText.Text = string.Format("Wrong writer settings:\n\n{0}", err.Message);
                return;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            finally
            {
                _barcodeWriting = false;
            }
            saveWriterImageButton.Enabled = readBarcodeFromWriterImageButton.Enabled = clearWriterImageButton.Enabled = true;
        }


        private void barcodeWriterSettingsControl1_WriterException(object sender, ExceptionEventArgs e)
        {
            if (barcodeWriterSettingsControl1.SelectedBarcodeSubset == null)
                barcodeWriterBarcodeInformation.Text = BarcodesInformation.GetInformation(_barcodeWriter.Settings.Barcode);
            else
                barcodeWriterBarcodeInformation.Text = BarcodesInformation.GetInformation(barcodeWriterSettingsControl1.SelectedBarcodeSubset);

            ClearWriterImage();
            barcodeWriterErrorText.Visible = true;
            barcodeWriterErrorText.Text = string.Format("Wrong writer settings:\n\n{0}", e.Exception.Message);
        }

        /// <summary>
        /// Clears the image with barcode.
        /// </summary>
        private void ClearWriterImage()
        {
            if (writerPictureBox.Image != null)
            {
                readBarcodeFromWriterImageButton.Enabled = false;
                saveWriterImageButton.Enabled = false;
                clearWriterImageButton.Enabled = false;

                if (_barcodeReaderSourceImage == writerPictureBox.Image)
                    CloseBarcodeReaderImage();

                writerPictureBox.Image.Dispose();
                writerPictureBox.Image = null;
            }
        }

        #endregion

        #endregion


    }
}