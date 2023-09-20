// generated from <Windows SDK Path>\um\ddrawint.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _VIDEOMEMORY
    {
        public uint dwFlags;
        public ulong fpStart;
        public _VIDEOMEMORY__union_0 __union_2;
        public _DDSCAPS ddsCaps;
        public _DDSCAPS ddsCapsAlt;
        public _VIDEOMEMORY__union_1 __union_5;
    }
}
