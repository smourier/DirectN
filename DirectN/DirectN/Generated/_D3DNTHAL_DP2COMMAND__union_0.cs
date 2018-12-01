// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3dnthal.h(522,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DNTHAL_DP2COMMAND__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte[] __bits;
        public ushort wPrimitiveCount => InteropRuntime.GetUInt16Bits(__bits, 0, 16);
        public ushort wStateCount => InteropRuntime.GetUInt16Bits(__bits, 0, 16);
    }
}
