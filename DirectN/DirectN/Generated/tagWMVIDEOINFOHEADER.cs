// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\wmsdkidl.h(1745,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagWMVIDEOINFOHEADER
    {
        public tagRECT rcSource;
        public tagRECT rcTarget;
        public uint dwBitRate;
        public uint dwBitErrorRate;
        public long AvgTimePerFrame;
        public tagBITMAPINFOHEADER bmiHeader;
    }
}
