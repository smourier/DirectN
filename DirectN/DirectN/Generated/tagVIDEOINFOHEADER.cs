// generated from <Windows SDK Path>\um\amvideo.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagVIDEOINFOHEADER
    {
        public tagRECT rcSource;
        public tagRECT rcTarget;
        public uint dwBitRate;
        public uint dwBitErrorRate;
        public long AvgTimePerFrame;
        public tagBITMAPINFOHEADER bmiHeader;
    }
}
