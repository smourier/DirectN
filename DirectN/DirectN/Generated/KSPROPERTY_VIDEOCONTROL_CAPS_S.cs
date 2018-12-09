// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\ksmedia.h(7184,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSPROPERTY_VIDEOCONTROL_CAPS_S
    {
        public KSIDENTIFIER Property;
        public uint StreamIndex;
        public uint VideoControlCaps;
    }
}
