// generated from <Windows SDK Path>\shared\d3dukmdt.h
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDI_SYNCHRONIZATIONOBJECTINFO2__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public _D3DDDI_SYNCHRONIZATIONOBJECTINFO2__union_0__struct_0 SynchronizationMutex {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_D3DDDI_SYNCHRONIZATIONOBJECTINFO2__union_0__struct_0>(__bits, 0, 32);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[64]; InteropRuntime.Set<_D3DDDI_SYNCHRONIZATIONOBJECTINFO2__union_0__struct_0>(value, __bits, 0, 32); } }
        public _D3DDDI_SYNCHRONIZATIONOBJECTINFO2__union_0__struct_1 Semaphore {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_D3DDDI_SYNCHRONIZATIONOBJECTINFO2__union_0__struct_1>(__bits, 0, 64);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[64]; InteropRuntime.Set<_D3DDDI_SYNCHRONIZATIONOBJECTINFO2__union_0__struct_1>(value, __bits, 0, 64); } }
        public _D3DDDI_SYNCHRONIZATIONOBJECTINFO2__union_0__struct_2 Fence {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_D3DDDI_SYNCHRONIZATIONOBJECTINFO2__union_0__struct_2>(__bits, 0, 64);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[64]; InteropRuntime.Set<_D3DDDI_SYNCHRONIZATIONOBJECTINFO2__union_0__struct_2>(value, __bits, 0, 64); } }
        public _D3DDDI_SYNCHRONIZATIONOBJECTINFO2__union_0__struct_3 CPUNotification {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_D3DDDI_SYNCHRONIZATIONOBJECTINFO2__union_0__struct_3>(__bits, 0, 64);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[64]; InteropRuntime.Set<_D3DDDI_SYNCHRONIZATIONOBJECTINFO2__union_0__struct_3>(value, __bits, 0, 64); } }
        public _D3DDDI_SYNCHRONIZATIONOBJECTINFO2__union_0__struct_4 MonitoredFence {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_D3DDDI_SYNCHRONIZATIONOBJECTINFO2__union_0__struct_4>(__bits, 0, 256);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[64]; InteropRuntime.Set<_D3DDDI_SYNCHRONIZATIONOBJECTINFO2__union_0__struct_4>(value, __bits, 0, 256); } }
        public _D3DDDI_SYNCHRONIZATIONOBJECTINFO2__union_0__struct_5 PeriodicMonitoredFence {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_D3DDDI_SYNCHRONIZATIONOBJECTINFO2__union_0__struct_5>(__bits, 0, 320);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[64]; InteropRuntime.Set<_D3DDDI_SYNCHRONIZATIONOBJECTINFO2__union_0__struct_5>(value, __bits, 0, 320); } }
        public _D3DDDI_SYNCHRONIZATIONOBJECTINFO2__union_0__struct_6 Reserved {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_D3DDDI_SYNCHRONIZATIONOBJECTINFO2__union_0__struct_6>(__bits, 0, 512);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[64]; InteropRuntime.Set<_D3DDDI_SYNCHRONIZATIONOBJECTINFO2__union_0__struct_6>(value, __bits, 0, 512); } }
    }
}
