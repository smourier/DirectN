// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\ksmedia.h(4004,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagKS_VIDEOINFOHEADER
    {
        public tagRECT rcSource;
        public tagRECT rcTarget;
        public uint dwBitRate;
        public uint dwBitErrorRate;
        public long AvgTimePerFrame;
        public tagKS_BITMAPINFOHEADER bmiHeader;
    }
}
