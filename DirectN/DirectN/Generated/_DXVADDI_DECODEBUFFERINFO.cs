// generated from <Windows SDK Path>\um\d3dumddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXVADDI_DECODEBUFFERINFO
    {
        public _D3DDDIFORMAT CompressedBufferType;
        public uint CreationWidth;
        public uint CreationHeight;
        public _D3DDDI_POOL CreationPool;
    }
}
