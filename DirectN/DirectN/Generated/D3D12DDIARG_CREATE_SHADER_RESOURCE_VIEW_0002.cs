// generated from <Windows SDK Path>\um\d3d12umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDIARG_CREATE_SHADER_RESOURCE_VIEW_0002
    {
        public D3D10DDI_HRESOURCE hDrvResource;
        public DXGI_FORMAT Format;
        public D3D12DDI_RESOURCE_DIMENSION ResourceDimension;
        public uint Shader4ComponentMapping;
        public D3D12DDIARG_CREATE_SHADER_RESOURCE_VIEW_0002__union_0 __union_4;
    }
}
