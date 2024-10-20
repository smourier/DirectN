// generated from <Windows SDK Path>\um\d3d12.h
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_VERSIONED_ROOT_SIGNATURE_DESC__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 40)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public D3D12_ROOT_SIGNATURE_DESC Desc_1_0 {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<D3D12_ROOT_SIGNATURE_DESC>(__bits, 0, 320);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[40]; InteropRuntime.Set<D3D12_ROOT_SIGNATURE_DESC>(value, __bits, 0, 320); } }
        public D3D12_ROOT_SIGNATURE_DESC1 Desc_1_1 {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<D3D12_ROOT_SIGNATURE_DESC1>(__bits, 0, 320);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[40]; InteropRuntime.Set<D3D12_ROOT_SIGNATURE_DESC1>(value, __bits, 0, 320); } }
        public D3D12_ROOT_SIGNATURE_DESC2 Desc_1_2 {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<D3D12_ROOT_SIGNATURE_DESC2>(__bits, 0, 320);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[40]; InteropRuntime.Set<D3D12_ROOT_SIGNATURE_DESC2>(value, __bits, 0, 320); } }
    }
}
