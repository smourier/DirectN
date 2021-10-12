// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3dumddi.h(3761,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3D12DDICB_RECLAIMALLOCATIONS2
    {
        public uint NumAllocations;
        public IntPtr HandleList;
        public IntPtr pDiscarded;
        public ulong PagingFenceValue;
    }
}
