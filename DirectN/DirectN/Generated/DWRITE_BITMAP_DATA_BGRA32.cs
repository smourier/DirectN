// generated from <Windows SDK Path>\um\dwrite_3.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Contains information about a bitmap associated with an IDWriteBitmapRenderTarget. The bitmap is top-down with 32-bits per pixel and no padding between scan lines.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DWRITE_BITMAP_DATA_BGRA32
    {
        public uint width;
        public uint height;
        public IntPtr pixels;
    }
}
