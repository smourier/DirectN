// generated from <Windows SDK Path>\um\d3d12umddi.h
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_ROOT_PARAMETER_0013__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public D3D12DDI_ROOT_DESCRIPTOR_TABLE_0013 DescriptorTable {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<D3D12DDI_ROOT_DESCRIPTOR_TABLE_0013>(__bits, 0, 128);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[16]; InteropRuntime.Set<D3D12DDI_ROOT_DESCRIPTOR_TABLE_0013>(value, __bits, 0, 128); } }
        public D3D12DDI_ROOT_CONSTANTS Constants {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<D3D12DDI_ROOT_CONSTANTS>(__bits, 0, 96);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[16]; InteropRuntime.Set<D3D12DDI_ROOT_CONSTANTS>(value, __bits, 0, 96); } }
        public D3D12DDI_ROOT_DESCRIPTOR_0013 Descriptor {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<D3D12DDI_ROOT_DESCRIPTOR_0013>(__bits, 0, 96);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[16]; InteropRuntime.Set<D3D12DDI_ROOT_DESCRIPTOR_0013>(value, __bits, 0, 96); } }
    }
}
