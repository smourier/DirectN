// generated from <Windows SDK Path>\um\d3d10_1.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D10_BLEND_DESC1
    {
        public bool AlphaToCoverageEnable;
        public bool IndependentBlendEnable;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)] 
        public D3D10_RENDER_TARGET_BLEND_DESC1[] RenderTarget;
    }
}
