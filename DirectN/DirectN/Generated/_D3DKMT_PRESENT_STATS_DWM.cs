// c:\program files (x86)\windows kits\10\include\10.0.22621.0\shared\d3dkmthk.h(4254,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_PRESENT_STATS_DWM
    {
        public uint PresentCount;
        public uint PresentRefreshCount;
        public long PresentQPCTime;
        public uint SyncRefreshCount;
        public long SyncQPCTime;
        public uint CustomPresentDuration;
    }
}
