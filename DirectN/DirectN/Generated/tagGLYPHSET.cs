// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wingdi.h(4290,9)
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
