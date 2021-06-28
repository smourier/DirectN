// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3d11.h(1555,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_DEPTH_STENCIL_DESC
    {
        public bool DepthEnable;
        public D3D11_DEPTH_WRITE_MASK DepthWriteMask;
        public D3D11_COMPARISON_FUNC DepthFunc;
        public bool StencilEnable;
        public byte StencilReadMask;
        public byte StencilWriteMask;
        public D3D11_DEPTH_STENCILOP_DESC FrontFace;
        public D3D11_DEPTH_STENCILOP_DESC BackFace;
    }
}
