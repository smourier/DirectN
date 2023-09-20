// generated from <Windows SDK Path>\shared\d3dkmdt.h
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
