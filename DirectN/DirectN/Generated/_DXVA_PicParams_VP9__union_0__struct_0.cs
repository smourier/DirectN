// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dxva.h(1341,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DXVA_PicParams_VP9__union_0__struct_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte[] __bits;
        public ushort frame_type => InteropRuntime.GetUInt16(__bits, 0, 1);
        public ushort show_frame => InteropRuntime.GetUInt16(__bits, 1, 1);
        public ushort error_resilient_mode => InteropRuntime.GetUInt16(__bits, 2, 1);
        public ushort subsampling_x => InteropRuntime.GetUInt16(__bits, 3, 1);
        public ushort subsampling_y => InteropRuntime.GetUInt16(__bits, 4, 1);
        public ushort extra_plane => InteropRuntime.GetUInt16(__bits, 5, 1);
        public ushort refresh_frame_context => InteropRuntime.GetUInt16(__bits, 6, 1);
        public ushort frame_parallel_decoding_mode => InteropRuntime.GetUInt16(__bits, 7, 1);
        public ushort intra_only => InteropRuntime.GetUInt16(__bits, 8, 1);
        public ushort frame_context_idx => InteropRuntime.GetUInt16(__bits, 9, 2);
        public ushort reset_frame_context => InteropRuntime.GetUInt16(__bits, 11, 2);
        public ushort allow_high_precision_mv => InteropRuntime.GetUInt16(__bits, 13, 1);
        public ushort ReservedFormatInfo2Bits => InteropRuntime.GetUInt16(__bits, 14, 2);
    }
}
