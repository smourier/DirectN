// generated from <Windows SDK Path>\um\d3d12umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_RESOURCE_ALLOCATION_INFO
    {
        public ulong ResourceDataSize;
        public ulong AdditionalDataHeaderSize;
        public ulong AdditionalDataSize;
        public ulong ResourceDataAlignment;
        public D3D12DDI_RESOURCE_ALLOCATION_INFO__union_0 __union_4;
        public ulong AdditionalDataAlignment;
        public D3D12DDI_TEXTURE_LAYOUT Layout;
        public byte MipLevelSwizzleTransition;
    }
}
