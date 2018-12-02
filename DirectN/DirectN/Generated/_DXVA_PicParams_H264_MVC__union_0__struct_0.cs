// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dxva.h(986,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DXVA_PicParams_H264_MVC__union_0__struct_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte[] __bits;
        public ushort field_pic_flag => InteropRuntime.GetUInt16(__bits, 0, 1);
        public ushort MbaffFrameFlag => InteropRuntime.GetUInt16(__bits, 1, 1);
        public ushort residual_colour_transform_flag => InteropRuntime.GetUInt16(__bits, 2, 1);
        public ushort sp_for_switch_flag => InteropRuntime.GetUInt16(__bits, 3, 1);
        public ushort chroma_format_idc => InteropRuntime.GetUInt16(__bits, 4, 2);
        public ushort RefPicFlag => InteropRuntime.GetUInt16(__bits, 6, 1);
        public ushort constrained_intra_pred_flag => InteropRuntime.GetUInt16(__bits, 7, 1);
        public ushort weighted_pred_flag => InteropRuntime.GetUInt16(__bits, 8, 1);
        public ushort weighted_bipred_idc => InteropRuntime.GetUInt16(__bits, 9, 2);
        public ushort MbsConsecutiveFlag => InteropRuntime.GetUInt16(__bits, 11, 1);
        public ushort frame_mbs_only_flag => InteropRuntime.GetUInt16(__bits, 12, 1);
        public ushort transform_8x8_mode_flag => InteropRuntime.GetUInt16(__bits, 13, 1);
        public ushort MinLumaBipredSize8x8Flag => InteropRuntime.GetUInt16(__bits, 14, 1);
        public ushort IntraPicFlag => InteropRuntime.GetUInt16(__bits, 15, 1);
    }
}
