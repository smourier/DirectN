// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmddi.h(2239,9)
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
