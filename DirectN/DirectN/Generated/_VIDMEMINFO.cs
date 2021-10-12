// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\ddrawi.h(606,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _VIDMEMINFO
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
        public uint dwNumHeaps;
        public IntPtr pvmList;
    }
}
