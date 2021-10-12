// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\dcomptypes.h(109,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagCOMPOSITION_FRAME_STATS
    {
        public ulong startTime;
        public ulong targetTime;
        public ulong framePeriod;
    }
}
