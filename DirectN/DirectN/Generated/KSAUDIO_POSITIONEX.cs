// c:\program files (x86)\windows kits\10\include\10.0.22621.0\shared\ksmedia.h(1905,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSAUDIO_POSITIONEX
    {
        public long TimerFrequency;
        public long TimeStamp1;
        public KSAUDIO_POSITION Position;
        public long TimeStamp2;
    }
}
