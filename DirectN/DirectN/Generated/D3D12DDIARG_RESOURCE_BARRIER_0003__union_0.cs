// generated from <Windows SDK Path>\um\d3d12umddi.h
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDIARG_RESOURCE_BARRIER_0003__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 24)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public D3D12DDI_RESOURCE_TRANSITION_BARRIER_0003 Transition {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<D3D12DDI_RESOURCE_TRANSITION_BARRIER_0003>(__bits, 0, 192);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[24]; InteropRuntime.Set<D3D12DDI_RESOURCE_TRANSITION_BARRIER_0003>(value, __bits, 0, 192); } }
        public D3D12DDI_RESOURCE_ALIASING_BARRIER Aliasing {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<D3D12DDI_RESOURCE_ALIASING_BARRIER>(__bits, 0, 128);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[24]; InteropRuntime.Set<D3D12DDI_RESOURCE_ALIASING_BARRIER>(value, __bits, 0, 128); } }
        public D3D12DDI_RESOURCE_UAV_BARRIER UAV {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<D3D12DDI_RESOURCE_UAV_BARRIER>(__bits, 0, 64);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[24]; InteropRuntime.Set<D3D12DDI_RESOURCE_UAV_BARRIER>(value, __bits, 0, 64); } }
    }
}
