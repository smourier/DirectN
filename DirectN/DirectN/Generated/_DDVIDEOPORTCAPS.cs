// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dvp.h(262,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDVIDEOPORTCAPS
    {
        public uint dwSize;
        public uint dwFlags;
        public uint dwMaxWidth;
        public uint dwMaxVBIWidth;
        public uint dwMaxHeight;
        public uint dwVideoPortID;
        public uint dwCaps;
        public uint dwFX;
        public uint dwNumAutoFlipSurfaces;
        public uint dwAlignVideoPortBoundary;
        public uint dwAlignVideoPortPrescaleWidth;
        public uint dwAlignVideoPortCropBoundary;
        public uint dwAlignVideoPortCropWidth;
        public uint dwPreshrinkXStep;
        public uint dwPreshrinkYStep;
        public uint dwNumVBIAutoFlipSurfaces;
        public uint dwNumPreferredAutoflip;
        public ushort wNumFilterTapsX;
        public ushort wNumFilterTapsY;
    }
}
