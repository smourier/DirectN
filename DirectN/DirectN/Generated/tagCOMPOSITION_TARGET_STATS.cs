// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\dcomptypes.h(151,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagCOMPOSITION_TARGET_STATS
    {
        public uint outstandingPresents;
        public ulong presentTime;
        public ulong vblankDuration;
        public tagCOMPOSITION_STATS presentedStats;
        public tagCOMPOSITION_STATS completedStats;
    }
}
