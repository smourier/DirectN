// generated from <Windows SDK Path>\shared\d3dkmddi.h
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
