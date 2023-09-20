// generated from <Windows SDK Path>\um\wingdi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagGLYPHSET
    {
        public uint cbThis;
        public uint flAccel;
        public uint cGlyphsSupported;
        public uint cRanges;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)] 
        public tagWCRANGE[] ranges;
    }
}
