// generated from <Windows SDK Path>\shared\d3dkmddi.h
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
