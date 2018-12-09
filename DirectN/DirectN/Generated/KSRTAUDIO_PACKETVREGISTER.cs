// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\ksmedia.h(1548,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSRTAUDIO_PACKETVREGISTER
    {
        public IntPtr CompletedPacketCount;
        public IntPtr CompletedPacketQPC;
        public IntPtr CompletedPacketHash;
    }
}
