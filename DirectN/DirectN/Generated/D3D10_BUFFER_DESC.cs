// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d10.h(1642,9)
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
