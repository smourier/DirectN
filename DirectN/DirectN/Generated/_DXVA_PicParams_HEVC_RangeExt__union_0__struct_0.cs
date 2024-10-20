// generated from <Windows SDK Path>\um\dxva.h
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DXVA_PicParams_HEVC_RangeExt__union_0__struct_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public ushort transform_skip_rotation_enabled_flag {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetUInt16(__bits, 0, 1);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[2]; InteropRuntime.SetUInt16(value, __bits, 0, 1); } }
        public ushort transform_skip_context_enabled_flag {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetUInt16(__bits, 1, 1);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[2]; InteropRuntime.SetUInt16(value, __bits, 1, 1); } }
        public ushort implicit_rdpcm_enabled_flag {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetUInt16(__bits, 2, 1);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[2]; InteropRuntime.SetUInt16(value, __bits, 2, 1); } }
        public ushort explicit_rdpcm_enabled_flag {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetUInt16(__bits, 3, 1);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[2]; InteropRuntime.SetUInt16(value, __bits, 3, 1); } }
        public ushort extended_precision_processing_flag {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetUInt16(__bits, 4, 1);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[2]; InteropRuntime.SetUInt16(value, __bits, 4, 1); } }
        public ushort intra_smoothing_disabled_flag {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetUInt16(__bits, 5, 1);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[2]; InteropRuntime.SetUInt16(value, __bits, 5, 1); } }
        public ushort persistent_rice_adaptation_enabled_flag {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetUInt16(__bits, 6, 1);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[2]; InteropRuntime.SetUInt16(value, __bits, 6, 1); } }
        public ushort high_precision_offsets_enabled_flag {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetUInt16(__bits, 7, 1);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[2]; InteropRuntime.SetUInt16(value, __bits, 7, 1); } }
        public ushort cabac_bypass_alignment_enabled_flag {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetUInt16(__bits, 8, 1);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[2]; InteropRuntime.SetUInt16(value, __bits, 8, 1); } }
        public ushort cross_component_prediction_enabled_flag {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetUInt16(__bits, 9, 1);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[2]; InteropRuntime.SetUInt16(value, __bits, 9, 1); } }
        public ushort chroma_qp_offset_list_enabled_flag {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetUInt16(__bits, 10, 1);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[2]; InteropRuntime.SetUInt16(value, __bits, 10, 1); } }
        public ushort ReservedBits8 {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetUInt16(__bits, 11, 5);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[2]; InteropRuntime.SetUInt16(value, __bits, 11, 5); } }
    }
}
