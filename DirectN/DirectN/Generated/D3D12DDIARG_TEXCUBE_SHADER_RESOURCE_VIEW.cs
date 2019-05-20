// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d12umddi.h(869,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDIARG_TEXCUBE_SHADER_RESOURCE_VIEW
    {
        public uint MostDetailedMip;
        public uint MipLevels;
        public uint First2DArrayFace;
        public uint NumCubes;
        public float ResourceMinLODClamp;
    }
}
