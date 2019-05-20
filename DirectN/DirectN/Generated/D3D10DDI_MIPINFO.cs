// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d10umddi.h(445,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D10DDI_MIPINFO
    {
        public uint TexelWidth;
        public uint TexelHeight;
        public uint TexelDepth;
        public uint PhysicalWidth;
        public uint PhysicalHeight;
        public uint PhysicalDepth;
    }
}
