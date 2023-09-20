// generated from <Windows SDK Path>\um\ddraw.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDOPTSURFACEDESC
    {
        public uint dwSize;
        public uint dwFlags;
        public _DDSCAPS2 ddSCaps;
        public _DDOSCAPS ddOSCaps;
        public Guid guid;
        public uint dwCompressionRatio;
    }
}
