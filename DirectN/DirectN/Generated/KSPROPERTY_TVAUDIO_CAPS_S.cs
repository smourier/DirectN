// c:\program files (x86)\windows kits\10\include\10.0.22621.0\shared\ksmedia.h(7302,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSPROPERTY_TVAUDIO_CAPS_S
    {
        public KSIDENTIFIER Property;
        public uint Capabilities;
        public KSIDENTIFIER InputMedium;
        public KSIDENTIFIER OutputMedium;
    }
}
