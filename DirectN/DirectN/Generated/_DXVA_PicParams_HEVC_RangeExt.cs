// generated from <Windows SDK Path>\um\dxva.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Ansi)]
    public partial struct _DXVA_PicParams_HEVC_RangeExt
    {
        public _DXVA_PicParams_HEVC @params;
        public _DXVA_PicParams_HEVC_RangeExt__union_0 __union_1;
        public byte diff_cu_chroma_qp_offset_depth;
        public byte log2_sao_offset_scale_luma;
        public byte log2_sao_offset_scale_chroma;
        public byte log2_max_transform_skip_block_size_minus2;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 6)] 
        public string cb_qp_offset_list;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 6)] 
        public string cr_qp_offset_list;
        public byte chroma_qp_offset_list_len_minus1;
        public ushort ReservedBits9;
    }
}
