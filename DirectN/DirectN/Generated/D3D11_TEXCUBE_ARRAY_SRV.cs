// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d11.h(3461,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_TEXCUBE_ARRAY_SRV
    {
        public uint MostDetailedMip;
        public uint MipLevels;
        public uint First2DArrayFace;
        public uint NumCubes;
    }
}
