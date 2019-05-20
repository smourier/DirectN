// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\d3dukmdt.h(1392,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDIGPUVIRTUALADDRESS_PROTECTION_TYPE__union_0__struct_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public ulong Write { get => InteropRuntime.GetUInt64(__bits, 0, 1); set => InteropRuntime.SetUInt64(value, __bits, 0, 1); }
        public ulong Execute { get => InteropRuntime.GetUInt64(__bits, 1, 1); set => InteropRuntime.SetUInt64(value, __bits, 1, 1); }
        public ulong Zero { get => InteropRuntime.GetUInt64(__bits, 2, 1); set => InteropRuntime.SetUInt64(value, __bits, 2, 1); }
        public ulong NoAccess { get => InteropRuntime.GetUInt64(__bits, 3, 1); set => InteropRuntime.SetUInt64(value, __bits, 3, 1); }
        public ulong SystemUseOnly { get => InteropRuntime.GetUInt64(__bits, 4, 1); set => InteropRuntime.SetUInt64(value, __bits, 4, 1); }
        public ulong Reserved { get => InteropRuntime.GetUInt64(__bits, 5, 59); set => InteropRuntime.SetUInt64(value, __bits, 5, 59); }
    }
}
