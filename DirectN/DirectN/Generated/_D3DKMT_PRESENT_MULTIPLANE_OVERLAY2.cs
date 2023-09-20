// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_PRESENT_MULTIPLANE_OVERLAY2
    {
        public uint hAdapter;
        public _D3DKMT_PRESENT_MULTIPLANE_OVERLAY2__union_0 __union_1;
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
