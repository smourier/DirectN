// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_VIRTUALADDRESSCAPS_DEPRECATED
    {
        public _DXGK_VIRTUALADDRESSCAPS_DEPRECATED__union_0 __union_0;
        public uint VirtualAddressBitCount;
        public uint PageTableCoverageBitCount;
        public uint PageDirectoryEntrySize;
        public uint PageDirectorySegment;
        public uint PageTableSegment;
        public uint IdealGPUPageSize;
    }
}
