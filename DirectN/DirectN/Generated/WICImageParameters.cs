// generated from <Windows SDK Path>\um\wincodec.h
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
