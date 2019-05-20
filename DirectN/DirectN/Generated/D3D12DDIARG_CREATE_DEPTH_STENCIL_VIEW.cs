// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d12umddi.h(1231,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDIARG_CREATE_DEPTH_STENCIL_VIEW
    {
        public D3D10DDI_HRESOURCE hDrvResource;
        public int Format;
        public D3D12DDI_RESOURCE_DIMENSION ResourceDimension;
        public D3D12DDI_CREATE_DEPTH_STENCIL_VIEW_FLAGS Flags;
        public D3D12DDIARG_CREATE_DEPTH_STENCIL_VIEW__union_0 __union_4;
    }
}
