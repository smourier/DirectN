// generated from <Windows SDK Path>\um\d3d10umddi.h
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D10DDIARG_CREATESHADERRESOURCEVIEW
    {
        public D3D10DDI_HRESOURCE hDrvResource;
        public DXGI_FORMAT Format;
        public D3D10DDIRESOURCE_TYPE ResourceDimension;
        public D3D10DDIARG_CREATESHADERRESOURCEVIEW__union_0 __union_3;
    }
}
