// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\strmif.h(20207,1)
using System;

namespace DirectN
{
    [Flags]
    public enum VMRMixerPrefs
    {
        MixerPref_NoDecimation = 0x00000001,
        MixerPref_DecimateOutput = 0x00000002,
        MixerPref_ARAdjustXorY = 0x00000004,
        MixerPref_DecimationReserved = 0x00000008,
        MixerPref_DecimateMask = 0x0000000F,
        MixerPref_BiLinearFiltering = 0x00000010,
        MixerPref_PointFiltering = 0x00000020,
        MixerPref_FilteringMask = 0x000000F0,
        MixerPref_RenderTargetRGB = 0x00000100,
        MixerPref_RenderTargetYUV = 0x00001000,
        MixerPref_RenderTargetYUV420 = 0x00000200,
        MixerPref_RenderTargetYUV422 = 0x00000400,
        MixerPref_RenderTargetYUV444 = 0x00000800,
        MixerPref_RenderTargetReserved = 0x0000E000,
        MixerPref_RenderTargetMask = 0x0000FF00,
        MixerPref_DynamicSwitchToBOB = 0x00010000,
        MixerPref_DynamicDecimateBy2 = 0x00020000,
        MixerPref_DynamicReserved = 0x000C0000,
        MixerPref_DynamicMask = 0x000F0000,
    }
}
