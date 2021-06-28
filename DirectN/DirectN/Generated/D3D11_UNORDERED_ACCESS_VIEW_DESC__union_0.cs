// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3d11.h(4635,5)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_UNORDERED_ACCESS_VIEW_DESC__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public D3D11_BUFFER_UAV Buffer { get => InteropRuntime.Get<D3D11_BUFFER_UAV>(__bits, 0, 96); set { if (__bits == null) __bits = new byte[12]; InteropRuntime.Set<D3D11_BUFFER_UAV>(value, __bits, 0, 96); } }
        public D3D11_TEX1D_UAV Texture1D { get => InteropRuntime.Get<D3D11_TEX1D_UAV>(__bits, 0, 32); set { if (__bits == null) __bits = new byte[12]; InteropRuntime.Set<D3D11_TEX1D_UAV>(value, __bits, 0, 32); } }
        public D3D11_TEX1D_ARRAY_UAV Texture1DArray { get => InteropRuntime.Get<D3D11_TEX1D_ARRAY_UAV>(__bits, 0, 96); set { if (__bits == null) __bits = new byte[12]; InteropRuntime.Set<D3D11_TEX1D_ARRAY_UAV>(value, __bits, 0, 96); } }
        public D3D11_TEX2D_UAV Texture2D { get => InteropRuntime.Get<D3D11_TEX2D_UAV>(__bits, 0, 32); set { if (__bits == null) __bits = new byte[12]; InteropRuntime.Set<D3D11_TEX2D_UAV>(value, __bits, 0, 32); } }
        public D3D11_TEX2D_ARRAY_UAV Texture2DArray { get => InteropRuntime.Get<D3D11_TEX2D_ARRAY_UAV>(__bits, 0, 96); set { if (__bits == null) __bits = new byte[12]; InteropRuntime.Set<D3D11_TEX2D_ARRAY_UAV>(value, __bits, 0, 96); } }
        public D3D11_TEX3D_UAV Texture3D { get => InteropRuntime.Get<D3D11_TEX3D_UAV>(__bits, 0, 96); set { if (__bits == null) __bits = new byte[12]; InteropRuntime.Set<D3D11_TEX3D_UAV>(value, __bits, 0, 96); } }
    }
}
