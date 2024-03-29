﻿// generated from <Windows SDK Path>\um\dxva.h
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DXVA_Deblock_H264__union_0__struct_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public byte ReservedBit {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetByte(__bits, 0, 1);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[1]; InteropRuntime.SetByte(value, __bits, 0, 1); } }
        public byte FieldModeCurrentMbFlag {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetByte(__bits, 1, 1);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[1]; InteropRuntime.SetByte(value, __bits, 1, 1); } }
        public byte FieldModeLeftMbFlag {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetByte(__bits, 2, 1);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[1]; InteropRuntime.SetByte(value, __bits, 2, 1); } }
        public byte FieldModeAboveMbFlag {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetByte(__bits, 3, 1);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[1]; InteropRuntime.SetByte(value, __bits, 3, 1); } }
        public byte FilterInternal8x8EdgesFlag {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetByte(__bits, 4, 1);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[1]; InteropRuntime.SetByte(value, __bits, 4, 1); } }
        public byte FilterInternal4x4EdgesFlag {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetByte(__bits, 5, 1);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[1]; InteropRuntime.SetByte(value, __bits, 5, 1); } }
        public byte FilterLeftMbEdgeFlag {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetByte(__bits, 6, 1);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[1]; InteropRuntime.SetByte(value, __bits, 6, 1); } }
        public byte FilterTopMbEdgeFlag {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetByte(__bits, 7, 1);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[1]; InteropRuntime.SetByte(value, __bits, 7, 1); } }
    }
}
