// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_BUILDPAGINGBUFFER_NOTIFYRESIDENCY2
    {
        public IntPtr hAllocation;
        public uint AllocationOffsetInPages;
        public uint SizeInPages;
        public ushort SegmentId;
        public ushort Padding0;
        public _DXGK_BUILDPAGINGBUFFER_NOTIFYRESIDENCY2__union_0 __union_5;
        public _DXGK_BUILDPAGINGBUFFER_NOTIFYRESIDENCY2__struct_1 __field_6;
    }
}
