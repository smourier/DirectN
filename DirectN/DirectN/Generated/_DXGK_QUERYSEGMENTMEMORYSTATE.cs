// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmddi.h(2658,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_QUERYSEGMENTMEMORYSTATE
    {
        public ushort DriverSegmentId;
        public ushort PhysicalAdapterIndex;
        public _DXGK_QUERYSEGMENTMEMORYSTATE__union_0 __union_2;
        public IntPtr pMemoryRanges;
    }
}
