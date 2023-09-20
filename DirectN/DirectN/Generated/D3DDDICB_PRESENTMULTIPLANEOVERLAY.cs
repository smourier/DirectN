// generated from <Windows SDK Path>\um\d3dumddi.h
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
