// generated from <Windows SDK Path>\um\d3d10umddi.h
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11DDIARG_CREATESHADERRESOURCEVIEW__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public D3D10DDIARG_BUFFER_SHADERRESOURCEVIEW Buffer {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<D3D10DDIARG_BUFFER_SHADERRESOURCEVIEW>(__bits, 0, 64);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[16]; InteropRuntime.Set<D3D10DDIARG_BUFFER_SHADERRESOURCEVIEW>(value, __bits, 0, 64); } }
        public D3D10DDIARG_TEX1D_SHADERRESOURCEVIEW Tex1D {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<D3D10DDIARG_TEX1D_SHADERRESOURCEVIEW>(__bits, 0, 128);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[16]; InteropRuntime.Set<D3D10DDIARG_TEX1D_SHADERRESOURCEVIEW>(value, __bits, 0, 128); } }
        public D3D10DDIARG_TEX2D_SHADERRESOURCEVIEW Tex2D {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<D3D10DDIARG_TEX2D_SHADERRESOURCEVIEW>(__bits, 0, 128);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[16]; InteropRuntime.Set<D3D10DDIARG_TEX2D_SHADERRESOURCEVIEW>(value, __bits, 0, 128); } }
        public D3D10DDIARG_TEX3D_SHADERRESOURCEVIEW Tex3D {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<D3D10DDIARG_TEX3D_SHADERRESOURCEVIEW>(__bits, 0, 64);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[16]; InteropRuntime.Set<D3D10DDIARG_TEX3D_SHADERRESOURCEVIEW>(value, __bits, 0, 64); } }
        public D3D10_1DDIARG_TEXCUBE_SHADERRESOURCEVIEW TexCube {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<D3D10_1DDIARG_TEXCUBE_SHADERRESOURCEVIEW>(__bits, 0, 128);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[16]; InteropRuntime.Set<D3D10_1DDIARG_TEXCUBE_SHADERRESOURCEVIEW>(value, __bits, 0, 128); } }
        public D3D11DDIARG_BUFFEREX_SHADERRESOURCEVIEW BufferEx {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<D3D11DDIARG_BUFFEREX_SHADERRESOURCEVIEW>(__bits, 0, 96);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[16]; InteropRuntime.Set<D3D11DDIARG_BUFFEREX_SHADERRESOURCEVIEW>(value, __bits, 0, 96); } }
    }
}
