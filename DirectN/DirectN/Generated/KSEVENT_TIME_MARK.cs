// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\ks.h(454,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSEVENT_TIME_MARK
    {
        public KSEVENTDATA EventData;
        public long MarkTime;
    }
}
