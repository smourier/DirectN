// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmddi.h(1389,9)
using System;
using System.Runtime.InteropServices;
using PHYSICAL_ADDRESS = System.Int64;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARGCB_GETCAPTUREADDRESS
    {
        public uint hAllocation;
        public uint SegmentId;
        public PHYSICAL_ADDRESS PhysicalAddress;
    }
}
