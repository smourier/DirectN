// generated from <Windows SDK Path>\um\d3d12umddi.h
using System;
using System.Runtime.InteropServices;
using PFND3D12DDI_BEGIN_RENDER_PASS = System.IntPtr;
using PFND3D12DDI_END_RENDER_PASS = System.IntPtr;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_RENDER_PASS_FUNCS_0043
    {
        public IntPtr pfnBeginRenderPass;
        public IntPtr pfnEndRenderPass;
    }
}
