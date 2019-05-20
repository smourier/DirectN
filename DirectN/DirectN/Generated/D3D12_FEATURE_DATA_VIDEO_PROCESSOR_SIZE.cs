// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d12video.h(898,9)
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
