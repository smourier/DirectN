// generated from <Windows SDK Path>\shared\dcomptypes.h
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
