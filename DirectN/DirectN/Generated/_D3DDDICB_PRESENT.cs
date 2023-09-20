// generated from <Windows SDK Path>\um\d3dumddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDICB_PRESENT
    {
        public uint hSrcAllocation;
        public uint hDstAllocation;
        public IntPtr hContext;
        public uint BroadcastContextCount;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)] 
        public IntPtr[] BroadcastContext;
        public IntPtr BroadcastSrcAllocation;
        public IntPtr BroadcastDstAllocation;
        public uint PrivateDriverDataSize;
        public IntPtr pPrivateDriverData;
        public byte bOptimizeForComposition;
        public bool SyncIntervalOverrideValid;
        public D3DDDI_FLIPINTERVAL_TYPE SyncIntervalOverride;
    }
}
