// generated from <Windows SDK Path>\um\d3dumddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDICB_CREATEHWQUEUE
    {
        public IntPtr hHwContext;
        public _D3DDDI_CREATEHWQUEUEFLAGS Flags;
        public uint PrivateDriverDataSize;
        public IntPtr pPrivateDriverData;
        public IntPtr hHwQueue;
        public uint hHwQueueProgressFence;
        public IntPtr HwQueueProgressFenceCPUVirtualAddress;
        public ulong HwQueueProgressFenceGPUVirtualAddress;
    }
}
