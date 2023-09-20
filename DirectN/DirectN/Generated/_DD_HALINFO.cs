// generated from <Windows SDK Path>\um\ddrawint.h
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
