// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wincodec.h(7803,24)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct WICDdsParameters
    {
        public uint Width;
        public uint Height;
        public uint Depth;
        public uint MipLevels;
        public uint ArraySize;
        public DXGI_FORMAT DxgiFormat;
        public WICDdsDimension Dimension;
        public WICDdsAlphaMode AlphaMode;
    }
}
