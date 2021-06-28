// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3d12.h(2754,5)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_RESOURCE_BARRIER__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public D3D12_RESOURCE_TRANSITION_BARRIER Transition { get => InteropRuntime.Get<D3D12_RESOURCE_TRANSITION_BARRIER>(__bits, 0, 96); set { if (__bits == null) __bits = new byte[12]; InteropRuntime.Set<D3D12_RESOURCE_TRANSITION_BARRIER>(value, __bits, 0, 96); } }
        public D3D12_RESOURCE_ALIASING_BARRIER Aliasing { get => InteropRuntime.Get<D3D12_RESOURCE_ALIASING_BARRIER>(__bits, 0, 0); set { if (__bits == null) __bits = new byte[12]; InteropRuntime.Set<D3D12_RESOURCE_ALIASING_BARRIER>(value, __bits, 0, 0); } }
        public D3D12_RESOURCE_UAV_BARRIER UAV { get => InteropRuntime.Get<D3D12_RESOURCE_UAV_BARRIER>(__bits, 0, 0); set { if (__bits == null) __bits = new byte[12]; InteropRuntime.Set<D3D12_RESOURCE_UAV_BARRIER>(value, __bits, 0, 0); } }
    }
}
