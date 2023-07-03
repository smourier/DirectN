// c:\program files (x86)\windows kits\10\include\10.0.22621.0\um\ddraw.h(2262,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDSURFACEDESC2
    {
        public uint dwSize;
        public uint dwFlags;
        public uint dwHeight;
        public uint dwWidth;
        public _DDSURFACEDESC2__union_0 __union_4;
        public _DDSURFACEDESC2__union_1 __union_5;
        public _DDSURFACEDESC2__union_2 __union_6;
        public uint dwAlphaBitDepth;
        public uint dwReserved;
        public IntPtr lpSurface;
        public _DDSURFACEDESC2__union_3 __union_10;
        public _DDCOLORKEY ddckCKDestBlt;
        public _DDCOLORKEY ddckCKSrcOverlay;
        public _DDCOLORKEY ddckCKSrcBlt;
        public _DDSURFACEDESC2__union_4 __union_14;
        public _DDSCAPS2 ddsCaps;
        public uint dwTextureStage;
    }
}
