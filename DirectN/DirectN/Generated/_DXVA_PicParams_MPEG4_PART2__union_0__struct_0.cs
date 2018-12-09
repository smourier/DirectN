// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dxva.h(1095,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DXVA_PicParams_MPEG4_PART2__union_0__struct_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public ushort unPicPostProc { get => InteropRuntime.GetUInt16(__bits, 0, 2); set => InteropRuntime.SetUInt16(value, __bits, 0, 2); }
        public ushort interlaced { get => InteropRuntime.GetUInt16(__bits, 2, 1); set => InteropRuntime.SetUInt16(value, __bits, 2, 1); }
        public ushort quant_type { get => InteropRuntime.GetUInt16(__bits, 3, 1); set => InteropRuntime.SetUInt16(value, __bits, 3, 1); }
        public ushort quarter_sample { get => InteropRuntime.GetUInt16(__bits, 4, 1); set => InteropRuntime.SetUInt16(value, __bits, 4, 1); }
        public ushort resync_marker_disable { get => InteropRuntime.GetUInt16(__bits, 5, 1); set => InteropRuntime.SetUInt16(value, __bits, 5, 1); }
        public ushort data_partitioned { get => InteropRuntime.GetUInt16(__bits, 6, 1); set => InteropRuntime.SetUInt16(value, __bits, 6, 1); }
        public ushort reversible_vlc { get => InteropRuntime.GetUInt16(__bits, 7, 1); set => InteropRuntime.SetUInt16(value, __bits, 7, 1); }
        public ushort reduced_resolution_vop_enable { get => InteropRuntime.GetUInt16(__bits, 8, 1); set => InteropRuntime.SetUInt16(value, __bits, 8, 1); }
        public ushort vop_coded { get => InteropRuntime.GetUInt16(__bits, 9, 1); set => InteropRuntime.SetUInt16(value, __bits, 9, 1); }
        public ushort vop_rounding_type { get => InteropRuntime.GetUInt16(__bits, 10, 1); set => InteropRuntime.SetUInt16(value, __bits, 10, 1); }
        public ushort intra_dc_vlc_thr { get => InteropRuntime.GetUInt16(__bits, 11, 3); set => InteropRuntime.SetUInt16(value, __bits, 11, 3); }
        public ushort top_field_first { get => InteropRuntime.GetUInt16(__bits, 14, 1); set => InteropRuntime.SetUInt16(value, __bits, 14, 1); }
        public ushort alternate_vertical_scan_flag { get => InteropRuntime.GetUInt16(__bits, 15, 1); set => InteropRuntime.SetUInt16(value, __bits, 15, 1); }
    }
}
