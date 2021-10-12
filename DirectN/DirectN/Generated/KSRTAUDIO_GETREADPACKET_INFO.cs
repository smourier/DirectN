// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\ksmedia.h(1535,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSRTAUDIO_GETREADPACKET_INFO
    {
        public uint PacketNumber;
        public uint Flags;
        public ulong PerformanceCounterValue;
        public bool MoreData;
    }
}
