using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
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
            IsPrimary = ((MONITORINFOF)mi.dwFlags).HasFlag(MONITORINFOF.MONITORINFOF_PRIMARY);
        }

        public IntPtr Handle { get; }
        public bool IsPrimary { get; }
        public tagRECT WorkingArea { get; }
        public tagRECT Bounds { get; }
        [Browsable(false)]
        public string DeviceName { get; }

        public D2D_SIZE_U EffectiveDpi => DpiUtilities.GetDpiForMonitor(Handle, MONITOR_DPI_TYPE.MDT_EFFECTIVE_DPI);
        public D2D_SIZE_U RawDpi => DpiUtilities.GetDpiForMonitor(Handle, MONITOR_DPI_TYPE.MDT_RAW_DPI);
        public D2D_SIZE_U AngularDpi => DpiUtilities.GetDpiForMonitor(Handle, MONITOR_DPI_TYPE.MDT_ANGULAR_DPI);

        public DEVICE_SCALE_FACTOR ScaleFactor
        {
            get
            {
                _ = GetScaleFactorForMonitor(Handle, out var factor);
                return factor;
            }
        }

        [Browsable(false)]
        public DISPLAY_DEVICE? DISPLAY_DEVICE
        {
            get
            {
                foreach (var dd in DirectN.DISPLAY_DEVICE.All)
                {
                    if (dd.DeviceName.EqualsIgnoreCase(DeviceName))
                        return dd;
                }
                return null;
            }
        }

        public override string ToString() => DeviceName;

        public static Monitor Desktop
        {
            get
            {
                var handle = GetDesktopMonitorHandle();
                return handle == IntPtr.Zero ? null : new Monitor(handle);
            }
        }

        public static Monitor Shell
        {
            get
            {
                var handle = GetShellMonitorHandle();
                return handle == IntPtr.Zero ? null : new Monitor(handle);
            }
        }

        public static IntPtr GetNearestFromWindow(IntPtr hwnd) => MonitorFromWindow(hwnd, MFW.MONITOR_DEFAULTTONEAREST);
        public static IntPtr GetNearestFromPoint(int x, int y) => MonitorFromPoint(new tagPOINT { x = x, y = y }, MFW.MONITOR_DEFAULTTONEAREST);

        public static IntPtr GetDesktopMonitorHandle() => GetNearestFromWindow(GetDesktopWindow());
        public static IntPtr GetShellMonitorHandle() => GetNearestFromWindow(GetShellWindow());

        public static Monitor FromWindow(IntPtr hwnd, MFW flags = MFW.MONITOR_DEFAULTTONULL)
        {
            var h = MonitorFromWindow(hwnd, flags);
            if (h == IntPtr.Zero)
                return null;

            return new Monitor(h);
        }

        public static Monitor Primary => All.FirstOrDefault(m => m.IsPrimary);
        public static IEnumerable<Monitor> All
        {
            get
            {
                var all = new List<Monitor>();
                EnumDisplayMonitors(IntPtr.Zero, IntPtr.Zero, (m, h, rc, p) =>
                {
                    all.Add(new Monitor(m));
                    return true;
                }, IntPtr.Zero);
                return all;
            }
        }

        private delegate bool MonitorEnumProc(IntPtr monitor, IntPtr hdc, IntPtr lprcMonitor, IntPtr lParam);

        [DllImport("user32")]
        private static extern IntPtr GetDesktopWindow();

        [DllImport("user32")]
        private static extern IntPtr GetShellWindow();

        [DllImport("user32")]
        private static extern bool EnumDisplayMonitors(IntPtr hdc, IntPtr lprcClip, MonitorEnumProc lpfnEnum, IntPtr dwData);

        [DllImport("user32")]
        private static extern IntPtr MonitorFromPoint(tagPOINT pt, MFW flags);

        [DllImport("user32")]
        private static extern IntPtr MonitorFromWindow(IntPtr hwnd, MFW flags);

        [DllImport("user32", CharSet = CharSet.Unicode)]
        private static extern bool GetMonitorInfo(IntPtr hmonitor, ref MONITORINFOEX info);

        [DllImport("shcore")]
        private static extern int GetScaleFactorForMonitor(IntPtr hmonitor, out DEVICE_SCALE_FACTOR factor);
    }
}
