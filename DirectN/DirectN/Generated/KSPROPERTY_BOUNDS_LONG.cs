﻿// generated from <Windows SDK Path>\shared\ks.h
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSPROPERTY_BOUNDS_LONG
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public __struct_0 __field_0 {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<__struct_0>(__bits, 0, 64);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[8]; InteropRuntime.Set<__struct_0>(value, __bits, 0, 64); } }
        public __struct_1 __field_1 {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<__struct_1>(__bits, 0, 64);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[8]; InteropRuntime.Set<__struct_1>(value, __bits, 0, 64); } }
    }
}
