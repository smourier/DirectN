// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d10umddi.h(2256,9)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11DDIARG_CREATEUNORDEREDACCESSVIEW
    {
        public D3D10DDI_HRESOURCE hDrvResource;
        public DXGI_FORMAT Format;
        public D3D10DDIRESOURCE_TYPE ResourceDimension;
        public D3D11DDIARG_CREATEUNORDEREDACCESSVIEW__union_0 __union_3;
    }
}
