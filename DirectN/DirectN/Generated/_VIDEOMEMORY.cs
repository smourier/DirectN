// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\ddrawint.h(281,9)
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
