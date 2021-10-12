// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12umddi.h(12810,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDICAPS_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_MODE_DATA_0080_2
    {
        public uint NodeIndex;
        public D3D12DDI_VIDEO_ENCODER_CODEC_0080 Codec;
        public D3D12DDI_VIDEO_ENCODER_PROFILE_DESC_0080_2 Profile;
        public D3D12DDI_VIDEO_ENCODER_LEVEL_SETTING_0080_2 Level;
        public D3D12DDI_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_MODE_0080 SubregionMode;
        public bool IsSupported;
    }
}
