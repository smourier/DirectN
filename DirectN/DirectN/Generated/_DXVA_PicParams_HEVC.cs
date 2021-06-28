// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\dxva.h(1159,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DXVA_PicParams_HEVC
    {
        public ushort PicWidthInMinCbsY;
        public ushort PicHeightInMinCbsY;
        public _DXVA_PicParams_HEVC__union_0 __union_2;
        public _DXVA_PicEntry_HEVC CurrPic;
        public byte sps_max_dec_pic_buffering_minus1;
        public byte log2_min_luma_coding_block_size_minus3;
        public byte log2_diff_max_min_luma_coding_block_size;
        public byte log2_min_transform_block_size_minus2;
        public byte log2_diff_max_min_transform_block_size;
        public byte max_transform_hierarchy_depth_inter;
        public byte max_transform_hierarchy_depth_intra;
        public byte num_short_term_ref_pic_sets;
        public byte num_long_term_ref_pics_sps;
        public byte num_ref_idx_l0_default_active_minus1;
        public byte num_ref_idx_l1_default_active_minus1;
        public sbyte init_qp_minus26;
        public byte ucNumDeltaPocsOfRefRpsIdx;
        public ushort wNumBitsForShortTermRPSInSlice;
        public ushort ReservedBits2;
        public _DXVA_PicParams_HEVC__union_1 __union_19;
        public _DXVA_PicParams_HEVC__union_2 __union_20;
        public sbyte pps_cb_qp_offset;
        public sbyte pps_cr_qp_offset;
        public byte num_tile_columns_minus1;
        public byte num_tile_rows_minus1;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 19)] 
        public ushort[] column_width_minus1;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 21)] 
        public ushort[] row_height_minus1;
        public byte diff_cu_qp_delta_depth;
        public sbyte pps_beta_offset_div2;
        public sbyte pps_tc_offset_div2;
        public byte log2_parallel_merge_level_minus2;
        public int CurrPicOrderCntVal;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 15)] 
        public _DXVA_PicEntry_HEVC[] RefPicList;
        public byte ReservedBits5;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 15)] 
        public int[] PicOrderCntValList;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)] 
        public byte[] RefPicSetStCurrBefore;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)] 
        public byte[] RefPicSetStCurrAfter;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)] 
        public byte[] RefPicSetLtCurr;
        public ushort ReservedBits6;
        public ushort ReservedBits7;
        public uint StatusReportFeedbackNumber;
    }
}
