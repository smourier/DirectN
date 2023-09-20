// generated from <Windows SDK Path>\um\d3d12umddi.h
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDIARG_RENDER_PASS_DEPTH_STENCIL_DESC_0053
    {
        public D3D12DDI_CPU_DESCRIPTOR_HANDLE cpuDescriptor;
        public D3D12DDI_RENDER_PASS_BEGINNING_ACCESS_0053 DepthBeginningAccess;
        public D3D12DDI_RENDER_PASS_BEGINNING_ACCESS_0053 StencilBeginningAccess;
        public D3D12DDI_RENDER_PASS_ENDING_ACCESS_0053 DepthEndingAccess;
        public D3D12DDI_RENDER_PASS_ENDING_ACCESS_0053 StencilEndingAccess;
    }
}
