// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\d3dukmdt.h(1191,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDICB_SIGNALFLAGS__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] __bits;
        public _D3DDDICB_SIGNALFLAGS__union_0__struct_0 __field_0 => InteropRuntime.GetBits<_D3DDDICB_SIGNALFLAGS__union_0__struct_0>(__bits, 0, 32);
        public uint Value => InteropRuntime.GetUInt32Bits(__bits, 0, 32);
    }
}
