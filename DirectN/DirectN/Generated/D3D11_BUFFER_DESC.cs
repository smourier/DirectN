// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3d11.h(2346,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_BUFFER_DESC
    {
        public uint ByteWidth;
        public D3D11_USAGE Usage;
        public uint BindFlags;
        public uint CPUAccessFlags;
        public uint MiscFlags;
        public uint StructureByteStride;
    }
}
