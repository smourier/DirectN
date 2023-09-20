// generated from <Windows SDK Path>\um\ddrawint.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DD_STEREOMODE
    {
        public uint dwSize;
        public uint dwHeight;
        public uint dwWidth;
        public uint dwBpp;
        public uint dwRefreshRate;
        public bool bSupported;
    }
}
