// c:\program files (x86)\windows kits\10\include\10.0.22621.0\shared\d3dukmdt.h(1816,5)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDI_SYNCHRONIZATIONOBJECTINFO2__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public _D3DDDI_SYNCHRONIZATIONOBJECTINFO2__union_0__struct_0 SynchronizationMutex { get => InteropRuntime.Get<_D3DDDI_SYNCHRONIZATIONOBJECTINFO2__union_0__struct_0>(__bits, 0, 32); set { if (__bits == null) __bits = new byte[64]; InteropRuntime.Set<_D3DDDI_SYNCHRONIZATIONOBJECTINFO2__union_0__struct_0>(value, __bits, 0, 32); } }
        public _D3DDDI_SYNCHRONIZATIONOBJECTINFO2__union_0__struct_1 Semaphore { get => InteropRuntime.Get<_D3DDDI_SYNCHRONIZATIONOBJECTINFO2__union_0__struct_1>(__bits, 0, 64); set { if (__bits == null) __bits = new byte[64]; InteropRuntime.Set<_D3DDDI_SYNCHRONIZATIONOBJECTINFO2__union_0__struct_1>(value, __bits, 0, 64); } }
        public _D3DDDI_SYNCHRONIZATIONOBJECTINFO2__union_0__struct_2 Fence { get => InteropRuntime.Get<_D3DDDI_SYNCHRONIZATIONOBJECTINFO2__union_0__struct_2>(__bits, 0, 64); set { if (__bits == null) __bits = new byte[64]; InteropRuntime.Set<_D3DDDI_SYNCHRONIZATIONOBJECTINFO2__union_0__struct_2>(value, __bits, 0, 64); } }
        public _D3DDDI_SYNCHRONIZATIONOBJECTINFO2__union_0__struct_3 CPUNotification { get => InteropRuntime.Get<_D3DDDI_SYNCHRONIZATIONOBJECTINFO2__union_0__struct_3>(__bits, 0, 64); set { if (__bits == null) __bits = new byte[64]; InteropRuntime.Set<_D3DDDI_SYNCHRONIZATIONOBJECTINFO2__union_0__struct_3>(value, __bits, 0, 64); } }
        public _D3DDDI_SYNCHRONIZATIONOBJECTINFO2__union_0__struct_4 MonitoredFence { get => InteropRuntime.Get<_D3DDDI_SYNCHRONIZATIONOBJECTINFO2__union_0__struct_4>(__bits, 0, 256); set { if (__bits == null) __bits = new byte[64]; InteropRuntime.Set<_D3DDDI_SYNCHRONIZATIONOBJECTINFO2__union_0__struct_4>(value, __bits, 0, 256); } }
        public _D3DDDI_SYNCHRONIZATIONOBJECTINFO2__union_0__struct_5 PeriodicMonitoredFence { get => InteropRuntime.Get<_D3DDDI_SYNCHRONIZATIONOBJECTINFO2__union_0__struct_5>(__bits, 0, 320); set { if (__bits == null) __bits = new byte[64]; InteropRuntime.Set<_D3DDDI_SYNCHRONIZATIONOBJECTINFO2__union_0__struct_5>(value, __bits, 0, 320); } }
        public _D3DDDI_SYNCHRONIZATIONOBJECTINFO2__union_0__struct_6 Reserved { get => InteropRuntime.Get<_D3DDDI_SYNCHRONIZATIONOBJECTINFO2__union_0__struct_6>(__bits, 0, 512); set { if (__bits == null) __bits = new byte[64]; InteropRuntime.Set<_D3DDDI_SYNCHRONIZATIONOBJECTINFO2__union_0__struct_6>(value, __bits, 0, 512); } }
    }
}
