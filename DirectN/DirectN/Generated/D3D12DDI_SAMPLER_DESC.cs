// generated from <Windows SDK Path>\um\d3d12umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_SAMPLER_DESC
    {
        public D3D12DDI_FILTER Filter;
        public D3D12DDI_TEXTURE_ADDRESS_MODE AddressU;
        public D3D12DDI_TEXTURE_ADDRESS_MODE AddressV;
        public D3D12DDI_TEXTURE_ADDRESS_MODE AddressW;
        public float MipLODBias;
        public uint MaxAnisotropy;
        public D3D12DDI_COMPARISON_FUNC ComparisonFunc;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)] 
        public float[] BorderColor;
        public float MinLOD;
        public float MaxLOD;
    }
}
