using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using NppGitPlugin.Utility;
using NppPlugin.DllExport;

namespace NppGitPlugin.NppPluginLib
{
    public static class UnmanagedEvents
    {
        public class NppNotifyEventArgs : EventArgs
        {
            public SCNotification Notification { get; }
            public NppNotifyEventArgs(SCNotification notification)
            {
                Notification = notification;
            }
        }

        private static readonly GitPlugin Plugin = GitPlugin.Instance;

        static UnmanagedEvents()
        {
            AppDomain.CurrentDomain.AssemblyResolve += CurrentDomain_AssemblyResolve;
        }

        private static Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        {
            string folderPath = Path.Combine(Util.AssemblyDirectory, "GitPlugin");
            string assemblyPath = Path.Combine(folderPath, new AssemblyName(args.Name).Name + ".dll");
            if (!File.Exists(assemblyPath)) return null;
            Assembly asm = Assembly.LoadFrom(assemblyPath);
            return asm;
        }

        public static event EventHandler SetInfo;
        private static void OnSetInfo()
        {
            SetInfo?.Invoke(null, EventArgs.Empty);
        }
        public static event EventHandler<NppNotifyEventArgs> BeNotified;
        private static void OnBeNotified(SCNotification e)
        {
            BeNotified?.Invoke(null, new NppNotifyEventArgs(e));
        }

        [DllExport(CallingConvention=CallingConvention.Cdecl)]
        static bool isUnicode()
        {
            return true;
        }

        [DllExport(CallingConvention = CallingConvention.Cdecl)]
        static void setInfo(NppData notepadPlusData)
        {
            GitPlugin.Instance.nppData = notepadPlusData;
            OnSetInfo();
        }

        [DllExport(CallingConvention = CallingConvention.Cdecl)]
        static IntPtr getFuncsArray(ref int nbF)
        {
            nbF = Plugin._funcItems.Items.Count;
            return Plugin._funcItems.NativePointer;
        }

        [DllExport(CallingConvention = CallingConvention.Cdecl)]
        static uint messageProc(uint Message, IntPtr wParam, IntPtr lParam)
        {
            WindowsMessage wm = (WindowsMessage) Message;
            Trace.TraceInformation($"WM {wm}: wParam: {string.Format("{0:X8}", wParam.ToInt32())}, lParam: {string.Format("{0:X8}", lParam.ToInt32())}");
            return 1;
        }

        static IntPtr _ptrPluginName = IntPtr.Zero;
        [DllExport(CallingConvention = CallingConvention.Cdecl)]
        static IntPtr getName()
        {
            if (_ptrPluginName == IntPtr.Zero)
                _ptrPluginName = Marshal.StringToHGlobalUni(GitPlugin.PluginName);
            return _ptrPluginName;
        }

        [DllExport(CallingConvention = CallingConvention.Cdecl)]
        static void beNotified(IntPtr notifyCode)
        {
            SCNotification nc = (SCNotification)Marshal.PtrToStructure(notifyCode, typeof(SCNotification));
            OnBeNotified(nc);
            if (nc.nmhdr.code == (uint)NppMsg.NPPN_SHUTDOWN)
            {
                Marshal.FreeHGlobal(_ptrPluginName);
            }
        }
    }
}
