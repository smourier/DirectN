// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_RECLAIMALLOCATIONS2
    {
        public uint hPagingQueue;
        public uint NumAllocations;
        public IntPtr pResources;
        public IntPtr HandleList;
        public _D3DKMT_RECLAIMALLOCATIONS2__union_0 __union_4;
        public ulong PagingFenceValue;
    }
}
