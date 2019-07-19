// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\dxgiddi.h(431,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGI_DDI_ARG_GETMULTIPLANEOVERLAYCAPS
    {
        public ulong hDevice;
        public int VidPnSourceId;
        public DXGI_DDI_MULTIPLANE_OVERLAY_CAPS MultiplaneOverlayCaps;
    }
}
