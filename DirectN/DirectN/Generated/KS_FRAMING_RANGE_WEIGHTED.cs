// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\ks.h(1733,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KS_FRAMING_RANGE_WEIGHTED
    {
        public KS_FRAMING_RANGE Range;
        public uint InPlaceWeight;
        public uint NotInPlaceWeight;
    }
}
