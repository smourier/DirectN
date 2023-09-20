// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_CREATEPAGINGQUEUE
    {
        public uint hDevice;
        public D3DDDI_PAGINGQUEUE_PRIORITY Priority;
        public uint hPagingQueue;
        public uint hSyncObject;
        public IntPtr FenceValueCPUVirtualAddress;
        public uint PhysicalAdapterIndex;
    }
}
