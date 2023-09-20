// generated from <Windows SDK Path>\um\dxgiddi.h
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
