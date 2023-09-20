// generated from <Windows SDK Path>\um\d3dumddi.h
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
