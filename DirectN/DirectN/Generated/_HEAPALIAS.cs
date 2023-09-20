// generated from <Windows SDK Path>\um\ddrawi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _HEAPALIAS
    {
        public ulong fpVidMem;
        public IntPtr lpAlias;
        public uint dwAliasSize;
    }
}
