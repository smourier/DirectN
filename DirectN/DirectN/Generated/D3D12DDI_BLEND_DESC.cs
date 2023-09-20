// generated from <Windows SDK Path>\um\d3d12umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_BLEND_DESC
    {
        public bool AlphaToCoverageEnable;
        public bool IndependentBlendEnable;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)] 
        public D3D12DDI_RENDER_TARGET_BLEND_DESC[] RenderTarget;
    }
}
