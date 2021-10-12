// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\ksmedia.h(1459,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSRTAUDIO_BUFFER_PROPERTY32
    {
        public KSIDENTIFIER Property;
        public uint BaseAddress;
        public uint RequestedBufferSize;
    }
}
