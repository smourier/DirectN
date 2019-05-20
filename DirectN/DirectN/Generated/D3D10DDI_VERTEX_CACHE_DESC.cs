// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d10umddi.h(1127,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D10DDI_VERTEX_CACHE_DESC
    {
        public uint Pattern;
        public uint OptMethod;
        public uint CacheSize;
        public uint MagicNumber;
    }
}
