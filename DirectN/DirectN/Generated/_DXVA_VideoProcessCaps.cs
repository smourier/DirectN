// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\dxva.h(1756,9)
using System;

namespace DirectN
{
    [Flags]
    public enum _DXVA_VideoProcessCaps
    {
        DXVA_VideoProcess_None = 0x00000000,
        DXVA_VideoProcess_YUV2RGB = 0x00000001,
        DXVA_VideoProcess_StretchX = 0x00000002,
        DXVA_VideoProcess_StretchY = 0x00000004,
        DXVA_VideoProcess_AlphaBlend = 0x00000008,
        DXVA_VideoProcess_SubRects = 0x00000010,
        DXVA_VideoProcess_SubStreams = 0x00000020,
        DXVA_VideoProcess_SubStreamsExtended = 0x00000040,
        DXVA_VideoProcess_YUV2RGBExtended = 0x00000080,
        DXVA_VideoProcess_AlphaBlendExtended = 0x00000100,
    }
}
