﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dxva9typ.h(904,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXVA_COPPStatusDisplayData
    {
        public Guid rApp;
        public uint dwFlags;
        public uint DisplayWidth;
        public uint DisplayHeight;
        public uint Format;
        public uint d3dFormat;
        public uint FreqNumerator;
        public uint FreqDenominator;
    }
}
