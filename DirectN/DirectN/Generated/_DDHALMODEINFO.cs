// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\ddrawi.h(1620,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDHALMODEINFO
    {
        public uint dwWidth;
        public uint dwHeight;
        public int lPitch;
        public uint dwBPP;
        public ushort wFlags;
        public ushort wRefreshRate;
        public uint dwRBitMask;
        public uint dwGBitMask;
        public uint dwBBitMask;
        public uint dwAlphaBitMask;
    }
}
