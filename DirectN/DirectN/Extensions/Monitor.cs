using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace DirectN
{
    public class Monitor
    {
        private Monitor(IntPtr handle)
        {
            Handle = handle;
            var mi = new MONITORINFOEX();
            mi.cbSize = Marshal.SizeOf(mi);
            if (!GetMonitorInfo(handle, ref mi))
                throw new Win32Exception(Marshal.GetLastWin32Error());

            DeviceName = mi.szDevice.ToString();
            Bounds = mi.rcMonitor;
            WorkingArea = mi.rcWork;
            IsPrimary = (mi.dwFlags & MONITORINFOF_PRIMARY) == MONITORINFOF_PRIMARY;
        }

        public IntPtr Handle { get; }
        public bool IsPrimary { get; }
        public tagRECT WorkingArea { get; }
        public tagRECT Bounds { get; }
        public string DeviceName { get; }

        public override string ToString() => DeviceName;

        public static Monitor FromWindow(IntPtr hwnd, MFW flags = MFW.MONITOR_DEFAULTTONULL)
        {
            var h = MonitorFromWindow(hwnd, (int)flags);
            if (h == IntPtr.Zero)
                return null;

            return new Monitor(h);
        }

        private const int MONITORINFOF_PRIMARY = 0x00000001;

        [DllImport("user32", ExactSpelling = true)]
        private static extern IntPtr MonitorFromWindow(IntPtr hwnd, int flags);

        [DllImport("user32", CharSet = CharSet.Auto)]
        private static extern bool GetMonitorInfo(IntPtr hmonitor, ref MONITORINFOEX info);

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        public struct MONITORINFOEX
        {
            public int cbSize;
            public tagRECT rcMonitor;
            public tagRECT rcWork;
            public int dwFlags;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string szDevice;
        }
    }
}
