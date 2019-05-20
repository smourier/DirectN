// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\ddrawi.h(577,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _VIDMEM
    {
        public uint dwFlags;
        public ulong fpStart;
        public _VIDMEM__union_0 __union_2;
        public _DDSCAPS ddsCaps;
        public _DDSCAPS ddsCapsAlt;
        public _VIDMEM__union_1 __union_5;
    }
}
