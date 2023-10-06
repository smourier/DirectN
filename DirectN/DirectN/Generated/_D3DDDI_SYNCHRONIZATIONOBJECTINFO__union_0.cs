// generated from <Windows SDK Path>\shared\d3dukmdt.h
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDI_SYNCHRONIZATIONOBJECTINFO__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public _D3DDDI_SYNCHRONIZATIONOBJECTINFO__union_0__struct_0 SynchronizationMutex {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_D3DDDI_SYNCHRONIZATIONOBJECTINFO__union_0__struct_0>(__bits, 0, 32);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[64]; InteropRuntime.Set<_D3DDDI_SYNCHRONIZATIONOBJECTINFO__union_0__struct_0>(value, __bits, 0, 32); } }
        public _D3DDDI_SYNCHRONIZATIONOBJECTINFO__union_0__struct_1 Semaphore {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_D3DDDI_SYNCHRONIZATIONOBJECTINFO__union_0__struct_1>(__bits, 0, 64);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[64]; InteropRuntime.Set<_D3DDDI_SYNCHRONIZATIONOBJECTINFO__union_0__struct_1>(value, __bits, 0, 64); } }
        public _D3DDDI_SYNCHRONIZATIONOBJECTINFO__union_0__struct_2 Reserved {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_D3DDDI_SYNCHRONIZATIONOBJECTINFO__union_0__struct_2>(__bits, 0, 512);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[64]; InteropRuntime.Set<_D3DDDI_SYNCHRONIZATIONOBJECTINFO__union_0__struct_2>(value, __bits, 0, 512); } }
    }
}
