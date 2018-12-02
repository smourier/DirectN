// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d10_1.h(154,9)
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
        public D3D10_RENDER_TARGET_BLEND_DESC1[][] RenderTarget;
    }
}
