// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\mfapi.h(1702,9)
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
