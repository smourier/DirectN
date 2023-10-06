// generated from <Windows SDK Path>\um\d3d12.h
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_RAYTRACING_GEOMETRY_DESC__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 48)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public D3D12_RAYTRACING_GEOMETRY_TRIANGLES_DESC Triangles {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<D3D12_RAYTRACING_GEOMETRY_TRIANGLES_DESC>(__bits, 0, 384);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[48]; InteropRuntime.Set<D3D12_RAYTRACING_GEOMETRY_TRIANGLES_DESC>(value, __bits, 0, 384); } }
        public D3D12_RAYTRACING_GEOMETRY_AABBS_DESC AABBs {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<D3D12_RAYTRACING_GEOMETRY_AABBS_DESC>(__bits, 0, 192);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[48]; InteropRuntime.Set<D3D12_RAYTRACING_GEOMETRY_AABBS_DESC>(value, __bits, 0, 192); } }
    }
}
