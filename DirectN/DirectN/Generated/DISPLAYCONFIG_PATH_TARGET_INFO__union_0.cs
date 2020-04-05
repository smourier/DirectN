// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\wingdi.h(2973,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DISPLAYCONFIG_PATH_TARGET_INFO__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public uint modeInfoIdx { get => InteropRuntime.GetUInt32(__bits, 0, 32); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 0, 32); } }
        public DISPLAYCONFIG_PATH_TARGET_INFO__union_0__struct_0 __field_1 { get => InteropRuntime.Get<DISPLAYCONFIG_PATH_TARGET_INFO__union_0__struct_0>(__bits, 0, 32); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.Set<DISPLAYCONFIG_PATH_TARGET_INFO__union_0__struct_0>(value, __bits, 0, 32); } }
    }
}
