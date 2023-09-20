// generated from <Windows SDK Path>\um\wincodecsdk.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct WICMetadataHeader
    {
        public ulong Position;
        public uint Length;
        public IntPtr Header;
        public ulong DataOffset;
    }
}
