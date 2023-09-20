// generated from <Windows SDK Path>\um\d3d12umddi.h
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDIARG_CREATE_RENDER_TARGET_VIEW_0002__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public D3D12DDIARG_BUFFER_RENDER_TARGET_VIEW Buffer { get => InteropRuntime.Get<D3D12DDIARG_BUFFER_RENDER_TARGET_VIEW>(__bits, 0, 96); set { if (__bits == null) __bits = new byte[16]; InteropRuntime.Set<D3D12DDIARG_BUFFER_RENDER_TARGET_VIEW>(value, __bits, 0, 96); } }
        public D3D12DDIARG_TEX1D_RENDER_TARGET_VIEW Tex1D { get => InteropRuntime.Get<D3D12DDIARG_TEX1D_RENDER_TARGET_VIEW>(__bits, 0, 96); set { if (__bits == null) __bits = new byte[16]; InteropRuntime.Set<D3D12DDIARG_TEX1D_RENDER_TARGET_VIEW>(value, __bits, 0, 96); } }
        public D3D12DDIARG_TEX2D_RENDER_TARGET_VIEW_0002 Tex2D { get => InteropRuntime.Get<D3D12DDIARG_TEX2D_RENDER_TARGET_VIEW_0002>(__bits, 0, 128); set { if (__bits == null) __bits = new byte[16]; InteropRuntime.Set<D3D12DDIARG_TEX2D_RENDER_TARGET_VIEW_0002>(value, __bits, 0, 128); } }
        public D3D12DDIARG_TEX3D_RENDER_TARGET_VIEW Tex3D { get => InteropRuntime.Get<D3D12DDIARG_TEX3D_RENDER_TARGET_VIEW>(__bits, 0, 96); set { if (__bits == null) __bits = new byte[16]; InteropRuntime.Set<D3D12DDIARG_TEX3D_RENDER_TARGET_VIEW>(value, __bits, 0, 96); } }
        public D3D12DDIARG_TEXCUBE_RENDER_TARGET_VIEW TexCube { get => InteropRuntime.Get<D3D12DDIARG_TEXCUBE_RENDER_TARGET_VIEW>(__bits, 0, 96); set { if (__bits == null) __bits = new byte[16]; InteropRuntime.Set<D3D12DDIARG_TEXCUBE_RENDER_TARGET_VIEW>(value, __bits, 0, 96); } }
    }
}
