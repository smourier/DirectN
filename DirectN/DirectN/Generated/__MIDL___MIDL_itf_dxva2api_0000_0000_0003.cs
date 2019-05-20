// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\dxva2api.h(330,1)
using System;

namespace DirectN
{
    [Flags]
    public enum __MIDL___MIDL_itf_dxva2api_0000_0000_0003
    {
        DXVA2_DeinterlaceTech_Unknown = 0x00000000,
        DXVA2_DeinterlaceTech_BOBLineReplicate = 0x00000001,
        DXVA2_DeinterlaceTech_BOBVerticalStretch = 0x00000002,
        DXVA2_DeinterlaceTech_BOBVerticalStretch4Tap = 0x00000004,
        DXVA2_DeinterlaceTech_MedianFiltering = 0x00000008,
        DXVA2_DeinterlaceTech_EdgeFiltering = 0x00000010,
        DXVA2_DeinterlaceTech_FieldAdaptive = 0x00000020,
        DXVA2_DeinterlaceTech_PixelAdaptive = 0x00000040,
        DXVA2_DeinterlaceTech_MotionVectorSteered = 0x00000080,
        DXVA2_DeinterlaceTech_InverseTelecine = 0x00000100,
        DXVA2_DeinterlaceTech_Mask = 0x000001FF,
    }
}
