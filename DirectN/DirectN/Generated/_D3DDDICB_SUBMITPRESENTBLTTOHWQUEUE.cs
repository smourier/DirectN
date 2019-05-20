// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3dumddi.h(4163,9)
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
