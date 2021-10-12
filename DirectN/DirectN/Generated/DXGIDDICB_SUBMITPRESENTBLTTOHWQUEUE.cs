// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dxgiddi.h(911,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DXGIDDICB_SUBMITPRESENTBLTTOHWQUEUE
    {
        public uint hSrcAllocation;
        public uint hDstAllocation;
        public IntPtr pDXGIContext;
        public IntPtr hHwQueue;
        public ulong HwQueueProgressFenceId;
        public uint PrivateDriverDataSize;
        public IntPtr pPrivateDriverData;
    }
}
