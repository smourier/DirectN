// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d12umddi.h(10454,5)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_RENDER_PASS_ENDING_ACCESS__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 88)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public D3D12DDI_RENDER_PASS_ENDING_ACCESS_RESOLVE_PARAMETERS Resolve { get => InteropRuntime.Get<D3D12DDI_RENDER_PASS_ENDING_ACCESS_RESOLVE_PARAMETERS>(__bits, 0, 704); set { if (__bits == null) __bits = new byte[88]; InteropRuntime.Set<D3D12DDI_RENDER_PASS_ENDING_ACCESS_RESOLVE_PARAMETERS>(value, __bits, 0, 704); } }
        public D3D12DDI_RENDER_PASS_ENDING_ACCESS_SUSPEND_LOCAL_READ_PARAMETERS SuspendLocalRead { get => InteropRuntime.Get<D3D12DDI_RENDER_PASS_ENDING_ACCESS_SUSPEND_LOCAL_READ_PARAMETERS>(__bits, 0, 64); set { if (__bits == null) __bits = new byte[88]; InteropRuntime.Set<D3D12DDI_RENDER_PASS_ENDING_ACCESS_SUSPEND_LOCAL_READ_PARAMETERS>(value, __bits, 0, 64); } }
    }
}
