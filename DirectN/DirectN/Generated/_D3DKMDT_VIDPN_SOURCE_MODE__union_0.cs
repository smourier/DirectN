﻿// generated from <Windows SDK Path>\shared\d3dkmdt.h
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMDT_VIDPN_SOURCE_MODE__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public _D3DKMDT_GRAPHICS_RENDERING_FORMAT Graphics {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_D3DKMDT_GRAPHICS_RENDERING_FORMAT>(__bits, 0, 256);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[32]; InteropRuntime.Set<_D3DKMDT_GRAPHICS_RENDERING_FORMAT>(value, __bits, 0, 256); } }
        public _D3DKMDT_TEXT_RENDERING_FORMAT Text {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_D3DKMDT_TEXT_RENDERING_FORMAT>(__bits, 0, 32);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[32]; InteropRuntime.Set<_D3DKMDT_TEXT_RENDERING_FORMAT>(value, __bits, 0, 32); } }
    }
}
