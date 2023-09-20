// generated from <Windows SDK Path>\shared\ks.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct __struct_ks_277__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 24)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public __struct_ks_277__union_0__struct_0 __field_0 { get => InteropRuntime.Get<__struct_ks_277__union_0__struct_0>(__bits, 0, 192); set { if (__bits == null) __bits = new byte[24]; InteropRuntime.Set<__struct_ks_277__union_0__struct_0>(value, __bits, 0, 192); } }
        public long Alignment { get => InteropRuntime.GetInt64(__bits, 0, 64); set { if (__bits == null) __bits = new byte[24]; InteropRuntime.SetInt64(value, __bits, 0, 64); } }
    }
}
