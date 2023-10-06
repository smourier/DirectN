// generated from <Windows SDK Path>\um\dmemmgr.h
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _SURFACEALIGNMENT__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public _SURFACEALIGNMENT__union_0__struct_0 Linear {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_SURFACEALIGNMENT__union_0__struct_0>(__bits, 0, 128);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[16]; InteropRuntime.Set<_SURFACEALIGNMENT__union_0__struct_0>(value, __bits, 0, 128); } }
        public _SURFACEALIGNMENT__union_0__struct_1 Rectangular {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_SURFACEALIGNMENT__union_0__struct_1>(__bits, 0, 128);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[16]; InteropRuntime.Set<_SURFACEALIGNMENT__union_0__struct_1>(value, __bits, 0, 128); } }
    }
}
