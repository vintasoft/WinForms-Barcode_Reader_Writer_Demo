Imports System.Collections.Generic
Imports System.Text

''' <summary>
''' Exception event args.
''' </summary>
Public Class ExceptionEventArgs
	Inherits EventArgs
	''' <summary>
	''' Initializes a new instance of the <see cref="ExceptionEventArgs"/> class.
	''' </summary>
	''' <param name="ex">The exception.</param>
	Public Sub New(ex As Exception)
		_exception = ex
	End Sub


	Private _exception As Exception
	''' <summary>
	''' Gets the exception.
	''' </summary>
	Public ReadOnly Property Exception() As Exception
		Get
			Return _exception
		End Get
	End Property
End Class

