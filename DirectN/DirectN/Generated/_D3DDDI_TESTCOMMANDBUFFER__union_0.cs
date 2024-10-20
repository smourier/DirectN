// generated from <Windows SDK Path>\shared\d3dukmdt.h
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public partial struct _D3DDDI_TESTCOMMANDBUFFER__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public _D3DDDI_TESTCOMMANDBUFFER_COPY Copy {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_D3DDDI_TESTCOMMANDBUFFER_COPY>(__bits, 0, 192);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[64]; InteropRuntime.Set<_D3DDDI_TESTCOMMANDBUFFER_COPY>(value, __bits, 0, 192); } }
        public _D3DDDI_TESTCOMMANDBUFFER_FILL Fill {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_D3DDDI_TESTCOMMANDBUFFER_FILL>(__bits, 0, 128);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[64]; InteropRuntime.Set<_D3DDDI_TESTCOMMANDBUFFER_FILL>(value, __bits, 0, 128); } }
        public string Reserved {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetString(__bits, 0, 512, UnmanagedType.LPStr);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[64]; InteropRuntime.SetString(value, __bits, 0, 512, UnmanagedType.LPStr); } }
    }
}
