// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\d3dkmddi.h(2937,9)
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
