// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_UPDATEOVERLAY
    {
        public uint hDevice;
        public uint hOverlay;
        public _D3DDDI_KERNELOVERLAYINFO OverlayInfo;
    }
}
