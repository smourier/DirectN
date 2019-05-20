// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d12umddi.h(7770,5)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_RAYTRACING_GEOMETRY_DESC_0054__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 48)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public D3D12DDI_RAYTRACING_GEOMETRY_TRIANGLES_DESC_0054 Triangles { get => InteropRuntime.Get<D3D12DDI_RAYTRACING_GEOMETRY_TRIANGLES_DESC_0054>(__bits, 0, 384); set => InteropRuntime.Set<D3D12DDI_RAYTRACING_GEOMETRY_TRIANGLES_DESC_0054>(value, __bits, 0, 384); }
        public D3D12DDI_RAYTRACING_GEOMETRY_AABBS_DESC_0054 AABBs { get => InteropRuntime.Get<D3D12DDI_RAYTRACING_GEOMETRY_AABBS_DESC_0054>(__bits, 0, 192); set => InteropRuntime.Set<D3D12DDI_RAYTRACING_GEOMETRY_AABBS_DESC_0054>(value, __bits, 0, 192); }
    }
}
