// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmthk.h(5046,9)
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
