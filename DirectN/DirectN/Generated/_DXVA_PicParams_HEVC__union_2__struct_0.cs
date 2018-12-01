// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dxva.h(1211,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DXVA_PicParams_HEVC__union_2__struct_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] __bits;
        public uint constrained_intra_pred_flag => InteropRuntime.GetUInt32Bits(__bits, 0, 1);
        public uint transform_skip_enabled_flag => InteropRuntime.GetUInt32Bits(__bits, 1, 1);
        public uint cu_qp_delta_enabled_flag => InteropRuntime.GetUInt32Bits(__bits, 2, 1);
        public uint pps_slice_chroma_qp_offsets_present_flag => InteropRuntime.GetUInt32Bits(__bits, 3, 1);
        public uint weighted_pred_flag => InteropRuntime.GetUInt32Bits(__bits, 4, 1);
        public uint weighted_bipred_flag => InteropRuntime.GetUInt32Bits(__bits, 5, 1);
        public uint transquant_bypass_enabled_flag => InteropRuntime.GetUInt32Bits(__bits, 6, 1);
        public uint tiles_enabled_flag => InteropRuntime.GetUInt32Bits(__bits, 7, 1);
        public uint entropy_coding_sync_enabled_flag => InteropRuntime.GetUInt32Bits(__bits, 8, 1);
        public uint uniform_spacing_flag => InteropRuntime.GetUInt32Bits(__bits, 9, 1);
        public uint loop_filter_across_tiles_enabled_flag => InteropRuntime.GetUInt32Bits(__bits, 10, 1);
        public uint pps_loop_filter_across_slices_enabled_flag => InteropRuntime.GetUInt32Bits(__bits, 11, 1);
        public uint deblocking_filter_override_enabled_flag => InteropRuntime.GetUInt32Bits(__bits, 12, 1);
        public uint pps_deblocking_filter_disabled_flag => InteropRuntime.GetUInt32Bits(__bits, 13, 1);
        public uint lists_modification_present_flag => InteropRuntime.GetUInt32Bits(__bits, 14, 1);
        public uint slice_segment_header_extension_present_flag => InteropRuntime.GetUInt32Bits(__bits, 15, 1);
        public uint IrapPicFlag => InteropRuntime.GetUInt32Bits(__bits, 16, 1);
        public uint IdrPicFlag => InteropRuntime.GetUInt32Bits(__bits, 17, 1);
        public uint IntraPicFlag => InteropRuntime.GetUInt32Bits(__bits, 18, 1);
        public uint ReservedBits4 => InteropRuntime.GetUInt32Bits(__bits, 19, 13);
    }
}
