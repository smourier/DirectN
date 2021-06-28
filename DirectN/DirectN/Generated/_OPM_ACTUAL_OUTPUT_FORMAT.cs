// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\opmapi.h(332,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _OPM_ACTUAL_OUTPUT_FORMAT
    {
        public _OPM_RANDOM_NUMBER rnRandomNumber;
        public uint ulStatusFlags;
        public uint ulDisplayWidth;
        public uint ulDisplayHeight;
        public _DXVA2_SampleFormat dsfSampleInterleaveFormat;
        public int d3dFormat;
        public uint ulFrequencyNumerator;
        public uint ulFrequencyDenominator;
    }
}
