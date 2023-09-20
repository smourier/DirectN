// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_PRESENT_STATS_DWM2
    {
        public uint cbSize;
        public uint PresentCount;
        public uint PresentRefreshCount;
        public long PresentQPCTime;
        public uint SyncRefreshCount;
        public long SyncQPCTime;
        public uint CustomPresentDuration;
        public uint VirtualSyncRefreshCount;
        public long VirtualSyncQPCTime;
    }
}
