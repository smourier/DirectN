// generated from <Windows SDK Path>\um\d3d12.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_HEAP_PROPERTIES
    {
        public D3D12_HEAP_TYPE Type;
        public D3D12_CPU_PAGE_PROPERTY CPUPageProperty;
        public D3D12_MEMORY_POOL MemoryPoolPreference;
        public uint CreationNodeMask;
        public uint VisibleNodeMask;
    }
}
