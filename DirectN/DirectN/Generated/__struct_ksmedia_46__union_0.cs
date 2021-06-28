// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\ksmedia.h(1859,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct __struct_ksmedia_46__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public int Reset { get => InteropRuntime.GetInt32(__bits, 0, 32); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetInt32(value, __bits, 0, 32); } }
        public int Resolution { get => InteropRuntime.GetInt32(__bits, 0, 32); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetInt32(value, __bits, 0, 32); } }
    }
}
