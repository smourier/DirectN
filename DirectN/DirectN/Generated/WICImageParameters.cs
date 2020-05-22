// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wincodec.h(1051,24)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct WICImageParameters
    {
        public D2D1_PIXEL_FORMAT PixelFormat;
        public float DpiX;
        public float DpiY;
        public float Top;
        public float Left;
        public uint PixelWidth;
        public uint PixelHeight;
    }
}
