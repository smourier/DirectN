﻿// generated from <Windows SDK Path>\um\d3dtypes.h
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct _D3DMATERIAL__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public _D3DCOLORVALUE diffuse {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_D3DCOLORVALUE>(__bits, 0, 128);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[16]; InteropRuntime.Set<_D3DCOLORVALUE>(value, __bits, 0, 128); } }
        public _D3DCOLORVALUE dcvDiffuse {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_D3DCOLORVALUE>(__bits, 0, 128);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[16]; InteropRuntime.Set<_D3DCOLORVALUE>(value, __bits, 0, 128); } }
    }
}
