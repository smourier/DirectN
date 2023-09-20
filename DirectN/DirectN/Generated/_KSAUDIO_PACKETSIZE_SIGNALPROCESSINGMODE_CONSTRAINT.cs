// generated from <Windows SDK Path>\shared\ksmedia.h
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
