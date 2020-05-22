// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\ddraw.h(2230,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDSURFACEDESC
    {
        public uint dwSize;
        public uint dwFlags;
        public uint dwHeight;
        public uint dwWidth;
        public _DDSURFACEDESC__union_0 __union_4;
        public uint dwBackBufferCount;
        public _DDSURFACEDESC__union_1 __union_6;
        public uint dwAlphaBitDepth;
        public uint dwReserved;
        public IntPtr lpSurface;
        public _DDCOLORKEY ddckCKDestOverlay;
        public _DDCOLORKEY ddckCKDestBlt;
        public _DDCOLORKEY ddckCKSrcOverlay;
        public _DDCOLORKEY ddckCKSrcBlt;
        public _DDPIXELFORMAT ddpfPixelFormat;
        public _DDSCAPS ddsCaps;
    }
}
