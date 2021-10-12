// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\ks.h(1740,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KS_COMPRESSION
    {
        public uint RatioNumerator;
        public uint RatioDenominator;
        public uint RatioConstantMargin;
    }
}
