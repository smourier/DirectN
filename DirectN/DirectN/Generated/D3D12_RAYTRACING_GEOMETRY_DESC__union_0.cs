// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d12.h(12283,5)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_RAYTRACING_GEOMETRY_DESC__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 48)]
        public byte[] __bits;
        public D3D12_RAYTRACING_GEOMETRY_TRIANGLES_DESC Triangles => InteropRuntime.Get<D3D12_RAYTRACING_GEOMETRY_TRIANGLES_DESC>(__bits, 0, 384);
        public D3D12_RAYTRACING_GEOMETRY_AABBS_DESC AABBs => InteropRuntime.Get<D3D12_RAYTRACING_GEOMETRY_AABBS_DESC>(__bits, 0, 192);
    }
}
