// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_BUILDPAGINGBUFFER__union_0__struct_0
    {
        public IntPtr hAllocation;
        public uint TransferOffset;
        public IntPtr TransferSize;
        public _DXGKARG_BUILDPAGINGBUFFER__union_0__struct_0__struct_0 Source;
        public _DXGKARG_BUILDPAGINGBUFFER__union_0__struct_0__struct_1 Destination;
        public _DXGK_TRANSFERFLAGS Flags;
        public uint MdlOffset;
    }
}
