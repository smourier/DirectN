// generated from <Windows SDK Path>\um\dxgiddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGI_DDI_ARG_CHECKMULTIPLANEOVERLAYCOLORSPACESUPPORT
    {
        public ulong hDevice;
        public uint VidPnSourceId;
        public DXGI_FORMAT Format;
        public D3DDDI_COLOR_SPACE_TYPE ColorSpace;
        public bool Supported;
    }
}
