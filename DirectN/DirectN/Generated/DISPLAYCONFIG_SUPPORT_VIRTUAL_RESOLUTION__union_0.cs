// c:\program files (x86)\windows kits\10\include\10.0.22621.0\um\wingdi.h(3141,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DISPLAYCONFIG_SUPPORT_VIRTUAL_RESOLUTION__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public DISPLAYCONFIG_SUPPORT_VIRTUAL_RESOLUTION__union_0__struct_0 __field_0 { get => InteropRuntime.Get<DISPLAYCONFIG_SUPPORT_VIRTUAL_RESOLUTION__union_0__struct_0>(__bits, 0, 32); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.Set<DISPLAYCONFIG_SUPPORT_VIRTUAL_RESOLUTION__union_0__struct_0>(value, __bits, 0, 32); } }
        public uint value { get => InteropRuntime.GetUInt32(__bits, 0, 32); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 0, 32); } }
    }
}
