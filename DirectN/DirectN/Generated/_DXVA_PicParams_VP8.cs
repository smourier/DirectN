// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\dxva.h(1419,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Ansi)]
    public partial struct _DXVA_PicParams_VP8
    {
        public uint first_part_size;
        public uint width;
        public uint height;
        public _DXVA_PicEntry_VPx CurrPic;
        public _DXVA_PicParams_VP8__union_0 __union_4;
        public _segmentation_VP8 stVP8Segments;
        public byte filter_type;
        public byte filter_level;
        public byte sharpness_level;
        public byte mode_ref_lf_delta_enabled;
        public byte mode_ref_lf_delta_update;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)] 
        public string ref_lf_deltas;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)] 
        public string mode_lf_deltas;
        public byte log2_nbr_of_dct_partitions;
        public byte base_qindex;
        public sbyte y1dc_delta_q;
        public sbyte y2dc_delta_q;
        public sbyte y2ac_delta_q;
        public sbyte uvdc_delta_q;
        public sbyte uvac_delta_q;
        public _DXVA_PicEntry_VPx alt_fb_idx;
        public _DXVA_PicEntry_VPx gld_fb_idx;
        public _DXVA_PicEntry_VPx lst_fb_idx;
        public byte ref_frame_sign_bias_golden;
        public byte ref_frame_sign_bias_altref;
        public byte refresh_entropy_probs;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1056)] 
        public byte[] vp8_coef_update_probs;
        public byte mb_no_coeff_skip;
        public byte prob_skip_false;
        public byte prob_intra;
        public byte prob_last;
        public byte prob_golden;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)] 
        public byte[] intra_16x16_prob;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)] 
        public byte[] intra_chroma_prob;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 38)] 
        public byte[] vp8_mv_update_probs;
        public ushort ReservedBits1;
        public ushort ReservedBits2;
        public ushort ReservedBits3;
        public uint StatusReportFeedbackNumber;
    }
}
