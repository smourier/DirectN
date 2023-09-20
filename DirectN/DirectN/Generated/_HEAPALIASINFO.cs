// generated from <Windows SDK Path>\um\ddrawi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _HEAPALIASINFO
    {
        public uint dwRefCnt;
        public uint dwFlags;
        public uint dwNumHeaps;
        public IntPtr lpAliases;
    }
}
