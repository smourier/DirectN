﻿// generated from <Windows SDK Path>\shared\ksmedia.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagKS_MPEG1VIDEOINFO
    {
        public tagKS_VIDEOINFOHEADER hdr;
        public uint dwStartTimeCode;
        public uint cbSequenceHeader;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)] 
        public byte[] bSequenceHeader;
    }
}
