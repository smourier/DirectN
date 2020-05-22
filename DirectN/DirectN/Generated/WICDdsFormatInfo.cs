// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wincodec.h(8025,24)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct WICDdsFormatInfo
    {
        public DXGI_FORMAT DxgiFormat;
        public uint BytesPerBlock;
        public uint BlockWidth;
        public uint BlockHeight;
    }
}
