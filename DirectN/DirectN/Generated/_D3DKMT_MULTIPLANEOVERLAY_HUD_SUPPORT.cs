// generated from <Windows SDK Path>\shared\d3dkmthk.h
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
