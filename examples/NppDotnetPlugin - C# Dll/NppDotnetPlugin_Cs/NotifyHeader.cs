using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;


namespace NppDotnetPlugin_Cs
{
    [StructLayout(LayoutKind.Sequential)]
    public class NotifyHeader
    {
        public IntPtr HwndFrom;
        public uint IdFrom;
        public uint Code;
    }

}
