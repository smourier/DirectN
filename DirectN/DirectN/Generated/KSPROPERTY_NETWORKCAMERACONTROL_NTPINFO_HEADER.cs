// c:\program files (x86)\windows kits\10\include\10.0.22621.0\shared\ksmedia.h(6870,9)
using System;
using System.Runtime.InteropServices;
using KSPROPERTY_NETWORKCAMERACONTROL_NTPINFO_TYPE = DirectN.KSPROPER;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSPROPERTY_NETWORKCAMERACONTROL_NTPINFO_HEADER
    {
        public uint Size;
        public KSPROPERTY_NETWORKCAMERACONTROL_NTPINFO_TYPE Type;
    }
}
