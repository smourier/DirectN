// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3dumddi.h(3782,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3DDDICB_PRESENTMULTIPLANEOVERLAY
    {
        public IntPtr hContext;
        public uint BroadcastContextCount;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)] 
        public IntPtr[] BroadcastContext;
        public uint AllocationInfoCount;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)] 
        public D3DDDI_MULTIPLANE_OVERLAY_ALLOCATION_INFO[] AllocationInfo;
    }
}
