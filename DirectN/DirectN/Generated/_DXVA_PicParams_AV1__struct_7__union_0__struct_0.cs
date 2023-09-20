// generated from <Windows SDK Path>\um\dxva.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DXVA_PicParams_AV1__struct_7__union_0__struct_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public ushort apply_grain { get => InteropRuntime.GetUInt16(__bits, 0, 1); set { if (__bits == null) __bits = new byte[2]; InteropRuntime.SetUInt16(value, __bits, 0, 1); } }
        public ushort scaling_shift_minus8 { get => InteropRuntime.GetUInt16(__bits, 1, 2); set { if (__bits == null) __bits = new byte[2]; InteropRuntime.SetUInt16(value, __bits, 1, 2); } }
        public ushort chroma_scaling_from_luma { get => InteropRuntime.GetUInt16(__bits, 3, 1); set { if (__bits == null) __bits = new byte[2]; InteropRuntime.SetUInt16(value, __bits, 3, 1); } }
        public ushort ar_coeff_lag { get => InteropRuntime.GetUInt16(__bits, 4, 2); set { if (__bits == null) __bits = new byte[2]; InteropRuntime.SetUInt16(value, __bits, 4, 2); } }
        public ushort ar_coeff_shift_minus6 { get => InteropRuntime.GetUInt16(__bits, 6, 2); set { if (__bits == null) __bits = new byte[2]; InteropRuntime.SetUInt16(value, __bits, 6, 2); } }
        public ushort grain_scale_shift { get => InteropRuntime.GetUInt16(__bits, 8, 2); set { if (__bits == null) __bits = new byte[2]; InteropRuntime.SetUInt16(value, __bits, 8, 2); } }
        public ushort overlap_flag { get => InteropRuntime.GetUInt16(__bits, 10, 1); set { if (__bits == null) __bits = new byte[2]; InteropRuntime.SetUInt16(value, __bits, 10, 1); } }
        public ushort clip_to_restricted_range { get => InteropRuntime.GetUInt16(__bits, 11, 1); set { if (__bits == null) __bits = new byte[2]; InteropRuntime.SetUInt16(value, __bits, 11, 1); } }
        public ushort matrix_coeff_is_identity { get => InteropRuntime.GetUInt16(__bits, 12, 1); set { if (__bits == null) __bits = new byte[2]; InteropRuntime.SetUInt16(value, __bits, 12, 1); } }
        public ushort Reserved { get => InteropRuntime.GetUInt16(__bits, 13, 3); set { if (__bits == null) __bits = new byte[2]; InteropRuntime.SetUInt16(value, __bits, 13, 3); } }
    }
}
