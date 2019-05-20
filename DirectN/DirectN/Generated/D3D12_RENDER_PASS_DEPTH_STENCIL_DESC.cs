// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d12.h(15229,9)
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
