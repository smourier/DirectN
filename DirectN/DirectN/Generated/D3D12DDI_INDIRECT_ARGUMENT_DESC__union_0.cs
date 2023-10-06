// generated from <Windows SDK Path>\um\d3d12umddi.h
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_INDIRECT_ARGUMENT_DESC__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public D3D12DDI_INDIRECT_ARGUMENT_DESC__union_0__struct_0 VertexBuffer {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<D3D12DDI_INDIRECT_ARGUMENT_DESC__union_0__struct_0>(__bits, 0, 32);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[12]; InteropRuntime.Set<D3D12DDI_INDIRECT_ARGUMENT_DESC__union_0__struct_0>(value, __bits, 0, 32); } }
        public D3D12DDI_INDIRECT_ARGUMENT_DESC__union_0__struct_1 Constant {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<D3D12DDI_INDIRECT_ARGUMENT_DESC__union_0__struct_1>(__bits, 0, 96);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[12]; InteropRuntime.Set<D3D12DDI_INDIRECT_ARGUMENT_DESC__union_0__struct_1>(value, __bits, 0, 96); } }
        public D3D12DDI_INDIRECT_ARGUMENT_DESC__union_0__struct_2 ConstantBufferView {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<D3D12DDI_INDIRECT_ARGUMENT_DESC__union_0__struct_2>(__bits, 0, 32);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[12]; InteropRuntime.Set<D3D12DDI_INDIRECT_ARGUMENT_DESC__union_0__struct_2>(value, __bits, 0, 32); } }
        public D3D12DDI_INDIRECT_ARGUMENT_DESC__union_0__struct_3 ShaderResourceView {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<D3D12DDI_INDIRECT_ARGUMENT_DESC__union_0__struct_3>(__bits, 0, 32);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[12]; InteropRuntime.Set<D3D12DDI_INDIRECT_ARGUMENT_DESC__union_0__struct_3>(value, __bits, 0, 32); } }
        public D3D12DDI_INDIRECT_ARGUMENT_DESC__union_0__struct_4 UnorderedAccessView {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<D3D12DDI_INDIRECT_ARGUMENT_DESC__union_0__struct_4>(__bits, 0, 32);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[12]; InteropRuntime.Set<D3D12DDI_INDIRECT_ARGUMENT_DESC__union_0__struct_4>(value, __bits, 0, 32); } }
    }
}
