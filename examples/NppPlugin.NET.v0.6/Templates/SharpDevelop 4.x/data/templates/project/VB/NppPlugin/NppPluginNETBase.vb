Imports System

Namespace NppPluginNET
	Friend Class PluginBase
		#Region " Fields "
		Friend Shared nppData As NppData
		Friend Shared _funcItems As New FuncItems()
		#End Region

		#Region " Helper "
		Friend Shared Sub SetCommand(index As Integer, commandName As String, functionPointer As NppFuncItemDelegate)
			SetCommand(index, commandName, functionPointer, New ShortcutKey(), False)
		End Sub
		Friend Shared Sub SetCommand(index As Integer, commandName As String, functionPointer As NppFuncItemDelegate, shortcut As ShortcutKey)
			SetCommand(index, commandName, functionPointer, shortcut, False)
		End Sub
		Friend Shared Sub SetCommand(index As Integer, commandName As String, functionPointer As NppFuncItemDelegate, checkOnInit As Boolean)
			SetCommand(index, commandName, functionPointer, New ShortcutKey(), checkOnInit)
		End Sub
		Friend Shared Sub SetCommand(index As Integer, commandName As String, functionPointer As NppFuncItemDelegate, shortcut As ShortcutKey, checkOnInit As Boolean)
			Dim funcItem As New FuncItem()
			funcItem._cmdID = index
			funcItem._itemName = commandName
			If functionPointer IsNot Nothing Then
				funcItem._pFunc = New NppFuncItemDelegate(AddressOf functionPointer.Invoke)
			End If
			If shortcut._key <> 0 Then
				funcItem._pShKey = shortcut
			End If
			funcItem._init2Check = checkOnInit
			_funcItems.Add(funcItem)
		End Sub

		Friend Shared Function GetCurrentScintilla() As IntPtr
			Dim curScintilla As Integer
			Win32.SendMessage(nppData._nppHandle, NppMsg.NPPM_GETCURRENTSCINTILLA, 0, curScintilla)
			If (curScintilla = 0) Then
				Return nppData._scintillaMainHandle
			Else
				Return nppData._scintillaSecondHandle
			End If
		End Function
		#End Region
	End Class
End Namespace
