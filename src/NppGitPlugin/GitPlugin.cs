using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows;
using System.Windows.Forms;
using NppGitPlugin.NppPluginLib;
using NppGitPlugin.Properties;
using NppGitPlugin.Utility;
using NppGitPlugin.Views;
using MessageBox = System.Windows.Forms.MessageBox;

namespace NppGitPlugin
{
    class GitPlugin : NppPluginBase
    {
        public static GitPlugin Instance => _instance.Value;
        private static Lazy<GitPlugin> _instance = new Lazy<GitPlugin>(() => new GitPlugin());

        private GitPlugin()
        {
            UnmanagedEvents.BeNotified += UnmanagedEvents_BeNotified;
            UnmanagedEvents.SetInfo += UnmanagedEvents_SetInfo;
        }

        private void UnmanagedEvents_SetInfo(object sender, EventArgs e)
        {
            CommandMenuInit();
        }

        private void UnmanagedEvents_BeNotified(object sender, UnmanagedEvents.NppNotifyEventArgs e)
        {
            Trace.TraceInformation($"BeNotified: {((NppMsg)e.Notification.nmhdr.code).ToString()}");
            if (e.Notification.nmhdr.code == (uint)NppMsg.NPPN_TBMODIFICATION)
            {
                _funcItems.RefreshItems();
                SetToolBarIcon();
            }
            else if (e.Notification.nmhdr.code == (uint)NppMsg.NPPN_SHUTDOWN)
            {
                PluginCleanUp();
            }
        }

        #region " Fields "
        public const string PluginName = "GitPlugin";
        private string _iniFilePath = null;
        private readonly Bitmap _gitBitmap = Resources.git_iconx16;
        private Icon _gitIcon;
        private Form _gitWindow;

        private int _idCommandShowGitGui = -1;
        #endregion

        #region " Startup/CleanUp "
        private void CommandMenuInit()
        {
            // Initialization of your plugin commands
            // You should fill your plugins commands here

	        // get path of plugin configuration
            StringBuilder sbIniFilePath = new StringBuilder(Win32.MAX_PATH);
            Win32.SendMessage(nppData._nppHandle, NppMsg.NPPM_GETPLUGINSCONFIGDIR, Win32.MAX_PATH, sbIniFilePath);
            _iniFilePath = sbIniFilePath.ToString();

	        // if config path doesn't exist, we create it
            if (!Directory.Exists(_iniFilePath))
	        {
                Directory.CreateDirectory(_iniFilePath);
	        }
	        // make your plugin config file full file path name
            _iniFilePath = Path.Combine(_iniFilePath, PluginName + ".ini");

            // with function :
            // SetCommand(int index,                            // zero based number to indicate the order of command
            //            string commandName,                   // the command name that you want to see in plugin menu
            //            NppFuncItemDelegate functionPointer,  // the symbol of function (function pointer) associated with this command. The body should be defined below. See Step 4.
            //            ShortcutKey *shortcut,                // optional. Define a shortcut to trigger this command
            //            bool check0nInit                      // optional. Make this menu item be checked visually
            //            );
            SetCommand(0, "Hello Notepad++", Hello);

            SetCommand(1, "Show Git GUI", ShowGitGui);
            _idCommandShowGitGui = 1;

        }
        private void SetToolBarIcon()
        {
            toolbarIcons tbIcons = new toolbarIcons();
            tbIcons.hToolbarBmp = _gitBitmap.GetHbitmap();
            IntPtr pTbIcons = Marshal.AllocHGlobal(Marshal.SizeOf(tbIcons));
            Marshal.StructureToPtr(tbIcons, pTbIcons, false);
            Win32.SendMessage(nppData._nppHandle, NppMsg.NPPM_ADDTOOLBARICON, _funcItems.Items[_idCommandShowGitGui]._cmdID, pTbIcons);
            Marshal.FreeHGlobal(pTbIcons);
        }
        private void PluginCleanUp()
        {
	        //save settings
        }
        #endregion

        #region " Menu functions "

        private void Hello()
        {
            MessageBox.Show("Test successful.");
        }

        private void ShowGitGui()
        {
            if (_gitWindow == null)
            {
                _gitWindow = new DockableGitForm();
                _gitWindow.Show();
                _gitIcon = Icon.FromHandle(_gitBitmap.GetHicon());

                NppTbData nppTbData = new NppTbData();
                nppTbData.hClient = _gitWindow.Handle;
                nppTbData.pszName = "Current Git Status";
                nppTbData.dlgID = _idCommandShowGitGui;
                nppTbData.uMask = NppTbMsg.DWS_DF_CONT_RIGHT | NppTbMsg.DWS_ICONTAB | NppTbMsg.DWS_ICONBAR;
                nppTbData.hIconTab = (uint) _gitIcon.Handle;
                nppTbData.pszModuleName = PluginName;
                IntPtr ptrNppTbData = Marshal.AllocHGlobal(Marshal.SizeOf(nppTbData));
                Marshal.StructureToPtr(nppTbData, ptrNppTbData, false);

                Win32.SendMessage(nppData._nppHandle, NppMsg.NPPM_DMMREGASDCKDLG, 0, ptrNppTbData);
                Win32.SendMessage(nppData._nppHandle, NppMsg.NPPM_SETMENUITEMCHECK,
                    _funcItems.Items[_idCommandShowGitGui]._cmdID, 1);
            }
            else
            {
                if (_gitWindow.Visible)
                {
                    Win32.SendMessage(nppData._nppHandle, NppMsg.NPPM_DMMHIDE, 0, _gitWindow.Handle);
                    Win32.SendMessage(nppData._nppHandle, NppMsg.NPPM_SETMENUITEMCHECK, _funcItems.Items[_idCommandShowGitGui]._cmdID, 0);
                }
                else
                {
                    Win32.SendMessage(nppData._nppHandle, NppMsg.NPPM_DMMSHOW, 0, _gitWindow.Handle);
                    Win32.SendMessage(nppData._nppHandle, NppMsg.NPPM_SETMENUITEMCHECK, _funcItems.Items[_idCommandShowGitGui]._cmdID, 1);
                }
            }
            
            
        }

        #endregion
    }
}   
