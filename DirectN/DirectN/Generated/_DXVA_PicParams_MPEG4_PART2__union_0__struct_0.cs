// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dxva.h(1095,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DXVA_PicParams_MPEG4_PART2__union_0__struct_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte[] __bits;
        public ushort unPicPostProc => InteropRuntime.GetUInt16(__bits, 0, 2);
        public ushort interlaced => InteropRuntime.GetUInt16(__bits, 2, 1);
        public ushort quant_type => InteropRuntime.GetUInt16(__bits, 3, 1);
        public ushort quarter_sample => InteropRuntime.GetUInt16(__bits, 4, 1);
        public ushort resync_marker_disable => InteropRuntime.GetUInt16(__bits, 5, 1);
        public ushort data_partitioned => InteropRuntime.GetUInt16(__bits, 6, 1);
        public ushort reversible_vlc => InteropRuntime.GetUInt16(__bits, 7, 1);
        public ushort reduced_resolution_vop_enable => InteropRuntime.GetUInt16(__bits, 8, 1);
        public ushort vop_coded => InteropRuntime.GetUInt16(__bits, 9, 1);
        public ushort vop_rounding_type => InteropRuntime.GetUInt16(__bits, 10, 1);
        public ushort intra_dc_vlc_thr => InteropRuntime.GetUInt16(__bits, 11, 3);
        public ushort top_field_first => InteropRuntime.GetUInt16(__bits, 14, 1);
        public ushort alternate_vertical_scan_flag => InteropRuntime.GetUInt16(__bits, 15, 1);
    }
}
