// c:\program files (x86)\windows kits\10\include\10.0.22621.0\shared\d3d9caps.h(93,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct _D3DCONTENTPROTECTIONCAPS
    {
        public uint Caps;
        public Guid KeyExchangeType;
        public uint BufferAlignmentStart;
        public uint BlockAlignmentSize;
        public ulong ProtectedMemorySize;
    }
}
