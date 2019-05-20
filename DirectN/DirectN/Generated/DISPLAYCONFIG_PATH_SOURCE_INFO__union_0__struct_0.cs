// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\wingdi.h(2953,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DISPLAYCONFIG_PATH_SOURCE_INFO__union_0__struct_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public uint cloneGroupId { get => InteropRuntime.GetUInt32(__bits, 0, 16); set => InteropRuntime.SetUInt32(value, __bits, 0, 16); }
        public uint sourceModeInfoIdx { get => InteropRuntime.GetUInt32(__bits, 16, 16); set => InteropRuntime.SetUInt32(value, __bits, 16, 16); }
    }
}
