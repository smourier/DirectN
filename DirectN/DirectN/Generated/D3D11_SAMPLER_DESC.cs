// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3d11.h(5845,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_SAMPLER_DESC
    {
        public D3D11_FILTER Filter;
        public D3D11_TEXTURE_ADDRESS_MODE AddressU;
        public D3D11_TEXTURE_ADDRESS_MODE AddressV;
        public D3D11_TEXTURE_ADDRESS_MODE AddressW;
        public float MipLODBias;
        public uint MaxAnisotropy;
        public D3D11_COMPARISON_FUNC ComparisonFunc;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)] 
        public float[] BorderColor;
        public float MinLOD;
        public float MaxLOD;
    }
}
