// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_SEGMENTDESCRIPTOR5
    {
        public _DXGK_SEGMENTTYPE SegmentType;
        public _DXGK_SEGMENTFLAGS Flags;
        public long BaseAddress;
        public ulong Size;
        public IntPtr SystemMemoryEndAddress;
        public _DXGK_SEGMENTDESCRIPTOR5__union_0 __union_5;
        public IntPtr VprRangeStartOffset;
        public IntPtr VprRangeSize;
        public uint VprAlignment;
        public uint NumInvalidMemoryRanges;
        public uint NumVprSupported;
        public uint VprReserveSize;
        public uint NumUEFIFrameBufferRanges;
        public _DXGK_PAGESIZE SlabSize;
    }
}
