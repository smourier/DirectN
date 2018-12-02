// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\ddrawint.h(739,9)
using System;
using System.Runtime.InteropServices;
using DDPIXELFORMAT = DirectN._DDPIXELFORMAT;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DD_SURFACE_GLOBAL
    {
        public _DD_SURFACE_GLOBAL__union_0 __union_0;
        public _DD_SURFACE_GLOBAL__union_1 __union_1;
        public ulong fpVidMem;
        public _DD_SURFACE_GLOBAL__union_2 __union_3;
        public int yHint;
        public int xHint;
        public uint wHeight;
        public uint wWidth;
        public IntPtr dwReserved1;
        public DDPIXELFORMAT ddpfSurface;
        public ulong fpHeapOffset;
        public IntPtr hCreatorProcess;
    }
}
