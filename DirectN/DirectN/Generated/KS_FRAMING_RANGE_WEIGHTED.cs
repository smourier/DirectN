// generated from <Windows SDK Path>\shared\ks.h
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
