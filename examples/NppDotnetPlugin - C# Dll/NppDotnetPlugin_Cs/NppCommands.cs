using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace NppDotnetPlugin_Cs
{
    class NppCommands
    {
        private NppData moNppData = null;

        public NppCommands(NppData oNppData)
        {
            moNppData = oNppData;
        }

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        public static extern IntPtr SendMessage(int hwnd, uint wMsg, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        public static extern int SendMessage(int hwnd, uint wMsg, int wParam, string lParam);

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        public static extern int SendMessage(int hwnd, uint wMsg, int wParam, out int lParam);

        public IntPtr GetCurrentScintillaHandle()
        {
            int iCurrentEdit = 0;
            SendMessage(moNppData.NppHandle.ToInt32(), NppConst.WM_GETCURRENTSCINTILLA, 0, out iCurrentEdit);
            return (iCurrentEdit == 0) ? moNppData.ScintillaMainHandle : moNppData.ScintillaSecondHandle;
        }


        #region Scintilla commands
        public void ScintillaReplaceSelection(IntPtr oScintillaHandle, string sText)
        {
            SendMessage(oScintillaHandle.ToInt32(), NppConst.SCI_REPLACESEL, 0, sText);
        }
        #endregion


    }
}
