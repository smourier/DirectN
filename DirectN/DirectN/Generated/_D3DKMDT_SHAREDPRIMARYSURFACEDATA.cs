// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmdt.h(1338,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMDT_SHAREDPRIMARYSURFACEDATA
    {
        public uint Width;
        public uint Height;
        public _D3DDDIFORMAT Format;
        public _D3DDDI_RATIONAL RefreshRate;
        public uint VidPnSourceId;
    }
}
