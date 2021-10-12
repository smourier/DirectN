// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dxva.h(1343,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Ansi)]
    public partial struct _DXVA_PicParams_VP9
    {
        public _DXVA_PicEntry_VPx CurrPic;
        public byte profile;
        public _DXVA_PicParams_VP9__union_0 __union_2;
        public uint width;
        public uint height;
        public byte BitDepthMinus8Luma;
        public byte BitDepthMinus8Chroma;
        public byte interp_filter;
        public byte Reserved8Bits;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)] 
        public _DXVA_PicEntry_VPx[] ref_frame_map;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)] 
        public uint[] ref_frame_coded_width;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)] 
        public uint[] ref_frame_coded_height;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)] 
        public _DXVA_PicEntry_VPx[] frame_refs;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)] 
        public string ref_frame_sign_bias;
        public sbyte filter_level;
        public sbyte sharpness_level;
        public _DXVA_PicParams_VP9__union_1 __union_16;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)] 
        public string ref_deltas;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)] 
        public string mode_deltas;
        public short base_qindex;
        public sbyte y_dc_delta_q;
        public sbyte uv_dc_delta_q;
        public sbyte uv_ac_delta_q;
        public _segmentation_VP9 stVP9Segments;
        public byte log2_tile_cols;
        public byte log2_tile_rows;
        public ushort uncompressed_header_size_byte_aligned;
        public ushort first_partition_size;
        public ushort Reserved16Bits;
        public uint Reserved32Bits;
        public uint StatusReportFeedbackNumber;
    }
}
