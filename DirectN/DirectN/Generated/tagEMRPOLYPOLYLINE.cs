﻿// generated from <Windows SDK Path>\um\wingdi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagEMRPOLYPOLYLINE
    {
        public tagEMR emr;
        public _RECTL rclBounds;
        public uint nPolys;
        public uint cptl;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)] 
        public uint[] aPolyCounts;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)] 
        public _POINTL[] aptl;
    }
}
