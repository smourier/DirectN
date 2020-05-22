// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\d3dkmthk.h(1723,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_MULTIPLANEOVERLAY_HUD_SUPPORT
    {
        public uint VidPnSourceId;
        public bool Update;
        public bool KernelSupported;
        public bool HudSupported;
    }
}
