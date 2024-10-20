// generated from <Windows SDK Path>\um\d3d12umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_VIDEO_ENCODER_AV1_CDEF_CONFIG_0095
    {
        public ulong CdefBits;
        public ulong CdefDampingMinus3;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)] 
        public ulong[] CdefYPriStrength;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)] 
        public ulong[] CdefUVPriStrength;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)] 
        public ulong[] CdefYSecStrength;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)] 
        public ulong[] CdefUVSecStrength;
    }
}
