// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12video.h(6135,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_VIDEO_ENCODER_SEQUENCE_GOP_STRUCTURE_HEVC
    {
        public uint GOPLength;
        public uint PPicturePeriod;
        public byte log2_max_pic_order_cnt_lsb_minus4;
    }
}
