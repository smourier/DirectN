// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d11_3.h(1623,5)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_UNORDERED_ACCESS_VIEW_DESC1__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public byte[] __bits;
        public D3D11_BUFFER_UAV Buffer => InteropRuntime.GetBits<D3D11_BUFFER_UAV>(__bits, 0, 96);
        public D3D11_TEX1D_UAV Texture1D => InteropRuntime.GetBits<D3D11_TEX1D_UAV>(__bits, 0, 32);
        public D3D11_TEX1D_ARRAY_UAV Texture1DArray => InteropRuntime.GetBits<D3D11_TEX1D_ARRAY_UAV>(__bits, 0, 96);
        public D3D11_TEX2D_UAV1 Texture2D => InteropRuntime.GetBits<D3D11_TEX2D_UAV1>(__bits, 0, 64);
        public D3D11_TEX2D_ARRAY_UAV1 Texture2DArray => InteropRuntime.GetBits<D3D11_TEX2D_ARRAY_UAV1>(__bits, 0, 128);
        public D3D11_TEX3D_UAV Texture3D => InteropRuntime.GetBits<D3D11_TEX3D_UAV>(__bits, 0, 96);
    }
}
