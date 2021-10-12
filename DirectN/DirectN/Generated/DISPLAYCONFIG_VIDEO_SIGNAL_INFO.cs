// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\wingdi.h(2846,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DISPLAYCONFIG_VIDEO_SIGNAL_INFO
    {
        public ulong pixelRate;
        public DISPLAYCONFIG_RATIONAL hSyncFreq;
        public DISPLAYCONFIG_RATIONAL vSyncFreq;
        public DISPLAYCONFIG_2DREGION activeSize;
        public DISPLAYCONFIG_2DREGION totalSize;
        public DISPLAYCONFIG_VIDEO_SIGNAL_INFO__union_0 __union_5;
        public DISPLAYCONFIG_SCANLINE_ORDERING scanLineOrdering;
    }
}
