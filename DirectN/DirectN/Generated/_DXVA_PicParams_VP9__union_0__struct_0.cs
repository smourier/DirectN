// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dxva.h(1347,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DXVA_PicParams_VP9__union_0__struct_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public ushort frame_type { get => InteropRuntime.GetUInt16(__bits, 0, 1); set { if (__bits == null) __bits = new byte[2]; InteropRuntime.SetUInt16(value, __bits, 0, 1); } }
        public ushort show_frame { get => InteropRuntime.GetUInt16(__bits, 1, 1); set { if (__bits == null) __bits = new byte[2]; InteropRuntime.SetUInt16(value, __bits, 1, 1); } }
        public ushort error_resilient_mode { get => InteropRuntime.GetUInt16(__bits, 2, 1); set { if (__bits == null) __bits = new byte[2]; InteropRuntime.SetUInt16(value, __bits, 2, 1); } }
        public ushort subsampling_x { get => InteropRuntime.GetUInt16(__bits, 3, 1); set { if (__bits == null) __bits = new byte[2]; InteropRuntime.SetUInt16(value, __bits, 3, 1); } }
        public ushort subsampling_y { get => InteropRuntime.GetUInt16(__bits, 4, 1); set { if (__bits == null) __bits = new byte[2]; InteropRuntime.SetUInt16(value, __bits, 4, 1); } }
        public ushort extra_plane { get => InteropRuntime.GetUInt16(__bits, 5, 1); set { if (__bits == null) __bits = new byte[2]; InteropRuntime.SetUInt16(value, __bits, 5, 1); } }
        public ushort refresh_frame_context { get => InteropRuntime.GetUInt16(__bits, 6, 1); set { if (__bits == null) __bits = new byte[2]; InteropRuntime.SetUInt16(value, __bits, 6, 1); } }
        public ushort frame_parallel_decoding_mode { get => InteropRuntime.GetUInt16(__bits, 7, 1); set { if (__bits == null) __bits = new byte[2]; InteropRuntime.SetUInt16(value, __bits, 7, 1); } }
        public ushort intra_only { get => InteropRuntime.GetUInt16(__bits, 8, 1); set { if (__bits == null) __bits = new byte[2]; InteropRuntime.SetUInt16(value, __bits, 8, 1); } }
        public ushort frame_context_idx { get => InteropRuntime.GetUInt16(__bits, 9, 2); set { if (__bits == null) __bits = new byte[2]; InteropRuntime.SetUInt16(value, __bits, 9, 2); } }
        public ushort reset_frame_context { get => InteropRuntime.GetUInt16(__bits, 11, 2); set { if (__bits == null) __bits = new byte[2]; InteropRuntime.SetUInt16(value, __bits, 11, 2); } }
        public ushort allow_high_precision_mv { get => InteropRuntime.GetUInt16(__bits, 13, 1); set { if (__bits == null) __bits = new byte[2]; InteropRuntime.SetUInt16(value, __bits, 13, 1); } }
        public ushort ReservedFormatInfo2Bits { get => InteropRuntime.GetUInt16(__bits, 14, 2); set { if (__bits == null) __bits = new byte[2]; InteropRuntime.SetUInt16(value, __bits, 14, 2); } }
    }
}
