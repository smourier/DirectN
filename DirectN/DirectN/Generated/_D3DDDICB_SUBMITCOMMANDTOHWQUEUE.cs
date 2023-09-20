// generated from <Windows SDK Path>\um\d3dumddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDICB_SUBMITCOMMANDTOHWQUEUE
    {
        public IntPtr hHwQueue;
        public ulong HwQueueProgressFenceId;
        public ulong Commands;
        public uint CommandLength;
        public _D3DDDICB_SUBMITCOMMANDTOHWQUEUEFLAGS Flags;
        public uint PrivateDriverDataSize;
        public IntPtr pPrivateDriverData;
        public uint NumPrimaries;
        public IntPtr WrittenPrimaries;
    }
}
