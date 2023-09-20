// generated from <Windows SDK Path>\um\dxgiddi.h
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
