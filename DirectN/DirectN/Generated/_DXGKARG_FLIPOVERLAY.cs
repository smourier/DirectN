// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\d3dkmddi.h(4893,9)
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
