// generated from <Windows SDK Path>\shared\ksmedia.h
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
