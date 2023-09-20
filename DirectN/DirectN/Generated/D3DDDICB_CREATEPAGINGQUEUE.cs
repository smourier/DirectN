// generated from <Windows SDK Path>\um\d3dumddi.h
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
