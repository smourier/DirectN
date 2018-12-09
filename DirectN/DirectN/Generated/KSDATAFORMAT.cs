// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\ks.h(1089,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSDATAFORMAT
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public __struct_0 __field_0 { get => InteropRuntime.Get<__struct_0>(__bits, 0, 512); set => InteropRuntime.Set<__struct_0>(value, __bits, 0, 512); }
        public long Alignment { get => InteropRuntime.GetInt64(__bits, 0, 64); set => InteropRuntime.SetInt64(value, __bits, 0, 64); }
    }
}
