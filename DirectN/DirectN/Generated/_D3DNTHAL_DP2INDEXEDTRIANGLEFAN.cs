﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3dnthal.h(706,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DNTHAL_DP2INDEXEDTRIANGLEFAN
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)] 
        public ushort[] wV;
    }
}
