// generated from <Windows SDK Path>\um\d3d12.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_STATIC_SAMPLER_DESC1
    {
        public D3D12_FILTER Filter;
        public D3D12_TEXTURE_ADDRESS_MODE AddressU;
        public D3D12_TEXTURE_ADDRESS_MODE AddressV;
        public D3D12_TEXTURE_ADDRESS_MODE AddressW;
        public float MipLODBias;
        public uint MaxAnisotropy;
        public D3D12_COMPARISON_FUNC ComparisonFunc;
        public D3D12_STATIC_BORDER_COLOR BorderColor;
        public float MinLOD;
        public float MaxLOD;
        public uint ShaderRegister;
        public uint RegisterSpace;
        public D3D12_SHADER_VISIBILITY ShaderVisibility;
        public D3D12_SAMPLER_FLAGS Flags;
    }
}
