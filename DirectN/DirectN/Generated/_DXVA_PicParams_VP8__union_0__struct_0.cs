﻿// generated from <Windows SDK Path>\um\dxva.h
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DXVA_PicParams_VP8__union_0__struct_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public byte frame_type {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetByte(__bits, 0, 1);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[1]; InteropRuntime.SetByte(value, __bits, 0, 1); } }
        public byte version {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetByte(__bits, 1, 3);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[1]; InteropRuntime.SetByte(value, __bits, 1, 3); } }
        public byte show_frame {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetByte(__bits, 4, 1);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[1]; InteropRuntime.SetByte(value, __bits, 4, 1); } }
        public byte clamp_type {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetByte(__bits, 5, 1);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[1]; InteropRuntime.SetByte(value, __bits, 5, 1); } }
        public byte ReservedFrameTag3Bits {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetByte(__bits, 6, 2);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[1]; InteropRuntime.SetByte(value, __bits, 6, 2); } }
    }
}
