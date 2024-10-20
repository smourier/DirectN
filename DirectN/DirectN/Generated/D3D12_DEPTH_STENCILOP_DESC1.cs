// generated from <Windows SDK Path>\um\d3d12.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_DEPTH_STENCILOP_DESC1
    {
        public D3D12_STENCIL_OP StencilFailOp;
        public D3D12_STENCIL_OP StencilDepthFailOp;
        public D3D12_STENCIL_OP StencilPassOp;
        public D3D12_COMPARISON_FUNC StencilFunc;
        public byte StencilReadMask;
        public byte StencilWriteMask;
    }
}
