// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d12.h(2860,5)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_SHADER_RESOURCE_VIEW_DESC__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 24)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public D3D12_BUFFER_SRV Buffer { get => InteropRuntime.Get<D3D12_BUFFER_SRV>(__bits, 0, 160); set { if (__bits == null) __bits = new byte[24]; InteropRuntime.Set<D3D12_BUFFER_SRV>(value, __bits, 0, 160); } }
        public D3D12_TEX1D_SRV Texture1D { get => InteropRuntime.Get<D3D12_TEX1D_SRV>(__bits, 0, 96); set { if (__bits == null) __bits = new byte[24]; InteropRuntime.Set<D3D12_TEX1D_SRV>(value, __bits, 0, 96); } }
        public D3D12_TEX1D_ARRAY_SRV Texture1DArray { get => InteropRuntime.Get<D3D12_TEX1D_ARRAY_SRV>(__bits, 0, 160); set { if (__bits == null) __bits = new byte[24]; InteropRuntime.Set<D3D12_TEX1D_ARRAY_SRV>(value, __bits, 0, 160); } }
        public D3D12_TEX2D_SRV Texture2D { get => InteropRuntime.Get<D3D12_TEX2D_SRV>(__bits, 0, 128); set { if (__bits == null) __bits = new byte[24]; InteropRuntime.Set<D3D12_TEX2D_SRV>(value, __bits, 0, 128); } }
        public D3D12_TEX2D_ARRAY_SRV Texture2DArray { get => InteropRuntime.Get<D3D12_TEX2D_ARRAY_SRV>(__bits, 0, 192); set { if (__bits == null) __bits = new byte[24]; InteropRuntime.Set<D3D12_TEX2D_ARRAY_SRV>(value, __bits, 0, 192); } }
        public D3D12_TEX2DMS_SRV Texture2DMS { get => InteropRuntime.Get<D3D12_TEX2DMS_SRV>(__bits, 0, 32); set { if (__bits == null) __bits = new byte[24]; InteropRuntime.Set<D3D12_TEX2DMS_SRV>(value, __bits, 0, 32); } }
        public D3D12_TEX2DMS_ARRAY_SRV Texture2DMSArray { get => InteropRuntime.Get<D3D12_TEX2DMS_ARRAY_SRV>(__bits, 0, 64); set { if (__bits == null) __bits = new byte[24]; InteropRuntime.Set<D3D12_TEX2DMS_ARRAY_SRV>(value, __bits, 0, 64); } }
        public D3D12_TEX3D_SRV Texture3D { get => InteropRuntime.Get<D3D12_TEX3D_SRV>(__bits, 0, 96); set { if (__bits == null) __bits = new byte[24]; InteropRuntime.Set<D3D12_TEX3D_SRV>(value, __bits, 0, 96); } }
        public D3D12_TEXCUBE_SRV TextureCube { get => InteropRuntime.Get<D3D12_TEXCUBE_SRV>(__bits, 0, 96); set { if (__bits == null) __bits = new byte[24]; InteropRuntime.Set<D3D12_TEXCUBE_SRV>(value, __bits, 0, 96); } }
        public D3D12_TEXCUBE_ARRAY_SRV TextureCubeArray { get => InteropRuntime.Get<D3D12_TEXCUBE_ARRAY_SRV>(__bits, 0, 160); set { if (__bits == null) __bits = new byte[24]; InteropRuntime.Set<D3D12_TEXCUBE_ARRAY_SRV>(value, __bits, 0, 160); } }
        public D3D12_RAYTRACING_ACCELERATION_STRUCTURE_SRV RaytracingAccelerationStructure { get => InteropRuntime.Get<D3D12_RAYTRACING_ACCELERATION_STRUCTURE_SRV>(__bits, 0, 64); set { if (__bits == null) __bits = new byte[24]; InteropRuntime.Set<D3D12_RAYTRACING_ACCELERATION_STRUCTURE_SRV>(value, __bits, 0, 64); } }
    }
}
