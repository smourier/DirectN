// generated from <Windows SDK Path>\um\d3d12.h
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_SET_PROGRAM_DESC__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 80)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public D3D12_SET_GENERIC_PIPELINE_DESC GenericPipeline {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<D3D12_SET_GENERIC_PIPELINE_DESC>(__bits, 0, 256);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[80]; InteropRuntime.Set<D3D12_SET_GENERIC_PIPELINE_DESC>(value, __bits, 0, 256); } }
        public D3D12_SET_RAYTRACING_PIPELINE_DESC RaytracingPipeline {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<D3D12_SET_RAYTRACING_PIPELINE_DESC>(__bits, 0, 256);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[80]; InteropRuntime.Set<D3D12_SET_RAYTRACING_PIPELINE_DESC>(value, __bits, 0, 256); } }
        public D3D12_SET_WORK_GRAPH_DESC WorkGraph {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<D3D12_SET_WORK_GRAPH_DESC>(__bits, 0, 640);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[80]; InteropRuntime.Set<D3D12_SET_WORK_GRAPH_DESC>(value, __bits, 0, 640); } }
    }
}
