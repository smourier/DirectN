﻿// generated from <Windows SDK Path>\um\d3dumddi.h
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3DDDIARG_COPYFLAGS__union_0__struct_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public uint NoOverwrite {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetUInt32(__bits, 0, 1);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 0, 1); } }
        public uint Discard {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetUInt32(__bits, 1, 1);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 1, 1); } }
        public uint Reserved1 {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetUInt32(__bits, 2, 22);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 2, 22); } }
        public uint BoxValid {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetUInt32(__bits, 24, 1);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 24, 1); } }
        public uint Reserved2 {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetUInt32(__bits, 25, 7);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 25, 7); } }
    }
}
