// generated from <Windows SDK Path>\um\dxgiddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DXGIDDICB_SUBMITPRESENTTOHWQUEUE
    {
        public IntPtr pDXGIContext;
        public IntPtr BroadcastSrcAllocations;
        public IntPtr BroadcastDstAllocations;
        public IntPtr hHwQueues;
        public uint BroadcastHwQueueCount;
        public uint PrivateDriverDataSize;
        public IntPtr pPrivateDriverData;
        public byte bOptimizeForComposition;
        public bool SyncIntervalOverrideValid;
        public DXGI_DDI_FLIP_INTERVAL_TYPE SyncIntervalOverride;
    }
}
