// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\ddrawi.h(2004,9)
using System;
using System.Runtime.InteropServices;
using LPDDHAL_GETDRIVERINFO = System.IntPtr;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDHALINFO
    {
        public uint dwSize;
        public IntPtr lpDDCallbacks;
        public IntPtr lpDDSurfaceCallbacks;
        public IntPtr lpDDPaletteCallbacks;
        public _VIDMEMINFO vmiData;
        public _DDCORECAPS ddCaps;
        public uint dwMonitorFrequency;
        public IntPtr GetDriverInfo;
        public uint dwModeIndex;
        public IntPtr lpdwFourCC;
        public uint dwNumModes;
        public IntPtr lpModeInfo;
        public uint dwFlags;
        public IntPtr lpPDevice;
        public uint hInstance;
        public IntPtr lpD3DGlobalDriverData;
        public IntPtr lpD3DHALCallbacks;
        public IntPtr lpDDExeBufCallbacks;
    }
}
