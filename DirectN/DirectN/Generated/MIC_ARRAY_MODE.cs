// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wmcodecdsp.h(3725,1)
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
