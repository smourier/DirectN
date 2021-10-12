// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dxva.h(1515,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DXVA_PicParams_AV1
    {
        public uint width;
        public uint height;
        public uint max_width;
        public uint max_height;
        public byte CurrPicTextureIndex;
        public byte superres_denom;
        public byte bitdepth;
        public byte seq_profile;
        public _DXVA_PicParams_AV1__struct_0 tiles;
        public _DXVA_PicParams_AV1__union_1 coding;
        public _DXVA_PicParams_AV1__union_2 format;
        public byte primary_ref_frame;
        public byte order_hint;
        public byte order_hint_bits;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 7)] 
        public _DXVA_PicEntry_AV1[] frame_refs;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)] 
        public byte[] RefFrameMapTextureIndex;
        public _DXVA_PicParams_AV1__struct_3 loop_filter;
        public _DXVA_PicParams_AV1__struct_4 quantization;
        public _DXVA_PicParams_AV1__struct_5 cdef;
        public byte interp_filter;
        public _DXVA_PicParams_AV1__struct_6 segmentation;
        public _DXVA_PicParams_AV1__struct_7 film_grain;
        public uint Reserved32Bits;
        public uint StatusReportFeedbackNumber;
    }
}
