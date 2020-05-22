// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\ksmedia.h(7140,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSPROPERTY_VIDEOCOMPRESSION_S
    {
        public KSIDENTIFIER Property;
        public uint StreamIndex;
        public int Value;
    }
}
