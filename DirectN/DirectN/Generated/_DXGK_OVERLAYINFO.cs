// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;
using PHYSICAL_ADDRESS = System.Int64;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_OVERLAYINFO
    {
        public IntPtr hAllocation;
        public PHYSICAL_ADDRESS PhysicalAddress;
        public uint SegmentId;
        public tagRECT DstRect;
        public tagRECT SrcRect;
        public IntPtr pPrivateDriverData;
        public uint PrivateDriverDataSize;
    }
}
