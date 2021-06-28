// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\ddraw.h(707,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDPIXELFORMAT
    {
        public uint dwSize;
        public uint dwFlags;
        public uint dwFourCC;
        public _DDPIXELFORMAT__union_0 __union_3;
        public _DDPIXELFORMAT__union_1 __union_4;
        public _DDPIXELFORMAT__union_2 __union_5;
        public _DDPIXELFORMAT__union_3 __union_6;
        public _DDPIXELFORMAT__union_4 __union_7;
    }
}
