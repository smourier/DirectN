// generated from <Windows SDK Path>\um\d3d12umddi.h
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_RENDER_PASS_ENDING_ACCESS_0053__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 92)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public D3D12DDI_RENDER_PASS_ENDING_ACCESS_RESOLVE_PARAMETERS_0053 Resolve { get => InteropRuntime.Get<D3D12DDI_RENDER_PASS_ENDING_ACCESS_RESOLVE_PARAMETERS_0053>(__bits, 0, 736); set { if (__bits == null) __bits = new byte[92]; InteropRuntime.Set<D3D12DDI_RENDER_PASS_ENDING_ACCESS_RESOLVE_PARAMETERS_0053>(value, __bits, 0, 736); } }
    }
}
