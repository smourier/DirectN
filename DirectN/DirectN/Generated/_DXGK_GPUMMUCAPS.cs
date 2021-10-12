// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmddi.h(2031,9)
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
