// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\ks.h(278,9)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSPROPERTY_BOUNDS_LONGLONG
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public __struct_0 __field_0 { get => InteropRuntime.Get<__struct_0>(__bits, 0, 128); set { if (__bits == null) __bits = new byte[16]; InteropRuntime.Set<__struct_0>(value, __bits, 0, 128); } }
        public __struct_1 __field_1 { get => InteropRuntime.Get<__struct_1>(__bits, 0, 128); set { if (__bits == null) __bits = new byte[16]; InteropRuntime.Set<__struct_1>(value, __bits, 0, 128); } }
    }
}
