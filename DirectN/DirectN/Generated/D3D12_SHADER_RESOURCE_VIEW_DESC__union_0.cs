// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d12.h(2787,5)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_SHADER_RESOURCE_VIEW_DESC__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 24)]
        public byte[] __bits;
        public D3D12_BUFFER_SRV Buffer => InteropRuntime.GetBits<D3D12_BUFFER_SRV>(__bits, 0, 160);
        public D3D12_TEX1D_SRV Texture1D => InteropRuntime.GetBits<D3D12_TEX1D_SRV>(__bits, 0, 96);
        public D3D12_TEX1D_ARRAY_SRV Texture1DArray => InteropRuntime.GetBits<D3D12_TEX1D_ARRAY_SRV>(__bits, 0, 160);
        public D3D12_TEX2D_SRV Texture2D => InteropRuntime.GetBits<D3D12_TEX2D_SRV>(__bits, 0, 128);
        public D3D12_TEX2D_ARRAY_SRV Texture2DArray => InteropRuntime.GetBits<D3D12_TEX2D_ARRAY_SRV>(__bits, 0, 192);
        public D3D12_TEX2DMS_SRV Texture2DMS => InteropRuntime.GetBits<D3D12_TEX2DMS_SRV>(__bits, 0, 32);
        public D3D12_TEX2DMS_ARRAY_SRV Texture2DMSArray => InteropRuntime.GetBits<D3D12_TEX2DMS_ARRAY_SRV>(__bits, 0, 64);
        public D3D12_TEX3D_SRV Texture3D => InteropRuntime.GetBits<D3D12_TEX3D_SRV>(__bits, 0, 96);
        public D3D12_TEXCUBE_SRV TextureCube => InteropRuntime.GetBits<D3D12_TEXCUBE_SRV>(__bits, 0, 96);
        public D3D12_TEXCUBE_ARRAY_SRV TextureCubeArray => InteropRuntime.GetBits<D3D12_TEXCUBE_ARRAY_SRV>(__bits, 0, 160);
        public D3D12_RAYTRACING_ACCELERATION_STRUCTURE_SRV RaytracingAccelerationStructure => InteropRuntime.GetBits<D3D12_RAYTRACING_ACCELERATION_STRUCTURE_SRV>(__bits, 0, 64);
    }
}
