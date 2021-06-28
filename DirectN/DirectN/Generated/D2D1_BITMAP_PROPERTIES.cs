// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d2d1.h(295,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Describes the pixel format and dpi of a bitmap.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D2D1_BITMAP_PROPERTIES
    {
        public D2D1_PIXEL_FORMAT pixelFormat;
        public float dpiX;
        public float dpiY;
    }
}
