// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\d3dukmdt.h(1807,4)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public partial struct _D3DDDI_QUERYREGISTRY_INFO__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public uint OutputDword { get => InteropRuntime.GetUInt32(__bits, 0, 32); set { if (__bits == null) __bits = new byte[8]; InteropRuntime.SetUInt32(value, __bits, 0, 32); } }
        public ulong OutputQword { get => InteropRuntime.GetUInt64(__bits, 0, 64); set { if (__bits == null) __bits = new byte[8]; InteropRuntime.SetUInt64(value, __bits, 0, 64); } }
        public string OutputString { get => InteropRuntime.GetString(__bits, 0, 8, UnmanagedType.LPWStr); set { if (__bits == null) __bits = new byte[8]; InteropRuntime.SetString(value, __bits, 0, 8, UnmanagedType.LPWStr); } }
        public byte[] OutputBinary { get => InteropRuntime.GetArray<byte>(__bits, 0, 8); set { if (__bits == null) __bits = new byte[8]; InteropRuntime.SetArray<byte>(value, __bits, 0, 8); } }
    }
}
