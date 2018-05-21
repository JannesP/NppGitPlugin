using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;


namespace NppDotnetPlugin_Cs
{
    [StructLayout(LayoutKind.Sequential)]
    public class NppData
    {
        public IntPtr NppHandle;
        public IntPtr ScintillaMainHandle;
        public IntPtr ScintillaSecondHandle;
    }   
}
