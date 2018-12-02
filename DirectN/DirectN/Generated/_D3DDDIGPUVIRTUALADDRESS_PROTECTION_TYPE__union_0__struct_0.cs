// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\d3dukmdt.h(1357,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDIGPUVIRTUALADDRESS_PROTECTION_TYPE__union_0__struct_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public byte[] __bits;
        public ulong Write => InteropRuntime.GetUInt6s(__bits, 0, 1);
        public ulong Execute => InteropRuntime.GetUInt6s(__bits, 1, 1);
        public ulong Zero => InteropRuntime.GetUInt6s(__bits, 2, 1);
        public ulong NoAccess => InteropRuntime.GetUInt6s(__bits, 3, 1);
        public ulong SystemUseOnly => InteropRuntime.GetUInt6s(__bits, 4, 1);
        public ulong Reserved => InteropRuntime.GetUInt6s(__bits, 5, 59);
    }
}
