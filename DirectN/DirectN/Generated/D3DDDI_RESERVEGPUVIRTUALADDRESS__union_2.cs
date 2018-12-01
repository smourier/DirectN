// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\d3dukmdt.h(1456,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3DDDI_RESERVEGPUVIRTUALADDRESS__union_2
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public byte[] __bits;
        public ulong DriverProtection => InteropRuntime.GetUInt64Bits(__bits, 0, 64);
        public ulong Reserved1 => InteropRuntime.GetUInt64Bits(__bits, 0, 64);
    }
}
