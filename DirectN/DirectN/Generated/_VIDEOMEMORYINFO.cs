// generated from <Windows SDK Path>\um\ddrawint.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _VIDEOMEMORYINFO
    {
        public ulong fpPrimary;
        public uint dwFlags;
        public uint dwDisplayWidth;
        public uint dwDisplayHeight;
        public int lDisplayPitch;
        public _DDPIXELFORMAT ddpfDisplay;
        public uint dwOffscreenAlign;
        public uint dwOverlayAlign;
        public uint dwTextureAlign;
        public uint dwZBufferAlign;
        public uint dwAlphaAlign;
        public IntPtr pvPrimary;
    }
}
