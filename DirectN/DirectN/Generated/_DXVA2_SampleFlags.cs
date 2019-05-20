// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\dxva2swdev.h(22,9)
using System;

namespace DirectN
{
    [Flags]
    public enum _DXVA2_SampleFlags
    {
        DXVA2_SampleFlag_Palette_Changed = 0x00000001,
        DXVA2_SampleFlag_SrcRect_Changed = 0x00000002,
        DXVA2_SampleFlag_DstRect_Changed = 0x00000004,
        DXVA2_SampleFlag_ColorData_Changed = 0x00000008,
        DXVA2_SampleFlag_PlanarAlpha_Changed = 0x00000010,
        DXVA2_SampleFlag_RFF = 0x00010000,
        DXVA2_SampleFlag_TFF = 0x00020000,
        DXVA2_SampleFlag_RFF_TFF_Present = 0x00040000,
        DXVA2_SampleFlagsMask = unchecked((int)0xFFFF001F),
    }
}
