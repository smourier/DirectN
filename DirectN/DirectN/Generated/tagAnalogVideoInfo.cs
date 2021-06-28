// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\amvideo.h(462,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagAnalogVideoInfo
    {
        public tagRECT rcSource;
        public tagRECT rcTarget;
        public uint dwActiveWidth;
        public uint dwActiveHeight;
        public long AvgTimePerFrame;
    }
}
