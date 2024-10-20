// generated from <Windows SDK Path>\shared\d3dukmdt.h
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_ISFEATUREENABLED_RESULT__union_0__struct_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public ushort Enabled {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetUInt16(__bits, 0, 1);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[2]; InteropRuntime.SetUInt16(value, __bits, 0, 1); } }
        public ushort KnownFeature {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetUInt16(__bits, 1, 1);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[2]; InteropRuntime.SetUInt16(value, __bits, 1, 1); } }
        public ushort SupportedByDriver {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetUInt16(__bits, 2, 1);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[2]; InteropRuntime.SetUInt16(value, __bits, 2, 1); } }
        public ushort SupportedOnCurrentConfig {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetUInt16(__bits, 3, 1);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[2]; InteropRuntime.SetUInt16(value, __bits, 3, 1); } }
        public ushort Reserved {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetUInt16(__bits, 4, 12);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[2]; InteropRuntime.SetUInt16(value, __bits, 4, 12); } }
    }
}
