// generated from <Windows SDK Path>\shared\ksmedia.h
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
