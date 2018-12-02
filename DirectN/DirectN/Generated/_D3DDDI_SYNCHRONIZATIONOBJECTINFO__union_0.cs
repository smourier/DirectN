// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\d3dukmdt.h(1556,5)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDI_SYNCHRONIZATIONOBJECTINFO__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public byte[] __bits;
        public _D3DDDI_SYNCHRONIZATIONOBJECTINFO__union_0__struct_0 SynchronizationMutex => InteropRuntime.Get<_D3DDDI_SYNCHRONIZATIONOBJECTINFO__union_0__struct_0>(__bits, 0, 32);
        public _D3DDDI_SYNCHRONIZATIONOBJECTINFO__union_0__struct_1 Semaphore => InteropRuntime.Get<_D3DDDI_SYNCHRONIZATIONOBJECTINFO__union_0__struct_1>(__bits, 0, 64);
        public _D3DDDI_SYNCHRONIZATIONOBJECTINFO__union_0__struct_2 Reserved => InteropRuntime.Get<_D3DDDI_SYNCHRONIZATIONOBJECTINFO__union_0__struct_2>(__bits, 0, 512);
    }
}
