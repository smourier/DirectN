// generated from <Windows SDK Path>\um\d3d10umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D10_DDI_RENDER_TARGET_BLEND_DESC1
    {
        public bool BlendEnable;
        public D3D10_DDI_BLEND SrcBlend;
        public D3D10_DDI_BLEND DestBlend;
        public D3D10_DDI_BLEND_OP BlendOp;
        public D3D10_DDI_BLEND SrcBlendAlpha;
        public D3D10_DDI_BLEND DestBlendAlpha;
        public D3D10_DDI_BLEND_OP BlendOpAlpha;
        public byte RenderTargetWriteMask;
    }
}
