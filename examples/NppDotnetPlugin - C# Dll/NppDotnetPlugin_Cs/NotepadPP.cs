using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Runtime.InteropServices;

namespace NppDotnetPlugin_Cs
{
    [Guid("03AD5D2D-2AFD-439f-8713-A4EC0705B4D9")]    
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    public interface INppPlugin
    {
        void DllMain(ulong iReasonForCall);
        void insertCurrentFullPath();
        void insertCurrentFileName();
        void insertCurrentDirectory();
        void insertShortDateTime();
        void insertLongDateTime();
        void getFileNamesDemo();
        

        //5 mandatory Methods
        void setInfo(NppData oNppData);
        void getName([MarshalAs(UnmanagedType.LPStr)]out string sName);

        void beNotified(SCNotification oNotification);
        void messageProc(uint Message, IntPtr wParam, IntPtr lParam);
        //void getFuncsArray(out int iLen, [MarshalAs(UnmanagedType.LPArray,ArraySubType=UnmanagedType.LPStruct)] out IntPtr[] oTab);
        void getFuncsArray(out int iLen, [MarshalAs(UnmanagedType.LPArray)] out IntPtr[] oTab);
        
    }

    [ClassInterface(ClassInterfaceType.None)]
    [Guid("0490E147-F2D2-4909-A4B8-3533D2F264D0")]
    public class NppPlugin : INppPlugin
    {

        private NppData moNppData;
        //private int moNbFunc = 10;
        private List<FuncItem> moTab = new List<FuncItem>();
        private IntPtr[] moTabIntPtr = null;
        private NppCommands moNppCommands = null;


        // Need a public default constructor for COM Interop.
        public NppPlugin() {
            //moTab = new FuncItem[moNbFunc];
            //moTabIntPtr = new IntPtr[moNbFunc];
        }


        ~NppPlugin()
        {
            //destructor
            foreach (IntPtr oElt in moTabIntPtr)
            {
                if (oElt != null)
                {
                    Marshal.FreeCoTaskMem(oElt);
                }
            }
        }

        #region Mapping of user32.dll
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        public static extern IntPtr SendMessage(
            int hwnd, uint wMsg, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        public static extern int SendMessage(
            int hwnd, uint wMsg, int wParam, string lParam);

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        public static extern int SendMessage(
            int hwnd, uint wMsg, int wParam, out int lParam);

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        public static extern int GetNbFiles(
            int hwnd, uint wMsg, int wParam, int lParam);

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        public static extern int GetFileNames(
            int hwnd, uint wMsg, 
            [MarshalAs(UnmanagedType.LPArray)]IntPtr[] wParam, 
            int lParam);

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        public static extern int SendMessage(
            int hwnd, uint wMsg, int wParam, StringBuilder lParam);

        #endregion

        #region Plugin functionnalities


        private int getCurrentHScintilla(int currentEdit){
            return (currentEdit == 0) ? moNppData.ScintillaMainHandle.ToInt32() : moNppData.ScintillaSecondHandle.ToInt32();
        }

        private void insertString(string sText){
            int currentEdit = 0;
            SendMessage(moNppData.NppHandle.ToInt32(), NppConst.WM_GETCURRENTSCINTILLA, 0, out currentEdit);
            SendMessage(getCurrentHScintilla(currentEdit), NppConst.SCI_REPLACESEL, 0, sText);
        }

        private void insertCurrentPath(uint which){
            try
            {
                uint msg = NppConst.WM_GET_FULLCURRENTPATH;
                if (which == NppConst.FILE_NAME)
                    msg = NppConst.WM_GET_FILENAME;
                else if (which == NppConst.CURRENT_DIRECTORY)
                    msg = NppConst.WM_GET_CURRENTDIRECTORY;

                StringBuilder path = new StringBuilder(260);

                SendMessage(moNppData.NppHandle.ToInt32(), msg, 0, path);
                insertString(path.ToString());
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Exception:" + e.Message);
            }

        }

        public void insertCurrentFullPath()
        {
            insertCurrentPath(NppConst.FULL_CURRENT_PATH);
        }

        public void insertCurrentFileName()
        {
            insertCurrentPath(NppConst.FILE_NAME);
        }

        public void insertCurrentDirectory()
        {
            insertCurrentPath(NppConst.CURRENT_DIRECTORY);
        }

        public void insertShortDateTime()
        {
            moNppCommands.ScintillaReplaceSelection(moNppCommands.GetCurrentScintillaHandle(), DateTime.Today.ToShortDateString());

        }

        public void insertLongDateTime()
        {
            moNppCommands.ScintillaReplaceSelection(moNppCommands.GetCurrentScintillaHandle(), DateTime.Today.ToLongDateString());
        }


        public void getFileNamesDemo()
        {
            try
            {

                int nbFile = GetNbFiles(moNppData.NppHandle.ToInt32(), NppConst.WM_NBOPENFILES, 0, 0);
                System.Windows.Forms.MessageBox.Show(string.Format("{0} nb opened files", nbFile));

                //ArrayList toStringBuilder = new ArrayList(nbFile);
                IntPtr[] toTab = new IntPtr[nbFile];
               
                for (int i = 0; i < nbFile; i++)
                {
                    toTab[i] = Marshal.AllocCoTaskMem(260);
                }

                GetFileNames(moNppData.NppHandle.ToInt32(), NppConst.WM_GETOPENFILENAMES, toTab, nbFile);
                
                foreach (IntPtr oElt in toTab)
                {
                    System.Windows.Forms.MessageBox.Show(Marshal.PtrToStringAnsi(oElt));
                }

            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
        }

        

        #endregion

        #region DllMain


        public void DllMain(ulong iReasonForCall)
        {
            
            switch (iReasonForCall)
            {
                // Here we initialize the FuncItem Array.
                // AWARE : no need to initialize _cmdID field.
                // This filed will be initialized by Notepad++ plugins system
                case NppConst.DLL_PROCESS_ATTACH:
                    {

                        FuncItem oElt = null;


                        oElt = new FuncItem();
                        oElt.ItemName = "Current Full Path";
                        oElt.pFunc = new TestDelegate(insertCurrentFullPath);
                        oElt.Init2Check = false;
                        oElt.PShKey = new ShortcutKey();
                        oElt.PShKey.IsAlt = true;
                        oElt.PShKey.Key = 0x46; //VK_F
                        moTab.Add(oElt);


                        oElt = new FuncItem();
                        oElt.ItemName = "Current File Name";
                        oElt.pFunc = new TestDelegate(insertCurrentFileName);
                        oElt.Init2Check = false;
                        oElt.PShKey = null;
                        moTab.Add(oElt);

                        oElt = new FuncItem();
                        oElt.ItemName = "Current Directory";
                        oElt.pFunc = new TestDelegate(insertCurrentDirectory);
                        oElt.Init2Check = false;
                        oElt.PShKey = null;
                        moTab.Add(oElt);

                        oElt = new FuncItem();
                        oElt.ItemName = "Date & Time - short format";
                        oElt.pFunc = new TestDelegate(insertShortDateTime);
                        oElt.Init2Check = false;
                        oElt.PShKey = null;
                        moTab.Add(oElt);

                        oElt = new FuncItem();
                        oElt.ItemName = "Date & Time - long format";
                        oElt.pFunc = new TestDelegate(insertLongDateTime);
                        oElt.Init2Check = false;
                        oElt.PShKey = null;
                        moTab.Add(oElt);

                        oElt = new FuncItem();
                        oElt.ItemName = "Get File Names Demo";
                        oElt.pFunc = new TestDelegate(getFileNamesDemo);
                        oElt.Init2Check = false;
                        oElt.PShKey = null;
                        moTab.Add(oElt);

                    }
                    break;
                case NppConst.DLL_PROCESS_DETACH:
                    break;
                case NppConst.DLL_THREAD_ATTACH:
                    break;
                case NppConst.DLL_THREAD_DETACH:
                    break;
            }

        }

        #endregion

        #region Mandatory functions


        public void setInfo(NppData oNppData)
        {
            
            moNppData = oNppData;
            moNppCommands = new NppCommands(moNppData);
        }

        public void getName(out string sName)
        {
            
            sName = "Dotnet Plugin Demo";
            
        }

        public void beNotified(SCNotification oNotification)
        {
            //nothing
        }

        public void messageProc(uint Message, IntPtr wParam, IntPtr lParam)
        {
            //nothing
        }

        public void getFuncsArray(out int iLen, out IntPtr[] oTab)
        {
            
            iLen = moTab.Count;
            moTabIntPtr = new IntPtr[iLen];
            

            for (int i = 0; i < iLen; i++)
            {
                moTabIntPtr[i] = Marshal.AllocCoTaskMem(Marshal.SizeOf(typeof(FuncItem)));
                Marshal.StructureToPtr(moTab[i], moTabIntPtr[i], false);
            }

            oTab = moTabIntPtr;

        }

        #endregion
    }


}