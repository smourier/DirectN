// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3d12video.h(959,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_FEATURE_DATA_VIDEO_DECODER_HEAP_SIZE
    {
        public D3D12_VIDEO_DECODER_HEAP_DESC VideoDecoderHeapDesc;
        public ulong MemoryPoolL0Size;
        public ulong MemoryPoolL1Size;
    }
}
