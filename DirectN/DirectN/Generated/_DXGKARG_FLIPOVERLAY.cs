// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;
using PHYSICAL_ADDRESS = System.Int64;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_FLIPOVERLAY
    {
        public IntPtr hSource;
        public PHYSICAL_ADDRESS SrcPhysicalAddress;
        public uint SrcSegmentId;
        public IntPtr pPrivateDriverData;
        public uint PrivateDriverDataSize;
    }
}
