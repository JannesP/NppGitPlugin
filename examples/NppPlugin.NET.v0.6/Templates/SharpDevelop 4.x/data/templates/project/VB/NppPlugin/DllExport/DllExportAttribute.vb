Imports System
Imports System.Runtime.InteropServices

Namespace NppPlugin.DllExport
	<AttributeUsage(AttributeTargets.Method, AllowMultiple := False)> _
	Partial Class DllExportAttribute
		Inherits Attribute
		Public Sub New()
		End Sub
		Public Sub New(exportName As String)
			Me.New(exportName, CallingConvention.StdCall)
		End Sub
		Public Sub New(exportName__1 As String, callingConvention__2 As CallingConvention)
			ExportName = exportName__1
			CallingConvention = callingConvention__2
		End Sub
		Private _callingConvention As CallingConvention
		Public Property CallingConvention() As CallingConvention
			Get
				Return _callingConvention
			End Get
			Set
				_callingConvention = value
			End Set
		End Property
		Private _exportName As String
		Public Property ExportName() As String
			Get
				Return _exportName
			End Get
			Set
				_exportName = value
			End Set
		End Property
	End Class
End Namespace
