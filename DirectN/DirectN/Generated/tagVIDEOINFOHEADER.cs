// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\amvideo.h(265,9)
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
