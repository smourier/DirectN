// generated from <Windows SDK Path>\shared\ksmedia.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSPROPERTY_TUNER_STATUS_S
    {
        public KSIDENTIFIER Property;
        public uint CurrentFrequency;
        public uint PLLOffset;
        public uint SignalStrength;
        public uint Busy;
    }
}
