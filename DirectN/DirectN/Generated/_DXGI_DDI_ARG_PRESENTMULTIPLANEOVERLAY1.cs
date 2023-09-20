// generated from <Windows SDK Path>\um\dxgiddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGI_DDI_ARG_PRESENTMULTIPLANEOVERLAY1
    {
        public ulong hDevice;
        public IntPtr pDXGIContext;
        public uint VidPnSourceId;
        public DXGI_DDI_PRESENT_FLAGS Flags;
        public DXGI_DDI_FLIP_INTERVAL_TYPE FlipInterval;
        public uint PresentPlaneCount;
        public IntPtr pPresentPlanes;
    }
}
