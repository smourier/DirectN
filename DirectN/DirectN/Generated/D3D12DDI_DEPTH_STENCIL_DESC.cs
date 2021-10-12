// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12umddi.h(2814,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_DEPTH_STENCIL_DESC
    {
        public bool DepthEnable;
        public D3D12DDI_DEPTH_WRITE_MASK DepthWriteMask;
        public D3D12DDI_COMPARISON_FUNC DepthFunc;
        public bool StencilEnable;
        public bool FrontEnable;
        public bool BackEnable;
        public byte StencilReadMask;
        public byte StencilWriteMask;
        public D3D12DDI_DEPTH_STENCILOP_DESC FrontFace;
        public D3D12DDI_DEPTH_STENCILOP_DESC BackFace;
    }
}
