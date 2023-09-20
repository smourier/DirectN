// generated from <Windows SDK Path>\um\d3d12umddi.h
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
