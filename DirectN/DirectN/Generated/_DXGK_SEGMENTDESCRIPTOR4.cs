// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;
using PHYSICAL_ADDRESS = System.Int64;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_SEGMENTDESCRIPTOR4
    {
        public _DXGK_SEGMENTFLAGS Flags;
        public PHYSICAL_ADDRESS BaseAddress;
        public IntPtr Size;
        public IntPtr CommitLimit;
        public IntPtr SystemMemoryEndAddress;
        public _DXGK_SEGMENTDESCRIPTOR4__union_0 __union_5;
        public uint NumInvalidMemoryRanges;
        public IntPtr VprRangeStartOffset;
        public IntPtr VprRangeSize;
        public uint VprAlignment;
        public uint NumVprSupported;
        public uint VprReserveSize;
        public uint NumUEFIFrameBufferRanges;
    }
}
