// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d10umddi.h(1790,9)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D10_1DDIARG_CREATESHADERRESOURCEVIEW
    {
        public D3D10DDI_HRESOURCE hDrvResource;
        public DXGI_FORMAT Format;
        public D3D10DDIRESOURCE_TYPE ResourceDimension;
        public D3D10_1DDIARG_CREATESHADERRESOURCEVIEW__union_0 __union_3;
    }
}
