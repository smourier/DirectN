// generated from <Windows SDK Path>\um\d3d12umddi.h
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDIARG_CREATE_UNORDERED_ACCESS_VIEW_0002__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 40)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public D3D12DDIARG_BUFFER_UNORDERED_ACCESS_VIEW Buffer {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<D3D12DDIARG_BUFFER_UNORDERED_ACCESS_VIEW>(__bits, 0, 320);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[40]; InteropRuntime.Set<D3D12DDIARG_BUFFER_UNORDERED_ACCESS_VIEW>(value, __bits, 0, 320); } }
        public D3D12DDIARG_TEX1D_UNORDERED_ACCESS_VIEW Tex1D {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<D3D12DDIARG_TEX1D_UNORDERED_ACCESS_VIEW>(__bits, 0, 96);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[40]; InteropRuntime.Set<D3D12DDIARG_TEX1D_UNORDERED_ACCESS_VIEW>(value, __bits, 0, 96); } }
        public D3D12DDIARG_TEX2D_UNORDERED_ACCESS_VIEW_0002 Tex2D {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<D3D12DDIARG_TEX2D_UNORDERED_ACCESS_VIEW_0002>(__bits, 0, 128);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[40]; InteropRuntime.Set<D3D12DDIARG_TEX2D_UNORDERED_ACCESS_VIEW_0002>(value, __bits, 0, 128); } }
        public D3D12DDIARG_TEX3D_UNORDERED_ACCESS_VIEW Tex3D {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<D3D12DDIARG_TEX3D_UNORDERED_ACCESS_VIEW>(__bits, 0, 96);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[40]; InteropRuntime.Set<D3D12DDIARG_TEX3D_UNORDERED_ACCESS_VIEW>(value, __bits, 0, 96); } }
    }
}
