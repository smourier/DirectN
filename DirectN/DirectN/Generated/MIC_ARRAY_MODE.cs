// generated from <Windows SDK Path>\um\wmcodecdsp.h
using System;

namespace DirectN
{
    [Flags]
    public enum MIC_ARRAY_MODE
    {
        MICARRAY_SINGLE_CHAN = 0x00000000,
        MICARRAY_SIMPLE_SUM = 0x00000100,
        MICARRAY_SINGLE_BEAM = 0x00000200,
        MICARRAY_FIXED_BEAM = 0x00000400,
        MICARRAY_EXTERN_BEAM = 0x00000800,
    }
}
