// generated from <Windows SDK Path>\um\wincodec.h
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
