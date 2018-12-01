// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d12.h(2740,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_TEXCUBE_ARRAY_SRV
    {
        public uint MostDetailedMip;
        public uint MipLevels;
        public uint First2DArrayFace;
        public uint NumCubes;
        public float ResourceMinLODClamp;
    }
}
