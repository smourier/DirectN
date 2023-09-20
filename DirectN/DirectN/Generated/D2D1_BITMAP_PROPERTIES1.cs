// generated from <Windows SDK Path>\um\d2d1_1.h
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
