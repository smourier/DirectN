// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d10umddi.h(683,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11DDIARG_CREATEDEPTHSTENCILVIEW
    {
        public D3D10DDI_HRESOURCE hDrvResource;
        public int Format;
        public D3D10DDIRESOURCE_TYPE ResourceDimension;
        public uint Flags;
        public D3D11DDIARG_CREATEDEPTHSTENCILVIEW__union_0 __union_4;
    }
}
