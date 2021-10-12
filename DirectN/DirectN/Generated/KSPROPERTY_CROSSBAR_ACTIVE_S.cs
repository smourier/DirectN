// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\ksmedia.h(7147,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSPROPERTY_CROSSBAR_ACTIVE_S
    {
        public KSIDENTIFIER Property;
        public uint IndexInputPin;
        public uint Active;
    }
}
