// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\ksmedia.h(6579,5)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _KSDEVICE_PROFILE_INFO__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 48)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public _KSDEVICE_PROFILE_INFO__union_0__struct_0 Camera { get => InteropRuntime.Get<_KSDEVICE_PROFILE_INFO__union_0__struct_0>(__bits, 0, 384); set => InteropRuntime.Set<_KSDEVICE_PROFILE_INFO__union_0__struct_0>(value, __bits, 0, 384); }
    }
}
