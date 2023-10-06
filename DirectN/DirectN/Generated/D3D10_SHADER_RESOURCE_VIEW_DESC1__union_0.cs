// generated from <Windows SDK Path>\um\d3d10_1.h
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D10_SHADER_RESOURCE_VIEW_DESC1__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public D3D10_BUFFER_SRV Buffer {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<D3D10_BUFFER_SRV>(__bits, 0, 64);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[16]; InteropRuntime.Set<D3D10_BUFFER_SRV>(value, __bits, 0, 64); } }
        public D3D10_TEX1D_SRV Texture1D {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<D3D10_TEX1D_SRV>(__bits, 0, 64);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[16]; InteropRuntime.Set<D3D10_TEX1D_SRV>(value, __bits, 0, 64); } }
        public D3D10_TEX1D_ARRAY_SRV Texture1DArray {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<D3D10_TEX1D_ARRAY_SRV>(__bits, 0, 128);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[16]; InteropRuntime.Set<D3D10_TEX1D_ARRAY_SRV>(value, __bits, 0, 128); } }
        public D3D10_TEX2D_SRV Texture2D {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<D3D10_TEX2D_SRV>(__bits, 0, 64);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[16]; InteropRuntime.Set<D3D10_TEX2D_SRV>(value, __bits, 0, 64); } }
        public D3D10_TEX2D_ARRAY_SRV Texture2DArray {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<D3D10_TEX2D_ARRAY_SRV>(__bits, 0, 128);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[16]; InteropRuntime.Set<D3D10_TEX2D_ARRAY_SRV>(value, __bits, 0, 128); } }
        public D3D10_TEX2DMS_SRV Texture2DMS {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<D3D10_TEX2DMS_SRV>(__bits, 0, 32);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[16]; InteropRuntime.Set<D3D10_TEX2DMS_SRV>(value, __bits, 0, 32); } }
        public D3D10_TEX2DMS_ARRAY_SRV Texture2DMSArray {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<D3D10_TEX2DMS_ARRAY_SRV>(__bits, 0, 64);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[16]; InteropRuntime.Set<D3D10_TEX2DMS_ARRAY_SRV>(value, __bits, 0, 64); } }
        public D3D10_TEX3D_SRV Texture3D {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<D3D10_TEX3D_SRV>(__bits, 0, 64);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[16]; InteropRuntime.Set<D3D10_TEX3D_SRV>(value, __bits, 0, 64); } }
        public D3D10_TEXCUBE_SRV TextureCube {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<D3D10_TEXCUBE_SRV>(__bits, 0, 64);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[16]; InteropRuntime.Set<D3D10_TEXCUBE_SRV>(value, __bits, 0, 64); } }
        public D3D10_TEXCUBE_ARRAY_SRV1 TextureCubeArray {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<D3D10_TEXCUBE_ARRAY_SRV1>(__bits, 0, 128);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[16]; InteropRuntime.Set<D3D10_TEXCUBE_ARRAY_SRV1>(value, __bits, 0, 128); } }
    }
}
