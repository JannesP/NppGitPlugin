using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace NppDotnetPlugin_Cs
{
    [StructLayout(LayoutKind.Sequential)]
    public class FuncItem
    {
        [MarshalAs(UnmanagedType.LPStr)]
        public string ItemName;
        [MarshalAs(UnmanagedType.FunctionPtr)]
        public TestDelegate pFunc;
        public int CmdID;
        public bool Init2Check;
        public ShortcutKey PShKey;
    }

    public delegate void TestDelegate();
}
