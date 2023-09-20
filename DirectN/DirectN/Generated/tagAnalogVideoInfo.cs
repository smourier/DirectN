// generated from <Windows SDK Path>\um\amvideo.h
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
