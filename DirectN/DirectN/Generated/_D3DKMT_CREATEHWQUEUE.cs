// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_CREATEHWQUEUE
    {
        public uint hHwContext;
        public _D3DDDI_CREATEHWQUEUEFLAGS Flags;
        public uint PrivateDriverDataSize;
        public IntPtr pPrivateDriverData;
        public uint hHwQueue;
        public uint hHwQueueProgressFence;
        public IntPtr HwQueueProgressFenceCPUVirtualAddress;
        public ulong HwQueueProgressFenceGPUVirtualAddress;
    }
}
