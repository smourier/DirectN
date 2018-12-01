// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dxgiddi.h(638,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DXGI1_6_1_DDI_ARG_PRESENTMULTIPLANEOVERLAY
    {
        public ulong hDevice;
        public IntPtr pDXGIContext;
        public int VidPnSourceId;
        public DXGI_DDI_PRESENT_FLAGS Flags;
        public DXGI_DDI_FLIP_INTERVAL_TYPE FlipInterval;
        public uint PresentPlaneCount;
        public IntPtr pPresentPlanes;
        public IntPtr pRotationHints;
    }
}
