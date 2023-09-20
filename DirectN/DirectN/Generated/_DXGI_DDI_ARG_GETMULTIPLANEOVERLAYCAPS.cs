// generated from <Windows SDK Path>\um\dxgiddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGI_DDI_ARG_GETMULTIPLANEOVERLAYCAPS
    {
        public ulong hDevice;
        public uint VidPnSourceId;
        public DXGI_DDI_MULTIPLANE_OVERLAY_CAPS MultiplaneOverlayCaps;
    }
}
