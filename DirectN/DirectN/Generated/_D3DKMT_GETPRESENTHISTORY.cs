// generated from <Windows SDK Path>\shared\d3dkmthk.h
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
