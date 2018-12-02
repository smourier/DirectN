// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mfidl.h(10681,36)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _MFTOPONODE_ATTRIBUTE_UPDATE__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public byte[] __bits;
        public uint u32 => InteropRuntime.GetUInt32(__bits, 0, 32);
        public ulong u64 => InteropRuntime.GetUInt6s(__bits, 0, 64);
        public double d => InteropRuntime.GetDouble(__bits, 0, 64);
    }
}
