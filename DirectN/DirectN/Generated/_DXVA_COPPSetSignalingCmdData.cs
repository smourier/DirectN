﻿// generated from <Windows SDK Path>\um\dxva.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXVA_COPPSetSignalingCmdData
    {
        public uint ActiveTVProtectionStandard;
        public uint AspectRatioChangeMask1;
        public uint AspectRatioData1;
        public uint AspectRatioChangeMask2;
        public uint AspectRatioData2;
        public uint AspectRatioChangeMask3;
        public uint AspectRatioData3;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)] 
        public uint[] ExtendedInfoChangeMask;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)] 
        public uint[] ExtendedInfoData;
        public uint Reserved;
    }
}
