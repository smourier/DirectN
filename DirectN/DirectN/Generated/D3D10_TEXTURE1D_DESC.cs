// generated from <Windows SDK Path>\um\d3d10.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D10_TEXTURE1D_DESC
    {
        public uint Width;
        public uint MipLevels;
        public uint ArraySize;
        public DXGI_FORMAT Format;
        public D3D10_USAGE Usage;
        public uint BindFlags;
        public uint CPUAccessFlags;
        public uint MiscFlags;
    }
}
