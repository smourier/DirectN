// generated from <Windows SDK Path>\shared\ksmedia.h
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
