﻿// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_BUILDPAGINGBUFFER__union_0__struct_2
    {
        public IntPtr hAllocation;
        public _DXGK_DISCARDCONTENTFLAGS Flags;
        public uint SegmentId;
        public long SegmentAddress;
    }
}
