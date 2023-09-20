// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;
using PHYSICAL_ADDRESS = System.Int64;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARGCB_CREATE_PHYSICAL_MEMORY_OBJECT__union_0__struct_0
    {
        public PHYSICAL_ADDRESS LowAddress;
        public PHYSICAL_ADDRESS HighAddress;
        public PHYSICAL_ADDRESS SkipBytes;
        public uint Flags;
    }
}
