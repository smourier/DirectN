// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\ddrawint.h(1841,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDCOMPBUFFERINFO
    {
        public uint dwSize;
        public uint dwNumCompBuffers;
        public uint dwWidthToCreate;
        public uint dwHeightToCreate;
        public uint dwBytesToAllocate;
        public _DDSCAPS2 ddCompCaps;
        public _DDPIXELFORMAT ddPixelFormat;
    }
}
