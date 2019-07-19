// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\dxgiddi.h(833,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DXGIDDICB_PRESENT
    {
        public uint hSrcAllocation;
        public uint hDstAllocation;
        public IntPtr pDXGIContext;
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
        public DXGI_DDI_FLIP_INTERVAL_TYPE SyncIntervalOverride;
    }
}
