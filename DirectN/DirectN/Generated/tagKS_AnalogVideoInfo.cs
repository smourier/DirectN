// c:\program files (x86)\windows kits\10\include\10.0.22621.0\shared\ksmedia.h(4117,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagKS_AnalogVideoInfo
    {
        public tagRECT rcSource;
        public tagRECT rcTarget;
        public uint dwActiveWidth;
        public uint dwActiveHeight;
        public long AvgTimePerFrame;
    }
}
