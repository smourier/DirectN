// generated from <Windows SDK Path>\um\d3d12umddi.h
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDIARG_CREATE_DEPTH_STENCIL_VIEW__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public D3D12DDIARG_TEX1D_DEPTH_STENCIL_VIEW Tex1D {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<D3D12DDIARG_TEX1D_DEPTH_STENCIL_VIEW>(__bits, 0, 96);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[12]; InteropRuntime.Set<D3D12DDIARG_TEX1D_DEPTH_STENCIL_VIEW>(value, __bits, 0, 96); } }
        public D3D12DDIARG_TEX2D_DEPTH_STENCIL_VIEW Tex2D {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<D3D12DDIARG_TEX2D_DEPTH_STENCIL_VIEW>(__bits, 0, 96);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[12]; InteropRuntime.Set<D3D12DDIARG_TEX2D_DEPTH_STENCIL_VIEW>(value, __bits, 0, 96); } }
        public D3D12DDIARG_TEXCUBE_DEPTH_STENCIL_VIEW TexCube {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<D3D12DDIARG_TEXCUBE_DEPTH_STENCIL_VIEW>(__bits, 0, 96);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[12]; InteropRuntime.Set<D3D12DDIARG_TEXCUBE_DEPTH_STENCIL_VIEW>(value, __bits, 0, 96); } }
    }
}
