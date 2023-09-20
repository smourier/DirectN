// generated from <Windows SDK Path>\um\d3dumddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _FORMATOP
    {
        public _D3DDDIFORMAT Format;
        public uint Operations;
        public uint FlipMsTypes;
        public uint BltMsTypes;
        public uint PrivateFormatBitCount;
    }
}
