// generated from <Windows SDK Path>\shared\ksmedia.h
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
