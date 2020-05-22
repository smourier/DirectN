// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3d10_1.h(142,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D10_RENDER_TARGET_BLEND_DESC1
    {
        public bool BlendEnable;
        public D3D10_BLEND SrcBlend;
        public D3D10_BLEND DestBlend;
        public D3D10_BLEND_OP BlendOp;
        public D3D10_BLEND SrcBlendAlpha;
        public D3D10_BLEND DestBlendAlpha;
        public D3D10_BLEND_OP BlendOpAlpha;
        public byte RenderTargetWriteMask;
    }
}
