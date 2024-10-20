// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_QUERYDIRTYBITDATA
    {
        public IntPtr MemoryBasis;
        public ulong SubrangeIndex;
        public ulong SubrangeOffset;
        public ulong SubrangeSize;
        public IntPtr Buffer;
        public IntPtr BufferSize;
        public uint Flags;
    }
}
