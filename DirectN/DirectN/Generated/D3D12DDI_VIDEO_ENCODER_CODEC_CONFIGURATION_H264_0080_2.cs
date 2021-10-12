// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12umddi.h(12915,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_0080_2
    {
        public D3D12DDI_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_FLAGS_0080 ConfigurationFlags;
        public D3D12DDI_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_DIRECT_MODES_0080 DirectModeConfig;
        public byte pic_order_cnt_type;
        public byte log2_max_frame_num_minus4;
        public byte log2_max_pic_order_cnt_lsb_minus4;
    }
}
