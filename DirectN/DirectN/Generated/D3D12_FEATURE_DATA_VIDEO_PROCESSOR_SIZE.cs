// generated from <Windows SDK Path>\um\d3d12video.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_FEATURE_DATA_VIDEO_PROCESSOR_SIZE
    {
        public uint NodeMask;
        public IntPtr pOutputStreamDesc;
        public uint NumInputStreamDescs;
        public IntPtr pInputStreamDescs;
        public ulong MemoryPoolL0Size;
        public ulong MemoryPoolL1Size;
    }
}
