// generated from <Windows SDK Path>\shared\d3dukmdt.h
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_ISFEATUREENABLED_RESULT__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public _DXGK_ISFEATUREENABLED_RESULT__union_0__struct_0 __field_0 {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_DXGK_ISFEATUREENABLED_RESULT__union_0__struct_0>(__bits, 0, 16);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[2]; InteropRuntime.Set<_DXGK_ISFEATUREENABLED_RESULT__union_0__struct_0>(value, __bits, 0, 16); } }
        public ushort Value {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetUInt16(__bits, 0, 16);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[2]; InteropRuntime.SetUInt16(value, __bits, 0, 16); } }
    }
}
