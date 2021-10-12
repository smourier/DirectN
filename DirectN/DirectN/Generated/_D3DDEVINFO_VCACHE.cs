// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3d9types.h(1933,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct _D3DDEVINFO_VCACHE
    {
        public uint Pattern;
        public uint OptMethod;
        public uint CacheSize;
        public uint MagicNumber;
    }
}
