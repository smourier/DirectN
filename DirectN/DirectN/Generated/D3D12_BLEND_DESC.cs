// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12.h(1524,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_BLEND_DESC
    {
        public bool AlphaToCoverageEnable;
        public bool IndependentBlendEnable;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)] 
        public D3D12_RENDER_TARGET_BLEND_DESC[] RenderTarget;
    }
}
