// generated from <Windows SDK Path>\um\wincodec.h
using System;
using System.Runtime.InteropServices;
using WICPixelFormatGUID = System.Guid;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct WICBitmapPlaneDescription
    {
        public WICPixelFormatGUID Format;
        public uint Width;
        public uint Height;
    }
}
