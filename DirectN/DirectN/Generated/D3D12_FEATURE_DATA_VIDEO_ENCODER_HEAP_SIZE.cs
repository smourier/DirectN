// generated from <Windows SDK Path>\um\d3d12video.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_FEATURE_DATA_VIDEO_ENCODER_HEAP_SIZE
    {
        public D3D12_VIDEO_ENCODER_HEAP_DESC HeapDesc;
        public bool IsSupported;
        public ulong MemoryPoolL0Size;
        public ulong MemoryPoolL1Size;
    }
}
