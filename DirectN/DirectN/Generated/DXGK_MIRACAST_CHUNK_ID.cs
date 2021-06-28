// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\d3dukmdt.h(1291,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DXGK_MIRACAST_CHUNK_ID
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public __struct_0 __field_0 { get => InteropRuntime.Get<__struct_0>(__bits, 0, 64); set { if (__bits == null) __bits = new byte[8]; InteropRuntime.Set<__struct_0>(value, __bits, 0, 64); } }
        public ulong Value { get => InteropRuntime.GetUInt64(__bits, 0, 64); set { if (__bits == null) __bits = new byte[8]; InteropRuntime.SetUInt64(value, __bits, 0, 64); } }
    }
}
