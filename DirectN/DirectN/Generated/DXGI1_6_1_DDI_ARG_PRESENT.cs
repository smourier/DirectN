// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\dxgiddi.h(621,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DXGI1_6_1_DDI_ARG_PRESENT
    {
        public ulong hDevice;
        public IntPtr phSurfacesToPresent;
        public uint SurfacesToPresent;
        public ulong hDstResource;
        public uint DstSubResourceIndex;
        public IntPtr pDXGIContext;
        public DXGI_DDI_PRESENT_FLAGS Flags;
        public DXGI_DDI_FLIP_INTERVAL_TYPE FlipInterval;
        public DXGI_DDI_MODE_ROTATION RotationHint;
        public IntPtr pDirtyRects;
        public uint DirtyRects;
        public uint BackBufferMultiplicity;
    }
}
