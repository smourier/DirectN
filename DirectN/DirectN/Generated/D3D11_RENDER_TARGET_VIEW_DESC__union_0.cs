// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d11.h(3915,5)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_RENDER_TARGET_VIEW_DESC__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public D3D11_BUFFER_RTV Buffer { get => InteropRuntime.Get<D3D11_BUFFER_RTV>(__bits, 0, 64); set { if (__bits == null) __bits = new byte[12]; InteropRuntime.Set<D3D11_BUFFER_RTV>(value, __bits, 0, 64); } }
        public D3D11_TEX1D_RTV Texture1D { get => InteropRuntime.Get<D3D11_TEX1D_RTV>(__bits, 0, 32); set { if (__bits == null) __bits = new byte[12]; InteropRuntime.Set<D3D11_TEX1D_RTV>(value, __bits, 0, 32); } }
        public D3D11_TEX1D_ARRAY_RTV Texture1DArray { get => InteropRuntime.Get<D3D11_TEX1D_ARRAY_RTV>(__bits, 0, 96); set { if (__bits == null) __bits = new byte[12]; InteropRuntime.Set<D3D11_TEX1D_ARRAY_RTV>(value, __bits, 0, 96); } }
        public D3D11_TEX2D_RTV Texture2D { get => InteropRuntime.Get<D3D11_TEX2D_RTV>(__bits, 0, 32); set { if (__bits == null) __bits = new byte[12]; InteropRuntime.Set<D3D11_TEX2D_RTV>(value, __bits, 0, 32); } }
        public D3D11_TEX2D_ARRAY_RTV Texture2DArray { get => InteropRuntime.Get<D3D11_TEX2D_ARRAY_RTV>(__bits, 0, 96); set { if (__bits == null) __bits = new byte[12]; InteropRuntime.Set<D3D11_TEX2D_ARRAY_RTV>(value, __bits, 0, 96); } }
        public D3D11_TEX2DMS_RTV Texture2DMS { get => InteropRuntime.Get<D3D11_TEX2DMS_RTV>(__bits, 0, 32); set { if (__bits == null) __bits = new byte[12]; InteropRuntime.Set<D3D11_TEX2DMS_RTV>(value, __bits, 0, 32); } }
        public D3D11_TEX2DMS_ARRAY_RTV Texture2DMSArray { get => InteropRuntime.Get<D3D11_TEX2DMS_ARRAY_RTV>(__bits, 0, 64); set { if (__bits == null) __bits = new byte[12]; InteropRuntime.Set<D3D11_TEX2DMS_ARRAY_RTV>(value, __bits, 0, 64); } }
        public D3D11_TEX3D_RTV Texture3D { get => InteropRuntime.Get<D3D11_TEX3D_RTV>(__bits, 0, 96); set { if (__bits == null) __bits = new byte[12]; InteropRuntime.Set<D3D11_TEX3D_RTV>(value, __bits, 0, 96); } }
    }
}
