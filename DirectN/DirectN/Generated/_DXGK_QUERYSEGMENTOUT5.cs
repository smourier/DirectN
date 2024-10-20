// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_QUERYSEGMENTOUT5
    {
        public IntPtr SegmentDescriptors;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)] 
        public uint[] Reserved;
    }
}
