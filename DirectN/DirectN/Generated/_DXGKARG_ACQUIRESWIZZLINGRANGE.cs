// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;
using PHYSICAL_ADDRESS = System.Int64;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_ACQUIRESWIZZLINGRANGE
    {
        public IntPtr hAllocation;
        public uint PrivateDriverData;
        public uint RangeId;
        public uint SegmentId;
        public IntPtr RangeSize;
        public PHYSICAL_ADDRESS CPUTranslatedAddress;
    }
}
