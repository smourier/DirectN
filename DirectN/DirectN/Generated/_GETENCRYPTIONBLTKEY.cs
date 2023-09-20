// generated from <Windows SDK Path>\um\d3dumddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _GETENCRYPTIONBLTKEY
    {
        public IntPtr hCryptoSession;
        public IntPtr pReadBackKey;
        public uint KeySize;
    }
}
