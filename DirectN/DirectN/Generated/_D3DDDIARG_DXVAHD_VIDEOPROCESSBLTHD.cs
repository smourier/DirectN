﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3dumddi.h(1876,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDIARG_DXVAHD_VIDEOPROCESSBLTHD
    {
        public IntPtr hVideoProcessor;
        public _DXVAHDDDI_SURFACE OutputSurface;
        public uint OutputFrame;
        public uint StreamCount;
        public IntPtr pStreams;
    }
}
