// generated from <Windows SDK Path>\um\dxgiddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DXGIDDICB_PRESENT_MULTIPLANE_OVERLAY1
    {
        public IntPtr pDXGIContext;
        public uint PresentPlaneCount;
        public IntPtr ppPresentPlanes;
    }
}
