// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\ksmedia.h(5363,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSPROPERTY_TUNER_CAPS_S
    {
        public KSIDENTIFIER Property;
        public uint ModesSupported;
        public KSIDENTIFIER VideoMedium;
        public KSIDENTIFIER TVAudioMedium;
        public KSIDENTIFIER RadioAudioMedium;
    }
}
