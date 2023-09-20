// generated from <Windows SDK Path>\shared\ksmedia.h
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
