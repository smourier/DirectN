// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_PRIMARYDATA
    {
        public IntPtr hAllocation;
        public ushort SegmentId;
        public long SegmentAddress;
    }
}
