// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\ksmedia.h(1465,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSRTAUDIO_BUFFER_PROPERTY_WITH_NOTIFICATION32
    {
        public KSIDENTIFIER Property;
        public uint BaseAddress;
        public uint RequestedBufferSize;
        public uint NotificationCount;
    }
}
