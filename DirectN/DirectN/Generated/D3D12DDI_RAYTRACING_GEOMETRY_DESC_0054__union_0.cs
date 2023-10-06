// generated from <Windows SDK Path>\um\d3d12umddi.h
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_RAYTRACING_GEOMETRY_DESC_0054__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 48)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public D3D12DDI_RAYTRACING_GEOMETRY_TRIANGLES_DESC_0054 Triangles {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<D3D12DDI_RAYTRACING_GEOMETRY_TRIANGLES_DESC_0054>(__bits, 0, 384);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[48]; InteropRuntime.Set<D3D12DDI_RAYTRACING_GEOMETRY_TRIANGLES_DESC_0054>(value, __bits, 0, 384); } }
        public D3D12DDI_RAYTRACING_GEOMETRY_AABBS_DESC_0054 AABBs {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<D3D12DDI_RAYTRACING_GEOMETRY_AABBS_DESC_0054>(__bits, 0, 192);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[48]; InteropRuntime.Set<D3D12DDI_RAYTRACING_GEOMETRY_AABBS_DESC_0054>(value, __bits, 0, 192); } }
    }
}
