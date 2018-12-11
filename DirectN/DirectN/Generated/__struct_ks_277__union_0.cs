// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\ks.h(107,5)
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
        public __struct_ks_277__union_0__struct_0 __field_0 { get => InteropRuntime.Get<__struct_ks_277__union_0__struct_0>(__bits, 0, 192); set => InteropRuntime.Set<__struct_ks_277__union_0__struct_0>(value, __bits, 0, 192); }
        public long Alignment { get => InteropRuntime.GetInt64(__bits, 0, 64); set => InteropRuntime.SetInt64(value, __bits, 0, 64); }
    }
}
