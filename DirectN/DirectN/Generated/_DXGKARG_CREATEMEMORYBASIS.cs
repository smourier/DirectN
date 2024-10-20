// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_CREATEMEMORYBASIS
    {
        public uint SegmentId;
        public ulong RangeCount;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)] 
        public _DXGK_MEMORYRANGE[] Ranges;
    }
}
