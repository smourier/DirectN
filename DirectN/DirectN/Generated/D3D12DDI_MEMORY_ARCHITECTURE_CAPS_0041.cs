// generated from <Windows SDK Path>\um\d3d12umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_MEMORY_ARCHITECTURE_CAPS_0041
    {
        public bool UMA;
        public bool IOCoherent;
        public bool CacheCoherent;
        public D3D12DDI_HEAP_SERIALIZATION_TIER_0041 HeapSerializationTier;
        public D3D12DDI_RESOURCE_SERIALIZATION_TIER_0041 ResourceSerializationTier;
    }
}
