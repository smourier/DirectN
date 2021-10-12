// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12umddi.h(4736,5)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDIARG_RESOURCE_BARRIER_0022__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 40)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public D3D12DDI_RESOURCE_TRANSITION_BARRIER_0003 Transition { get => InteropRuntime.Get<D3D12DDI_RESOURCE_TRANSITION_BARRIER_0003>(__bits, 0, 160); set { if (__bits == null) __bits = new byte[40]; InteropRuntime.Set<D3D12DDI_RESOURCE_TRANSITION_BARRIER_0003>(value, __bits, 0, 160); } }
        public D3D12DDI_RESOURCE_RANGED_BARRIER_0022 Ranged { get => InteropRuntime.Get<D3D12DDI_RESOURCE_RANGED_BARRIER_0022>(__bits, 0, 320); set { if (__bits == null) __bits = new byte[40]; InteropRuntime.Set<D3D12DDI_RESOURCE_RANGED_BARRIER_0022>(value, __bits, 0, 320); } }
        public D3D12DDI_RESOURCE_UAV_BARRIER UAV { get => InteropRuntime.Get<D3D12DDI_RESOURCE_UAV_BARRIER>(__bits, 0, 64); set { if (__bits == null) __bits = new byte[40]; InteropRuntime.Set<D3D12DDI_RESOURCE_UAV_BARRIER>(value, __bits, 0, 64); } }
    }
}
