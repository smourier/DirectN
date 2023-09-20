// generated from <Windows SDK Path>\shared\ksmedia.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSEVENT_TUNER_INITIATE_SCAN_S
    {
        public KSEVENTDATA EventData;
        public uint StartFrequency;
        public uint EndFrequency;
    }
}
