// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3d10.h(990,9)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D10_DEPTH_STENCILOP_DESC
    {
        public D3D10_STENCIL_OP StencilFailOp;
        public D3D10_STENCIL_OP StencilDepthFailOp;
        public D3D10_STENCIL_OP StencilPassOp;
        public D3D10_COMPARISON_FUNC StencilFunc;
    }
}
