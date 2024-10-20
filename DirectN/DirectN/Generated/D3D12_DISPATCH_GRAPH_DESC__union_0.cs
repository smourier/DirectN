// generated from <Windows SDK Path>\um\d3d12.h
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_DISPATCH_GRAPH_DESC__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 24)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public D3D12_NODE_CPU_INPUT NodeCPUInput {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<D3D12_NODE_CPU_INPUT>(__bits, 0, 192);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[24]; InteropRuntime.Set<D3D12_NODE_CPU_INPUT>(value, __bits, 0, 192); } }
        public ulong NodeGPUInput {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetUInt64(__bits, 0, 64);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[24]; InteropRuntime.SetUInt64(value, __bits, 0, 64); } }
        public D3D12_MULTI_NODE_CPU_INPUT MultiNodeCPUInput {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<D3D12_MULTI_NODE_CPU_INPUT>(__bits, 0, 192);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[24]; InteropRuntime.Set<D3D12_MULTI_NODE_CPU_INPUT>(value, __bits, 0, 192); } }
        public ulong MultiNodeGPUInput {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetUInt64(__bits, 0, 64);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[24]; InteropRuntime.SetUInt64(value, __bits, 0, 64); } }
    }
}
