// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3d9types.h(1747,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct _D3DVOLUME_DESC
    {
        public _D3DFORMAT Format;
        public _D3DRESOURCETYPE Type;
        public uint Usage;
        public _D3DPOOL Pool;
        public uint Width;
        public uint Height;
        public uint Depth;
    }
}
