// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d10umddi.h(1381,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D10_DDI_BLEND_DESC
    {
        public bool AlphaToCoverageEnable;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)] 
        public bool[] BlendEnable;
        public D3D10_DDI_BLEND SrcBlend;
        public D3D10_DDI_BLEND DestBlend;
        public D3D10_DDI_BLEND_OP BlendOp;
        public D3D10_DDI_BLEND SrcBlendAlpha;
        public D3D10_DDI_BLEND DestBlendAlpha;
        public D3D10_DDI_BLEND_OP BlendOpAlpha;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)] 
        public byte[] RenderTargetWriteMask;
    }
}
