// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d12.h(3002,5)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_UNORDERED_ACCESS_VIEW_DESC__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 28)]
        public byte[] __bits;
        public D3D12_BUFFER_UAV Buffer => InteropRuntime.Get<D3D12_BUFFER_UAV>(__bits, 0, 224);
        public D3D12_TEX1D_UAV Texture1D => InteropRuntime.Get<D3D12_TEX1D_UAV>(__bits, 0, 32);
        public D3D12_TEX1D_ARRAY_UAV Texture1DArray => InteropRuntime.Get<D3D12_TEX1D_ARRAY_UAV>(__bits, 0, 96);
        public D3D12_TEX2D_UAV Texture2D => InteropRuntime.Get<D3D12_TEX2D_UAV>(__bits, 0, 64);
        public D3D12_TEX2D_ARRAY_UAV Texture2DArray => InteropRuntime.Get<D3D12_TEX2D_ARRAY_UAV>(__bits, 0, 128);
        public D3D12_TEX3D_UAV Texture3D => InteropRuntime.Get<D3D12_TEX3D_UAV>(__bits, 0, 96);
    }
}
