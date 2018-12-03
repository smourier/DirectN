// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\d3dukmdt.h(1248,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DXGK_MIRACAST_CHUNK_ID
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public byte[] __bits;
        public __struct_0 __field_0 => InteropRuntime.Get<__struct_0>(__bits, 0, 64);
        public ulong Value => InteropRuntime.GetUInt6s(__bits, 0, 64);
    }
}
