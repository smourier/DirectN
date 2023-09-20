// generated from <Windows SDK Path>\um\mfapi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagHistogramHeader
    {
        public uint Size;
        public uint Bins;
        public uint FourCC;
        public uint ChannelMasks;
        public tagHistogramGrid Grid;
    }
}
