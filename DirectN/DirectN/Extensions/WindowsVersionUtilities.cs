using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace DirectN
{
    public static class WindowsVersionUtilities
    {
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

            var vi = FileVersionInfo.GetVersionInfo(System.IO.Path.Combine(Environment.SystemDirectory, "kernel32.dll"));
            return new Version(vi.FileMajorPart, vi.FileMinorPart, vi.FileBuildPart, vi.FilePrivatePart);
        }, true);

        public static Version KernelVersion => _kernelVersion.Value;

        public static bool IsWindowsVistaOrGreater() => IsWindowsVersionOrGreater(HIBYTE(_WIN32_WINNT_VISTA), LOBYTE(_WIN32_WINNT_VISTA), 0);
        public static bool IsWindowsVistaSP1OrGreater() => IsWindowsVersionOrGreater(HIBYTE(_WIN32_WINNT_VISTA), LOBYTE(_WIN32_WINNT_VISTA), 1);
        public static bool IsWindowsVistaSP2OrGreater() => IsWindowsVersionOrGreater(HIBYTE(_WIN32_WINNT_VISTA), LOBYTE(_WIN32_WINNT_VISTA), 2);
        public static bool IsWindows7OrGreater() => IsWindowsVersionOrGreater(HIBYTE(_WIN32_WINNT_WIN7), LOBYTE(_WIN32_WINNT_WIN7), 0);
        public static bool IsWindows7SP1OrGreater() => IsWindowsVersionOrGreater(HIBYTE(_WIN32_WINNT_WIN7), LOBYTE(_WIN32_WINNT_WIN7), 1);
        public static bool IsWindows8OrGreater() => IsWindowsVersionOrGreater(HIBYTE(_WIN32_WINNT_WIN8), LOBYTE(_WIN32_WINNT_WIN8), 0);
        public static bool IsWindows8Point1OrGreater() => IsWindowsVersionOrGreater(HIBYTE(_WIN32_WINNT_WINBLUE), LOBYTE(_WIN32_WINNT_WINBLUE), 0);
        public static bool IsWindows10OrGreater() => IsWindowsVersionOrGreater(HIBYTE(_WIN32_WINNT_WIN10), LOBYTE(_WIN32_WINNT_WIN10), 0);
        public static bool IsWindowsVersionOrGreater(int majorVersion, int minorVersion, short servicePackMajor)
        {
            var osvi = new OSVERSIONINFOEXW();
            osvi.dwOSVersionInfoSize = Marshal.SizeOf<OSVERSIONINFOEXW>();
            var mask = VerSetConditionMask(VerSetConditionMask(VerSetConditionMask(0, VER_MAJORVERSION, VER_GREATER_EQUAL), VER_MINORVERSION, VER_GREATER_EQUAL), VER_SERVICEPACKMAJOR, VER_GREATER_EQUAL);
            osvi.dwMajorVersion = majorVersion;
            osvi.dwMinorVersion = minorVersion;
            osvi.wServicePackMajor = servicePackMajor;
            return VerifyVersionInfoW(ref osvi, VER_MAJORVERSION | VER_MINORVERSION | VER_SERVICEPACKMAJOR, mask);
        }

#pragma warning disable IDE1006 // Naming Styles
        private const int VER_GREATER_EQUAL = 3;
        private const int VER_MINORVERSION = 0x0000001;
        private const int VER_MAJORVERSION = 0x0000002;
        private const int VER_SERVICEPACKMAJOR = 0x0000020;
        private const ushort _WIN32_WINNT_VISTA = 0x0600;
        private const ushort _WIN32_WINNT_WIN7 = 0x0601;
        private const ushort _WIN32_WINNT_WIN8 = 0x0602;
        private const ushort _WIN32_WINNT_WINBLUE = 0x0603;
        private const ushort _WIN32_WINNT_WIN10 = 0x0A00;
#pragma warning restore IDE1006 // Naming Styles

        private static byte LOBYTE(ushort w) => (byte)(w & 0xff);
        private static byte HIBYTE(ushort w) => (byte)(w >> 8 & 0xff);

        [DllImport("kernel32")]
        private static extern ulong VerSetConditionMask(ulong ConditionMask, uint TypeMask, byte Condition);

        [DllImport("kernel32")]
        private static extern bool VerifyVersionInfoW(ref OSVERSIONINFOEXW lpVersionInformation, uint dwTypeMask, ulong dwlConditionMask);

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        private struct OSVERSIONINFOEXW
        {
            public int dwOSVersionInfoSize;
            public int dwMajorVersion;
            public int dwMinorVersion;
            public int dwBuildNumber;
            public int dwPlatformId;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string szCSDVersion;
            public short wServicePackMajor;
            public short wServicePackMinor;
            public short wSuiteMask;
            public byte wProductType;
            public byte wReserved;
        }
    }
}
