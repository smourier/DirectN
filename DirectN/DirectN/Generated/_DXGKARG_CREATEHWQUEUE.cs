// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmddi.h(1601,9)
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
