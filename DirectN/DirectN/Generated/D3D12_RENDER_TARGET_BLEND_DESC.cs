// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12.h(1510,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_RENDER_TARGET_BLEND_DESC
    {
        public bool BlendEnable;
        public bool LogicOpEnable;
        public D3D12_BLEND SrcBlend;
        public D3D12_BLEND DestBlend;
        public D3D12_BLEND_OP BlendOp;
        public D3D12_BLEND SrcBlendAlpha;
        public D3D12_BLEND DestBlendAlpha;
        public D3D12_BLEND_OP BlendOpAlpha;
        public D3D12_LOGIC_OP LogicOp;
        public byte RenderTargetWriteMask;
    }
}
