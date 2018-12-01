// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\shtypes.h(277,36)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public partial struct _STRRET__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 260)]
        public byte[] __bits;
        public string pOleStr => InteropRuntime.GetStringBits(__bits, 0, 64);
        public uint uOffset => InteropRuntime.GetUInt32Bits(__bits, 0, 32);
        public string cStr => InteropRuntime.GetStringBits(__bits, 0, 2080);
    }
}
