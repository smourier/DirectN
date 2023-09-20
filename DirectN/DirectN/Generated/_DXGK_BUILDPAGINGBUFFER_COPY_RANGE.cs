// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_BUILDPAGINGBUFFER_COPY_RANGE
    {
        public uint NumPageTableEntries;
        public ulong SrcPageTableAddress;
        public ulong DstPageTableAddress;
        public uint SrcStartPteIndex;
        public uint DstStartPteIndex;
    }
}
