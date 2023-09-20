// generated from <Windows SDK Path>\um\ddrawint.h
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
