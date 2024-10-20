// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_SETVIRTUALGPURESOURCES2
    {
        public uint vfIndex;
        public uint SegmentCount;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)] 
        public _DXGK_GPU_PHYSICAL_RESERVE_DESCRIPTOR[] SegmentDescriptors;
    }
}
