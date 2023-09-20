// generated from <Windows SDK Path>\um\d3dumddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDICHECKOVERLAYSUPPORTINPUT
    {
        public uint OverlayWidth;
        public uint OverlayHeight;
        public _D3DDDIFORMAT OverlayFormat;
        public uint DisplayWidth;
        public uint DisplayHeight;
        public uint DisplayRefreshRate;
        public _D3DDDIFORMAT DisplayFormat;
        public D3DDDI_SCANLINEORDERING DisplayScanLineOrdering;
        public _D3DDDI_ROTATION DisplayRotation;
    }
}
