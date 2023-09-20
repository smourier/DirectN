// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_SEGMENT_CAPS
    {
        public ulong Size;
        public uint PageSize;
        public uint SegmentId;
        public byte bAperture;
        public byte bReservedSysMem;
        public _D3DKMT_MEMORY_SEGMENT_GROUP BudgetGroup;
    }
}
