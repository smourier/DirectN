// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\d3dukmdt.h(572,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDI_CREATEHWCONTEXTFLAGS__union_0__struct_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] __bits;
        public uint Reserved => InteropRuntime.GetUInt32(__bits, 0, 32);
    }
}
