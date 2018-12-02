// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dxva.h(1157,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DXVA_PicParams_HEVC__union_0__struct_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte[] __bits;
        public ushort chroma_format_idc => InteropRuntime.GetUInt16(__bits, 0, 2);
        public ushort separate_colour_plane_flag => InteropRuntime.GetUInt16(__bits, 2, 1);
        public ushort bit_depth_luma_minus8 => InteropRuntime.GetUInt16(__bits, 3, 3);
        public ushort bit_depth_chroma_minus8 => InteropRuntime.GetUInt16(__bits, 6, 3);
        public ushort log2_max_pic_order_cnt_lsb_minus4 => InteropRuntime.GetUInt16(__bits, 9, 4);
        public ushort NoPicReorderingFlag => InteropRuntime.GetUInt16(__bits, 13, 1);
        public ushort NoBiPredFlag => InteropRuntime.GetUInt16(__bits, 14, 1);
        public ushort ReservedBits1 => InteropRuntime.GetUInt16(__bits, 15, 1);
    }
}
