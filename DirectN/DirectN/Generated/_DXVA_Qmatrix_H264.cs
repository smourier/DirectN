// generated from <Windows SDK Path>\um\dxva.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DXVA_Qmatrix_H264
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 96)] 
        public byte[] bScalingLists4x4;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)] 
        public byte[] bScalingLists8x8;
    }
}
