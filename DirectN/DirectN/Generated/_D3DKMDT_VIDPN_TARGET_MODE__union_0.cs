﻿// generated from <Windows SDK Path>\shared\d3dkmdt.h
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMDT_VIDPN_TARGET_MODE__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public _D3DKMDT_WIRE_FORMAT_AND_PREFERENCE WireFormatAndPreference {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_D3DKMDT_WIRE_FORMAT_AND_PREFERENCE>(__bits, 0, 32);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[4]; InteropRuntime.Set<_D3DKMDT_WIRE_FORMAT_AND_PREFERENCE>(value, __bits, 0, 32); } }
        public _D3DKMDT_VIDPN_TARGET_MODE__union_0__struct_0 __field_1 {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_D3DKMDT_VIDPN_TARGET_MODE__union_0__struct_0>(__bits, 0, 32);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[4]; InteropRuntime.Set<_D3DKMDT_VIDPN_TARGET_MODE__union_0__struct_0>(value, __bits, 0, 32); } }
    }
}
