// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmthk.h(4404,9)
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
