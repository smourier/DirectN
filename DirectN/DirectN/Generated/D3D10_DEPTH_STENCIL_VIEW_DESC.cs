// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3d10.h(3200,9)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D10_DEPTH_STENCIL_VIEW_DESC
    {
        public DXGI_FORMAT Format;
        public D3D10_DSV_DIMENSION ViewDimension;
        public D3D10_DEPTH_STENCIL_VIEW_DESC__union_0 __union_2;
    }
}
