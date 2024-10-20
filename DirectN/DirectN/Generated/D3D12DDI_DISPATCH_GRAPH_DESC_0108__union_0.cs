// generated from <Windows SDK Path>\um\d3d12umddi.h
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_DISPATCH_GRAPH_DESC_0108__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 24)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public D3D12DDI_NODE_CPU_INPUT_0108 NodeCPUInput {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<D3D12DDI_NODE_CPU_INPUT_0108>(__bits, 0, 192);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[24]; InteropRuntime.Set<D3D12DDI_NODE_CPU_INPUT_0108>(value, __bits, 0, 192); } }
        public ulong NodeGPUInput {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetUInt64(__bits, 0, 64);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[24]; InteropRuntime.SetUInt64(value, __bits, 0, 64); } }
        public D3D12DDI_MULTI_NODE_CPU_INPUT_0108 MultiNodeCPUInput {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<D3D12DDI_MULTI_NODE_CPU_INPUT_0108>(__bits, 0, 192);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[24]; InteropRuntime.Set<D3D12DDI_MULTI_NODE_CPU_INPUT_0108>(value, __bits, 0, 192); } }
        public ulong MultiNodeGPUInput {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetUInt64(__bits, 0, 64);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[24]; InteropRuntime.SetUInt64(value, __bits, 0, 64); } }
    }
}
