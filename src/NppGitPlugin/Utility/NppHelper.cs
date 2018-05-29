using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NppGitPlugin.NppPluginLib;

namespace NppGitPlugin.Utility
{
    static class NppHelper
    {
        public static IntPtr NppHandle { get; set; }

        public static string GetCurrentFilePath()
        {
            return GetStringFromNpp(NppMsg.NPPM_GETFULLCURRENTPATH);
        }

        public static string GetStringFromNpp(NppMsg message)
        {
            message = message | NppMsg.RUNCOMMAND_USER;
            StringBuilder sb = new StringBuilder(Win32.MAX_PATH);
            Win32.SendMessage(NppHandle, message, 0, sb);
            return sb.ToString();
        }
    }
}
