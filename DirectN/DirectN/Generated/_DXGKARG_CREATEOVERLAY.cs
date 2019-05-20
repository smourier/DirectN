// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\d3dkmddi.h(4855,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_CREATEOVERLAY
    {
        public uint VidPnSourceId;
        public _DXGK_OVERLAYINFO OverlayInfo;
        public IntPtr hOverlay;
    }
}
