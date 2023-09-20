// generated from <Windows SDK Path>\um\d3dumddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDICB_SUBMITPRESENTBLTTOHWQUEUE
    {
        public uint hSrcAllocation;
        public uint hDstAllocation;
        public IntPtr hHwQueue;
        public ulong HwQueueProgressFenceId;
        public uint PrivateDriverDataSize;
        public IntPtr pPrivateDriverData;
    }
}
