// generated from <Windows SDK Path>\shared\d3dkmthk.h
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
