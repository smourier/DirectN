// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\ddraw.h(2412,9)
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
