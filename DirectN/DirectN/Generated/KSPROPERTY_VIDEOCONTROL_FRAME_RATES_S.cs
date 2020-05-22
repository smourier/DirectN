// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\ksmedia.h(7298,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSPROPERTY_VIDEOCONTROL_FRAME_RATES_S
    {
        public KSIDENTIFIER Property;
        public uint StreamIndex;
        public uint RangeIndex;
        public tagSIZE Dimensions;
    }
}
