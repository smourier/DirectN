// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12umddi.h(1354,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_STATIC_SAMPLER
    {
        public D3D12DDI_FILTER Filter;
        public D3D12DDI_TEXTURE_ADDRESS_MODE AddressU;
        public D3D12DDI_TEXTURE_ADDRESS_MODE AddressV;
        public D3D12DDI_TEXTURE_ADDRESS_MODE AddressW;
        public float MipLODBias;
        public uint MaxAnisotropy;
        public D3D12DDI_COMPARISON_FUNC ComparisonFunc;
        public D3D12DDI_STATIC_BORDER_COLOR BorderColor;
        public float MinLOD;
        public float MaxLOD;
        public uint ShaderRegister;
        public uint RegisterSpace;
        public D3D12DDI_SHADER_VISIBILITY ShaderVisibility;
    }
}
