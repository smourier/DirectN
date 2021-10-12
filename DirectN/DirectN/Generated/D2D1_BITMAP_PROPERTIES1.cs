// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d2d1_1.h(403,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Extended bitmap properties.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D2D1_BITMAP_PROPERTIES1
    {
        public D2D1_PIXEL_FORMAT pixelFormat;
        public float dpiX;
        public float dpiY;
        /// <summary>
        /// Specifies how the bitmap can be used.
        /// </summary>
        public D2D1_BITMAP_OPTIONS bitmapOptions;
        public IntPtr colorContext;
    }
}
