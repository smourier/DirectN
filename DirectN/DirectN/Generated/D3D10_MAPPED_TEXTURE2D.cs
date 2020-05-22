// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3d10.h(2140,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D10_MAPPED_TEXTURE2D
    {
        public IntPtr pData;
        public uint RowPitch;
    }
}
