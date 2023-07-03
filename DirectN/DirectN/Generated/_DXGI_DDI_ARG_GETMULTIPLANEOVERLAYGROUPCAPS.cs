// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dxgiddi.h(438,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGI_DDI_ARG_GETMULTIPLANEOVERLAYGROUPCAPS
    {
        public ulong hDevice;
        public uint VidPnSourceId;
        public uint GroupIndex;
        public DXGI_DDI_MULTIPLANE_OVERLAY_GROUP_CAPS MultiplaneOverlayGroupCaps;
    }
}
