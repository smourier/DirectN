// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3d12video.h(3402,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_FEATURE_DATA_VIDEO_DECODER_HEAP_SIZE1
    {
        public D3D12_VIDEO_DECODER_HEAP_DESC VideoDecoderHeapDesc;
        public bool Protected;
        public ulong MemoryPoolL0Size;
        public ulong MemoryPoolL1Size;
    }
}
