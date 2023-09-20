// generated from <Windows SDK Path>\um\d3d12umddi.h
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_DEPTH_STENCILOP_DESC
    {
        public D3D12DDI_STENCIL_OP StencilFailOp;
        public D3D12DDI_STENCIL_OP StencilDepthFailOp;
        public D3D12DDI_STENCIL_OP StencilPassOp;
        public D3D12DDI_COMPARISON_FUNC StencilFunc;
    }
}
