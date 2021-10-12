// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmthk.h(1286,9)
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
