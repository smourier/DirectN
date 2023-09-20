// generated from <Windows SDK Path>\shared\d3dkmthk.h
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
