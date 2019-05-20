// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3dumddi.h(4178,9)
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
