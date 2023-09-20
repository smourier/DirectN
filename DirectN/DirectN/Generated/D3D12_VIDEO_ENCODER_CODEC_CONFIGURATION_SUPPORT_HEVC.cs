// generated from <Windows SDK Path>\um\d3d12video.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC
    {
        public D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC_FLAGS SupportFlags;
        public D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_CUSIZE MinLumaCodingUnitSize;
        public D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_CUSIZE MaxLumaCodingUnitSize;
        public D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_TUSIZE MinLumaTransformUnitSize;
        public D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_TUSIZE MaxLumaTransformUnitSize;
        public byte max_transform_hierarchy_depth_inter;
        public byte max_transform_hierarchy_depth_intra;
    }
}
