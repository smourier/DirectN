// generated from <Windows SDK Path>\shared\ks.h
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct __struct_ks_286__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 24)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public __struct_ks_286__union_0__struct_0 EventHandle { get => InteropRuntime.Get<__struct_ks_286__union_0__struct_0>(__bits, 0, 192); set { if (__bits == null) __bits = new byte[24]; InteropRuntime.Set<__struct_ks_286__union_0__struct_0>(value, __bits, 0, 192); } }
        public __struct_ks_286__union_0__struct_1 SemaphoreHandle { get => InteropRuntime.Get<__struct_ks_286__union_0__struct_1>(__bits, 0, 128); set { if (__bits == null) __bits = new byte[24]; InteropRuntime.Set<__struct_ks_286__union_0__struct_1>(value, __bits, 0, 128); } }
        public __struct_ks_286__union_0__struct_2 Alignment { get => InteropRuntime.Get<__struct_ks_286__union_0__struct_2>(__bits, 0, 192); set { if (__bits == null) __bits = new byte[24]; InteropRuntime.Set<__struct_ks_286__union_0__struct_2>(value, __bits, 0, 192); } }
    }
}
