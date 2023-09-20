// generated from <Windows SDK Path>\shared\ksmedia.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct TUNER_ANALOG_CAPS_S
    {
        public uint Mode;
        public uint StandardsSupported;
        public uint MinFrequency;
        public uint MaxFrequency;
        public uint TuningGranularity;
        public uint SettlingTime;
        public uint ScanSensingRange;
        public uint FineTuneSensingRange;
    }
}
