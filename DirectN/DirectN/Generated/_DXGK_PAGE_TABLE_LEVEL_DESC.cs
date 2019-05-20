// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\d3dkmddi.h(1767,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_PAGE_TABLE_LEVEL_DESC
    {
        public uint PageTableIndexBitCount;
        public uint PageTableSegmentId;
        public uint PagingProcessPageTableSegmentId;
        public uint PageTableSizeInBytes;
        public uint PageTableAlignmentInBytes;
    }
}
