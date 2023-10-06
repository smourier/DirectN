// generated from <Windows SDK Path>\um\dwrite_1.h
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Typeface classification values, used for font selection and matching.  <remarks> Note the family type (index 0) is the only stable entry in the 10-byte array, as all the following entries can change dynamically depending on context of the first field. </remarks>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DWRITE_PANOSE
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public byte[] values {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetArray<byte>(__bits, 0, 80);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[10]; InteropRuntime.SetArray<byte>(value, __bits, 0, 80); } }
        public byte familyKind {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetByte(__bits, 0, 8);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[10]; InteropRuntime.SetByte(value, __bits, 0, 8); } }
        public DWRITE_PANOSE__struct_0 text {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<DWRITE_PANOSE__struct_0>(__bits, 0, 80);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[10]; InteropRuntime.Set<DWRITE_PANOSE__struct_0>(value, __bits, 0, 80); } }
        public DWRITE_PANOSE__struct_1 script {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<DWRITE_PANOSE__struct_1>(__bits, 0, 80);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[10]; InteropRuntime.Set<DWRITE_PANOSE__struct_1>(value, __bits, 0, 80); } }
        public DWRITE_PANOSE__struct_2 decorative {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<DWRITE_PANOSE__struct_2>(__bits, 0, 80);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[10]; InteropRuntime.Set<DWRITE_PANOSE__struct_2>(value, __bits, 0, 80); } }
        public DWRITE_PANOSE__struct_3 symbol {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<DWRITE_PANOSE__struct_3>(__bits, 0, 80);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[10]; InteropRuntime.Set<DWRITE_PANOSE__struct_3>(value, __bits, 0, 80); } }
    }
}
