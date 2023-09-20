// generated from <Windows SDK Path>\um\d3d12umddi.h
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDIARG_RESOURCE_BARRIER_0003__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public D3D12DDI_RESOURCE_TRANSITION_BARRIER_0003 Transition { get => InteropRuntime.Get<D3D12DDI_RESOURCE_TRANSITION_BARRIER_0003>(__bits, 0, 160); set { if (__bits == null) __bits = new byte[20]; InteropRuntime.Set<D3D12DDI_RESOURCE_TRANSITION_BARRIER_0003>(value, __bits, 0, 160); } }
        public D3D12DDI_RESOURCE_ALIASING_BARRIER Aliasing { get => InteropRuntime.Get<D3D12DDI_RESOURCE_ALIASING_BARRIER>(__bits, 0, 128); set { if (__bits == null) __bits = new byte[20]; InteropRuntime.Set<D3D12DDI_RESOURCE_ALIASING_BARRIER>(value, __bits, 0, 128); } }
        public D3D12DDI_RESOURCE_UAV_BARRIER UAV { get => InteropRuntime.Get<D3D12DDI_RESOURCE_UAV_BARRIER>(__bits, 0, 64); set { if (__bits == null) __bits = new byte[20]; InteropRuntime.Set<D3D12DDI_RESOURCE_UAV_BARRIER>(value, __bits, 0, 64); } }
    }
}
