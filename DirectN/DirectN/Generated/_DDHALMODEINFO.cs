// generated from <Windows SDK Path>\um\ddrawi.h
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
