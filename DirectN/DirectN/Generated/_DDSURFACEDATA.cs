// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\dxmini.h(95,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDSURFACEDATA
    {
        public uint ddsCaps;
        public uint dwSurfaceOffset;
        public IntPtr fpLockPtr;
        public uint dwWidth;
        public uint dwHeight;
        public int lPitch;
        public uint dwOverlayFlags;
        public uint dwOverlayOffset;
        public uint dwOverlaySrcWidth;
        public uint dwOverlaySrcHeight;
        public uint dwOverlayDestWidth;
        public uint dwOverlayDestHeight;
        public uint dwVideoPortId;
        public uint dwFormatFlags;
        public uint dwFormatFourCC;
        public uint dwFormatBitCount;
        public uint dwRBitMask;
        public uint dwGBitMask;
        public uint dwBBitMask;
        public uint dwDriverReserved1;
        public uint dwDriverReserved2;
        public uint dwDriverReserved3;
        public uint dwDriverReserved4;
    }
}
