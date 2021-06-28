// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3d11.h(1798,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_RENDER_TARGET_BLEND_DESC
    {
        public bool BlendEnable;
        public D3D11_BLEND SrcBlend;
        public D3D11_BLEND DestBlend;
        public D3D11_BLEND_OP BlendOp;
        public D3D11_BLEND SrcBlendAlpha;
        public D3D11_BLEND DestBlendAlpha;
        public D3D11_BLEND_OP BlendOpAlpha;
        public byte RenderTargetWriteMask;
    }
}
