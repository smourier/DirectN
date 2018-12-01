// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dxva.h(932,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DXVA_FilmGrainCharacteristics
    {
        public ushort wFrameWidthInMbsMinus1;
        public ushort wFrameHeightInMbsMinus1;
        public _DXVA_PicEntry_H264 InPic;
        public _DXVA_PicEntry_H264 OutPic;
        public ushort PicOrderCnt_offset;
        public int CurrPicOrderCnt;
        public uint StatusReportFeedbackNumber;
        public byte model_id;
        public byte separate_colour_description_present_flag;
        public byte film_grain_bit_depth_luma_minus8;
        public byte film_grain_bit_depth_chroma_minus8;
        public byte film_grain_full_range_flag;
        public byte film_grain_colour_primaries;
        public byte film_grain_transfer_characteristics;
        public byte film_grain_matrix_coefficients;
        public byte blending_mode_id;
        public byte log2_scale_factor;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)] 
        public byte comp_model_present_flag;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)] 
        public byte num_intensity_intervals_minus1;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)] 
        public byte num_model_values_minus1;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 48)] 
        public byte intensity_interval_lower_bound;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 48)] 
        public byte intensity_interval_upper_bound;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 384)] 
        public short comp_model_value;
    }
}
