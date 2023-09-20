// generated from <Windows SDK Path>\um\d3d10.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D10_BUFFER_DESC
    {
        public uint ByteWidth;
        public D3D10_USAGE Usage;
        public uint BindFlags;
        public uint CPUAccessFlags;
        public uint MiscFlags;
    }
}
