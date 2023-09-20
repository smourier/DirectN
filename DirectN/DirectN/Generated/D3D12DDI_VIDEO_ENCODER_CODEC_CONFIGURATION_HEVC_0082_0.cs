// generated from <Windows SDK Path>\um\d3d12umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_0082_0
    {
        public D3D12DDI_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_FLAGS_0082_0 ConfigurationFlags;
        public D3D12DDI_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_CUSIZE_0080 MinLumaCodingUnitSize;
        public D3D12DDI_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_CUSIZE_0080 MaxLumaCodingUnitSize;
        public D3D12DDI_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_TUSIZE_0082_0 MinLumaTransformUnitSize;
        public D3D12DDI_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_TUSIZE_0082_0 MaxLumaTransformUnitSize;
        public byte max_transform_hierarchy_depth_inter;
        public byte max_transform_hierarchy_depth_intra;
    }
}
