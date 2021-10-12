// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d11.h(3484,5)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_SHADER_RESOURCE_VIEW_DESC__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public D3D11_BUFFER_SRV Buffer { get => InteropRuntime.Get<D3D11_BUFFER_SRV>(__bits, 0, 64); set { if (__bits == null) __bits = new byte[16]; InteropRuntime.Set<D3D11_BUFFER_SRV>(value, __bits, 0, 64); } }
        public D3D11_TEX1D_SRV Texture1D { get => InteropRuntime.Get<D3D11_TEX1D_SRV>(__bits, 0, 64); set { if (__bits == null) __bits = new byte[16]; InteropRuntime.Set<D3D11_TEX1D_SRV>(value, __bits, 0, 64); } }
        public D3D11_TEX1D_ARRAY_SRV Texture1DArray { get => InteropRuntime.Get<D3D11_TEX1D_ARRAY_SRV>(__bits, 0, 128); set { if (__bits == null) __bits = new byte[16]; InteropRuntime.Set<D3D11_TEX1D_ARRAY_SRV>(value, __bits, 0, 128); } }
        public D3D11_TEX2D_SRV Texture2D { get => InteropRuntime.Get<D3D11_TEX2D_SRV>(__bits, 0, 64); set { if (__bits == null) __bits = new byte[16]; InteropRuntime.Set<D3D11_TEX2D_SRV>(value, __bits, 0, 64); } }
        public D3D11_TEX2D_ARRAY_SRV Texture2DArray { get => InteropRuntime.Get<D3D11_TEX2D_ARRAY_SRV>(__bits, 0, 128); set { if (__bits == null) __bits = new byte[16]; InteropRuntime.Set<D3D11_TEX2D_ARRAY_SRV>(value, __bits, 0, 128); } }
        public D3D11_TEX2DMS_SRV Texture2DMS { get => InteropRuntime.Get<D3D11_TEX2DMS_SRV>(__bits, 0, 32); set { if (__bits == null) __bits = new byte[16]; InteropRuntime.Set<D3D11_TEX2DMS_SRV>(value, __bits, 0, 32); } }
        public D3D11_TEX2DMS_ARRAY_SRV Texture2DMSArray { get => InteropRuntime.Get<D3D11_TEX2DMS_ARRAY_SRV>(__bits, 0, 64); set { if (__bits == null) __bits = new byte[16]; InteropRuntime.Set<D3D11_TEX2DMS_ARRAY_SRV>(value, __bits, 0, 64); } }
        public D3D11_TEX3D_SRV Texture3D { get => InteropRuntime.Get<D3D11_TEX3D_SRV>(__bits, 0, 64); set { if (__bits == null) __bits = new byte[16]; InteropRuntime.Set<D3D11_TEX3D_SRV>(value, __bits, 0, 64); } }
        public D3D11_TEXCUBE_SRV TextureCube { get => InteropRuntime.Get<D3D11_TEXCUBE_SRV>(__bits, 0, 64); set { if (__bits == null) __bits = new byte[16]; InteropRuntime.Set<D3D11_TEXCUBE_SRV>(value, __bits, 0, 64); } }
        public D3D11_TEXCUBE_ARRAY_SRV TextureCubeArray { get => InteropRuntime.Get<D3D11_TEXCUBE_ARRAY_SRV>(__bits, 0, 128); set { if (__bits == null) __bits = new byte[16]; InteropRuntime.Set<D3D11_TEXCUBE_ARRAY_SRV>(value, __bits, 0, 128); } }
        public D3D11_BUFFEREX_SRV BufferEx { get => InteropRuntime.Get<D3D11_BUFFEREX_SRV>(__bits, 0, 96); set { if (__bits == null) __bits = new byte[16]; InteropRuntime.Set<D3D11_BUFFEREX_SRV>(value, __bits, 0, 96); } }
    }
}
