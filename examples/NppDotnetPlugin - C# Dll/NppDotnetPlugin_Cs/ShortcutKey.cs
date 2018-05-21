using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace NppDotnetPlugin_Cs
{
    [StructLayout(LayoutKind.Sequential)]
    public class ShortcutKey
    {
        public bool IsCtrl;
        public bool IsAlt;
        public bool IsShift;
        public int Key;
    }
}
