﻿// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\d3dkmdt.h(1400,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMDT_VIRTUALGPUSURFACEDATA
    {
        public ulong Size;
        public uint Alignment;
        public uint DriverSegmentId;
        public uint PrivateDriverData;
    }
}
