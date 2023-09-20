// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_CREATEHWQUEUE
    {
        public IntPtr hHwQueue;
        public _D3DDDI_CREATEHWQUEUEFLAGS Flags;
        public uint PrivateDriverDataSize;
        public IntPtr pPrivateDriverData;
        public uint hHwQueueProgressFence;
        public IntPtr HwQueueProgressFenceCPUVirtualAddress;
        public ulong HwQueueProgressFenceGPUVirtualAddress;
    }
}
