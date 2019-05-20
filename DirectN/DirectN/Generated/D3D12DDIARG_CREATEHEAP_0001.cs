// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d12umddi.h(298,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDIARG_CREATEHEAP_0001
    {
        public ulong ByteSize;
        public ulong Alignment;
        public D3D12DDI_MEMORY_POOL MemoryPool;
        public D3D12DDI_CPU_PAGE_PROPERTY CPUPageProperty;
        public D3D12DDI_HEAP_FLAGS Flags;
        public uint CreationNodeMask;
        public uint VisibleNodeMask;
    }
}
