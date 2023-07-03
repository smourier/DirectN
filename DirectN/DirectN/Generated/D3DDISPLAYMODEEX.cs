// c:\program files (x86)\windows kits\10\include\10.0.22621.0\shared\d3d9types.h(2032,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct D3DDISPLAYMODEEX
    {
        public uint Size;
        public uint Width;
        public uint Height;
        public uint RefreshRate;
        public _D3DFORMAT Format;
        public D3DSCANLINEORDERING ScanLineOrdering;
    }
}
