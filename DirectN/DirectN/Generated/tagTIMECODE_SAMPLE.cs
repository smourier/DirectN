// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\strmif.h(13491,9)
using System;
using System.Runtime.InteropServices;
using TIMECODE = DirectN._timecode;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagTIMECODE_SAMPLE
    {
        public long qwTick;
        public TIMECODE timecode;
        public uint dwUser;
        public uint dwFlags;
    }
}
