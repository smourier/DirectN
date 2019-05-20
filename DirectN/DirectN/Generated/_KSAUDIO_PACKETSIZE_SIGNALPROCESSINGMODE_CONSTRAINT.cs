// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\ksmedia.h(1020,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _KSAUDIO_PACKETSIZE_SIGNALPROCESSINGMODE_CONSTRAINT
    {
        public Guid ProcessingMode;
        public uint SamplesPerProcessingPacket;
        public uint ProcessingPacketDurationInHns;
    }
}
