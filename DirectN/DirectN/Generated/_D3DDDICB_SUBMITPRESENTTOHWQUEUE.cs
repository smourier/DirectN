// generated from <Windows SDK Path>\um\d3dumddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDICB_SUBMITPRESENTTOHWQUEUE
    {
        public IntPtr BroadcastSrcAllocations;
        public IntPtr BroadcastDstAllocations;
        public IntPtr hHwQueues;
        public uint BroadcastHwQueueCount;
        public uint PrivateDriverDataSize;
        public IntPtr pPrivateDriverData;
        public byte bOptimizeForComposition;
        public bool SyncIntervalOverrideValid;
        public D3DDDI_FLIPINTERVAL_TYPE SyncIntervalOverride;
    }
}
