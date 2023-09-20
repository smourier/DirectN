// generated from <Windows SDK Path>\um\wingdi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DISPLAYCONFIG_SOURCE_MODE
    {
        public uint width;
        public uint height;
        public DISPLAYCONFIG_PIXELFORMAT pixelFormat;
        public _POINTL position;
    }
}
