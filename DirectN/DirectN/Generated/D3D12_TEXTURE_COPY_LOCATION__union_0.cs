﻿// generated from <Windows SDK Path>\um\d3d12.h
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_TEXTURE_COPY_LOCATION__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public D3D12_PLACED_SUBRESOURCE_FOOTPRINT PlacedFootprint {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<D3D12_PLACED_SUBRESOURCE_FOOTPRINT>(__bits, 0, 256);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[32]; InteropRuntime.Set<D3D12_PLACED_SUBRESOURCE_FOOTPRINT>(value, __bits, 0, 256); } }
        public uint SubresourceIndex {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetUInt32(__bits, 0, 32);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[32]; InteropRuntime.SetUInt32(value, __bits, 0, 32); } }
    }
}
