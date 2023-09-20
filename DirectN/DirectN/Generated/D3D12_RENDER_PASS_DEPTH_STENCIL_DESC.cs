// generated from <Windows SDK Path>\um\d3d12.h
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_RENDER_PASS_DEPTH_STENCIL_DESC
    {
        public D3D12_CPU_DESCRIPTOR_HANDLE cpuDescriptor;
        public D3D12_RENDER_PASS_BEGINNING_ACCESS DepthBeginningAccess;
        public D3D12_RENDER_PASS_BEGINNING_ACCESS StencilBeginningAccess;
        public D3D12_RENDER_PASS_ENDING_ACCESS DepthEndingAccess;
        public D3D12_RENDER_PASS_ENDING_ACCESS StencilEndingAccess;
    }
}
