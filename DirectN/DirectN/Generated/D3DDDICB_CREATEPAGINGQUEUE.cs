// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3dumddi.h(3921,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3DDDICB_CREATEPAGINGQUEUE
    {
        public D3DDDI_PAGINGQUEUE_PRIORITY Priority;
        public uint hPagingQueue;
        public uint hSyncObject;
        public IntPtr FenceValueCPUVirtualAddress;
        public uint PhysicalAdapterIndex;
    }
}
