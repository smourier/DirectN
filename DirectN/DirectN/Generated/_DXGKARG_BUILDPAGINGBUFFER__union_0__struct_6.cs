// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_BUILDPAGINGBUFFER__union_0__struct_6
    {
        public IntPtr hDevice;
        public IntPtr hAllocation;
        public uint SegmentId;
        public IntPtr OffsetInPages;
        public IntPtr NumberOfPages;
        public long DummyPage;
    }
}
