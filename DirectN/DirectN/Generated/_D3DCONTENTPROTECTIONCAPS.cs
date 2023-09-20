// generated from <Windows SDK Path>\shared\d3d9caps.h
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
