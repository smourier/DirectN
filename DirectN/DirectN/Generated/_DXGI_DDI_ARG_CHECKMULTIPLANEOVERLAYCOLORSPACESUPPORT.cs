// generated from <Windows SDK Path>\um\dxgiddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGI_DDI_ARG_CHECKMULTIPLANEOVERLAYCOLORSPACESUPPORT
    {
        public ulong hDevice;
        public int VidPnSourceId;
        public DXGI_FORMAT Format;
        public int ColorSpace;
        public bool Supported;
    }
}
