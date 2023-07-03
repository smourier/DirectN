// c:\program files (x86)\windows kits\10\include\10.0.22621.0\shared\ksmedia.h(7210,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSPROPERTY_CROSSBAR_CAPS_S
    {
        public KSIDENTIFIER Property;
        public uint NumberOfInputs;
        public uint NumberOfOutputs;
    }
}
