using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using Microsoft.Win32;

namespace DirectN
{
    // note this class considers dpix = dpiy
    public static class DpiUtilities
    {
        public static Version KernelVersion => _kernelVersion.Value;
        private static readonly Lazy<Version> _kernelVersion = new Lazy<Version>(() =>
        {
            // warning: this requires a manifest with Windows 10 marked, like this
            //
            //<compatibility xmlns="urn:schemas-microsoft-com:compatibility.v1">
            //  <application>
            //    <!-- Windows 10 -->
            //    <supportedOS Id="{8e0f7a12-bfb3-4fe8-b9a5-48fd50a15a9a}" />
            //  </application>
            //</compatibility>
            //

            var vi = FileVersionInfo.GetVersionInfo(Path.Combine(Environment.SystemDirectory, "kernel32.dll"));
            return new Version(vi.FileMajorPart, vi.FileMinorPart, vi.FileBuildPart, vi.FilePrivatePart);
        }, true);

        public static int TextScaleFactor => _textScaleFactor.Value;
        private static readonly Lazy<int> _textScaleFactor = new Lazy<int>(() =>
        {
            try
            {
                // https://stackoverflow.com/questions/64785427/c-windows-api-how-to-retrieve-font-scaling-percentage
                using (var key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Accessibility", false))
                {
                    if (key != null)
                    {
                        if (Conversions.TryChangeType<int>(key.GetValue("TextScaleFactor"), out var factor) && factor > 0)
                            return factor;
                    }
                }
            }
            catch
            {
                // continue
            }
            return 100;
        }, true);

        // you should always use this one and it will fallback if necessary
        // https://docs.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-getdpiforwindow
        public static D2D_SIZE_U GetDpiForWindow(IntPtr hwnd)
        {
            var h = LoadLibrary("user32.dll");
            try
            {
                var ptr = GetProcAddress(h, "GetDpiForWindow"); // Windows 10 1607
                if (ptr == IntPtr.Zero)
                    return GetDpiForNearestMonitor(hwnd);

                var dpi = Marshal.GetDelegateForFunctionPointer<GetDpiForWindowFn>(ptr)(hwnd);
                return new D2D_SIZE_U((uint)dpi, (uint)dpi);
            }
            finally
            {
                if (h != IntPtr.Zero)
                {
                    FreeLibrary(h);
                }
            }
        }

        public static D2D_SIZE_U GetDpiForNearestMonitor(IntPtr hwnd) => GetDpiForMonitor(Monitor.GetNearestFromWindow(hwnd));
        public static D2D_SIZE_U GetDpiForNearestMonitor(int x, int y) => GetDpiForMonitor(Monitor.GetNearestFromPoint(x, y));
        public static D2D_SIZE_U GetDpiForMonitor(IntPtr monitor, MONITOR_DPI_TYPE type = MONITOR_DPI_TYPE.MDT_EFFECTIVE_DPI)
        {
            if (monitor == IntPtr.Zero)
                return new D2D_SIZE_U(96, 96);

            var h = LoadLibrary("shcore.dll");
            try
            {
                var ptr = GetProcAddress(h, "GetDpiForMonitor"); // Windows 8.1
                if (ptr == IntPtr.Zero)
                    return GetDpiForDesktop();

                var hr = Marshal.GetDelegateForFunctionPointer<GetDpiForMonitorFn>(ptr)(monitor, type, out int x, out int y);
                if (hr < 0)
                    return GetDpiForDesktop();

                return new D2D_SIZE_U((uint)x, (uint)y);
            }
            finally
            {
                if (h != IntPtr.Zero)
                {
                    FreeLibrary(h);
                }
            }
        }

        public static D2D_SIZE_F GetDpiForDesktopF() => D2D1Functions.GetDesktopDpi();
        public static D2D_SIZE_U GetDpiForDesktop()
        {
            var dpi = D2D1Functions.GetDesktopDpi();
            return new D2D_SIZE_U((uint)dpi.width, (uint)dpi.height);
        }

        public static int GetDpiFromDpiAwarenessContext(DPI_AWARENESS_CONTEXT value)
        {
            // Windows 10, version 1803
            // see here for correspondance https://en.wikipedia.org/wiki/Windows_10_version_history
            if (KernelVersion >= new Version(10, 0, 17134))
                return GetDpiFromDpiAwarenessContext((IntPtr)value);

            return 0;
        }

        public static int GetWindowDpi(IntPtr hwnd) => GetDpiFromDpiAwarenessContext(GetWindowDpiAwarenessContext(hwnd));
        public static IntPtr GetWindowDpiAwarenessContext(IntPtr hwnd)
        {
            // Windows 10, version 1607
            // see here for correspondance https://en.wikipedia.org/wiki/Windows_10_version_history
            if (KernelVersion >= new Version(10, 0, 14393))
                return GetWindowDpiAwarenessContextPrivate(hwnd);

            return (IntPtr)DPI_AWARENESS_CONTEXT.DPI_AWARENESS_CONTEXT_INVALID;
        }

        public static int AdjustForWindowDpi(int value, IntPtr handle)
        {
            var dpi = GetDpiForWindow(handle);
            if (dpi.width == 96)
                return value;

            return (int)(value * dpi.width / 96);
        }

        public static float AdjustForWindowDpi(float value, IntPtr handle)
        {
            var dpi = GetDpiForWindow(handle);
            if (dpi.width == 96)
                return value;

            return value * dpi.width / 96;
        }

        private delegate int GetDpiForWindowFn(IntPtr hwnd);
        private delegate int GetDpiForMonitorFn(IntPtr hmonitor, MONITOR_DPI_TYPE dpiType, out int dpiX, out int dpiY);

        [DllImport("user32")]
        private static extern int GetDpiFromDpiAwarenessContext(IntPtr value);

        [DllImport("user32", EntryPoint = nameof(GetWindowDpiAwarenessContext))]
        private static extern IntPtr GetWindowDpiAwarenessContextPrivate(IntPtr hwnd);

        [DllImport("kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
        private static extern IntPtr LoadLibrary(string lpLibFileName);

        [DllImport("kernel32", SetLastError = true)]
        private static extern bool FreeLibrary(IntPtr hLibModule);

        [DllImport("kernel32", CharSet = CharSet.Ansi, SetLastError = true)] // stupid warning
        private static extern IntPtr GetProcAddress(IntPtr hModule, string lpProcName);
    }
}
