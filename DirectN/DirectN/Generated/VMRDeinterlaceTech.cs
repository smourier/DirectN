// generated from <Windows SDK Path>\um\strmif.h
using System;

namespace DirectN
{
    [Flags]
    public enum VMRDeinterlaceTech
    {
        DeinterlaceTech_Unknown = 0x00000000,
        DeinterlaceTech_BOBLineReplicate = 0x00000001,
        DeinterlaceTech_BOBVerticalStretch = 0x00000002,
        DeinterlaceTech_MedianFiltering = 0x00000004,
        DeinterlaceTech_EdgeFiltering = 0x00000010,
        DeinterlaceTech_FieldAdaptive = 0x00000020,
        DeinterlaceTech_PixelAdaptive = 0x00000040,
        DeinterlaceTech_MotionVectorSteered = 0x00000080,
    }
}
