// c:\program files (x86)\windows kits\10\include\10.0.22621.0\shared\d3dkmthk.h(3424,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_QUERYSTATISTICS_PROCESS_VIDPNSOURCE_INFORMATION
    {
        public uint Frame;
        public uint CancelledFrame;
        public uint QueuedPresent;
        public uint Padding;
        public ulong IsVSyncEnabled;
        public ulong VSyncOnTotalTimeMs;
        public ulong VSyncOffKeepPhaseTotalTimeMs;
        public ulong VSyncOffNoPhaseTotalTimeMs;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)] 
        public ulong[] Reserved;
    }
}
