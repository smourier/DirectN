// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\d3dukmdt.h(339,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDI_ALLOCATIONINFO2__union_2
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public byte[] __bits;
        public uint Priority => InteropRuntime.GetUInt32(__bits, 0, 32);
        public IntPtr Unused => InteropRuntime.Get<IntPtr>(__bits, 0, 64);
    }
}
