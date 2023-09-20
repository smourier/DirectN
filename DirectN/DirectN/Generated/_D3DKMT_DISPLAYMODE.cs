// generated from <Windows SDK Path>\shared\d3dkmthk.h
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
