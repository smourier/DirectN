﻿// generated from <Windows SDK Path>\shared\ksmedia.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagKS_MPEGVIDEOINFO2
    {
        public tagKS_VIDEOINFOHEADER2 hdr;
        public uint dwStartTimeCode;
        public uint cbSequenceHeader;
        public uint dwProfile;
        public uint dwLevel;
        public uint dwFlags;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)] 
        public uint[] bSequenceHeader;
    }
}
