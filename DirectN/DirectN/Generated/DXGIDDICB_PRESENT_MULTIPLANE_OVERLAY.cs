// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\dxgiddi.h(868,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DXGIDDICB_PRESENT_MULTIPLANE_OVERLAY
    {
        public IntPtr pDXGIContext;
        public IntPtr hContext;
        public uint BroadcastContextCount;
        public IntPtr BroadcastContext;
        public uint AllocationInfoCount;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)] 
        public DXGIDDI_MULTIPLANE_OVERLAY_ALLOCATION_INFO[] AllocationInfo;
    }
}
