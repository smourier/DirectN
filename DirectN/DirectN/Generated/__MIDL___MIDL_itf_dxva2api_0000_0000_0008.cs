// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\dxva2api.h(391,1)
using System;

namespace DirectN
{
    [Flags]
    public enum __MIDL___MIDL_itf_dxva2api_0000_0000_0008
    {
        DXVA2_VideoProcess_None = 0x00000000,
        DXVA2_VideoProcess_YUV2RGB = 0x00000001,
        DXVA2_VideoProcess_StretchX = 0x00000002,
        DXVA2_VideoProcess_StretchY = 0x00000004,
        DXVA2_VideoProcess_AlphaBlend = 0x00000008,
        DXVA2_VideoProcess_SubRects = 0x00000010,
        DXVA2_VideoProcess_SubStreams = 0x00000020,
        DXVA2_VideoProcess_SubStreamsExtended = 0x00000040,
        DXVA2_VideoProcess_YUV2RGBExtended = 0x00000080,
        DXVA2_VideoProcess_AlphaBlendExtended = 0x00000100,
        DXVA2_VideoProcess_Constriction = 0x00000200,
        DXVA2_VideoProcess_NoiseFilter = 0x00000400,
        DXVA2_VideoProcess_DetailFilter = 0x00000800,
        DXVA2_VideoProcess_PlanarAlpha = 0x00001000,
        DXVA2_VideoProcess_LinearScaling = 0x00002000,
        DXVA2_VideoProcess_GammaCompensated = 0x00004000,
        DXVA2_VideoProcess_MaintainsOriginalFieldData = 0x00008000,
        DXVA2_VideoProcess_Mask = 0x0000FFFF,
    }
}
