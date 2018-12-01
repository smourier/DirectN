// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\d3dukmdt.h(221,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_PTE__union_1
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public byte[] __bits;
        public ulong PageAddress => InteropRuntime.GetUInt64Bits(__bits, 0, 64);
        public ulong PageTableAddress => InteropRuntime.GetUInt64Bits(__bits, 0, 64);
    }
}
