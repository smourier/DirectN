// generated from <Windows SDK Path>\um\d3d12umddi.h
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDIARG_BARRIER_0088__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 72)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public D3D12DDI_GLOBAL_BARRIER_0088 GlobalBarrier {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<D3D12DDI_GLOBAL_BARRIER_0088>(__bits, 0, 128);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[72]; InteropRuntime.Set<D3D12DDI_GLOBAL_BARRIER_0088>(value, __bits, 0, 128); } }
        public D3D12DDI_TEXTURE_BARRIER_0088 TextureBarrier {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<D3D12DDI_TEXTURE_BARRIER_0088>(__bits, 0, 512);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[72]; InteropRuntime.Set<D3D12DDI_TEXTURE_BARRIER_0088>(value, __bits, 0, 512); } }
        public D3D12DDI_BUFFER_BARRIER_0088 BufferBarrier {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<D3D12DDI_BUFFER_BARRIER_0088>(__bits, 0, 192);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[72]; InteropRuntime.Set<D3D12DDI_BUFFER_BARRIER_0088>(value, __bits, 0, 192); } }
        public D3D12DDI_RANGED_BARRIER_0088 RangedBarrier {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<D3D12DDI_RANGED_BARRIER_0088>(__bits, 0, 576);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[72]; InteropRuntime.Set<D3D12DDI_RANGED_BARRIER_0088>(value, __bits, 0, 576); } }
    }
}
