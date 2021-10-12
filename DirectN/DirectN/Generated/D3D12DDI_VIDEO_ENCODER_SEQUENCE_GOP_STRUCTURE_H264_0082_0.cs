// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12umddi.h(13357,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_VIDEO_ENCODER_SEQUENCE_GOP_STRUCTURE_H264_0082_0
    {
        public uint GOPLength;
        public uint PPicturePeriod;
        public byte pic_order_cnt_type;
        public byte log2_max_frame_num_minus4;
        public byte log2_max_pic_order_cnt_lsb_minus4;
    }
}
