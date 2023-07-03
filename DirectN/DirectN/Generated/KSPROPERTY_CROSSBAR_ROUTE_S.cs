// c:\program files (x86)\windows kits\10\include\10.0.22621.0\shared\ksmedia.h(7225,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSPROPERTY_CROSSBAR_ROUTE_S
    {
        public KSIDENTIFIER Property;
        public uint IndexInputPin;
        public uint IndexOutputPin;
        public uint CanRoute;
    }
}
