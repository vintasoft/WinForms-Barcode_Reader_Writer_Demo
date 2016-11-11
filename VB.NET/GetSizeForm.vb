Imports System.Globalization
Imports System.Windows.Forms
Imports Vintasoft.Barcode

Public Partial Class GetSizeForm
	Inherits Form

	#Region "Constructors"

	Public Sub New(variable As String, value As Single, dpi As Integer, units As UnitOfMeasure)
		InitializeComponent()
		cbUnits.Items.Add(UnitOfMeasure.Pixels)
		cbUnits.Items.Add(UnitOfMeasure.Inches)
		cbUnits.Items.Add(UnitOfMeasure.Centimeters)
		cbUnits.Items.Add(UnitOfMeasure.Millimeters)
		cbUnits.SelectedItem = units
		variableValue.Text = value.ToString(CultureInfo.InvariantCulture)
		dpiValue.Value = dpi
		Text = String.Format(Text, variable)
		labelSize.Text = String.Format(labelSize.Text, variable)
		_dpi = dpi
		_value = value
		_units = units
	End Sub



	#End Region



	#Region "Properties"

	Private _value As Single
	Friend ReadOnly Property Value() As Single
		Get
			Return _value
		End Get
	End Property

	Private _dpi As Integer
	Friend ReadOnly Property Resolution() As Integer
		Get
			Return _dpi
		End Get
	End Property

	Private _units As UnitOfMeasure
	Friend ReadOnly Property Units() As UnitOfMeasure
		Get
			Return _units
		End Get
	End Property

	#End Region



	#Region "Methods"

    Private Sub buttonOK_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonOK.Click
        _units = DirectCast(cbUnits.SelectedItem, UnitOfMeasure)
        _dpi = CInt(Math.Truncate(dpiValue.Value))
        _value = Single.Parse(variableValue.Text.Replace(","c, "."c), CultureInfo.InvariantCulture)
        DialogResult = DialogResult.OK
        Close()
    End Sub

    Private Sub buttonCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonCancel.Click
        DialogResult = DialogResult.Cancel
        Close()
    End Sub

	#End Region

End Class
