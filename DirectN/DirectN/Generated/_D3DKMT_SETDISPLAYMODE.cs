// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\d3dkmthk.h(291,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_SETDISPLAYMODE
    {
        public uint hDevice;
        public uint hPrimaryAllocation;
        public _D3DDDI_VIDEO_SIGNAL_SCANLINE_ORDERING ScanLineOrdering;
        public _D3DDDI_ROTATION DisplayOrientation;
        public uint PrivateDriverFormatAttribute;
        public _D3DKMT_SETDISPLAYMODE_FLAGS Flags;
    }
}
