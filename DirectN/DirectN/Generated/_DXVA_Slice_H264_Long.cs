// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\dxva.h(797,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DXVA_Slice_H264_Long
    {
        public uint BSNALunitDataLocation;
        public uint SliceBytesInBuffer;
        public ushort wBadSliceChopping;
        public ushort first_mb_in_slice;
        public ushort NumMbsForSlice;
        public ushort BitOffsetToSliceData;
        public byte slice_type;
        public byte luma_log2_weight_denom;
        public byte chroma_log2_weight_denom;
        public byte num_ref_idx_l0_active_minus1;
        public byte num_ref_idx_l1_active_minus1;
        public sbyte slice_alpha_c0_offset_div2;
        public sbyte slice_beta_offset_div2;
        public byte Reserved8Bits;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)] 
        public _DXVA_PicEntry_H264[] RefPicList;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 384)] 
        public short[] Weights;
        public sbyte slice_qs_delta;
        public sbyte slice_qp_delta;
        public byte redundant_pic_cnt;
        public byte direct_spatial_mv_pred_flag;
        public byte cabac_init_idc;
        public byte disable_deblocking_filter_idc;
        public ushort slice_id;
    }
}
