// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dxva.h(709,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DXVA_PicParams_H264
    {
        public ushort wFrameWidthInMbsMinus1;
        public ushort wFrameHeightInMbsMinus1;
        public _DXVA_PicEntry_H264 CurrPic;
        public byte num_ref_frames;
        public _DXVA_PicParams_H264__union_0 __union_4;
        public byte bit_depth_luma_minus8;
        public byte bit_depth_chroma_minus8;
        public ushort Reserved16Bits;
        public uint StatusReportFeedbackNumber;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)] 
        public _DXVA_PicEntry_H264[] RefFrameList;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)] 
        public int[] CurrFieldOrderCnt;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)] 
        public int[] FieldOrderCntList;
        public sbyte pic_init_qs_minus26;
        public sbyte chroma_qp_index_offset;
        public sbyte second_chroma_qp_index_offset;
        public byte ContinuationFlag;
        public sbyte pic_init_qp_minus26;
        public byte num_ref_idx_l0_active_minus1;
        public byte num_ref_idx_l1_active_minus1;
        public byte Reserved8BitsA;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)] 
        public ushort[] FrameNumList;
        public uint UsedForReferenceFlags;
        public ushort NonExistingFrameFlags;
        public ushort frame_num;
        public byte log2_max_frame_num_minus4;
        public byte pic_order_cnt_type;
        public byte log2_max_pic_order_cnt_lsb_minus4;
        public byte delta_pic_order_always_zero_flag;
        public byte direct_8x8_inference_flag;
        public byte entropy_coding_mode_flag;
        public byte pic_order_present_flag;
        public byte num_slice_groups_minus1;
        public byte slice_group_map_type;
        public byte deblocking_filter_control_present_flag;
        public byte redundant_pic_cnt_present_flag;
        public byte Reserved8BitsB;
        public ushort slice_group_change_rate_minus1;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 810)] 
        public byte[] SliceGroupMap;
    }
}
