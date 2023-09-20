// generated from <Windows SDK Path>\um\wincodec.h
using System;
using System.Runtime.InteropServices;
using WICPixelFormatGUID = System.Guid;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct WICBitmapPlane
    {
        public WICPixelFormatGUID Format;
        public IntPtr pbBuffer;
        public uint cbStride;
        public uint cbBufferSize;
    }
}
