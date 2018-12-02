// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\d3dukmdt.h(1640,5)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDI_SYNCHRONIZATIONOBJECTINFO2__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public byte[] __bits;
        public _D3DDDI_SYNCHRONIZATIONOBJECTINFO2__union_0__struct_0 SynchronizationMutex => InteropRuntime.Get<_D3DDDI_SYNCHRONIZATIONOBJECTINFO2__union_0__struct_0>(__bits, 0, 32);
        public _D3DDDI_SYNCHRONIZATIONOBJECTINFO2__union_0__struct_1 Semaphore => InteropRuntime.Get<_D3DDDI_SYNCHRONIZATIONOBJECTINFO2__union_0__struct_1>(__bits, 0, 64);
        public _D3DDDI_SYNCHRONIZATIONOBJECTINFO2__union_0__struct_2 Fence => InteropRuntime.Get<_D3DDDI_SYNCHRONIZATIONOBJECTINFO2__union_0__struct_2>(__bits, 0, 64);
        public _D3DDDI_SYNCHRONIZATIONOBJECTINFO2__union_0__struct_3 CPUNotification => InteropRuntime.Get<_D3DDDI_SYNCHRONIZATIONOBJECTINFO2__union_0__struct_3>(__bits, 0, 64);
        public _D3DDDI_SYNCHRONIZATIONOBJECTINFO2__union_0__struct_4 MonitoredFence => InteropRuntime.Get<_D3DDDI_SYNCHRONIZATIONOBJECTINFO2__union_0__struct_4>(__bits, 0, 224);
        public _D3DDDI_SYNCHRONIZATIONOBJECTINFO2__union_0__struct_5 PeriodicMonitoredFence => InteropRuntime.Get<_D3DDDI_SYNCHRONIZATIONOBJECTINFO2__union_0__struct_5>(__bits, 0, 288);
        public _D3DDDI_SYNCHRONIZATIONOBJECTINFO2__union_0__struct_6 Reserved => InteropRuntime.Get<_D3DDDI_SYNCHRONIZATIONOBJECTINFO2__union_0__struct_6>(__bits, 0, 512);
    }
}
