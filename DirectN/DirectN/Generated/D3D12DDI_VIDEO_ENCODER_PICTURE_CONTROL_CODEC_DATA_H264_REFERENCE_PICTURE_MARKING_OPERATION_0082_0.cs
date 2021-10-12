// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12umddi.h(13468,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_H264_REFERENCE_PICTURE_MARKING_OPERATION_0082_0
    {
        public byte memory_management_control_operation;
        public uint difference_of_pic_nums_minus1;
        public uint long_term_pic_num;
        public uint long_term_frame_idx;
        public uint max_long_term_frame_idx_plus1;
    }
}
