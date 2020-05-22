// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wincodec.h(1063,24)
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
