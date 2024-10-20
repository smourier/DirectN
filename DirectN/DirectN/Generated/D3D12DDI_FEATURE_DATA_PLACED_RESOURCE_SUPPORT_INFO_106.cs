// generated from <Windows SDK Path>\um\d3d12umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_FEATURE_DATA_PLACED_RESOURCE_SUPPORT_INFO_106
    {
        public DXGI_FORMAT Format;
        public D3D12DDI_RESOURCE_TYPE ResourceType;
        public D3D12DDI_MEMORY_POOL MemoryPool;
        public D3D12DDI_CPU_PAGE_PROPERTY CPUPageProperty;
        public uint CreationNodeMask;
        public uint VisibleNodeMask;
        public bool Supported;
    }
}
