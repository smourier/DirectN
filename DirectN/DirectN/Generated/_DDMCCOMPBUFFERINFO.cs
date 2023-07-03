// c:\program files (x86)\windows kits\10\include\10.0.22621.0\um\ddrawi.h(2856,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDMCCOMPBUFFERINFO
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
