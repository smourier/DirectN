// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wincodecsdk.h(1592,9)
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
