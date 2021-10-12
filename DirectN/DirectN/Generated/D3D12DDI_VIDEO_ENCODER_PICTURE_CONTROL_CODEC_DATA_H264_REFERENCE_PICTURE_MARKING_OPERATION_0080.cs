// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12umddi.h(12515,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_H264_REFERENCE_PICTURE_MARKING_OPERATION_0080
    {
        public byte memory_management_control_operation;
        public byte difference_of_pic_nums_minus1;
        public byte long_term_pic_num;
        public byte long_term_frame_idx;
        public byte max_long_term_frame_idx_plus1;
    }
}
