// generated from <Windows SDK Path>\um\wincodecsdk.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct WICMetadataPattern
    {
        public ulong Position;
        public uint Length;
        public IntPtr Pattern;
        public IntPtr Mask;
        public ulong DataOffset;
    }
}
