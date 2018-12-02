// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\d3dukmdt.h(1764,4)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public partial struct _D3DDDI_QUERYREGISTRY_INFO__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public byte[] __bits;
        public uint OutputDword => InteropRuntime.GetUInt32(__bits, 0, 32);
        public ulong OutputQword => InteropRuntime.GetUInt6s(__bits, 0, 64);
        public string[] OutputString => InteropRuntime.GetArray<string>(__bits, 0, 8);
        public byte[] OutputBinary => InteropRuntime.GetArray<byte>(__bits, 0, 8);
    }
}
