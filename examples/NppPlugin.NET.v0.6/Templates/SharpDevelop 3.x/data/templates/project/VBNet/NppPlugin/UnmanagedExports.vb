Imports System
Imports System.Runtime.InteropServices
Imports NppPluginNET
Imports NppPlugin.DllExport

Namespace ${ProjectName}
    Friend Class UnmanagedExports
        <DllExport(CallingConvention:=CallingConvention.Cdecl)> _
        Private Shared Function isUnicode() As Boolean
            Return True
        End Function

        <DllExport(CallingConvention:=CallingConvention.Cdecl)> _
        Private Shared Sub setInfo(ByVal notepadPlusData As NppData)
            PluginBase.nppData = notepadPlusData
            Main.CommandMenuInit()
        End Sub

        <DllExport(CallingConvention:=CallingConvention.Cdecl)> _
        Private Shared Function getFuncsArray(ByRef nbF As Integer) As IntPtr
            nbF = PluginBase._funcItems.Items.Count
            Return PluginBase._funcItems.NativePointer
        End Function

        <DllExport(CallingConvention:=CallingConvention.Cdecl)> _
        Private Shared Function messageProc(ByVal Message As UInteger, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As UInteger
            Return 1
        End Function

        Shared _ptrPluginName As IntPtr = IntPtr.Zero
        <DllExport(CallingConvention:=CallingConvention.Cdecl)> _
        Private Shared Function getName() As IntPtr
            If _ptrPluginName = IntPtr.Zero Then
                _ptrPluginName = Marshal.StringToHGlobalUni(Main.PluginName)
            End If
            Return _ptrPluginName
        End Function

        <DllExport(CallingConvention:=CallingConvention.Cdecl)> _
        Private Shared Sub beNotified(ByVal notifyCode As IntPtr)
            Dim nc As SCNotification = CType(Marshal.PtrToStructure(notifyCode, GetType(SCNotification)), SCNotification)
            If nc.nmhdr.code = CUInt(NppMsg.NPPN_TBMODIFICATION) Then
                PluginBase._funcItems.RefreshItems()
                Main.SetToolBarIcon()
            ElseIf nc.nmhdr.code = CUInt(NppMsg.NPPN_SHUTDOWN) Then
                Main.PluginCleanUp()
                Marshal.FreeHGlobal(_ptrPluginName)
            End If
        End Sub
    End Class
End Namespace
