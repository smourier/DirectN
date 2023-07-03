// c:\program files (x86)\windows kits\10\include\10.0.22621.0\shared\ksmedia.h(5419,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSPROPERTY_TUNER_MODE_CAPS_S
    {
        public KSIDENTIFIER Property;
        public uint Mode;
        public uint StandardsSupported;
        public uint MinFrequency;
        public uint MaxFrequency;
        public uint TuningGranularity;
        public uint NumberOfInputs;
        public uint SettlingTime;
        public uint Strategy;
    }
}
