// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\d3d9types.h(1710,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct _D3DVERTEXBUFFER_DESC
    {
        public _D3DFORMAT Format;
        public _D3DRESOURCETYPE Type;
        public uint Usage;
        public _D3DPOOL Pool;
        public uint Size;
        public uint FVF;
    }
}
