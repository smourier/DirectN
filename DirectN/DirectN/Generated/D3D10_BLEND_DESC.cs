// generated from <Windows SDK Path>\um\d3d10.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D10_BLEND_DESC
    {
        public bool AlphaToCoverageEnable;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)] 
        public bool[] BlendEnable;
        public D3D10_BLEND SrcBlend;
        public D3D10_BLEND DestBlend;
        public D3D10_BLEND_OP BlendOp;
        public D3D10_BLEND SrcBlendAlpha;
        public D3D10_BLEND DestBlendAlpha;
        public D3D10_BLEND_OP BlendOpAlpha;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)] 
        public byte[] RenderTargetWriteMask;
    }
}
