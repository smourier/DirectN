// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\ddrawint.h(946,9)
using System;
using System.Runtime.InteropServices;
using PDD_GETDRIVERINFO = System.IntPtr;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DD_HALINFO
    {
        public uint dwSize;
        public _VIDEOMEMORYINFO vmiData;
        public _DDNTCORECAPS ddCaps;
        public IntPtr GetDriverInfo;
        public uint dwFlags;
        public IntPtr lpD3DGlobalDriverData;
        public IntPtr lpD3DHALCallbacks;
        public IntPtr lpD3DBufCallbacks;
    }
}
