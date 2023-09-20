// generated from <Windows SDK Path>\shared\ksmedia.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSRTAUDIO_SETWRITEPACKET_INFO
    {
        public uint PacketNumber;
        public uint Flags;
        public uint EosPacketLength;
    }
}
