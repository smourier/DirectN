// generated from <Windows SDK Path>\um\ddrawint.h
using System;
using System.Runtime.InteropServices;
using PDD_GETDRIVERINFO = System.IntPtr;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DD_HALINFO_V4
    {
        public uint dwSize;
        public _VIDEOMEMORYINFO vmiData;
        public _DDNTCORECAPS ddCaps;
        public IntPtr GetDriverInfo;
        public uint dwFlags;
    }
}
