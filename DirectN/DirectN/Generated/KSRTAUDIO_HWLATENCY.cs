// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\ksmedia.h(1484,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSRTAUDIO_HWLATENCY
    {
        public uint FifoSize;
        public uint ChipsetDelay;
        public uint CodecDelay;
    }
}
