// generated from <Windows SDK Path>\um\d3dumddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDIARG_CREATEOVERLAY
    {
        public uint VidPnSourceId;
        public _D3DDDI_OVERLAYINFO OverlayInfo;
        public IntPtr hOverlay;
    }
}
