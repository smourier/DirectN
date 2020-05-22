// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\d3dkmthk.h(3013,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_GETPRESENTHISTORY
    {
        public uint hAdapter;
        public uint ProvidedSize;
        public uint WrittenSize;
        public IntPtr pTokens;
        public uint NumTokens;
    }
}
