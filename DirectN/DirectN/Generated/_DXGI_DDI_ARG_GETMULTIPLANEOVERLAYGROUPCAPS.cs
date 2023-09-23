// generated from <Windows SDK Path>\um\dxgiddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGI_DDI_ARG_GETMULTIPLANEOVERLAYGROUPCAPS
    {
        public ulong hDevice;
        public int VidPnSourceId;
        public uint GroupIndex;
        public DXGI_DDI_MULTIPLANE_OVERLAY_GROUP_CAPS MultiplaneOverlayGroupCaps;
    }
}
