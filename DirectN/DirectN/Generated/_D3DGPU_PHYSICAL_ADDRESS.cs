// generated from <Windows SDK Path>\shared\d3dukmdt.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DGPU_PHYSICAL_ADDRESS
    {
        public uint SegmentId;
        public uint Padding;
        public ulong SegmentOffset;
    }
}
