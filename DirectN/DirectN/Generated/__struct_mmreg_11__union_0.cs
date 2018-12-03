// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\mmreg.h(2524,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct __struct_mmreg_11__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte[] __bits;
        public ushort wValidBitsPerSample => InteropRuntime.GetUInt16(__bits, 0, 16);
        public ushort wSamplesPerBlock => InteropRuntime.GetUInt16(__bits, 0, 16);
        public ushort wReserved => InteropRuntime.GetUInt16(__bits, 0, 16);
    }
}
