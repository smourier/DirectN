// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_QUERYSTATISTICS_SEGMENT_INFORMATION__struct_1
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public ulong SystemMemory {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetUInt64(__bits, 0, 1);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[8]; InteropRuntime.SetUInt64(value, __bits, 0, 1); } }
        public ulong PopulatedByReservedDDRByFirmware {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetUInt64(__bits, 1, 1);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[8]; InteropRuntime.SetUInt64(value, __bits, 1, 1); } }
        public ulong SegmentType {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetUInt64(__bits, 2, 4);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[8]; InteropRuntime.SetUInt64(value, __bits, 2, 4); } }
        public ulong SegmentGroup {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetUInt64(__bits, 6, 2);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[8]; InteropRuntime.SetUInt64(value, __bits, 6, 2); } }
        public ulong FullyCPUVisible {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetUInt64(__bits, 8, 1);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[8]; InteropRuntime.SetUInt64(value, __bits, 8, 1); } }
        public ulong Reserved {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetUInt64(__bits, 9, 55);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[8]; InteropRuntime.SetUInt64(value, __bits, 9, 55); } }
    }
}
