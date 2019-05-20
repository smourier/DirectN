// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\wingdi.h(2256,5)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _devicemodeW__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public _devicemodeW__union_0__struct_0 __field_0 { get => InteropRuntime.Get<_devicemodeW__union_0__struct_0>(__bits, 0, 128); set => InteropRuntime.Set<_devicemodeW__union_0__struct_0>(value, __bits, 0, 128); }
        public _devicemodeW__union_0__struct_1 __field_1 { get => InteropRuntime.Get<_devicemodeW__union_0__struct_1>(__bits, 0, 128); set => InteropRuntime.Set<_devicemodeW__union_0__struct_1>(value, __bits, 0, 128); }
    }
}
