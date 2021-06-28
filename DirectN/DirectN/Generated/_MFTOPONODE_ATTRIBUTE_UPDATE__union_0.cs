// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\mfidl.h(10826,36)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _MFTOPONODE_ATTRIBUTE_UPDATE__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public uint u32 { get => InteropRuntime.GetUInt32(__bits, 0, 32); set { if (__bits == null) __bits = new byte[8]; InteropRuntime.SetUInt32(value, __bits, 0, 32); } }
        public ulong u64 { get => InteropRuntime.GetUInt64(__bits, 0, 64); set { if (__bits == null) __bits = new byte[8]; InteropRuntime.SetUInt64(value, __bits, 0, 64); } }
        public double d { get => InteropRuntime.GetDouble(__bits, 0, 64); set { if (__bits == null) __bits = new byte[8]; InteropRuntime.SetDouble(value, __bits, 0, 64); } }
    }
}
