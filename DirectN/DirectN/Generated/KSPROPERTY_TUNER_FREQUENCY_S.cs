// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\ksmedia.h(5413,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSPROPERTY_TUNER_FREQUENCY_S
    {
        public KSIDENTIFIER Property;
        public uint Frequency;
        public uint LastFrequency;
        public uint TuningFlags;
        public uint VideoSubChannel;
        public uint AudioSubChannel;
        public uint Channel;
        public uint Country;
    }
}
