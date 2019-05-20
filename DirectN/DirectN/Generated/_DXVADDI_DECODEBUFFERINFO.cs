// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3dumddi.h(2364,13)
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
