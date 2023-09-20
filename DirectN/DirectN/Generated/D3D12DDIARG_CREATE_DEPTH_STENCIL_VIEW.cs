// generated from <Windows SDK Path>\um\d3d12umddi.h
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDIARG_CREATE_DEPTH_STENCIL_VIEW
    {
        public D3D10DDI_HRESOURCE hDrvResource;
        public DXGI_FORMAT Format;
        public D3D12DDI_RESOURCE_DIMENSION ResourceDimension;
        public D3D12DDI_CREATE_DEPTH_STENCIL_VIEW_FLAGS Flags;
        public D3D12DDIARG_CREATE_DEPTH_STENCIL_VIEW__union_0 __union_4;
    }
}
