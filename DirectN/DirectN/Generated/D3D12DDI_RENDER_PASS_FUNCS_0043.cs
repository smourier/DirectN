// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d12umddi.h(10501,9)
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
