﻿// generated from <Windows SDK Path>\um\wingdi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagLOCALESIGNATURE
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)] 
        public uint[] lsUsb;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)] 
        public uint[] lsCsbDefault;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)] 
        public uint[] lsCsbSupported;
    }
}
