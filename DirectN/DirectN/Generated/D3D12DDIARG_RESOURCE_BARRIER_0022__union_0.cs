// generated from <Windows SDK Path>\um\d3d12umddi.h
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDIARG_RESOURCE_BARRIER_0022__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public D3D12DDI_RESOURCE_TRANSITION_BARRIER_0003 Transition {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<D3D12DDI_RESOURCE_TRANSITION_BARRIER_0003>(__bits, 0, 192);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[32]; InteropRuntime.Set<D3D12DDI_RESOURCE_TRANSITION_BARRIER_0003>(value, __bits, 0, 192); } }
        public D3D12DDI_RESOURCE_RANGED_BARRIER_0022 Ranged {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<D3D12DDI_RESOURCE_RANGED_BARRIER_0022>(__bits, 0, 256);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[32]; InteropRuntime.Set<D3D12DDI_RESOURCE_RANGED_BARRIER_0022>(value, __bits, 0, 256); } }
        public D3D12DDI_RESOURCE_UAV_BARRIER UAV {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<D3D12DDI_RESOURCE_UAV_BARRIER>(__bits, 0, 64);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[32]; InteropRuntime.Set<D3D12DDI_RESOURCE_UAV_BARRIER>(value, __bits, 0, 64); } }
    }
}
