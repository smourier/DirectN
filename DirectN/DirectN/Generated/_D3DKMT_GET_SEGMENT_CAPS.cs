// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\d3dkmthk.h(2498,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_GET_SEGMENT_CAPS
    {
        public uint PhysicalAdapterIndex;
        public uint NumSegments;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)] 
        public _D3DKMT_SEGMENT_CAPS[] SegmentCaps;
    }
}
