// generated from <Windows SDK Path>\shared\ks.h
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSDATAFORMAT
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public __struct_0 __field_0 {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<__struct_0>(__bits, 0, 512);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[64]; InteropRuntime.Set<__struct_0>(value, __bits, 0, 512); } }
        public long Alignment {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetInt64(__bits, 0, 64);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[64]; InteropRuntime.SetInt64(value, __bits, 0, 64); } }
    }
}
