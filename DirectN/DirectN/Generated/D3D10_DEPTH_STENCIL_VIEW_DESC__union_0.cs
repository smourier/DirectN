// generated from <Windows SDK Path>\um\d3d10.h
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D10_DEPTH_STENCIL_VIEW_DESC__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public D3D10_TEX1D_DSV Texture1D {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<D3D10_TEX1D_DSV>(__bits, 0, 32);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[12]; InteropRuntime.Set<D3D10_TEX1D_DSV>(value, __bits, 0, 32); } }
        public D3D10_TEX1D_ARRAY_DSV Texture1DArray {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<D3D10_TEX1D_ARRAY_DSV>(__bits, 0, 96);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[12]; InteropRuntime.Set<D3D10_TEX1D_ARRAY_DSV>(value, __bits, 0, 96); } }
        public D3D10_TEX2D_DSV Texture2D {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<D3D10_TEX2D_DSV>(__bits, 0, 32);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[12]; InteropRuntime.Set<D3D10_TEX2D_DSV>(value, __bits, 0, 32); } }
        public D3D10_TEX2D_ARRAY_DSV Texture2DArray {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<D3D10_TEX2D_ARRAY_DSV>(__bits, 0, 96);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[12]; InteropRuntime.Set<D3D10_TEX2D_ARRAY_DSV>(value, __bits, 0, 96); } }
        public D3D10_TEX2DMS_DSV Texture2DMS {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<D3D10_TEX2DMS_DSV>(__bits, 0, 32);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[12]; InteropRuntime.Set<D3D10_TEX2DMS_DSV>(value, __bits, 0, 32); } }
        public D3D10_TEX2DMS_ARRAY_DSV Texture2DMSArray {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<D3D10_TEX2DMS_ARRAY_DSV>(__bits, 0, 64);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[12]; InteropRuntime.Set<D3D10_TEX2DMS_ARRAY_DSV>(value, __bits, 0, 64); } }
    }
}
