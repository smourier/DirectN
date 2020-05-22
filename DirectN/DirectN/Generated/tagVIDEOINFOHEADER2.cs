// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\dvdmedia.h(307,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagVIDEOINFOHEADER2
    {
        public tagRECT rcSource;
        public tagRECT rcTarget;
        public uint dwBitRate;
        public uint dwBitErrorRate;
        public int AvgTimePerFrame;
        public uint dwInterlaceFlags;
        public uint dwCopyProtectFlags;
        public uint dwPictAspectRatioX;
        public uint dwPictAspectRatioY;
        public tagVIDEOINFOHEADER2__union_0 __union_9;
        public uint dwReserved2;
        public tagBITMAPINFOHEADER bmiHeader;
    }
}
