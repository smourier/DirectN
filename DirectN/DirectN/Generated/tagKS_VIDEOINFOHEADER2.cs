﻿// generated from <Windows SDK Path>\shared\ksmedia.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagKS_VIDEOINFOHEADER2
    {
        public tagRECT rcSource;
        public tagRECT rcTarget;
        public uint dwBitRate;
        public uint dwBitErrorRate;
        public long AvgTimePerFrame;
        public uint dwInterlaceFlags;
        public uint dwCopyProtectFlags;
        public uint dwPictAspectRatioX;
        public uint dwPictAspectRatioY;
        public tagKS_VIDEOINFOHEADER2__union_0 __union_9;
        public uint dwReserved2;
        public tagKS_BITMAPINFOHEADER bmiHeader;
    }
}
