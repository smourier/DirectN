// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d12umddi.h(1238,5)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDIARG_CREATE_DEPTH_STENCIL_VIEW__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public D3D12DDIARG_TEX1D_DEPTH_STENCIL_VIEW Tex1D { get => InteropRuntime.Get<D3D12DDIARG_TEX1D_DEPTH_STENCIL_VIEW>(__bits, 0, 96); set { if (__bits == null) __bits = new byte[12]; InteropRuntime.Set<D3D12DDIARG_TEX1D_DEPTH_STENCIL_VIEW>(value, __bits, 0, 96); } }
        public D3D12DDIARG_TEX2D_DEPTH_STENCIL_VIEW Tex2D { get => InteropRuntime.Get<D3D12DDIARG_TEX2D_DEPTH_STENCIL_VIEW>(__bits, 0, 96); set { if (__bits == null) __bits = new byte[12]; InteropRuntime.Set<D3D12DDIARG_TEX2D_DEPTH_STENCIL_VIEW>(value, __bits, 0, 96); } }
        public D3D12DDIARG_TEXCUBE_DEPTH_STENCIL_VIEW TexCube { get => InteropRuntime.Get<D3D12DDIARG_TEXCUBE_DEPTH_STENCIL_VIEW>(__bits, 0, 96); set { if (__bits == null) __bits = new byte[12]; InteropRuntime.Set<D3D12DDIARG_TEXCUBE_DEPTH_STENCIL_VIEW>(value, __bits, 0, 96); } }
    }
}
