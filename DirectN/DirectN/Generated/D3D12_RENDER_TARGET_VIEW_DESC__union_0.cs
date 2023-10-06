// generated from <Windows SDK Path>\um\d3d12.h
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_RENDER_TARGET_VIEW_DESC__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public D3D12_BUFFER_RTV Buffer {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<D3D12_BUFFER_RTV>(__bits, 0, 128);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[16]; InteropRuntime.Set<D3D12_BUFFER_RTV>(value, __bits, 0, 128); } }
        public D3D12_TEX1D_RTV Texture1D {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<D3D12_TEX1D_RTV>(__bits, 0, 32);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[16]; InteropRuntime.Set<D3D12_TEX1D_RTV>(value, __bits, 0, 32); } }
        public D3D12_TEX1D_ARRAY_RTV Texture1DArray {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<D3D12_TEX1D_ARRAY_RTV>(__bits, 0, 96);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[16]; InteropRuntime.Set<D3D12_TEX1D_ARRAY_RTV>(value, __bits, 0, 96); } }
        public D3D12_TEX2D_RTV Texture2D {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<D3D12_TEX2D_RTV>(__bits, 0, 64);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[16]; InteropRuntime.Set<D3D12_TEX2D_RTV>(value, __bits, 0, 64); } }
        public D3D12_TEX2D_ARRAY_RTV Texture2DArray {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<D3D12_TEX2D_ARRAY_RTV>(__bits, 0, 128);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[16]; InteropRuntime.Set<D3D12_TEX2D_ARRAY_RTV>(value, __bits, 0, 128); } }
        public D3D12_TEX2DMS_RTV Texture2DMS {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<D3D12_TEX2DMS_RTV>(__bits, 0, 32);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[16]; InteropRuntime.Set<D3D12_TEX2DMS_RTV>(value, __bits, 0, 32); } }
        public D3D12_TEX2DMS_ARRAY_RTV Texture2DMSArray {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<D3D12_TEX2DMS_ARRAY_RTV>(__bits, 0, 64);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[16]; InteropRuntime.Set<D3D12_TEX2DMS_ARRAY_RTV>(value, __bits, 0, 64); } }
        public D3D12_TEX3D_RTV Texture3D {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<D3D12_TEX3D_RTV>(__bits, 0, 96);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[16]; InteropRuntime.Set<D3D12_TEX3D_RTV>(value, __bits, 0, 96); } }
    }
}
