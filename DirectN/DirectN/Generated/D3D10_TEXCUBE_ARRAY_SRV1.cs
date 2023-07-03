// c:\program files (x86)\windows kits\10\include\10.0.22621.0\um\d3d10_1.h(320,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D10_TEXCUBE_ARRAY_SRV1
    {
        public uint MostDetailedMip;
        public uint MipLevels;
        public uint First2DArrayFace;
        public uint NumCubes;
    }
}
