﻿// generated from <Windows SDK Path>\um\wingdi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagEMRPLGBLT
    {
        public tagEMR emr;
        public _RECTL rclBounds;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)] 
        public _POINTL[] aptlDest;
        public int xSrc;
        public int ySrc;
        public int cxSrc;
        public int cySrc;
        public tagXFORM xformSrc;
        public uint crBkColorSrc;
        public uint iUsageSrc;
        public uint offBmiSrc;
        public uint cbBmiSrc;
        public uint offBitsSrc;
        public uint cbBitsSrc;
        public int xMask;
        public int yMask;
        public uint iUsageMask;
        public uint offBmiMask;
        public uint cbBmiMask;
        public uint offBitsMask;
        public uint cbBitsMask;
    }
}
