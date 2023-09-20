// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_GPUMMUCAPS
    {
        public _DXGK_GPUMMUCAPS__union_0 __union_0;
        public _DXGK_PAGETABLEUPDATEMODE PageTableUpdateMode;
        public uint VirtualAddressBitCount;
        public uint LeafPageTableSizeFor64KPagesInBytes;
        public uint PageTableLevelCount;
        public _DXGK_GPUMMUCAPS__struct_1 LegacyBehaviors;
    }
}
