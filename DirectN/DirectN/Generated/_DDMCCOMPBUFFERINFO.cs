// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\ddrawi.h(2856,9)
using System;
using System.Runtime.InteropServices;
using DDPIXELFORMAT = DirectN._DDPIXELFORMAT;
using DDSCAPS2 = DirectN._DDSCAPS2;

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
        public DDSCAPS2 ddCompCaps;
        public DDPIXELFORMAT ddPixelFormat;
    }
}
