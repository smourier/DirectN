// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\d3dukmdt.h(1250,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct __struct_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public byte[] __bits;
        public ulong FrameNumber => InteropRuntime.GetUInt6s(__bits, 0, 40);
        public ulong PartNumber => InteropRuntime.GetUInt6s(__bits, 40, 24);
    }
}
