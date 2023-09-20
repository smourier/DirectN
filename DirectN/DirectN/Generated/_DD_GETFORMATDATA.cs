// generated from <Windows SDK Path>\um\d3dhal.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DD_GETFORMATDATA
    {
        public _DD_GETDRIVERINFO2DATA gdi2;
        public uint dwFormatIndex;
        public _DDPIXELFORMAT format;
    }
}
