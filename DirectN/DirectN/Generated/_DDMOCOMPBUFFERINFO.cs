// generated from <Windows SDK Path>\um\ddrawint.h
using System;
using System.Runtime.InteropServices;
using PDD_SURFACE_LOCAL = DirectN._DD_SURFACE_LOCAL;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDMOCOMPBUFFERINFO
    {
        public uint dwSize;
        public IntPtr lpCompSurface;
        public uint dwDataOffset;
        public uint dwDataSize;
        public IntPtr lpPrivate;
    }
}
