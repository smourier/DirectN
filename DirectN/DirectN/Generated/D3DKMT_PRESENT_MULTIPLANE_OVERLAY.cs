// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\d3dkmthk.h(1127,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3DKMT_PRESENT_MULTIPLANE_OVERLAY
    {
        public D3DKMT_PRESENT_MULTIPLANE_OVERLAY__union_0 __union_0;
        public uint BroadcastContextCount;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)] 
        public uint[] BroadcastContext;
        public uint VidPnSourceId;
        public uint PresentCount;
        public D3DDDI_FLIPINTERVAL_TYPE FlipInterval;
        public _D3DKMT_PRESENTFLAGS Flags;
        public uint PresentPlaneCount;
        public IntPtr pPresentPlanes;
        public uint Duration;
    }
}
