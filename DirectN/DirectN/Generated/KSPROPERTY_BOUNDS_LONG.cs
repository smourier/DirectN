// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\ks.h(259,9)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSPROPERTY_BOUNDS_LONG
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public __struct_0 __field_0 { get => InteropRuntime.Get<__struct_0>(__bits, 0, 64); set => InteropRuntime.Set<__struct_0>(value, __bits, 0, 64); }
        public __struct_1 __field_1 { get => InteropRuntime.Get<__struct_1>(__bits, 0, 64); set => InteropRuntime.Set<__struct_1>(value, __bits, 0, 64); }
    }
}
