// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\ksmedia.h(2730,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct LOOPEDSTREAMING_POSITION_EVENT_DATA
    {
        public KSEVENTDATA KsEventData;
        public ulong Position;
    }
}
