// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\d3dkmdt.h(1732,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DXGKMDT_OPM_ACTUAL_OUTPUT_FORMAT
    {
        public _DXGKMDT_OPM_RANDOM_NUMBER rnRandomNumber;
        public uint ulStatusFlags;
        public uint ulDisplayWidth;
        public uint ulDisplayHeight;
        public _DXGKMDT_OPM_INTERLEAVE_FORMAT ifInterleaveFormat;
        public uint d3dFormat;
        public uint ulFrequencyNumerator;
        public uint ulFrequencyDenominator;
    }
}
