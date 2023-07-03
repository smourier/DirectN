// c:\program files (x86)\windows kits\10\include\10.0.22621.0\shared\d3dkmdt.h(1394,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMDT_GDISURFACEDATA
    {
        public uint Width;
        public uint Height;
        public _D3DDDIFORMAT Format;
        public _D3DKMDT_GDISURFACETYPE Type;
        public _D3DKMDT_GDISURFACEFLAGS Flags;
        public uint Pitch;
    }
}
