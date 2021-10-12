// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmthk.h(4839,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_SUBMITCOMMANDTOHWQUEUE
    {
        public uint hHwQueue;
        public ulong HwQueueProgressFenceId;
        public ulong CommandBuffer;
        public uint CommandLength;
        public uint PrivateDriverDataSize;
        public IntPtr pPrivateDriverData;
        public uint NumPrimaries;
        public IntPtr WrittenPrimaries;
    }
}
