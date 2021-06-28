// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\ksmedia.h(1458,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSRTAUDIO_BUFFER_PROPERTY_WITH_NOTIFICATION
    {
        public KSIDENTIFIER Property;
        public IntPtr BaseAddress;
        public uint RequestedBufferSize;
        public uint NotificationCount;
    }
}
