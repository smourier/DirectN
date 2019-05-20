// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d10umddi.h(2601,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_1_DDI_BLEND_DESC
    {
        public bool AlphaToCoverageEnable;
        public bool IndependentBlendEnable;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)] 
        public D3D11_1_DDI_RENDER_TARGET_BLEND_DESC[] RenderTarget;
    }
}
