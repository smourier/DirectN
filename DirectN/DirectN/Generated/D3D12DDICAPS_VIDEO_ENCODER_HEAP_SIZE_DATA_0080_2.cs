// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12umddi.h(12876,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDICAPS_VIDEO_ENCODER_HEAP_SIZE_DATA_0080_2
    {
        public D3D12DDIARG_CREATE_VIDEO_ENCODER_HEAP_0080_2 HeapDesc;
        public bool IsSupported;
        public ulong MemoryPoolL0Size;
        public ulong MemoryPoolL1Size;
    }
}
