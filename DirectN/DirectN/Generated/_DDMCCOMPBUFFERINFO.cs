// generated from <Windows SDK Path>\um\ddrawi.h
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
