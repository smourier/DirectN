// generated from <Windows SDK Path>\shared\d3dkmthk.h
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
