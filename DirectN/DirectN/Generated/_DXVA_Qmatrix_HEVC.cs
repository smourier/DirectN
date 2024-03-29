﻿// generated from <Windows SDK Path>\um\dxva.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DXVA_Qmatrix_HEVC
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 96)] 
        public byte[] ucScalingLists0;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 384)] 
        public byte[] ucScalingLists1;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 384)] 
        public byte[] ucScalingLists2;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)] 
        public byte[] ucScalingLists3;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)] 
        public byte[] ucScalingListDCCoefSizeID2;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)] 
        public byte[] ucScalingListDCCoefSizeID3;
    }
}
