// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d11.h(10074,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_VIDEO_CONTENT_PROTECTION_CAPS
    {
        public uint Caps;
        public uint KeyExchangeTypeCount;
        public uint BlockAlignmentSize;
        public ulong ProtectedMemorySize;
    }
}
