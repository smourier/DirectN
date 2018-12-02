// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\ddrawint.h(937,9)
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
