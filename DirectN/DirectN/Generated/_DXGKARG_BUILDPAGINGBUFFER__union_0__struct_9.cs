// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_BUILDPAGINGBUFFER__union_0__struct_9
    {
        public IntPtr hDevice;
        public IntPtr hAllocation;
        public uint SegmentId;
        public IntPtr OffsetInPages;
        public IntPtr NumberOfPages;
        public _DXGK_ADL Adl;
        public _DXGK_MAPAPERTUREFLAGS Flags;
        public uint AdlOffset;
        public IntPtr CpuVisibleAddress;
    }
}
