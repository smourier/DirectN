// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dxgiddi.h(471,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGI_DDI_ARG_PRESENTMULTIPLANEOVERLAY
    {
        public ulong hDevice;
        public IntPtr pDXGIContext;
        public uint VidPnSourceId;
        public DXGI_DDI_PRESENT_FLAGS Flags;
        public DXGI_DDI_FLIP_INTERVAL_TYPE FlipInterval;
        public uint PresentPlaneCount;
        public IntPtr pPresentPlanes;
        public uint Reserved;
    }
}
