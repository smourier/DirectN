// c:\program files (x86)\windows kits\10\include\10.0.22621.0\shared\ksmedia.h(7146,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagTIMECODE_SAMPLE
    {
        public long qwTick;
        public _timecode timecode;
        public uint dwUser;
        public uint dwFlags;
    }
}
