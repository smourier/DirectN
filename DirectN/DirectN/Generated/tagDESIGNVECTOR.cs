﻿// generated from <Windows SDK Path>\um\wingdi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagDESIGNVECTOR
    {
        public uint dvReserved;
        public uint dvNumAxes;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)] 
        public int[] dvValues;
    }
}
