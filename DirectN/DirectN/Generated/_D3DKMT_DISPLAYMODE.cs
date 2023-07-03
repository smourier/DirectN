// c:\program files (x86)\windows kits\10\include\10.0.22621.0\shared\d3dkmthk.h(282,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_DISPLAYMODE
    {
        public uint Width;
        public uint Height;
        public _D3DDDIFORMAT Format;
        public uint IntegerRefreshRate;
        public _D3DDDI_RATIONAL RefreshRate;
        public _D3DDDI_VIDEO_SIGNAL_SCANLINE_ORDERING ScanLineOrdering;
        public _D3DDDI_ROTATION DisplayOrientation;
        public uint DisplayFixedOutput;
        public _D3DKMDT_DISPLAYMODE_FLAGS Flags;
    }
}
