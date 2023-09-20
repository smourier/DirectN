// generated from <Windows SDK Path>\um\dxva.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DXVA_BufferDescription
    {
        public uint dwTypeIndex;
        public uint dwBufferIndex;
        public uint dwDataOffset;
        public uint dwDataSize;
        public uint dwFirstMBaddress;
        public uint dwNumMBsInBuffer;
        public uint dwWidth;
        public uint dwHeight;
        public uint dwStride;
        public uint dwReservedBits;
    }
}
