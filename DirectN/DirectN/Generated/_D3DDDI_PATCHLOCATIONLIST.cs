﻿// generated from <Windows SDK Path>\shared\d3dukmdt.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDI_PATCHLOCATIONLIST
    {
        public uint AllocationIndex;
        public _D3DDDI_PATCHLOCATIONLIST__union_0 __union_1;
        public uint DriverId;
        public uint AllocationOffset;
        public uint PatchOffset;
        public uint SplitOffset;
    }
}
