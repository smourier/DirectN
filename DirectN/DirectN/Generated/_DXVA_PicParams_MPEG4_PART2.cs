// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\dxva.h(1082,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DXVA_PicParams_MPEG4_PART2
    {
        public byte short_video_header;
        public byte vop_coding_type;
        public byte vop_quant;
        public ushort wDecodedPictureIndex;
        public ushort wDeblockedPictureIndex;
        public ushort wForwardRefPictureIndex;
        public ushort wBackwardRefPictureIndex;
        public ushort vop_time_increment_resolution;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)] 
        public uint[] TRB;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)] 
        public uint[] TRD;
        public _DXVA_PicParams_MPEG4_PART2__union_0 __union_10;
        public byte profile_and_level_indication;
        public byte video_object_layer_verid;
        public ushort vop_width;
        public ushort vop_height;
        public _DXVA_PicParams_MPEG4_PART2__union_1 __union_15;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)] 
        public short[] warping_mv;
        public _DXVA_PicParams_MPEG4_PART2__union_2 __union_17;
        public ushort StatusReportFeedbackNumber;
        public ushort Reserved16BitsA;
        public ushort Reserved16BitsB;
    }
}
