// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3d12.h(17483,9)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_RENDER_PASS_RENDER_TARGET_DESC
    {
        public D3D12_CPU_DESCRIPTOR_HANDLE cpuDescriptor;
        public D3D12_RENDER_PASS_BEGINNING_ACCESS BeginningAccess;
        public D3D12_RENDER_PASS_ENDING_ACCESS EndingAccess;
    }
}
