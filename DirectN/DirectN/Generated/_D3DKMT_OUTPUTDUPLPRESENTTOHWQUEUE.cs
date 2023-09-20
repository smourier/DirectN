// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_OUTPUTDUPLPRESENTTOHWQUEUE
    {
        public uint hSource;
        public uint VidPnSourceId;
        public uint BroadcastHwQueueCount;
        public IntPtr hHwQueues;
        public _D3DKMT_PRESENT_RGNS PresentRegions;
        public _D3DKMT_OUTPUTDUPLPRESENTFLAGS Flags;
        public uint hIndirectHwQueue;
    }
}
