// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d12umddi.h(1141,5)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDIARG_CREATE_UNORDERED_ACCESS_VIEW_0002__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 36)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public D3D12DDIARG_BUFFER_UNORDERED_ACCESS_VIEW Buffer { get => InteropRuntime.Get<D3D12DDIARG_BUFFER_UNORDERED_ACCESS_VIEW>(__bits, 0, 288); set { if (__bits == null) __bits = new byte[36]; InteropRuntime.Set<D3D12DDIARG_BUFFER_UNORDERED_ACCESS_VIEW>(value, __bits, 0, 288); } }
        public D3D12DDIARG_TEX1D_UNORDERED_ACCESS_VIEW Tex1D { get => InteropRuntime.Get<D3D12DDIARG_TEX1D_UNORDERED_ACCESS_VIEW>(__bits, 0, 96); set { if (__bits == null) __bits = new byte[36]; InteropRuntime.Set<D3D12DDIARG_TEX1D_UNORDERED_ACCESS_VIEW>(value, __bits, 0, 96); } }
        public D3D12DDIARG_TEX2D_UNORDERED_ACCESS_VIEW_0002 Tex2D { get => InteropRuntime.Get<D3D12DDIARG_TEX2D_UNORDERED_ACCESS_VIEW_0002>(__bits, 0, 128); set { if (__bits == null) __bits = new byte[36]; InteropRuntime.Set<D3D12DDIARG_TEX2D_UNORDERED_ACCESS_VIEW_0002>(value, __bits, 0, 128); } }
        public D3D12DDIARG_TEX3D_UNORDERED_ACCESS_VIEW Tex3D { get => InteropRuntime.Get<D3D12DDIARG_TEX3D_UNORDERED_ACCESS_VIEW>(__bits, 0, 96); set { if (__bits == null) __bits = new byte[36]; InteropRuntime.Set<D3D12DDIARG_TEX3D_UNORDERED_ACCESS_VIEW>(value, __bits, 0, 96); } }
    }
}
