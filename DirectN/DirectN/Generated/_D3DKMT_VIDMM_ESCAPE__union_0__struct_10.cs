// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\d3dkmthk.h(2603,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_VIDMM_ESCAPE__union_0__struct_10
    {
        public _D3DKMT_DEFRAG_ESCAPE_OPERATION Operation;
        public uint SegmentId;
        public ulong TotalCommitted;
        public ulong TotalFree;
        public ulong LargestGapBefore;
        public ulong LargestGapAfter;
    }
}
