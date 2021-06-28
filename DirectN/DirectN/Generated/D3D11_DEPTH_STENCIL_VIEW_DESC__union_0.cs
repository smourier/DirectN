// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3d11.h(4308,5)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_DEPTH_STENCIL_VIEW_DESC__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public D3D11_TEX1D_DSV Texture1D { get => InteropRuntime.Get<D3D11_TEX1D_DSV>(__bits, 0, 32); set { if (__bits == null) __bits = new byte[12]; InteropRuntime.Set<D3D11_TEX1D_DSV>(value, __bits, 0, 32); } }
        public D3D11_TEX1D_ARRAY_DSV Texture1DArray { get => InteropRuntime.Get<D3D11_TEX1D_ARRAY_DSV>(__bits, 0, 96); set { if (__bits == null) __bits = new byte[12]; InteropRuntime.Set<D3D11_TEX1D_ARRAY_DSV>(value, __bits, 0, 96); } }
        public D3D11_TEX2D_DSV Texture2D { get => InteropRuntime.Get<D3D11_TEX2D_DSV>(__bits, 0, 32); set { if (__bits == null) __bits = new byte[12]; InteropRuntime.Set<D3D11_TEX2D_DSV>(value, __bits, 0, 32); } }
        public D3D11_TEX2D_ARRAY_DSV Texture2DArray { get => InteropRuntime.Get<D3D11_TEX2D_ARRAY_DSV>(__bits, 0, 96); set { if (__bits == null) __bits = new byte[12]; InteropRuntime.Set<D3D11_TEX2D_ARRAY_DSV>(value, __bits, 0, 96); } }
        public D3D11_TEX2DMS_DSV Texture2DMS { get => InteropRuntime.Get<D3D11_TEX2DMS_DSV>(__bits, 0, 32); set { if (__bits == null) __bits = new byte[12]; InteropRuntime.Set<D3D11_TEX2DMS_DSV>(value, __bits, 0, 32); } }
        public D3D11_TEX2DMS_ARRAY_DSV Texture2DMSArray { get => InteropRuntime.Get<D3D11_TEX2DMS_ARRAY_DSV>(__bits, 0, 64); set { if (__bits == null) __bits = new byte[12]; InteropRuntime.Set<D3D11_TEX2DMS_ARRAY_DSV>(value, __bits, 0, 64); } }
    }
}
