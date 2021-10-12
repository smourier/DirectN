// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12umddi.h(14091,5)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_RENDER_PASS_BEGINNING_ACCESS_0053__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public D3D12DDI_RENDER_PASS_BEGINNING_ACCESS_CLEAR_PARAMETERS_0053 Clear { get => InteropRuntime.Get<D3D12DDI_RENDER_PASS_BEGINNING_ACCESS_CLEAR_PARAMETERS_0053>(__bits, 0, 256); set { if (__bits == null) __bits = new byte[32]; InteropRuntime.Set<D3D12DDI_RENDER_PASS_BEGINNING_ACCESS_CLEAR_PARAMETERS_0053>(value, __bits, 0, 256); } }
    }
}
