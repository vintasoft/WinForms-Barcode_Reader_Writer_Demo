Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Text
Imports System.Windows.Forms
Imports System.Xml.Serialization

Imports Vintasoft.Barcode
Imports Vintasoft.Barcode.BarcodeInfo
Imports Vintasoft.Barcode.GS1
Imports Vintasoft.Barcode.SymbologySubsets

Public Partial Class MainForm
	Inherits Form

	#Region "Fields"

	''' <summary>
	''' Title of the application's main form.
	''' </summary>
	Private _formTitle As String

	''' <summary>
	''' Indicates whether the main form of application is loaded.
	''' </summary>
	Private _isMainFormLoaded As Boolean = False


	''' <summary>
	''' Names of files, which are located in current working directory.
	''' </summary>
	Private _filesList As String() = Nothing
	''' <summary>
	''' Name of file, which is loaded for barcode recognition.
	''' </summary>
	Private _currentFileName As String = Nothing
	''' <summary>
	''' Indicates whether the events of filesListTrackBar control are disabled.
	''' </summary>
	Private _disableFilesListEventHandler As Boolean = False


	''' <summary>
	''' Form for selection page of multipage image.
	''' </summary>
	Private _selectPageFromMultipageImageForm As New SelectImageFrameForm()
	''' <summary>
	''' Form for selection page of PDF document.
	''' </summary>
	Private _selectPdfPageForm As New SelectPdfPageForm()


	''' <summary>
	''' Name of the file from which the barcode reader source image is loaded.
	''' </summary>
	Private _fileName As String = Nothing
	''' <summary>
	''' The source image, loaded from file or received from barcode writer,
	''' in which the barcode reader searches the barcodes.
	''' </summary>
	Private _barcodeReaderSourceImage As Image = Nothing
	''' <summary>
	''' Image (may contain recognition results) in which the barcode reader searches the barcodes.
	''' </summary>
	Private _barcodeReaderImage As Image = Nothing


	''' <summary>
	''' Barcode reader.
	''' </summary>
	Private _barcodeReader As New BarcodeReader()

	''' <summary>
	''' Indicates, whether the barcode recognition must be stopped.
	''' </summary>
	Private _stopReadBarcodes As Boolean = False

	''' <summary>
	''' Results of barcode recognition.
	''' </summary>
	Private _barcodeRecognitionResults As IBarcodeInfo()

	''' <summary>
	''' Indicates, whether the image contains barcode recognition results.
	''' </summary>
	Private _isBarcodeReaderImageMarked As Boolean = False

	''' <summary>
	''' Location of the last mouse position in the picture box of barcode reader.
	''' </summary>
	Private _lastMousePosition As Point

	''' <summary>
	''' Threshold trackbar, that the user has changed the last.
	''' </summary>
	Private _lastThresholdTrackBar As TrackBar = Nothing

	''' <summary>
	''' Indicates whether the events of threshold trackbar are disabled.
	''' </summary>
	Private _disableThreshold1ChangeEvent As Boolean = False


	''' <summary>
	''' Barcode writer.
	''' </summary>
	Private _barcodeWriter As New BarcodeWriter()

	''' <summary>
	''' Indicates when barcode writing.
	''' </summary>
	Private _barcodeWriting As Boolean = False

	#End Region



	#Region "Constructors"

	Public Sub New()
		InitializeComponent()


		' this code is necessary for evaluation version only
		Using image As Image = New Bitmap(32, 32)
			_barcodeReader.ReadBarcodes(image)
		End Using


		_formTitle = String.Format("VintaSoft 1D/2D Barcode Reader/Writer Demo v{0} ", BarcodeGlobalSettings.ProductVersion)
		' update the application title
		Me.Text = _formTitle

        AddHandler _barcodeReader.Progress, New EventHandler(Of BarcodeReaderProgressEventArgs)(AddressOf _barcodeReader_RecognizeProgress)

		_barcodeReader.Settings.CollectTestInformation = True

		AddHandler readerBarcodeTypes.SettingsChanged, New EventHandler(AddressOf ReaderBarcodeTypes_SettingsChanged)

		_barcodeWriter.Settings.Barcode = BarcodeType.Code128
		_barcodeWriter.Settings.Value = "012345"
		_barcodeWriter.Settings.PixelFormat = BarcodeImagePixelFormat.Bgr24
        barcodeWriterSettingsControl1.BarcodeWriterSettings = _barcodeWriter.Settings
        AddHandler _barcodeWriter.Settings.Changed, New EventHandler(AddressOf WriterSettings_Changed)
	End Sub

	#End Region



	#Region "Properties"

	''' <summary>
	''' Current working directory.
	''' </summary>
	Private _currentDirectory As String = Environment.CurrentDirectory
	''' <summary>
	''' Gets or set the current working directory.
	''' </summary>
	Friend Property CurrentDirectory() As String
		Get
			Return _currentDirectory
		End Get
		Set
			_currentDirectory = value

			' updates the file list
			UpdateFileList()
		End Set
	End Property

	#End Region



	#Region "Methods"

	#Region "'File' menu"

	''' <summary>
	''' Exit from application.
	''' </summary>
    Private Sub exitToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles exitToolStripMenuItem.Click
        Close()
    End Sub

	''' <summary>
	''' Selects and opens the image file.
	''' </summary>
    Private Sub openImageButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles openToolStripMenuItem.Click
        SelectAndOpenBarcodeReaderImage()
    End Sub

	''' <summary>
	''' Closes the image file.
	''' </summary>
    Private Sub closeImageButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles closeToolStripMenuItem.Click
        CloseBarcodeReaderImage()
    End Sub

	#End Region


	#Region "'Help' menu"

	''' <summary>
	''' Shows 'About' dialog.
    Private Sub aboutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles aboutToolStripMenuItem.Click
        Using aboutDialog As New AboutBoxForm("vsbarcode-dotnet")
            aboutDialog.ShowDialog()
        End Using
    End Sub

	#End Region


	#Region "Common"

	''' <summary>
	''' Main form is loaded.
	''' </summary>
    Private Sub MainForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            ' get the path to directory with barcode image samples
            Dim directoryWithBarcodeImageSamples As String = GetDirectoryWithBarcodeImageSamples()
            ' if directory exists
            If Directory.Exists(directoryWithBarcodeImageSamples) Then
                ' make the directory as initial directory for the open file dialog
                openFileDialog1.InitialDirectory = directoryWithBarcodeImageSamples
            End If
        Catch generatedExceptionName As Exception
        End Try

        ' set the current working directory
        CurrentDirectory = openFileDialog1.InitialDirectory

        ' indicate that form is loaded
        _isMainFormLoaded = True

        ' show group box with restrictions of demo version if demo version is used
        demoVersionRestrictionsGroupBox.Visible = BarcodeGlobalSettings.IsDemoVersion
    End Sub

	''' <summary>
	''' Gets the path to directory with barcode image samples.
	''' </summary>
	Private Function GetDirectoryWithBarcodeImageSamples() As String
		Try
			Dim directoryPath As String = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().ManifestModule.FullyQualifiedName)
			directoryPath = Path.GetDirectoryName(directoryPath)
			directoryPath = Path.GetDirectoryName(directoryPath)
			directoryPath = Path.GetDirectoryName(directoryPath)
			directoryPath = Path.Combine(directoryPath, "Images")
			If Directory.Exists(directoryPath) Then
				Return directoryPath
			End If

			directoryPath = Path.GetDirectoryName(directoryPath)
			directoryPath = Path.GetDirectoryName(directoryPath)
			directoryPath = Path.Combine(directoryPath, "Images")
			Return directoryPath
		Catch
			Return ""
		End Try
	End Function

	''' <summary>
	''' Main form is shown.
	''' </summary>
    Private Sub MainForm_Shown(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Shown
        ' update the application title
        Me.Text = "Loading settings..."
        Application.DoEvents()

        _barcodeReader.Settings = DeserializeBarcodeReaderSettings("ReaderSettings.xml")
        _barcodeReader.Settings.TryTransmitGS1Value = False
        _barcodeReader.Settings.Erode = False

        InitBarcodeReaderSettingsControls(_barcodeReader.Settings)
        InitBarcodeReaderSettingsUI(_barcodeReader.Settings)
        UpdateVisibilityOfDemoVersionRestrictionGroupBox()
        CloseBarcodeReaderImage()
    End Sub

	''' <summary>
	''' Key is down in main form.
	''' </summary>
    Private Sub MainForm_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Space AndAlso tabControl.SelectedTab Is readerTabPage Then
            ReadBarcodes()
            e.Handled = True
            Return
        End If
        If readBarcodesButton.Text <> "Stop" Then
            If e.Control AndAlso e.KeyCode = Keys.O AndAlso tabControl.SelectedTab Is readerTabPage Then
                SelectAndOpenBarcodeReaderImage()
                Return
            End If
            If e.KeyCode = Keys.PageUp Then
                e.Handled = True
                If filesListTrackBar.Value < filesListTrackBar.Maximum Then
                    filesListTrackBar.Value += 1
                End If
            End If
            If e.KeyCode = Keys.PageDown Then
                e.Handled = True
                If filesListTrackBar.Value > filesListTrackBar.Minimum Then
                    filesListTrackBar.Value -= 1
                End If
            End If
        End If
    End Sub

	''' <summary>
	''' Tab page is changed.
	''' </summary>
    Private Sub tabControl_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles tabControl.SelectedIndexChanged
        readerTools.Visible = (tabControl.SelectedTab IsNot writerTabPage) AndAlso (tabControl.SelectedTab IsNot tpResults)
        writerTabPage.Refresh()
    End Sub

	''' <summary>
	''' Main form is closed.
	''' </summary>
    Private Sub MainForm_FormClosed(ByVal sender As Object, ByVal e As FormClosedEventArgs) Handles MyBase.FormClosed
        ' update the application title
        Me.Text = "Save settings..."
        Application.DoEvents()

        InitBarcodeReaderSettings()
        SerializeBarcodeReaderSettings(_barcodeReader.Settings, "ReaderSettings.xml")
    End Sub


	''' <summary>
	''' Determines whether the image is large.
	''' </summary>
	Private Function IsLargeImage(image As Image) As Boolean
		If image Is Nothing Then
			Return False
		End If

		Return Not IsIndexedImage(image) AndAlso ((image.Width * image.Height) > (30 * 1024 * 1024))
	End Function

	''' <summary>
	''' Determines whether the image is palette image.
	''' </summary>
	''' <param name="image"></param>
	''' <returns></returns>
	Private Function IsIndexedImage(image As Image) As Boolean
		Return image.PixelFormat = PixelFormat.Format1bppIndexed OrElse image.PixelFormat = PixelFormat.Format4bppIndexed OrElse image.PixelFormat = PixelFormat.Format8bppIndexed OrElse image.PixelFormat = PixelFormat.Indexed
	End Function

	#End Region


	#Region "Barcode reader"

	#Region "Update the barcode reader UI"

	''' <summary>
	''' Updates the UI of barcode reader.
	''' </summary>
	Private Sub UpdateBarcodeReaderUI()
		Dim isBarcodeReaderImageLoaded As Boolean = _barcodeReaderImage IsNot Nothing
		Dim isAutomaticRecognitionEnabled As Boolean = automaticRecognitionCheckBox.Checked
		Dim isThresholdingEnabled__1 As Boolean = isBarcodeReaderImageLoaded AndAlso IsThresholdingEnabled()

		closeToolStripMenuItem.Enabled = isBarcodeReaderImageLoaded
		readBarcodesButton.Enabled = isBarcodeReaderImageLoaded

		automaticRecognitionCheckBox.Enabled = isBarcodeReaderImageLoaded

		thresholdMethodGroupBox.Enabled = isBarcodeReaderImageLoaded AndAlso Not isAutomaticRecognitionEnabled
		thresholdGroupBox.Enabled = isBarcodeReaderImageLoaded AndAlso Not isAutomaticRecognitionEnabled
		highThresholdGroupBox.Enabled = isBarcodeReaderImageLoaded AndAlso Not isAutomaticRecognitionEnabled

		zoomImageCheckBox.Enabled = isBarcodeReaderImageLoaded
		showImageProcessingCheckBox.Enabled = isBarcodeReaderImageLoaded
		readerErodeCheckBox.Enabled = isBarcodeReaderImageLoaded
		removePeasCheckBox.Enabled = isBarcodeReaderImageLoaded
		invertColorsCheckBox.Enabled = isBarcodeReaderImageLoaded

		If isAutomaticRecognitionEnabled Then
			showImageProcessingCheckBox.Checked = False
		End If

		If isAutomaticRecognitionEnabled Then
			thresholdMethodGroupBox.Visible = False
			thresholdIterationGroupBox.Visible = False
			thresholdGroupBox.Visible = False
			highThresholdGroupBox.Visible = False

			showProgressCheckBox.Visible = True

			showImageProcessingCheckBox.Enabled = False
		Else
			showImageProcessingCheckBox.Enabled = True
			thresholdMethodGroupBox.Visible = True
			thresholdGroupBox.Visible = True

			If thresholdMethodAutoRadioButton.Checked Then
				thresholdIterationGroupBox.Visible = False
				thresholdGroupBox.Enabled = False
				highThresholdGroupBox.Visible = False

				showProgressCheckBox.Visible = False
			ElseIf thresholdMethodManualRadioButton.Checked Then
				thresholdIterationGroupBox.Visible = False
				thresholdGroupBox.Enabled = isThresholdingEnabled__1
				UpdateThresholdMinValue()
				highThresholdGroupBox.Visible = False

				showProgressCheckBox.Visible = False
			ElseIf thresholdMethodIterationRadioButton.Checked Then
				thresholdIterationGroupBox.Visible = True
				thresholdGroupBox.Enabled = isThresholdingEnabled__1
				UpdateThresholdMinValue()
				highThresholdGroupBox.Visible = True
				highThresholdGroupBox.Enabled = isThresholdingEnabled__1
				UpdateThresholdMaxValue()

				showProgressCheckBox.Visible = True
			End If
		End If

		expectedBarcodesSlaveEditor.Visible = isBarcodeReaderImageLoaded AndAlso isAutomaticRecognitionEnabled
		scanIntervalSlaveEditor.Visible = isBarcodeReaderImageLoaded AndAlso isAutomaticRecognitionEnabled
	End Sub

	#End Region


	#Region "Image files in current working directory"

	''' <summary>
	''' Updates the list of files, which are located in current directory.
	''' </summary>
	Private Sub UpdateFileList()
		' if current working directory is not specified or does not exist
		If CurrentDirectory = "" OrElse Not Directory.Exists(CurrentDirectory) Then
			fileListGroupBox.Visible = False
			Return
		End If

		fileListGroupBox.Visible = True

		' get the list of files, which are located in current working directory
		_filesList = FindFiles.Find(CurrentDirectory, FindFiles.GRAPHIC_FILES)

		' disable events of filesListTrackBar
		_disableFilesListEventHandler = True
		filesListTrackBar.Maximum = _filesList.Length
		If _currentFileName IsNot Nothing Then
			Dim i As Integer = Array.IndexOf(_filesList, _currentFileName)
			If i >= 0 Then
				filesListTrackBar.Value = i + 1
			End If
		Else
			filesListTrackBar.Value = Math.Min(1, _filesList.Length)
		End If
		' enable events of filesListTrackBar
		_disableFilesListEventHandler = False

		UpdateFileListGroupBoxText()
	End Sub

	''' <summary>
	''' Updates the text of fileListGroupBox.
	''' </summary>
	Private Sub UpdateFileListGroupBoxText()
		If _currentFileName Is Nothing Then
			fileListGroupBox.Text = String.Format("{0} files", filesListTrackBar.Maximum)
		Else
			fileListGroupBox.Text = String.Format("File {0} of {1}", filesListTrackBar.Value, filesListTrackBar.Maximum)
		End If
	End Sub

	''' <summary>
	''' Value of filesListTrackBar control is changed.
	''' </summary>
    Private Sub filesListTrackBar_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles filesListTrackBar.ValueChanged
        ' if events of filesListTrackBar control are not disabled
        If Not _disableFilesListEventHandler Then
            If (filesListTrackBar.Maximum > 0) Then
                ' open the image file, which is selected using the trackbar
                OpenBarcodeReaderImageFromFile(_filesList(filesListTrackBar.Value - 1))
            End If
        End If

        UpdateFileListGroupBoxText()
    End Sub

	#End Region


	#Region "Load/close the barcode reader image (image where barcodes must be searched)"


	''' <summary>
	''' Selects an image file and opens it.
	''' </summary>
	Private Sub SelectAndOpenBarcodeReaderImage()
		If openFileDialog1.ShowDialog() = DialogResult.OK Then
			OpenBarcodeReaderImageFromFile(openFileDialog1.FileName)

			' set the current working directory as directory where the opened file is located
			CurrentDirectory = Path.GetDirectoryName(openFileDialog1.FileName)
		End If
	End Sub


	''' <summary>
	''' Opens an image file and loads image from file.
	''' </summary>
	Private Sub OpenBarcodeReaderImageFromFile(fileName As String)
		'
		If _barcodeReaderImage IsNot Nothing Then
			CloseBarcodeReaderImage()
		End If

		_fileName = fileName
		Try
			' check that file is not used by another process
			Using tempStream As Stream = File.Open(_fileName, FileMode.Open)
			End Using

			' if file has ".pdf" extension
			If Path.GetExtension(_fileName).ToUpper() = ".PDF" Then
				If BarcodeGlobalSettings.IsDemoVersion Then
					MessageBox.Show("Evaluation version allows to extract images only from the first page of PDF document.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
				End If
				' load image from PDF document
				_barcodeReaderImage = _selectPdfPageForm.SelectImage(_fileName)
			Else
				' load image from image file
				_barcodeReaderImage = Image.FromFile(_fileName)
			End If
			' if image is not loaded
			If _barcodeReaderImage Is Nothing Then
				Return
			End If

			' enable image processing for not big images
			showImageProcessingCheckBox.Visible = Not IsLargeImage(_barcodeReaderImage)
			' specify that image is loaded from file
			_barcodeReaderSourceImage = _barcodeReaderImage
		Catch e As IOException
			MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
			Return
		Catch generatedExceptionName As Exception
			MessageBox.Show(String.Format("Image '{0}' has unsupported format.", System.IO.Path.GetFileName(_fileName)), "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
			Return
		End Try

		' save the filename of opened file
		_currentFileName = fileName.ToLower()

		' update the application title
		Me.Text = String.Format("{0} - {1}", _formTitle, System.IO.Path.GetFileName(_fileName))

		' 
		OpenBarcodeReaderImage(_barcodeReaderImage)
	End Sub

	''' <summary>
	''' Opens the barcode reader images.
	''' </summary>
	Private Sub OpenBarcodeReaderImage(image As Image)
		_barcodeReaderImage = image
		_selectPageFromMultipageImageForm.SelectFrame(_barcodeReaderImage)

		tabControl.SelectedTab = readerTabPage
		readerTabPage.Text = "Reader [source]"

		barcodeReaderPictureBox.Image = _barcodeReaderImage

		If Not IsThresholdingEnabled() Then
			outputTextRichTextBox.Text = "Threshold option is disabled because image is black-white."
		Else
			outputTextRichTextBox.Text = ""
		End If

		ClearBarcodeRecognitionResults()
		barcodeReaderResultsControl1.BarcodeImage = image

		UpdateBarcodeReaderUI()
	End Sub

	''' <summary>
	''' Closes the barcode reader image.
	''' </summary>
	Private Sub CloseBarcodeReaderImage()
		ClearBarcodeRecognitionResults()
		barcodeReaderResultsControl1.BarcodeImage = Nothing

		barcodeReaderPictureBox.Image = Nothing

		If _barcodeReaderImage IsNot Nothing AndAlso _barcodeReaderSourceImage IsNot writerPictureBox.Image Then
			If _barcodeReaderSourceImage IsNot _barcodeReaderImage Then
				_barcodeReaderSourceImage.Dispose()
				_barcodeReaderSourceImage = Nothing
			End If
			_barcodeReaderImage.Dispose()
			_barcodeReaderImage = Nothing
		End If

		_barcodeReaderImage = Nothing
		GC.Collect()

		outputTextRichTextBox.Clear()
		currentBarcodeInfo.Text = "(0,0)"

		Me.Text = _formTitle
		readerTabPage.Text = "Reader [no image]"

		UpdateBarcodeReaderUI()
	End Sub

	#End Region


	#Region "PictureBox of barcode reader"

	''' <summary>
	''' Updates an image in picture box of barcode reader.
	''' </summary>
	Private Sub UpdateImageInBarcodeReaderPictureBox()
		If _barcodeReaderImage Is Nothing Then
			Return
		End If

		Dim tempBitmap As Bitmap
		Dim bitmap As Bitmap = DirectCast(_barcodeReaderImage, Bitmap)
		If showImageProcessingCheckBox.Checked AndAlso Not IsLargeImage(_barcodeReaderImage) Then
			tempBitmap = bitmap

			If thresholdMethodIterationRadioButton.Checked AndAlso _lastThresholdTrackBar IsNot Nothing Then
				_barcodeReader.Settings.Threshold = _lastThresholdTrackBar.Value
			ElseIf thresholdMethodManualRadioButton.Checked Then
				_barcodeReader.Settings.Threshold = thresholdMinTrackBar.Value
			End If

			bitmap = DirectCast(_barcodeReader.ProcessImage(bitmap), Bitmap)

			If tempBitmap IsNot _barcodeReaderImage Then
				tempBitmap.Dispose()
			End If

			If thresholdMethodAutoRadioButton.Checked Then
				_disableThreshold1ChangeEvent = True
				thresholdMinTrackBar.Value = _barcodeReader.Settings.Threshold
				_disableThreshold1ChangeEvent = False
			End If
		End If

		If bitmap IsNot barcodeReaderPictureBox.Image Then
			tempBitmap = DirectCast(barcodeReaderPictureBox.Image, Bitmap)
			barcodeReaderPictureBox.Image = bitmap
			If tempBitmap IsNot _barcodeReaderImage Then
				tempBitmap.Dispose()
			End If
		End If
		UpdateImageText()
	End Sub

	''' <summary>
	''' Zooming of the barcode reader image is enabled/disabled.
	''' </summary>
    Private Sub zoomReaderImage_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles zoomImageCheckBox.CheckedChanged
        If zoomImageCheckBox.Checked Then
            Dim bitmap As Image = barcodeReaderPictureBox.Image
            barcodeReaderPictureBox.Image = Nothing
            UpdateBarcodeReaderPictureBoxSize()
            barcodeReaderPictureBox.SizeMode = PictureBoxSizeMode.Zoom
            barcodeReaderPictureBox.Image = bitmap
            currentBarcodeInfo.Text = ""
        Else
            barcodeReaderPictureBox.SizeMode = PictureBoxSizeMode.AutoSize
        End If
    End Sub

	''' <summary>
	''' Updates size of PictureBox.
	''' </summary>
	Private Sub UpdateBarcodeReaderPictureBoxSize()
		barcodeReaderPictureBox.Size = New Size(splitContainer1.Panel1.ClientSize.Width - 3, splitContainer1.Panel1.ClientSize.Height - panel9.Height - 3)
	End Sub

	''' <summary>
	''' Form is resized.
	''' </summary>
    Private Sub MainForm_Resize(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Resize
        ' if image must be zoomed in PictureBox
        If zoomImageCheckBox.Checked Then
            ' update size of PictureBox
            UpdateBarcodeReaderPictureBoxSize()
        End If
    End Sub

	''' <summary>
	''' Mouse is clicked on PictureBox.
	''' </summary>
    Private Sub barcodeReaderPictureBox_Click(ByVal sender As Object, ByVal e As EventArgs) Handles barcodeReaderPictureBox.Click
        If zoomImageCheckBox.Checked Then
            Return
        End If

        Dim index As Integer = FindInfoIndex(_lastMousePosition)
        If index >= 0 Then
            barcodeReaderResultsControl1.BarcodeInfoIndex = index
            tabControl.SelectedTab = tpResults
        End If
    End Sub

	''' <summary>
	''' Mouse is moved over the PictureBox.
	''' </summary>
    Private Sub barcodeReaderPictureBox_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles barcodeReaderPictureBox.MouseMove
        _lastMousePosition = e.Location
        If _barcodeReaderImage Is Nothing OrElse zoomImageCheckBox.Checked Then
            Return
        End If
        Dim s As String = String.Format("({0},{1})   ", e.X, e.Y)
        Dim index As Integer = FindInfoIndex(_lastMousePosition)
        If index >= 0 Then
            Dim barcodeType As String = _barcodeRecognitionResults(index).BarcodeType.ToString()
            If TypeOf _barcodeRecognitionResults(index) Is BarcodeSubsetInfo Then
                barcodeType = DirectCast(_barcodeRecognitionResults(index), BarcodeSubsetInfo).BarcodeSubset.Name
            End If
            s += String.Format("[{0}:{1}] {2}", index + 1, barcodeType, _barcodeRecognitionResults(index).Value)
        End If
        If currentBarcodeInfo.Text <> s Then
            currentBarcodeInfo.Text = s
        End If
    End Sub

	''' <summary>
	''' Finds index of the barcode located in specified position.
	''' </summary>
	''' <param name="p"></param>
	''' <returns></returns>
	Private Function FindInfoIndex(mousePosition As Point) As Integer
		If _barcodeRecognitionResults Is Nothing OrElse _barcodeRecognitionResults.Length = 0 Then
			Return -1
		End If
		For i As Integer = 0 To _barcodeRecognitionResults.Length - 1
			If _barcodeRecognitionResults(i).Region.IsPointInRegion(mousePosition) Then
				Return i
			End If
		Next
		Return -1
	End Function

	''' <summary>
	''' Updates information about the barcode reader image.
	''' </summary>
	Private Sub UpdateImageText()
		Dim readerTabPageText As String
		If showImageProcessingCheckBox.Checked Then
			readerTabPageText = [String].Format("Reader [threshold {0}]", _barcodeReader.Settings.Threshold)
		Else
			readerTabPageText = "Reader [source]"
		End If
		If readerTabPage.Text <> readerTabPageText Then
			readerTabPage.Text = readerTabPageText
		End If
	End Sub

	#End Region


	#Region "Process the barcode reader image"

	''' <summary>
	''' Preview of the barcode reader image processing is enabled/disabled.
	''' </summary>
    Private Sub showImageProcessing_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles showImageProcessingCheckBox.CheckedChanged
        UpdateImageInBarcodeReaderPictureBox()
    End Sub

	''' <summary>
	''' Eroding of the barcode reader image is enabled/disabled.
	''' </summary>
    Private Sub readerErode_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles readerErodeCheckBox.CheckedChanged
        If Not _isMainFormLoaded Then
            Return
        End If

        _barcodeReader.Settings.Erode = readerErodeCheckBox.Checked
        If _barcodeReader.Settings.Erode Then
            readerErodeCheckBox.ForeColor = Color.Red
        Else
            readerErodeCheckBox.ForeColor = Color.Black
        End If

        UpdateBarcodeReaderUI()

        If showImageProcessingCheckBox.Checked Then
            UpdateImageInBarcodeReaderPictureBox()
        End If
    End Sub

	''' <summary>
	''' Peas removing in the barcode reader image is enabled/disabled.
	''' </summary>
    Private Sub removePeas_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles removePeasCheckBox.CheckedChanged
        _barcodeReader.Settings.RemovePeas = removePeasCheckBox.Checked

        If showImageProcessingCheckBox.Checked Then
            UpdateImageInBarcodeReaderPictureBox()
        End If
    End Sub

	''' <summary>
	''' Color inverting in the barcode reader image is enabled/disabled.
	''' </summary>
    Private Sub invertColor_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles invertColorsCheckBox.CheckedChanged
        _barcodeReader.Settings.InvertImageColors = invertColorsCheckBox.Checked

        If showImageProcessingCheckBox.Checked Then
            UpdateImageInBarcodeReaderPictureBox()
        End If
    End Sub

	#End Region


	#Region "Barcode reader settings"

	''' <summary>
	''' Initializes the barcode reader settings UI from the barcode reader settings.
	''' </summary>
	Private Sub InitBarcodeReaderSettingsUI(settings As ReaderSettings)
		thresholdIterationsTrackBar.Maximum = ReaderSettings.MaxThresholdInterations
		If settings.ThresholdIterations > 1 Then
			thresholdIterationsTrackBar.Value = settings.ThresholdIterations
		Else
			thresholdIterationsTrackBar.Value = 8
		End If
		thresholdMinTrackBar.Value = settings.Threshold
		thresholdMaxTrackBar.Value = settings.ThresholdMax

		Select Case settings.ThresholdMode
			Case ThresholdMode.Automatic
				thresholdMethodAutoRadioButton.Checked = True
				Exit Select

			Case ThresholdMode.Iterations
				thresholdMethodIterationRadioButton.Checked = True
				Exit Select

			Case ThresholdMode.Manual
				thresholdMethodManualRadioButton.Checked = True
				Exit Select
		End Select

		automaticRecognitionCheckBox.Checked = settings.AutomaticRecognition

		readerErodeCheckBox.Checked = settings.Erode
		removePeasCheckBox.Checked = settings.RemovePeas
		invertColorsCheckBox.Checked = settings.InvertImageColors

		readerBarcodeTypes.UpdateUI()
		advancedReaderSettings.UpdateUI()

		UpdateBarcodeReaderUI()
	End Sub

	''' <summary>
	''' Initializes the barcode reader settings controls.
	''' </summary>
	Private Sub InitBarcodeReaderSettingsControls(settings As ReaderSettings)
		readerBarcodeTypes.SetBarcodeReaderSettings(settings)
		advancedReaderSettings.SetBarcodeReaderSettings(settings)
		minConfidenceEditor.SetBarcodeReaderSettings(settings)
		maxThreadsCountEditor.SetBarcodeReaderSettings(settings)
		scanDirectionEditor.SetBarcodeReaderSettings(settings)
		expectedBarcodesEditor.SetBarcodeReaderSettings(settings)
		scanIntervalEditor.SetBarcodeReaderSettings(settings)
	End Sub


	''' <summary>
	''' Initializes the barcode reader settings from UI.
	''' </summary>
	Private Sub InitBarcodeReaderSettings()
		_barcodeReader.Settings.AutomaticRecognition = automaticRecognitionCheckBox.Checked

		_barcodeReader.Settings.Erode = readerErodeCheckBox.Checked
		_barcodeReader.Settings.RemovePeas = removePeasCheckBox.Checked
		_barcodeReader.Settings.InvertImageColors = invertColorsCheckBox.Checked

		_barcodeReader.Settings.Threshold = thresholdMinTrackBar.Value
		If thresholdMethodIterationRadioButton.Checked Then
			' threshold interations method ON
			_barcodeReader.Settings.ThresholdMode = ThresholdMode.Iterations
			_barcodeReader.Settings.ThresholdIterations = thresholdIterationsTrackBar.Value
			_barcodeReader.Settings.ThresholdMin = thresholdMinTrackBar.Value
			_barcodeReader.Settings.ThresholdMax = thresholdMaxTrackBar.Value
		Else
			If thresholdMethodAutoRadioButton.Checked Then
				_barcodeReader.Settings.ThresholdMode = ThresholdMode.Automatic
			Else
				_barcodeReader.Settings.ThresholdMode = ThresholdMode.Manual
			End If
		End If
	End Sub

	''' <summary>
	''' Gets the default reader settings.
	''' </summary>
	Private Function GetDefaultReaderSettings() As ReaderSettings
		Dim settings As New ReaderSettings()
		settings.ScanBarcodeTypes = BarcodeType.Code39 Or BarcodeType.Code128 Or BarcodeType.EAN13 Or BarcodeType.UPCA
		settings.ScanDirection = ScanDirection.LeftToRight Or ScanDirection.RightToLeft Or ScanDirection.BottomToTop Or ScanDirection.TopToBottom
		settings.ThresholdIterations = 8
		settings.ThresholdMode = ThresholdMode.Automatic
		settings.MinConfidence = 95
		Dim processorCount As Integer = Environment.ProcessorCount
		settings.MaximalThreadsCount = processorCount + processorCount \ 2
		settings.CollectTestInformation = True
		settings.TryTransmitGS1Value = False
		Return settings
	End Function


	''' <summary>
	''' Automatic barcode recognition is enabled/disabled.
	''' </summary>
    Private Sub automaticRecognitionCheckBox_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles automaticRecognitionCheckBox.CheckedChanged
        _barcodeReader.Settings.AutomaticRecognition = automaticRecognitionCheckBox.Checked

        UpdateBarcodeReaderUI()
    End Sub


	#Region "Threshold settings"

	''' <summary>
	''' Automatic threshold method is selected.
	''' </summary>
    Private Sub thresholdMethodAutoRadioButton_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles thresholdMethodAutoRadioButton.CheckedChanged
        If Not _isMainFormLoaded Then
            Return
        End If

        _barcodeReader.Settings.ThresholdMode = ThresholdMode.Automatic

        UpdateBarcodeReaderUI()
    End Sub

	''' <summary>
	''' Manual threshold method is selected.
	''' </summary>
    Private Sub thresholdMethodManualRadioButton_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles thresholdMethodManualRadioButton.CheckedChanged
        If Not _isMainFormLoaded Then
            Return
        End If

        _barcodeReader.Settings.ThresholdMode = ThresholdMode.Manual

        UpdateBarcodeReaderUI()
    End Sub

	''' <summary>
	''' Iteration threshold method is selected.
	''' </summary>
    Private Sub thresholdMethodIterationRadioButton_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles thresholdMethodIterationRadioButton.CheckedChanged
        If Not _isMainFormLoaded Then
            Return
        End If

        _barcodeReader.Settings.ThresholdMode = ThresholdMode.Iterations

        thresholdMinTrackBar.Value = 250
        thresholdMaxTrackBar.Value = 500

        UpdateBarcodeReaderUI()
    End Sub


	''' <summary>
	''' Iteration count in the iteration threshold method is changed.
	''' </summary>
    Private Sub thresholdIterationsTrackBar_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles thresholdIterationsTrackBar.ValueChanged
        thresholdIterationGroupBox.Text = String.Format("Iteration count - {0}", thresholdIterationsTrackBar.Value)
    End Sub

	''' <summary>
	''' Value of (low) threshold is changed.
	''' </summary>
    Private Sub thresholdMinTrackBar_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles thresholdMinTrackBar.ValueChanged
        UpdateThresholdMinValue()
    End Sub

	''' <summary>
	''' Value of high threshold is changed.
	''' </summary>
    Private Sub thresholdMaxTrackBar_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles thresholdMaxTrackBar.ValueChanged
        UpdateThresholdMaxValue()
    End Sub


	''' <summary>
	''' Determines that thresholding is enabled.
	''' </summary>
	Private Function IsThresholdingEnabled() As Boolean
		Dim isBlackWhiteImage As Boolean = _barcodeReaderImage.PixelFormat <> System.Drawing.Imaging.PixelFormat.Format1bppIndexed
		Return isBlackWhiteImage OrElse automaticRecognitionCheckBox.Checked OrElse readerErodeCheckBox.Checked
	End Function


	''' <summary>
	''' Updates the (low) threshold value.
	''' </summary>
	Private Sub UpdateThresholdMinValue()
		Dim thresholdFormatString As String
		If thresholdMethodIterationRadioButton.Checked Then
			thresholdFormatString = "Low threshold - {0}"
		Else
			thresholdFormatString = "Threshold - {0}"
		End If
		thresholdGroupBox.Text = String.Format(thresholdFormatString, thresholdMinTrackBar.Value)

		If thresholdMethodManualRadioButton.Checked Then
			_barcodeReader.Settings.Threshold = thresholdMinTrackBar.Value
		Else
			_barcodeReader.Settings.ThresholdMin = thresholdMinTrackBar.Value
		End If

		_lastThresholdTrackBar = thresholdMinTrackBar

		If showImageProcessingCheckBox.Checked AndAlso Not _disableThreshold1ChangeEvent Then
			UpdateImageInBarcodeReaderPictureBox()
		End If
	End Sub

	''' <summary>
	''' Updates the high threshold value.
	''' </summary>
	Private Sub UpdateThresholdMaxValue()
		highThresholdGroupBox.Text = String.Format("High threshold - {0}", thresholdMaxTrackBar.Value)

		_barcodeReader.Settings.ThresholdMax = thresholdMaxTrackBar.Value

		_lastThresholdTrackBar = thresholdMaxTrackBar

		If showImageProcessingCheckBox.Checked Then
			UpdateImageInBarcodeReaderPictureBox()
		End If
	End Sub

	#End Region


	''' <summary>
	''' Barcode types for barcode recognition are changed.
	''' </summary>
	Private Sub ReaderBarcodeTypes_SettingsChanged(sender As Object, e As EventArgs)
		UpdateVisibilityOfDemoVersionRestrictionGroupBox()
	End Sub

	''' <summary>
	''' Updates visibility of demo version restriction group box.
	''' </summary>
	Private Sub UpdateVisibilityOfDemoVersionRestrictionGroupBox()
		Dim barcodeTypes As BarcodeType = _barcodeReader.Settings.ScanBarcodeTypes
		For Each subset As BarcodeSymbologySubset In _barcodeReader.Settings.ScanBarcodeSubsets
			barcodeTypes = barcodeTypes Or subset.BaseType
		Next
		Dim visible As Boolean = (barcodeTypes And BarcodeType.QR) <> 0 OrElse (barcodeTypes And BarcodeType.RSS14) <> 0 OrElse (barcodeTypes And BarcodeType.RSS14Stacked) <> 0 OrElse (barcodeTypes And BarcodeType.RSSExpanded) <> 0 OrElse (barcodeTypes And BarcodeType.RSSExpandedStacked) <> 0 OrElse (barcodeTypes And BarcodeType.RSSLimited) <> 0 OrElse (barcodeTypes And BarcodeType.IntelligentMail) <> 0
		demoVersionRestrictionsGroupBox.Visible = visible
	End Sub


	''' <summary>
	''' Resets the barcode reader settings.
	''' </summary>
    Private Sub ResetSettingsButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles resetSettingsButton.Click
        _barcodeReader.Settings = GetDefaultReaderSettings()

        InitBarcodeReaderSettingsControls(_barcodeReader.Settings)
        InitBarcodeReaderSettingsUI(_barcodeReader.Settings)
        UpdateVisibilityOfDemoVersionRestrictionGroupBox()
    End Sub


	''' <summary>
	''' Serializes the barcode reader settings.
	''' </summary>
	Private Sub SerializeBarcodeReaderSettings(settings As ReaderSettings, filename As String)
		Try
			Dim serializer As New XmlSerializer(GetType(ReaderSettings))
			Using stream As New FileStream(filename, FileMode.Create, FileAccess.Write)
				serializer.Serialize(stream, settings)
			End Using
		Catch
		End Try
	End Sub

	''' <summary>
	''' Deserializes the barcode reader settings from file.
	''' </summary>
	Private Function DeserializeBarcodeReaderSettings(filename As String) As ReaderSettings
		If File.Exists(filename) Then
			Try
				Dim serializer As New XmlSerializer(GetType(ReaderSettings))
				Using stream As New FileStream(filename, FileMode.Open, FileAccess.Read)
					Return DirectCast(serializer.Deserialize(stream), ReaderSettings)
				End Using
			Catch
				Return GetDefaultReaderSettings()
			End Try
		Else
			Return GetDefaultReaderSettings()
		End If
	End Function

	#End Region


	#Region "Read barcodes"

	''' <summary>
	''' Recognizes the barcodes in image.
	''' </summary>
    Private Sub readBarcodesButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles readBarcodesButton.Click
        ReadBarcodes()
    End Sub

	''' <summary>
	''' Showing of barcode recognition progress is enabled/disabled.
	''' </summary>
    Private Sub showProgressCheckBox_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles showProgressCheckBox.CheckedChanged
        If showProgressCheckBox.Checked Then
            AddHandler _barcodeReader.Progress, New EventHandler(Of BarcodeReaderProgressEventArgs)(AddressOf _barcodeReader_RecognizeProgress)
        Else
            RemoveHandler _barcodeReader.Progress, New EventHandler(Of BarcodeReaderProgressEventArgs)(AddressOf _barcodeReader_RecognizeProgress)
        End If
    End Sub

	''' <summary>
	''' Progress of barcode recognition is changed.
	''' </summary>
	Private Sub _barcodeReader_RecognizeProgress(sender As Object, e As BarcodeReaderProgressEventArgs)
		progressGroupBox.Text = String.Format("{0}%; {1} barcodes found", e.Progress, e.FoundBarcodes.Count)
		progressBar.Value = e.Progress
		If e.Progress = 100 Then
			progressGroupBox.Visible = False
			fileListGroupBox.Visible = True
			fileListGroupBox.Refresh()
			readBarcodesButton.Text = "Read barcodes"
			readBarcodesButton.Refresh()
		Else
			readBarcodesButton.Text = "Stop"
			fileListGroupBox.Visible = False
			progressGroupBox.Visible = True

			If e.Progress > 0 Then
				Application.DoEvents()
			End If

			If _stopReadBarcodes Then
				e.Cancel = True
			End If
		End If
	End Sub

	''' <summary>
	''' Reads barcodes from the image.
	''' </summary>
	Private Sub ReadBarcodes()
		If readBarcodesButton.Text = "Stop" Then
			_stopReadBarcodes = True
			Return
		End If

		If _barcodeReaderImage Is Nothing Then
			Return
		End If

		' change tab
		If tabControl.SelectedTab IsNot readerTabPage Then
			tabControl.SelectedTab = readerTabPage
		End If

		Dim tempBitmap As Bitmap = DirectCast(barcodeReaderPictureBox.Image, Bitmap)
		If barcodeReaderPictureBox.Image IsNot _barcodeReaderImage Then
			barcodeReaderPictureBox.Image = _barcodeReaderImage
		End If
		If tempBitmap IsNot _barcodeReaderImage Then
			tempBitmap.Dispose()
			tempBitmap = Nothing
		End If

		InitBarcodeReaderSettings()

		outputTextRichTextBox.Text = "Recognition..."
		outputTextRichTextBox.Refresh()

		If _isBarcodeReaderImageMarked Then
			_barcodeReaderImage.Dispose()
			OpenBarcodeReaderImageFromFile(_fileName)
			_isBarcodeReaderImageMarked = False
		End If

		_stopReadBarcodes = False

		Try
			_barcodeRecognitionResults = _barcodeReader.ReadBarcodes(_barcodeReaderImage)

			barcodeReaderResultsControl1.InterpretEciCharacters = advancedReaderSettings.InterpretEciCharacters
			barcodeReaderResultsControl1.RecognizedBarcodes = _barcodeRecognitionResults
			barcodeReaderResultsControl1.InvertBarcodeImage = _barcodeReader.Settings.InvertImageColors
		Catch e As Exception
			MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
			outputTextRichTextBox.Text = ""
			Return
		End Try

		If readBarcodesButton.Text = "Stop" Then
			readBarcodesButton.Text = "Read barcodes"
		End If

		_disableThreshold1ChangeEvent = True
		If thresholdMethodAutoRadioButton.Checked Then
			thresholdMinTrackBar.Value = _barcodeReader.Settings.Threshold
		End If
		_disableThreshold1ChangeEvent = False

		' extended info
		Dim c As Integer = 0
		For i As Integer = 0 To _barcodeRecognitionResults.Length - 1
			If _barcodeRecognitionResults(i).Confidence > 95 Then
				c += 1
			End If
		Next
		Dim barcodeRecognitionTimeInMilliseconds As Double = _barcodeReader.RecognizeTime.TotalMilliseconds
		Dim totalInfo As String = Nothing
		If _barcodeRecognitionResults.Length > 0 Then
			Dim barcodeRecognitionTimeInMillisecondsAsString As String
			If barcodeRecognitionTimeInMilliseconds <= Double.Epsilon Then
				barcodeRecognitionTimeInMillisecondsAsString = "<1"
			Else
				barcodeRecognitionTimeInMillisecondsAsString = barcodeRecognitionTimeInMilliseconds.ToString()
			End If
			totalInfo = String.Format("{0} barcode(s) found, {1} with confidence >95%, recognition time {2} ms.", _barcodeRecognitionResults.Length, c, barcodeRecognitionTimeInMillisecondsAsString)
		Else
			totalInfo = String.Format("No barcodes found({0} ms)." & vbCr & vbLf & vbCr & vbLf & "You should try to change barcode recognition settings, for example decrease scan interval, use advanced threshold mode, add new scan direction, etc if you are sure that image contains a barcode." & vbCr & vbLf & vbCr & vbLf, barcodeRecognitionTimeInMilliseconds)
			If Not automaticRecognitionCheckBox.Checked Then
				totalInfo += "Please try to use ""Automatic recognition"" mode if you have barcodes with low quality." & vbCr & vbLf & vbCr & vbLf
			End If
			totalInfo += vbCr & vbLf & "Please send image with barcode to support@vintasoft.com if you cannot recognize barcode - we will do the best to help you."
		End If

		' short info
		Dim sb As New StringBuilder()
		sb.Append(totalInfo)
		sb.Append(vbCr & vbLf)
		sb.Append(vbCr & vbLf)
		For i As Integer = 0 To _barcodeRecognitionResults.Length - 1
			sb.AppendLine(GetBarcodeInfo(i, _barcodeRecognitionResults(i)))
		Next

		outputTextRichTextBox.Text = sb.ToString()
		outputTextRichTextBox.Refresh()

		' bitmap, which must be displayed in picture box
		Dim bitmap As Bitmap
		' if image is big
		If IsLargeImage(_barcodeReaderImage) Then
			' picture box will display source image 
			bitmap = DirectCast(_barcodeReaderImage, Bitmap)
			_isBarcodeReaderImageMarked = _barcodeRecognitionResults.Length > 0
		Else
			' if picture box must contain processed image
			If showImageProcessingCheckBox.Checked Then
				' create the processed image from the source image
				bitmap = DirectCast(_barcodeReader.ProcessImage(_barcodeReaderImage), Bitmap)
			Else
				' get clone of source image
				bitmap = New Bitmap(_barcodeReaderImage)
			End If
		End If
		UpdateImageText()
		GC.Collect()

		' draws an information about found barcodes on the reader image
		DrawBarcodeInfoOnReaderImage(bitmap, _barcodeRecognitionResults)

		' shows the reader image in picture box
		barcodeReaderPictureBox.Image = bitmap
	End Sub

	''' <summary>
	''' Draws an information about found barcodes on the reader image.
	''' </summary>
	''' <param name="bitmap"></param>
	''' <param name="barcodeInfos"></param>
	Private Sub DrawBarcodeInfoOnReaderImage(bitmap As Bitmap, barcodeInfos As IBarcodeInfo())
		Using g As Graphics = Graphics.FromImage(bitmap)
			Dim brush As Brush = Brushes.Blue
			For i As Integer = 0 To barcodeInfos.Length - 1
				Dim inf As IBarcodeInfo = barcodeInfos(i)
				Dim p As New Pen(Color.Blue)
				If inf.Confidence > 95 OrElse inf.Confidence = ReaderSettings.ConfidenceNotAvailable Then
					If inf.BarcodeType = BarcodeType.UnknownLinear Then
						p.Color = Color.Red
					Else
						p.Color = Color.Green
					End If
					p.Width = 2
				Else
					If inf.Confidence <= 50 Then
						p.Color = Color.Red
					End If
				End If
				If inf.SymbolComponents IsNot Nothing Then
					Dim symbolComponentPen As New Pen(Color.FromArgb(192, Color.Blue), 2)
					For Each symbolComponentInfo As IBarcodeInfo In inf.SymbolComponents
						g.DrawPolygon(symbolComponentPen, symbolComponentInfo.Region.GetPoints())
					Next
				End If
				p.Color = Color.FromArgb(192, p.Color)
				g.FillPolygon(New SolidBrush(Color.FromArgb(48, p.Color)), inf.Region.GetPoints())
				g.DrawPolygon(p, inf.Region.GetPoints())

				Dim br As New SolidBrush(Color.Lime)
				If inf.ReadingQuality < 0.75 Then
					If inf.ReadingQuality >= 0.5 Then
						br.Color = Color.Yellow
					Else
						br.Color = Color.Red
					End If
				End If

				Dim barcodeTypeValue As String
				If TypeOf inf Is BarcodeSubsetInfo Then
					barcodeTypeValue = DirectCast(inf, BarcodeSubsetInfo).BarcodeSubset.Name
				Else
					barcodeTypeValue = inf.BarcodeType.ToString()
				End If

				br.Color = Color.FromArgb(192, br.Color)
				g.FillRectangle(br, inf.Region.LeftTop.X, inf.Region.LeftTop.Y, p.Width + 2, p.Width + 2)
				inf.ShowNonDataFlagsInValue = True
				Using gp As GraphicsPath = New System.Drawing.Drawing2D.GraphicsPath()
					g.DrawString(String.Format("[{0}] {1}: {2}", i + 1, barcodeTypeValue, inf.Value), New Font("Courier New", 8), brush, inf.Region.LeftTop.X, inf.Region.LeftTop.Y - 20)
                End Using

                If TypeOf inf Is AztecInfo Then
                    p = New Pen(Color.Lime, 1)
                    Dim delta As Single = CSng(Math.Max(DirectCast(inf, BarcodeInfo2D).CellWidth, DirectCast(inf, BarcodeInfo2D).CellHeight)) / 2
                    Dim center As PointF = DirectCast(inf, AztecInfo).BulleyeCenter
                    g.DrawLine(p, New PointF(center.X - delta, center.Y - delta), New PointF(center.X + delta, center.Y + delta))
                    g.DrawLine(p, New PointF(center.X - delta, center.Y + delta), New PointF(center.X + delta, center.Y - delta))
                End If

			Next
		End Using
	End Sub

	#End Region


	#Region "Barcode reader results"

	''' <summary>
	''' Gets the barcode value as string.
	''' </summary>
	Private Function GetBarcodeInfo(index As Integer, info As IBarcodeInfo) As String
		info.ShowNonDataFlagsInValue = True

		Dim value As String
		If info.BarcodeInfoClass = BarcodeInfoClass.Barcode2D AndAlso advancedReaderSettings.InterpretEciCharacters Then
			value = EciCharacterDecoder.Decode(info.ValueItems)
		Else
			value = info.Value
		End If

		If (info.BarcodeType And BarcodeType.UPCE) <> 0 Then
			value += String.Format(" (UPC-E: {0})", TryCast(info, UPCEANInfo).UPCEValue)
		End If

		If (info.BarcodeType And BarcodeType.UPCA) <> 0 Then
			value += String.Format(" (UPC-A: {0})", TryCast(info, UPCEANInfo).UPCAValue)
		End If


		Dim confidence As String
		If info.Confidence = ReaderSettings.ConfidenceNotAvailable Then
			confidence = "N/A"
		Else
			confidence = Math.Round(info.Confidence).ToString() & "%"
		End If

		If TypeOf info Is BarcodeSubsetInfo Then
			value = String.Format("{0}{1}Base value: {2}", RemoveSpecialCharacters(value), Environment.NewLine, RemoveSpecialCharacters(DirectCast(info, BarcodeSubsetInfo).BaseBarcodeInfo.Value))
		Else
			value = RemoveSpecialCharacters(value)
		End If

		Dim barcodeTypeValue As String
		If TypeOf info Is BarcodeSubsetInfo Then
			barcodeTypeValue = DirectCast(info, BarcodeSubsetInfo).BarcodeSubset.ToString()
		Else
			barcodeTypeValue = info.BarcodeType.ToString()
		End If

		Dim result As New StringBuilder()
		result.AppendLine(String.Format("[{0}:{1}]", index + 1, barcodeTypeValue))
		result.AppendLine(String.Format("Value: {0}", value))
		result.AppendLine(String.Format("Confidence: {0}", confidence))
		result.AppendLine(String.Format("Reading quality: {0}", info.ReadingQuality))
		result.AppendLine(String.Format("Threshold: {0}", info.Threshold))
		result.AppendLine(String.Format("Region: {0}", info.Region))
		Return result.ToString()
	End Function

	''' <summary>
	''' Removes special characters from the text.
	''' </summary>
	Private Function RemoveSpecialCharacters(text As String) As String
		Dim sb As New StringBuilder()
		If text IsNot Nothing Then
			For i As Integer = 0 To text.Length - 1
				If text(i) >= " "C OrElse text(i) = ControlChars.Lf OrElse text(i) = ControlChars.Cr OrElse text(i) = ControlChars.Tab Then
					sb.Append(text(i))
				Else
					sb.Append("?"C)
				End If
			Next
		End If
		Return sb.ToString()
	End Function

	''' <summary>
	''' Clears the barcode reader results.
	''' </summary>
	Private Sub ClearBarcodeRecognitionResults()
		_barcodeRecognitionResults = Nothing

		barcodeReaderResultsControl1.RecognizedBarcodes = Nothing
		barcodeReaderResultsControl1.BarcodeInfoIndex = 0
	End Sub

	#End Region

	#End Region


	#Region "Barcode writer"

	''' <summary>
	''' Creates the image with barcode.
	''' </summary>
    Private Sub createWriterImageButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles createWriterImageButton.Click
        If barcodeWriterSettingsControl1.EncodeValue() Then
            WriteBarcode()
        End If
    End Sub

	''' <summary>
	''' Saves image with barcode.
	''' </summary>
    Private Sub saveImageButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles saveWriterImageButton.Click
        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            writerPictureBox.Image.Save(saveFileDialog1.FileName)
        End If
    End Sub

	''' <summary>
	''' Reads barcodes from image with barcode, which was created by the barcode writer.
	''' </summary>
    Private Sub readBarcodesInWriterButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles readBarcodeFromWriterImageButton.Click
        If writerPictureBox.Image Is Nothing Then
            Return
        End If

        If _barcodeReaderSourceImage IsNot writerPictureBox.Image Then
            CloseBarcodeReaderImage()
        End If

        _fileName = "from Barcode Writer"
        _barcodeReaderSourceImage = writerPictureBox.Image
        OpenBarcodeReaderImage(writerPictureBox.Image)
        _barcodeReader.Settings.ScanBarcodeTypes = _barcodeReader.Settings.ScanBarcodeTypes Or _barcodeWriter.Settings.Barcode
        _barcodeReader.Settings.EnableTelepenNumericMode = _barcodeWriter.Settings.EnableTelepenNumericMode
        _barcodeReader.Settings.OptionalCheckSum = _barcodeWriter.Settings.OptionalCheckSum
        _barcodeReader.Settings.AustralianPostCustomerInfoFormat = _barcodeWriter.Settings.AustralianPostCustomerInfoFormat
        _barcodeReader.Settings.MSIChecksum = _barcodeWriter.Settings.MSIChecksum
        If barcodeWriterSettingsControl1.SelectedBarcodeSubset IsNot Nothing Then
            If Not _barcodeReader.Settings.ScanBarcodeSubsets.Contains(barcodeWriterSettingsControl1.SelectedBarcodeSubset) Then
                _barcodeReader.Settings.ScanBarcodeSubsets.Add(barcodeWriterSettingsControl1.SelectedBarcodeSubset)
            End If
        End If
        advancedReaderSettings.InterpretEciCharacters = barcodeWriterSettingsControl1.EncodeEciCharacter
        readerBarcodeTypes.UpdateUI()
        advancedReaderSettings.UpdateUI()

        ReadBarcodes()
    End Sub

	''' <summary>
	''' Clears the image with barcode.
	''' </summary>
    Private Sub clearWriterImageButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles clearWriterImageButton.Click
        ClearWriterImage()
    End Sub

	''' <summary>
	''' Barcode writer settings are changed.
	''' </summary>
	Private Sub WriterSettings_Changed(sender As Object, e As EventArgs)
		If Not _barcodeWriting Then
			WriteBarcode()
		End If
	End Sub

	''' <summary>
	''' Creates image with barcode.
	''' </summary>
	Private Sub WriteBarcode()
		If barcodeWriterSettingsControl1.SelectedBarcodeSubset Is Nothing Then
			barcodeWriterBarcodeInformation.Text = BarcodesInformation.GetInformation(_barcodeWriter.Settings.Barcode)
		Else
			barcodeWriterBarcodeInformation.Text = BarcodesInformation.GetInformation(barcodeWriterSettingsControl1.SelectedBarcodeSubset)
		End If

		If Not _isMainFormLoaded Then
			Return
		End If
		_barcodeWriting = True
		Try
			If barcodeWriterSettingsControl1.SelectedBarcodeSubset IsNot Nothing Then
				If Not barcodeWriterSettingsControl1.EncodeValue() Then
					Return
				End If
			End If
			barcodeWriterErrorText.Visible = False
			writerPictureBox.Image = _barcodeWriter.GetBarcodeAsBitmap()
			barcodeWriterSettingsControl1.UpdateBarcodeWriterSettings()
			barcodeWriterSettingsControl1.BarcodeImage = writerPictureBox.Image
		Catch err As WriterSettingsException
			ClearWriterImage()
			barcodeWriterErrorText.Visible = True
			barcodeWriterErrorText.Text = String.Format("Wrong writer settings:" & vbLf & vbLf & "{0}", err.Message)
			Return
		Catch e As Exception
			MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
			Return
		Finally
			_barcodeWriting = False
		End Try
		saveWriterImageButton.Enabled = InlineAssignHelper(readBarcodeFromWriterImageButton.Enabled, InlineAssignHelper(clearWriterImageButton.Enabled, True))
	End Sub


    Private Sub barcodeWriterSettingsControl1_WriterException(ByVal sender As Object, ByVal e As ExceptionEventArgs) Handles barcodeWriterSettingsControl1.WriterException
        If barcodeWriterSettingsControl1.SelectedBarcodeSubset Is Nothing Then
            barcodeWriterBarcodeInformation.Text = BarcodesInformation.GetInformation(_barcodeWriter.Settings.Barcode)
        Else
            barcodeWriterBarcodeInformation.Text = BarcodesInformation.GetInformation(barcodeWriterSettingsControl1.SelectedBarcodeSubset)
        End If

        ClearWriterImage()
        barcodeWriterErrorText.Visible = True
        barcodeWriterErrorText.Text = String.Format("Wrong writer settings:" & vbLf & vbLf & "{0}", e.Exception.Message)
    End Sub

	''' <summary>
	''' Clears the image with barcode.
	''' </summary>
	Private Sub ClearWriterImage()
		If writerPictureBox.Image IsNot Nothing Then
			readBarcodeFromWriterImageButton.Enabled = False
			saveWriterImageButton.Enabled = False
			clearWriterImageButton.Enabled = False

			If _barcodeReaderSourceImage Is writerPictureBox.Image Then
				CloseBarcodeReaderImage()
			End If

			writerPictureBox.Image.Dispose()
			writerPictureBox.Image = Nothing
		End If
	End Sub
	Private Shared Function InlineAssignHelper(Of T)(ByRef target As T, value As T) As T
		target = value
		Return value
	End Function

	#End Region


	#End Region

End Class
