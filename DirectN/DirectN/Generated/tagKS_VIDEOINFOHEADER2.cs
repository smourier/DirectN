// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\ksmedia.h(4193,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagKS_VIDEOINFOHEADER2
    {
        public tagRECT rcSource;
        public tagRECT rcTarget;
        public uint dwBitRate;
        public uint dwBitErrorRate;
        public long AvgTimePerFrame;
        public uint dwInterlaceFlags;
        public uint dwCopyProtectFlags;
        public uint dwPictAspectRatioX;
        public uint dwPictAspectRatioY;
        public tagKS_VIDEOINFOHEADER2__union_0 __union_9;
        public uint dwReserved2;
        public tagKS_BITMAPINFOHEADER bmiHeader;
    }
}
