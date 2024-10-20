// generated from <Windows SDK Path>\um\d3d12umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_SAMPLER_DESC_0096
    {
        public D3D12DDI_FILTER Filter;
        public D3D12DDI_TEXTURE_ADDRESS_MODE AddressU;
        public D3D12DDI_TEXTURE_ADDRESS_MODE AddressV;
        public D3D12DDI_TEXTURE_ADDRESS_MODE AddressW;
        public float MipLODBias;
        public uint MaxAnisotropy;
        public D3D12DDI_COMPARISON_FUNC ComparisonFunc;
        public D3D12DDI_SAMPLER_DESC_0096__union_0 __union_7;
        public float MinLOD;
        public float MaxLOD;
        public D3D12DDI_SAMPLER_FLAGS_0096 Flags;
    }
}
