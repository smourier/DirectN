// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3d12.h(12484,5)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_RAYTRACING_GEOMETRY_DESC__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 48)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public D3D12_RAYTRACING_GEOMETRY_TRIANGLES_DESC Triangles { get => InteropRuntime.Get<D3D12_RAYTRACING_GEOMETRY_TRIANGLES_DESC>(__bits, 0, 384); set { if (__bits == null) __bits = new byte[48]; InteropRuntime.Set<D3D12_RAYTRACING_GEOMETRY_TRIANGLES_DESC>(value, __bits, 0, 384); } }
        public D3D12_RAYTRACING_GEOMETRY_AABBS_DESC AABBs { get => InteropRuntime.Get<D3D12_RAYTRACING_GEOMETRY_AABBS_DESC>(__bits, 0, 192); set { if (__bits == null) __bits = new byte[48]; InteropRuntime.Set<D3D12_RAYTRACING_GEOMETRY_AABBS_DESC>(value, __bits, 0, 192); } }
    }
}
