// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\ks.h(3095,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSPROPERTY_SERIAL
    {
        public KSIDENTIFIER PropTypeSet;
        public uint Id;
        public uint PropertyLength;
    }
}
