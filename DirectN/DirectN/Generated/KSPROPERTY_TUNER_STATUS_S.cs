// c:\program files (x86)\windows kits\10\include\10.0.22621.0\shared\ksmedia.h(5462,9)
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
