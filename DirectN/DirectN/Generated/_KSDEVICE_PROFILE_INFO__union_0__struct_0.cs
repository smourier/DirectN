﻿// generated from <Windows SDK Path>\shared\ksmedia.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _KSDEVICE_PROFILE_INFO__union_0__struct_0
    {
        public _KSCAMERA_PROFILE_INFO Info;
        public uint Reserved;
        public uint ConcurrencyCount;
        public IntPtr Concurrency;
    }
}
