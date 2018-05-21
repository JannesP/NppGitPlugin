Imports System
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Windows.Forms
Imports NppPluginNET

Namespace ${ProjectName}
    Friend Class Main
        #Region " Fields "
        Friend Const PluginName As String = "${ProjectName}"
        Shared iniFilePath As String = Nothing
        Shared someSetting As Boolean = False
        Shared frmMyDlg As frmMyDlg = Nothing
        Shared idMyDlg As Integer = -1
        Shared tbBmp As Bitmap = My.Resources.star
        Shared tbBmp_tbTab As Bitmap = My.Resources.star_bmp
        Shared tbIcon As Icon = Nothing
        #End Region

        #Region " StartUp/CleanUp "
        Friend Shared Sub CommandMenuInit()
            Dim sbIniFilePath As New StringBuilder(Win32.MAX_PATH)
            Win32.SendMessage(PluginBase.nppData._nppHandle, NppMsg.NPPM_GETPLUGINSCONFIGDIR, Win32.MAX_PATH, sbIniFilePath)
            iniFilePath = sbIniFilePath.ToString()
            If Not Directory.Exists(iniFilePath) Then
                Directory.CreateDirectory(iniFilePath)
            End If
            iniFilePath = Path.Combine(iniFilePath, PluginName & ".ini")
            someSetting = (NppPluginNET.Win32.GetPrivateProfileInt("SomeSection", "SomeKey", 0, iniFilePath) <> 0)

            PluginBase.SetCommand(0, "MyMenuCommand", AddressOf myMenuFunction, New ShortcutKey(False, False, False, Keys.None))
            PluginBase.SetCommand(1, "MyDockableDialog", AddressOf myDockableDialog)
            idMyDlg = 1
        End Sub
        Friend Shared Sub SetToolBarIcon()
            Dim tbIcons As New toolbarIcons()
            tbIcons.hToolbarBmp = tbBmp.GetHbitmap()
            Dim pTbIcons As IntPtr = Marshal.AllocHGlobal(Marshal.SizeOf(tbIcons))
            Marshal.StructureToPtr(tbIcons, pTbIcons, False)
            Win32.SendMessage(PluginBase.nppData._nppHandle, NppMsg.NPPM_ADDTOOLBARICON, PluginBase._funcItems.Items(idMyDlg)._cmdID, pTbIcons)
            Marshal.FreeHGlobal(pTbIcons)
        End Sub
        Friend Shared Sub PluginCleanUp()
            If (someSetting) Then
                Win32.WritePrivateProfileString("SomeSection", "SomeKey", "1", iniFilePath)
            Else
                Win32.WritePrivateProfileString("SomeSection", "SomeKey", "0", iniFilePath)
            End If
        End Sub
        #End Region

        #Region " Menu functions "
        Friend Shared Sub myMenuFunction()
            MessageBox.Show("Hello N++!")
        End Sub
        Friend Shared Sub myDockableDialog()
            If frmMyDlg Is Nothing Then
                frmMyDlg = New frmMyDlg()

                Using newBmp As New Bitmap(16, 16)
                    Dim g As Graphics = Graphics.FromImage(newBmp)
                    Dim colorMap As ColorMap() = New ColorMap(0) {}
                    colorMap(0) = New ColorMap()
                    colorMap(0).OldColor = Color.Fuchsia
                    colorMap(0).NewColor = Color.FromKnownColor(KnownColor.ButtonFace)
                    Dim attr As New ImageAttributes()
                    attr.SetRemapTable(colorMap)
                    g.DrawImage(tbBmp_tbTab, New Rectangle(0, 0, 16, 16), 0, 0, 16, 16, _
                     GraphicsUnit.Pixel, attr)
                    tbIcon = Icon.FromHandle(newBmp.GetHicon())
                End Using

                Dim _nppTbData As New NppTbData()
                _nppTbData.hClient = frmMyDlg.Handle
                _nppTbData.pszName = "My dockable dialog"
                _nppTbData.dlgID = idMyDlg
                _nppTbData.uMask = NppTbMsg.DWS_DF_CONT_RIGHT Or NppTbMsg.DWS_ICONTAB Or NppTbMsg.DWS_ICONBAR
                _nppTbData.hIconTab = CUInt(tbIcon.Handle)
                _nppTbData.pszModuleName = PluginName
                Dim _ptrNppTbData As IntPtr = Marshal.AllocHGlobal(Marshal.SizeOf(_nppTbData))
                Marshal.StructureToPtr(_nppTbData, _ptrNppTbData, False)

                Win32.SendMessage(PluginBase.nppData._nppHandle, NppMsg.NPPM_DMMREGASDCKDLG, 0, _ptrNppTbData)
            Else
                Win32.SendMessage(PluginBase.nppData._nppHandle, NppMsg.NPPM_DMMSHOW, 0, frmMyDlg.Handle)
            End If
        End Sub
        #End Region
    End Class
End Namespace
