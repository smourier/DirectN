// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12video.h(3637,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_FEATURE_DATA_VIDEO_PROCESSOR_SIZE1
    {
        public uint NodeMask;
        public IntPtr pOutputStreamDesc;
        public uint NumInputStreamDescs;
        public IntPtr pInputStreamDescs;
        public bool Protected;
        public ulong MemoryPoolL0Size;
        public ulong MemoryPoolL1Size;
    }
}
