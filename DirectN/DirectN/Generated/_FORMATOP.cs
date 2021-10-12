// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3dumddi.h(2227,13)
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
