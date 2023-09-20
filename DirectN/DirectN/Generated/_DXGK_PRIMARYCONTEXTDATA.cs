// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;
using PHYSICAL_ADDRESS = System.Int64;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_PRIMARYCONTEXTDATA
    {
        public IntPtr hContext;
        public IntPtr hAllocation;
        public ushort SegmentId;
        public PHYSICAL_ADDRESS SegmentAddress;
    }
}
